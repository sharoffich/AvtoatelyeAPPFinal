
namespace AvtoatelyeApp
{
    partial class MasterInsertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterInsertForm));
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelMiddlename = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxMiddlename = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.fIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtoatelyeBDDataSet5 = new AvtoatelyeApp.AvtoatelyeBDDataSet5();
            this.fIASTableAdapter = new AvtoatelyeApp.AvtoatelyeBDDataSet5TableAdapters.FIASTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            this.textBoxCar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(224, 473);
            this.maskedTextBoxNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.maskedTextBoxNumber.Mask = "0 (999) 000-00-00";
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(164, 30);
            this.maskedTextBoxNumber.TabIndex = 34;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(224, 149);
            this.dateTimePickerTime.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(164, 30);
            this.dateTimePickerTime.TabIndex = 33;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(224, 76);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(164, 30);
            this.dateTimePickerDate.TabIndex = 32;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(32, 478);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(166, 26);
            this.labelNumber.TabIndex = 31;
            this.labelNumber.Text = "Номер телефона";
            // 
            // labelMiddlename
            // 
            this.labelMiddlename.AutoSize = true;
            this.labelMiddlename.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddlename.Location = new System.Drawing.Point(32, 397);
            this.labelMiddlename.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMiddlename.Name = "labelMiddlename";
            this.labelMiddlename.Size = new System.Drawing.Size(96, 26);
            this.labelMiddlename.TabIndex = 30;
            this.labelMiddlename.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(32, 316);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 26);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(32, 234);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(94, 26);
            this.labelSurname.TabIndex = 28;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(32, 152);
            this.labelTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(68, 26);
            this.labelTime.TabIndex = 27;
            this.labelTime.Text = "Время";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData.ForeColor = System.Drawing.Color.Black;
            this.labelData.Location = new System.Drawing.Point(32, 80);
            this.labelData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(56, 26);
            this.labelData.TabIndex = 26;
            this.labelData.Text = "Дата";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(91, 687);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(204, 41);
            this.buttonExit.TabIndex = 25;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.buttonInsert.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsert.Location = new System.Drawing.Point(91, 635);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(204, 41);
            this.buttonInsert.TabIndex = 24;
            this.buttonInsert.Text = "Добавить запись";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxMiddlename
            // 
            this.textBoxMiddlename.Location = new System.Drawing.Point(224, 392);
            this.textBoxMiddlename.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxMiddlename.Name = "textBoxMiddlename";
            this.textBoxMiddlename.Size = new System.Drawing.Size(164, 30);
            this.textBoxMiddlename.TabIndex = 23;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(224, 310);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(164, 30);
            this.textBoxName.TabIndex = 22;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(224, 228);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(164, 30);
            this.textBoxSurname.TabIndex = 21;
            // 
            // fIASBindingSource
            // 
            this.fIASBindingSource.DataMember = "FIAS";
            this.fIASBindingSource.DataSource = this.avtoatelyeBDDataSet5;
            // 
            // avtoatelyeBDDataSet5
            // 
            this.avtoatelyeBDDataSet5.DataSetName = "AvtoatelyeBDDataSet5";
            this.avtoatelyeBDDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fIASTableAdapter
            // 
            this.fIASTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 38);
            this.label1.TabIndex = 35;
            this.label1.Text = "Добавление записи";
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.FormattingEnabled = true;
            this.comboBoxOrder.Items.AddRange(new object[] {
            "Заказ принят",
            "В работе",
            "Заверешен"});
            this.comboBoxOrder.Location = new System.Drawing.Point(224, 583);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(164, 31);
            this.comboBoxOrder.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 588);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "Статус заказа";
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCar.Location = new System.Drawing.Point(32, 529);
            this.labelCar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(155, 26);
            this.labelCar.TabIndex = 37;
            this.labelCar.Text = "Номер машины";
            // 
            // textBoxCar
            // 
            this.textBoxCar.Location = new System.Drawing.Point(224, 528);
            this.textBoxCar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxCar.Name = "textBoxCar";
            this.textBoxCar.Size = new System.Drawing.Size(164, 30);
            this.textBoxCar.TabIndex = 36;
            // 
            // MasterInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(398, 738);
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
            this.Name = "MasterInsertForm";
            this.Text = "Добавить запись";
            this.Load += new System.EventHandler(this.MaterInsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelMiddlename;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxMiddlename;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private AvtoatelyeBDDataSet5 avtoatelyeBDDataSet5;
        private System.Windows.Forms.BindingSource fIASBindingSource;
        private AvtoatelyeBDDataSet5TableAdapters.FIASTableAdapter fIASTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.TextBox textBoxCar;
    }
}