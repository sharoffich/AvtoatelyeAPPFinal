
namespace AvtoatelyeApp
{
    partial class MastersServiceInsertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MastersServiceInsertForm));
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxService = new System.Windows.Forms.TextBox();
            this.comboBoxSurname = new System.Windows.Forms.ComboBox();
            this.recordingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.avtoatelyeBDDataSet12 = new AvtoatelyeApp.AvtoatelyeBDDataSet12();
            this.recordingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.avtoatelyeBDDataSet8 = new AvtoatelyeApp.AvtoatelyeBDDataSet8();
            this.recordingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtoatelyeBDDataSet = new AvtoatelyeApp.AvtoatelyeBDDataSet();
            this.recordingTableAdapter = new AvtoatelyeApp.AvtoatelyeBDDataSetTableAdapters.RecordingTableAdapter();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.materialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.avtoatelyeBDDataSet13 = new AvtoatelyeApp.AvtoatelyeBDDataSet13();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtoatelyeBDDataSet6 = new AvtoatelyeApp.AvtoatelyeBDDataSet6();
            this.materialTableAdapter = new AvtoatelyeApp.AvtoatelyeBDDataSet6TableAdapters.MaterialTableAdapter();
            this.recordingTableAdapter1 = new AvtoatelyeApp.AvtoatelyeBDDataSet8TableAdapters.RecordingTableAdapter();
            this.recordingTableAdapter2 = new AvtoatelyeApp.AvtoatelyeBDDataSet12TableAdapters.RecordingTableAdapter();
            this.materialTableAdapter1 = new AvtoatelyeApp.AvtoatelyeBDDataSet13TableAdapters.MaterialTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recordingBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(17, 301);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(58, 26);
            this.labelPrice.TabIndex = 27;
            this.labelPrice.Text = "Цена";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaterial.Location = new System.Drawing.Point(17, 220);
            this.labelMaterial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(102, 26);
            this.labelMaterial.TabIndex = 26;
            this.labelMaterial.Text = "Материал";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelService.Location = new System.Drawing.Point(17, 140);
            this.labelService.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(75, 26);
            this.labelService.TabIndex = 25;
            this.labelService.Text = "Услуга";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(17, 68);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(94, 26);
            this.labelSurname.TabIndex = 24;
            this.labelSurname.Text = "Фамилия";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(82, 406);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(204, 41);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.buttonAdd.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(82, 355);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(204, 41);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Добавить запись";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(184, 299);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(164, 30);
            this.textBoxPrice.TabIndex = 21;
            // 
            // textBoxService
            // 
            this.textBoxService.Location = new System.Drawing.Point(184, 138);
            this.textBoxService.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxService.Name = "textBoxService";
            this.textBoxService.Size = new System.Drawing.Size(164, 30);
            this.textBoxService.TabIndex = 19;
            // 
            // comboBoxSurname
            // 
            this.comboBoxSurname.DataSource = this.recordingBindingSource2;
            this.comboBoxSurname.DisplayMember = "Surname";
            this.comboBoxSurname.FormattingEnabled = true;
            this.comboBoxSurname.Location = new System.Drawing.Point(184, 65);
            this.comboBoxSurname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBoxSurname.Name = "comboBoxSurname";
            this.comboBoxSurname.Size = new System.Drawing.Size(164, 31);
            this.comboBoxSurname.TabIndex = 18;
            this.comboBoxSurname.ValueMember = "Id";
            // 
            // recordingBindingSource2
            // 
            this.recordingBindingSource2.DataMember = "Recording";
            this.recordingBindingSource2.DataSource = this.avtoatelyeBDDataSet12;
            // 
            // avtoatelyeBDDataSet12
            // 
            this.avtoatelyeBDDataSet12.DataSetName = "AvtoatelyeBDDataSet12";
            this.avtoatelyeBDDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordingBindingSource1
            // 
            this.recordingBindingSource1.DataMember = "Recording";
            this.recordingBindingSource1.DataSource = this.avtoatelyeBDDataSet8;
            // 
            // avtoatelyeBDDataSet8
            // 
            this.avtoatelyeBDDataSet8.DataSetName = "AvtoatelyeBDDataSet8";
            this.avtoatelyeBDDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordingBindingSource
            // 
            this.recordingBindingSource.DataMember = "Recording";
            this.recordingBindingSource.DataSource = this.avtoatelyeBDDataSet;
            // 
            // avtoatelyeBDDataSet
            // 
            this.avtoatelyeBDDataSet.DataSetName = "AvtoatelyeBDDataSet";
            this.avtoatelyeBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordingTableAdapter
            // 
            this.recordingTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DataSource = this.materialBindingSource1;
            this.comboBoxMaterial.DisplayMember = "Material";
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(184, 217);
            this.comboBoxMaterial.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(164, 31);
            this.comboBoxMaterial.TabIndex = 28;
            this.comboBoxMaterial.ValueMember = "Id";
            // 
            // materialBindingSource1
            // 
            this.materialBindingSource1.DataMember = "Material";
            this.materialBindingSource1.DataSource = this.avtoatelyeBDDataSet13;
            // 
            // avtoatelyeBDDataSet13
            // 
            this.avtoatelyeBDDataSet13.DataSetName = "AvtoatelyeBDDataSet13";
            this.avtoatelyeBDDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.avtoatelyeBDDataSet6;
            // 
            // avtoatelyeBDDataSet6
            // 
            this.avtoatelyeBDDataSet6.DataSetName = "AvtoatelyeBDDataSet6";
            this.avtoatelyeBDDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // recordingTableAdapter1
            // 
            this.recordingTableAdapter1.ClearBeforeFill = true;
            // 
            // recordingTableAdapter2
            // 
            this.recordingTableAdapter2.ClearBeforeFill = true;
            // 
            // materialTableAdapter1
            // 
            this.materialTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 38);
            this.label1.TabIndex = 29;
            this.label1.Text = "Добавление записи";
            // 
            // MastersServiceInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(363, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxService);
            this.Controls.Add(this.comboBoxSurname);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MastersServiceInsertForm";
            this.Text = "Добавить запись";
            this.Load += new System.EventHandler(this.MastersServiceInsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordingBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxService;
        private System.Windows.Forms.ComboBox comboBoxSurname;
        private AvtoatelyeBDDataSet avtoatelyeBDDataSet;
        private System.Windows.Forms.BindingSource recordingBindingSource;
        private AvtoatelyeBDDataSetTableAdapters.RecordingTableAdapter recordingTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private AvtoatelyeBDDataSet6 avtoatelyeBDDataSet6;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private AvtoatelyeBDDataSet6TableAdapters.MaterialTableAdapter materialTableAdapter;
        private AvtoatelyeBDDataSet8 avtoatelyeBDDataSet8;
        private System.Windows.Forms.BindingSource recordingBindingSource1;
        private AvtoatelyeBDDataSet8TableAdapters.RecordingTableAdapter recordingTableAdapter1;
        private AvtoatelyeBDDataSet12 avtoatelyeBDDataSet12;
        private System.Windows.Forms.BindingSource recordingBindingSource2;
        private AvtoatelyeBDDataSet12TableAdapters.RecordingTableAdapter recordingTableAdapter2;
        private AvtoatelyeBDDataSet13 avtoatelyeBDDataSet13;
        private System.Windows.Forms.BindingSource materialBindingSource1;
        private AvtoatelyeBDDataSet13TableAdapters.MaterialTableAdapter materialTableAdapter1;
        private System.Windows.Forms.Label label1;
    }
}