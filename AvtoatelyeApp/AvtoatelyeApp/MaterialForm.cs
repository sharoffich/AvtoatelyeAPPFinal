using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtoatelyeApp
{
    public partial class MaterialForm : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        //private SqlDataAdapter SqlDataAdapter = null;
        private DataTable table;

        //private DataSet dataSet = null;
        public MaterialForm()
        {
            InitializeComponent();
        }

        private void MaterialForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-UFFHUAS\SQLEXPRESS;Initial Catalog=AvtoatelyeBD;Integrated Security=True");
            connection.Open();

            // создание таблицы в дата грид вью
            adapter = new SqlDataAdapter("SELECT* FROM Material", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridViewMaterial.RowHeadersVisible = false;
            dataGridViewMaterial.DataSource = table;
            dataGridViewMaterial.Columns[0].HeaderCell.Value = "№";
            dataGridViewMaterial.Columns[0].Width = 50;
            dataGridViewMaterial.Columns[1].HeaderCell.Value = "Материал";
            dataGridViewMaterial.Columns[1].Width = 350;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Material](Material) VALUES (N'{textBoxMaterial.Text}')", connection);
            MessageBox.Show("Добавление записей: " + command.ExecuteNonQuery().ToString());
            table.Clear();
            adapter.Fill(table);
            dataGridViewMaterial.DataSource = table;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Material WHERE ID = N'{textBoxID.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();         // обновление таблицы после добавления записи
                adapter.Fill(table);
                dataGridViewMaterial.DataSource = table;
            }
        }

        private void dataGridViewMaterial_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxID.Text = dataGridViewMaterial.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand($"UPDATE [Material] SET Material = N'{textBoxEdit.Text}' WHERE id = {int.Parse(textBoxIDEdit.Text)}", connection);
                MessageBox.Show("Записи обновлены. " + command.ExecuteNonQuery().ToString());
                textBoxEdit.Clear();
                textBoxIDEdit.Clear();
                table.Clear();         // обновление таблицы после добавления записи
                adapter.Fill(table);
                dataGridViewMaterial.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Выберите строчку!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMaterial_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxIDEdit.Text = dataGridViewMaterial.CurrentRow.Cells[0].Value.ToString();
            textBoxEdit.Text = dataGridViewMaterial.CurrentRow.Cells[1].Value.ToString();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewMaterial.DataSource as DataTable).DefaultView.RowFilter = string.Format("Material LIKE '%{0}%'", textBox_search.Text);
        }

        private void textBox_search_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_search.Clear();
        }
    }
}
