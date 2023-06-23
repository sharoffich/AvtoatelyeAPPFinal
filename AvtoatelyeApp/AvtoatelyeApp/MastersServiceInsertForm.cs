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

namespace AvtoatelyeApp
{
    public partial class MastersServiceInsertForm : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        //private SqlDataAdapter SqlDataAdapter = null;
        private DataTable table;
        public MastersServiceInsertForm()
        {
            InitializeComponent();
        }

        private void MastersServiceInsertForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoatelyeBDDataSet13.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter1.Fill(this.avtoatelyeBDDataSet13.Material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoatelyeBDDataSet12.Recording". При необходимости она может быть перемещена или удалена.
            this.recordingTableAdapter2.Fill(this.avtoatelyeBDDataSet12.Recording);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoatelyeBDDataSet8.Recording". При необходимости она может быть перемещена или удалена.
            this.recordingTableAdapter1.Fill(this.avtoatelyeBDDataSet8.Recording);
            connection = new SqlConnection(@"Data Source=DESKTOP-UFFHUAS\SQLEXPRESS;Initial Catalog=AvtoatelyeBD;Integrated Security=True");
            connection.Open();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Service](Surname, Service, Material, Price) VALUES (N'{comboBoxSurname.Text}', N'{textBoxService.Text}', N'{comboBoxMaterial.Text}', N'{textBoxPrice.Text}')", connection);
            MessageBox.Show("Добавление записей: " + command.ExecuteNonQuery().ToString());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceMasterForm servicemaster = new ServiceMasterForm();
            servicemaster.ShowDialog();
            connection.Close();
        }
    }
}
