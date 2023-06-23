
namespace AvtoatelyeApp
{
    partial class ServiceInsertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceInsertForm));
            this.avtoatelyeBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtoatelyeBDDataSet = new AvtoatelyeApp.AvtoatelyeBDDataSet();
            this.recordingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.avtoatelyeBDDataSet10 = new AvtoatelyeApp.AvtoatelyeBDDataSet10();
            this.recordingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordingTableAdapter = new AvtoatelyeApp.AvtoatelyeBDDataSetTableAdapters.RecordingTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordingTableAdapter1 = new AvtoatelyeApp.AvtoatelyeBDDataSet10TableAdapters.RecordingTableAdapter();
            this.comboBoxSurname = new System.Windows.Forms.ComboBox();
            this.recordingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.avtoatelyeBDDataSet9 = new AvtoatelyeApp.AvtoatelyeBDDataSet9();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.materialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.avtoatelyeBDDataSet11 = new AvtoatelyeApp.AvtoatelyeBDDataSet11();
            this.recordingTableAdapter2 = new AvtoatelyeApp.AvtoatelyeBDDataSet9TableAdapters.RecordingTableAdapter();
            this.materialTableAdapter = new AvtoatelyeApp.AvtoatelyeBDDataSet11TableAdapters.MaterialTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.avtoatelyeBDDataSet14 = new AvtoatelyeApp.AvtoatelyeBDDataSet14();
            this.materialBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter1 = new AvtoatelyeApp.AvtoatelyeBDDataSet14TableAdapters.MaterialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordingBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // avtoatelyeBDDataSetBindingSource
            // 
            this.avtoatelyeBDDataSetBindingSource.DataSource = this.avtoatelyeBDDataSet;
            this.avtoatelyeBDDataSetBindingSource.Position = 0;
            // 
            // avtoatelyeBDDataSet
            // 
            this.avtoatelyeBDDataSet.DataSetName = "AvtoatelyeBDDataSet";
            this.avtoatelyeBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordingBindingSource1
            // 
            this.recordingBindingSource1.DataMember = "Recording";
            this.recordingBindingSource1.DataSource = this.avtoatelyeBDDataSet10;
            // 
            // avtoatelyeBDDataSet10
            // 
            this.avtoatelyeBDDataSet10.DataSetName = "AvtoatelyeBDDataSet10";
            this.avtoatelyeBDDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordingBindingSource
            // 
            this.recordingBindingSource.DataMember = "Recording";
            this.recordingBindingSource.DataSource = this.avtoatelyeBDDataSet;
            // 
            // recordingTableAdapter
            // 
            this.recordingTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 147);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 30);
            this.textBox1.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(182, 308);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 30);
            this.textBox3.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.buttonAdd.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(77, 393);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(207, 41);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить запись";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(77, 444);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(207, 41);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(16, 76);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(94, 26);
            this.labelSurname.TabIndex = 14;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelService.Location = new System.Drawing.Point(16, 148);
            this.labelService.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(75, 26);
            this.labelService.TabIndex = 15;
            this.labelService.Text = "Услуга";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaterial.Location = new System.Drawing.Point(16, 228);
            this.labelMaterial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(102, 26);
            this.labelMaterial.TabIndex = 16;
            this.labelMaterial.Text = "Материал";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(16, 309);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(58, 26);
            this.labelPrice.TabIndex = 17;
            this.labelPrice.Text = "Цена";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            // 
            // recordingTableAdapter1
            // 
            this.recordingTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBoxSurname
            // 
            this.comboBoxSurname.FormattingEnabled = true;
            this.comboBoxSurname.Location = new System.Drawing.Point(182, 75);
            this.comboBoxSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSurname.Name = "comboBoxSurname";
            this.comboBoxSurname.Size = new System.Drawing.Size(164, 31);
            this.comboBoxSurname.TabIndex = 18;
            // 
            // recordingBindingSource2
            // 
            this.recordingBindingSource2.DataMember = "Recording";
            this.recordingBindingSource2.DataSource = this.avtoatelyeBDDataSet9;
            // 
            // avtoatelyeBDDataSet9
            // 
            this.avtoatelyeBDDataSet9.DataSetName = "AvtoatelyeBDDataSet9";
            this.avtoatelyeBDDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(182, 227);
            this.comboBoxMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(164, 31);
            this.comboBoxMaterial.TabIndex = 19;
            // 
            // materialBindingSource1
            // 
            this.materialBindingSource1.DataMember = "Material";
            this.materialBindingSource1.DataSource = this.avtoatelyeBDDataSet11;
            // 
            // avtoatelyeBDDataSet11
            // 
            this.avtoatelyeBDDataSet11.DataSetName = "AvtoatelyeBDDataSet11";
            this.avtoatelyeBDDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordingTableAdapter2
            // 
            this.recordingTableAdapter2.ClearBeforeFill = true;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 38);
            this.label1.TabIndex = 30;
            this.label1.Text = "Добавление услуги";
            // 
            // avtoatelyeBDDataSet14
            // 
            this.avtoatelyeBDDataSet14.DataSetName = "AvtoatelyeBDDataSet14";
            this.avtoatelyeBDDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialBindingSource2
            // 
            this.materialBindingSource2.DataMember = "Material";
            this.materialBindingSource2.DataSource = this.avtoatelyeBDDataSet14;
            // 
            // materialTableAdapter1
            // 
            this.materialTableAdapter1.ClearBeforeFill = true;
            // 
            // ServiceInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(368, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.comboBoxSurname);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ServiceInsertForm";
            this.Text = "Добавление записи";
            this.Load += new System.EventHandler(this.ServiceInsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordingBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AvtoatelyeBDDataSet avtoatelyeBDDataSet;
        private System.Windows.Forms.BindingSource recordingBindingSource;
        private AvtoatelyeBDDataSetTableAdapters.RecordingTableAdapter recordingTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.BindingSource avtoatelyeBDDataSetBindingSource;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private AvtoatelyeBDDataSet10 avtoatelyeBDDataSet10;
        private System.Windows.Forms.BindingSource recordingBindingSource1;
        private AvtoatelyeBDDataSet10TableAdapters.RecordingTableAdapter recordingTableAdapter1;
        private System.Windows.Forms.ComboBox comboBoxSurname;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private AvtoatelyeBDDataSet9 avtoatelyeBDDataSet9;
        private System.Windows.Forms.BindingSource recordingBindingSource2;
        private AvtoatelyeBDDataSet9TableAdapters.RecordingTableAdapter recordingTableAdapter2;
        private AvtoatelyeBDDataSet11 avtoatelyeBDDataSet11;
        private System.Windows.Forms.BindingSource materialBindingSource1;
        private AvtoatelyeBDDataSet11TableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.Label label1;
        private AvtoatelyeBDDataSet14 avtoatelyeBDDataSet14;
        private System.Windows.Forms.BindingSource materialBindingSource2;
        private AvtoatelyeBDDataSet14TableAdapters.MaterialTableAdapter materialTableAdapter1;
    }
}