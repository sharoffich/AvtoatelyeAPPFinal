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
using System.Configuration;
using System.Reflection;

namespace AvtoatelyeApp
{
    public partial class ServiceInsertForm : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        //private SqlDataAdapter SqlDataAdapter = null;
        private DataTable table;
        private string connString;

        public ServiceInsertForm()
        {
            InitializeComponent();
        }

        private void ServiceInsertForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoatelyeBDDataSet14.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter1.Fill(this.avtoatelyeBDDataSet14.Material);
            connection = new SqlConnection(@"Data Source=DESKTOP-UFFHUAS\SQLEXPRESS;Initial Catalog=AvtoatelyeBD;Integrated Security=True");
            connection.Open();
            FillComboSearch();
        }

        private void FillComboSearch()
        {
            comboBoxSurname.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select o.Surname, o.OrderStatus from Recording o inner join Recording c on o.Id = c.Id where o.OrderStatus = 'В работе'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxSurname.Items.Add(dr["Surname"].ToString());
            }

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Service](Surname, Service, Material, Price) VALUES (N'{comboBoxSurname.Text}', N'{textBox1.Text}', N'{comboBoxMaterial.Text}', N'{textBox3.Text}')", connection);
            MessageBox.Show("Добавление записей: " + command.ExecuteNonQuery().ToString());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceForm service = new ServiceForm();
            service.ShowDialog();
            connection.Close();
        }
    }
}
