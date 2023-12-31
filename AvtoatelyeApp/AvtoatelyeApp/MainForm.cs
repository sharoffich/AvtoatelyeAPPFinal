﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections;
using Microsoft.SqlServer.Server;
using System.Data.Common;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace AvtoatelyeApp
{
    public partial class MainForm : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        //private SqlDataAdapter SqlDataAdapter = null;
        private DataTable table;

        //private DataSet dataSet = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-UFFHUAS\SQLEXPRESS;Initial Catalog=AvtoatelyeBD;Integrated Security=True");
            connection.Open();

            // создание таблицы в дата грид вью
            adapter = new SqlDataAdapter("SELECT* FROM Recording", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderCell.Value = "№";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderCell.Value = "Дата";
            dataGridView1.Columns[2].HeaderCell.Value = "Время";
            dataGridView1.Columns[3].HeaderCell.Value = "Фамилия";
            dataGridView1.Columns[4].HeaderCell.Value = "Имя";
            dataGridView1.Columns[5].HeaderCell.Value = "Отчество";
            dataGridView1.Columns[6].HeaderCell.Value = "Номер телефона";
            dataGridView1.Columns[6].Width = 160;
            dataGridView1.Columns[7].HeaderCell.Value = "Номер автомобиля";
            dataGridView1.Columns[8].HeaderCell.Value = "Статус заказа";

        }

        private void обновитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            MessageBox.Show("Записи обновлены!", "Уведомление");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form insert = new InsertForm();
            insert.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Recording WHERE ID = N'{textBoxID.Text}'", connection);
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

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form service = new ServiceForm();
            service.ShowDialog();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            MessageBox.Show("Записи обновлены!", "Уведомление");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxCar.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBoxOrder.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand($"UPDATE [Recording] SET Data = N'{textBox2.Text}', Time = N'{textBox3.Text}', Surname = N'{textBox4.Text}', Name = N'{textBox5.Text}', Middlename = N'{textBox6.Text}', Number = N'{maskedTextBox1.Text}', StateNumber = N'{textBoxCar.Text}', OrderStatus = N'{comboBoxOrder.Text}' WHERE id = {int.Parse(textBox1.Text)}", connection);
                MessageBox.Show("Записи обновлены. " + command.ExecuteNonQuery().ToString());
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                maskedTextBox1.Clear();
                textBoxCar.Clear();
                comboBoxOrder.SelectedIndex = -1;
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Surname LIKE '%{0}%'", textBox_search.Text);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form info = new InfoForm();
            info.ShowDialog();
        }

        private void textBox_search_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_search.Clear();
        }

        private void материалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialForm material = new MaterialForm();
            material.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        { 
          try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("Recording"))
                    {
                        using(SqlCommand cmd = new SqlCommand(" select o.Id, o.Data, o.Time, o.Surname, o.Name, o.Middlename, o.Number, o.StateNumber, o.OrderStatus from Recording o inner join Recording c on o.Id = c.Id  where o.Data between @fromdate and @todate ", cn))
                        {
                            cmd.Parameters.AddWithValue("@fromdate", string.Format("{0:yyyy-MM-dd}",dateTimePickerStart.Value));
                            cmd.Parameters.AddWithValue("@todate", string.Format("{0:yyyy-MM-dd}",dateTimePickerEnd.Value));
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                            sqlDataAdapter.Fill(dt);
                            connection = new SqlConnection(@"Data Source=DESKTOP-UFFHUAS\SQLEXPRESS;Initial Catalog=AvtoatelyeBD;Integrated Security=True");
                            connection.Open();

                            // создание таблицы в дата грид вью
                            dataGridView1.RowHeadersVisible = false;
                            dataGridView1.DataSource = dt;
                            dataGridView1.Columns[0].HeaderCell.Value = "№";
                            dataGridView1.Columns[0].Width = 50;
                            dataGridView1.Columns[1].HeaderCell.Value = "Дата";
                            dataGridView1.Columns[2].HeaderCell.Value = "Время";
                            dataGridView1.Columns[3].HeaderCell.Value = "Фамилия";
                            dataGridView1.Columns[4].HeaderCell.Value = "Имя";
                            dataGridView1.Columns[5].HeaderCell.Value = "Отчество";
                            dataGridView1.Columns[6].HeaderCell.Value = "Номер телефона";
                            dataGridView1.Columns[6].Width = 160;
                            dataGridView1.Columns[7].HeaderCell.Value = "Номер автомобиля";
                            dataGridView1.Columns[8].HeaderCell.Value = "Статус заказа";
                            labelTotal.Text = $"Всего заказов: {dataGridView1.RowCount}";
                        }    
                    }    
                }
            }
            catch 
            { 
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = null;
                String TemplatePath = System.Windows.Forms.Application.StartupPath + @"\Отчет.xlsx";
                try
                {
                    wb = ExcelApp.Workbooks.Add(TemplatePath); // !!! 
                }
                catch (System.Exception ex)
                {
                    throw new Exception("Не удалось загрузить шаблон для экспорта " + TemplatePath + "\n" + ex.Message);
                }
                MessageBox.Show("Шаблон найден, для продолжения нажмите кнопку ОК.", "Формирование отчета!");

                ExcelApp.Columns[1].ColumnWidth = 10;
                ExcelApp.Columns[2].ColumnWidth = 13;
                ExcelApp.Columns[3].ColumnWidth = 20;
                ExcelApp.Columns[4].ColumnWidth = 20;
                ExcelApp.Columns[5].ColumnWidth = 20;
                ExcelApp.Columns[6].ColumnWidth = 20;
                ExcelApp.Columns[7].ColumnWidth = 25;
                ExcelApp.Columns[8].ColumnWidth = 23;
                ExcelApp.Columns[9].ColumnWidth = 20;

                ExcelApp.Cells[2, 1] = "№";
                ExcelApp.Cells[2, 2] = "Дата";
                ExcelApp.Cells[2, 3] = "Время";
                ExcelApp.Cells[2, 4] = "Фамилия";
                ExcelApp.Cells[2, 5] = "Имя";
                ExcelApp.Cells[2, 6] = "Отчество";
                ExcelApp.Cells[2, 7] = "Номер телефона";
                ExcelApp.Cells[2, 8] = "Номер автомобиля";
                ExcelApp.Cells[2, 9] = "Статус заказа";

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        ExcelApp.Cells[j + 3, i + 1] = (dataGridView1[i, j].Value).ToString();
                    }
                }
                ExcelApp.Visible = true;
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Surname LIKE '%{0}%'", textBox_search.Text);
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("StateNumber LIKE '%{0}%'", textBox_search.Text);

        }
    }
}