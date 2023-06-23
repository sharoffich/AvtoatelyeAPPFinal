
namespace AvtoatelyeApp
{
    partial class InsertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertForm));
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMiddlename = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelData = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMiddlename = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.fIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtoatelyeBDDataSet1 = new AvtoatelyeApp.AvtoatelyeBDDataSet1();
            this.fIASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.avtoatelyeBDDataSet3 = new AvtoatelyeApp.AvtoatelyeBDDataSet3();
            this.fIASBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.avtoatelyeBDDataSet4 = new AvtoatelyeApp.AvtoatelyeBDDataSet4();
            this.fIASTableAdapter = new AvtoatelyeApp.AvtoatelyeBDDataSet1TableAdapters.FIASTableAdapter();
            this.fIASTableAdapter1 = new AvtoatelyeApp.AvtoatelyeBDDataSet3TableAdapters.FIASTableAdapter();
            this.fIASTableAdapter2 = new AvtoatelyeApp.AvtoatelyeBDDataSet4TableAdapters.FIASTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            this.textBoxCar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIASBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIASBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(185, 235);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(164, 30);
            this.textBoxSurname.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(185, 317);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(164, 30);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxMiddlename
            // 
            this.textBoxMiddlename.Location = new System.Drawing.Point(185, 399);
            this.textBoxMiddlename.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxMiddlename.Name = "textBoxMiddlename";
            this.textBoxMiddlename.Size = new System.Drawing.Size(164, 30);
            this.textBoxMiddlename.TabIndex = 5;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.buttonInsert.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsert.Location = new System.Drawing.Point(85, 642);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(204, 41);
            this.buttonInsert.TabIndex = 7;
            this.buttonInsert.Text = "Добавить запись";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(85, 693);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(204, 41);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData.ForeColor = System.Drawing.Color.Black;
            this.labelData.Location = new System.Drawing.Point(15, 83);
            this.labelData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(56, 26);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "Дата";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(15, 156);
            this.labelTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(68, 26);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "Время";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(15, 235);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(94, 26);
            this.labelSurname.TabIndex = 13;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(15, 317);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 26);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Имя";
            // 
            // labelMiddlename
            // 
            this.labelMiddlename.AutoSize = true;
            this.labelMiddlename.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddlename.Location = new System.Drawing.Point(15, 399);
            this.labelMiddlename.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMiddlename.Name = "labelMiddlename";
            this.labelMiddlename.Size = new System.Drawing.Size(96, 26);
            this.labelMiddlename.TabIndex = 15;
            this.labelMiddlename.Text = "Отчество";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(15, 474);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(166, 26);
            this.labelNumber.TabIndex = 16;
            this.labelNumber.Text = "Номер телефона";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(185, 83);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(164, 30);
            this.dateTimePickerDate.TabIndex = 18;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(185, 156);
            this.dateTimePickerTime.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(164, 30);
            this.dateTimePickerTime.TabIndex = 19;
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(185, 474);
            this.maskedTextBoxNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.maskedTextBoxNumber.Mask = "0 (999) 000-00-00";
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(164, 30);
            this.maskedTextBoxNumber.TabIndex = 20;
            // 
            // fIASBindingSource
            // 
            this.fIASBindingSource.DataMember = "FIAS";
            this.fIASBindingSource.DataSource = this.avtoatelyeBDDataSet1;
            // 
            // avtoatelyeBDDataSet1
            // 
            this.avtoatelyeBDDataSet1.DataSetName = "AvtoatelyeBDDataSet1";
            this.avtoatelyeBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fIASBindingSource1
            // 
            this.fIASBindingSource1.DataMember = "FIAS";
            this.fIASBindingSource1.DataSource = this.avtoatelyeBDDataSet3;
            // 
            // avtoatelyeBDDataSet3
            // 
            this.avtoatelyeBDDataSet3.DataSetName = "AvtoatelyeBDDataSet3";
            this.avtoatelyeBDDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fIASBindingSource2
            // 
            this.fIASBindingSource2.DataMember = "FIAS";
            this.fIASBindingSource2.DataSource = this.avtoatelyeBDDataSet4;
            // 
            // avtoatelyeBDDataSet4
            // 
            this.avtoatelyeBDDataSet4.DataSetName = "AvtoatelyeBDDataSet4";
            this.avtoatelyeBDDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fIASTableAdapter
            // 
            this.fIASTableAdapter.ClearBeforeFill = true;
            // 
            // fIASTableAdapter1
            // 
            this.fIASTableAdapter1.ClearBeforeFill = true;
            // 
            // fIASTableAdapter2
            // 
            this.fIASTableAdapter2.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "Добавление клиента";
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCar.Location = new System.Drawing.Point(15, 539);
            this.labelCar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(155, 26);
            this.labelCar.TabIndex = 23;
            this.labelCar.Text = "Номер машины";
            // 
            // textBoxCar
            // 
            this.textBoxCar.Location = new System.Drawing.Point(185, 539);
            this.textBoxCar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxCar.Name = "textBoxCar";
            this.textBoxCar.Size = new System.Drawing.Size(164, 30);
            this.textBoxCar.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 599);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Статус заказа";
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.FormattingEnabled = true;
            this.comboBoxOrder.Items.AddRange(new object[] {
            "Заказ принят",
            "В работе",
            "Заверешен"});
            this.comboBoxOrder.Location = new System.Drawing.Point(185, 594);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(164, 31);
            this.comboBoxOrder.TabIndex = 26;
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(365, 738);
            this.Controls.Add(this.comboBoxOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCar);
            this.Controls.Add(this.textBoxCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxNumber);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelMiddlename);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxMiddlename);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "InsertForm";
            this.Text = "Добавить запись";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIASBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIASBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMiddlename;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMiddlename;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private AvtoatelyeBDDataSet1 avtoatelyeBDDataSet1;
        private System.Windows.Forms.BindingSource fIASBindingSource;
        private AvtoatelyeBDDataSet1TableAdapters.FIASTableAdapter fIASTableAdapter;
        private AvtoatelyeBDDataSet3 avtoatelyeBDDataSet3;
        private System.Windows.Forms.BindingSource fIASBindingSource1;
        private AvtoatelyeBDDataSet3TableAdapters.FIASTableAdapter fIASTableAdapter1;
        private AvtoatelyeBDDataSet4 avtoatelyeBDDataSet4;
        private System.Windows.Forms.BindingSource fIASBindingSource2;
        private AvtoatelyeBDDataSet4TableAdapters.FIASTableAdapter fIASTableAdapter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.TextBox textBoxCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOrder;
    }
}