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

namespace AvtoatelyeApp
{
    public partial class AuthorizationForm : Form
    {


        public AuthorizationForm()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }
        //писать описание здесь
        private void buttonEntry_Click(object sender, EventArgs e)
        {
            {
                string user_type;
                using (SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-UFFHUAS\SQLEXPRESS;Initial Catalog=AvtoatelyeBD;Integrated Security=True"))
                {
                    sqlcon.Open();
                    SqlCommand command = new SqlCommand("SELECT [UserType] FROM Users where Users = @Users and Password = @Password", sqlcon);
                    command.Parameters.AddWithValue("@Users", textBoxLogin.Text);
                    command.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                    user_type = (string)command.ExecuteScalar();
                }
                if (user_type == "Администратор")
                {
                    this.Hide();
                    MainForm main = new MainForm();
                    main.ShowDialog();
                    this.Close();
                }
                else if (user_type == "Мастер")
                {
                    this.Hide();
                    MasterForm master = new MasterForm();
                    master.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не правильно введен логин/пароль", "Ошибка!");
                }
            }
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
