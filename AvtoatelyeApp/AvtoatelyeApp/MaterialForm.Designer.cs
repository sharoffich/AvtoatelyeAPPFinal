namespace AvtoatelyeApp
{
    partial class MaterialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialForm));
            this.dataGridViewMaterial = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxEdit = new System.Windows.Forms.TextBox();
            this.textBoxIDEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMaterial
            // 
            this.dataGridViewMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterial.Location = new System.Drawing.Point(20, 64);
            this.dataGridViewMaterial.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridViewMaterial.Name = "dataGridViewMaterial";
            this.dataGridViewMaterial.Size = new System.Drawing.Size(403, 475);
            this.dataGridViewMaterial.TabIndex = 0;
            this.dataGridViewMaterial.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMaterial_CellMouseClick);
            this.dataGridViewMaterial.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewMaterial_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(129, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 38);
            this.label3.TabIndex = 33;
            this.label3.Text = "Материалы";
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(455, 127);
            this.textBoxMaterial.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(238, 30);
            this.textBoxMaterial.TabIndex = 34;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.buttonAdd.Location = new System.Drawing.Point(455, 173);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(241, 41);
            this.buttonAdd.TabIndex = 35;
            this.buttonAdd.Text = "Добавить запись";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(628, 239);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(14, 30);
            this.textBoxID.TabIndex = 36;
            this.textBoxID.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.buttonDelete.Location = new System.Drawing.Point(455, 388);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(241, 41);
            this.buttonDelete.TabIndex = 37;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.buttonEdit.Location = new System.Drawing.Point(455, 336);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(241, 41);
            this.buttonEdit.TabIndex = 38;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxEdit
            // 
            this.textBoxEdit.Location = new System.Drawing.Point(455, 290);
            this.textBoxEdit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxEdit.Name = "textBoxEdit";
            this.textBoxEdit.Size = new System.Drawing.Size(238, 30);
            this.textBoxEdit.TabIndex = 39;
            // 
            // textBoxIDEdit
            // 
            this.textBoxIDEdit.Location = new System.Drawing.Point(645, 239);
            this.textBoxIDEdit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxIDEdit.Name = "textBoxIDEdit";
            this.textBoxIDEdit.Size = new System.Drawing.Size(14, 30);
            this.textBoxIDEdit.TabIndex = 40;
            this.textBoxIDEdit.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(451, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 71);
            this.label1.TabIndex = 41;
            this.label1.Text = "Редактирование материала";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(453, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 58);
            this.label2.TabIndex = 42;
            this.label2.Text = "Добавление нового материала";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(447, 21);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(245, 30);
            this.textBox_search.TabIndex = 43;
            this.textBox_search.Text = "Поиск";
            this.textBox_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_search_MouseClick);
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::AvtoatelyeApp.Properties.Resources.Search;
            this.pictureBox2.Location = new System.Drawing.Point(669, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(717, 558);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDEdit);
            this.Controls.Add(this.textBoxEdit);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewMaterial);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MaterialForm";
            this.Text = "Материал";
            this.Load += new System.EventHandler(this.MaterialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxEdit;
        private System.Windows.Forms.TextBox textBoxIDEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}