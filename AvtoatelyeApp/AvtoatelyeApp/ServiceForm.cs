using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;

namespace AvtoatelyeApp
{
    public partial class ServiceForm : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        //private SqlDataAdapter SqlDataAdapter = null;
        private DataTable table;
        private double d;

        public ServiceForm()
        {
            InitializeComponent();
        }

        private void заказнарядыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form main = new MainForm();
            main.ShowDialog();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            MessageBox.Show("Записи обновлены!", "Уведомление");
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new AuthorizationForm();
            login.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-UFFHUAS\SQLEXPRESS;Initial Catalog=AvtoatelyeBD;Integrated Security=True");
            connection.Open();

            // создание таблицы в дата грид вью
            adapter = new SqlDataAdapter("SELECT *FROM Service, Recording WHERE Recording.Surname = Service.Surname AND OrderStatus = 'В работе'", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderCell.Value = "№";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderCell.Value = "Фамилия";
            dataGridView1.Columns[2].HeaderCell.Value = "Услуга";
            dataGridView1.Columns[3].HeaderCell.Value = "Материал";
            dataGridView1.Columns[4].HeaderCell.Value = "Цена";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            FillComboSearch();
        }

        private void FillComboSearch()
        {
            comboBoxMaterial.Items.Clear();
            SqlCommand cma = new SqlCommand();
            cma = connection.CreateCommand();
            cma.CommandType = CommandType.Text;
            cma.CommandText = "select Material.Material from Material";
            cma.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cma);
            da2.Fill(dt2);

            foreach (DataRow dg in dt2.Rows)
            {
                comboBoxMaterial.Items.Add(dg["Material"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceInsertForm serviceinsert = new ServiceInsertForm();
            serviceinsert.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Service WHERE ID = N'{textBoxID.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();         // обновление таблицы после добавления записи
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

    private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                double number;
                string value = row.Cells[4].Value.ToString();

                if (Double.TryParse(value, out number))
                    d += number;
            }
            label1.Text = d.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d = 0;
            label1.Text = d.ToString();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Surname LIKE '%{0}%'", textBox_search.Text);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand($"UPDATE [Service] SET Surname = N'{textBoxSurname.Text}', Service = N'{textBoxService.Text}', Material = N'{comboBoxMaterial.Text}', Price = N'{textBoxPrice.Text}' WHERE id = {int.Parse(textBox_ID.Text)}", connection);
                MessageBox.Show("Записи обновлены. " + command.ExecuteNonQuery().ToString());
                textBoxSurname.Clear();
                textBoxService.Clear();
                comboBoxMaterial.SelectedIndex = -1;
                textBoxPrice.Clear();
                table.Clear();         // обновление таблицы после добавления записи
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Выберите строчку!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxSurname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxService.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxMaterial.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxPrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void textBox_search_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_search.Clear();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form info = new InfoForm();
            info.ShowDialog();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string name = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                string number = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                string statenumber = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                MessageBox.Show("Имя: " + name + " Номер телефона: " + number + " Номер автомобиля: " + statenumber, "Данные клиента!");
            }
        }
    }
}
