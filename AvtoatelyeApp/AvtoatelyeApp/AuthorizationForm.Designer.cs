
namespace AvtoatelyeApp
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.panelAuthorization = new System.Windows.Forms.Panel();
            this.buttonEntry = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.avtoatelyeBDDataSet7 = new AvtoatelyeApp.AvtoatelyeBDDataSet7();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new AvtoatelyeApp.AvtoatelyeBDDataSet7TableAdapters.UsersTableAdapter();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.panelAuthorization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAuthorization
            // 
            this.panelAuthorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(108)))), ((int)(((byte)(163)))));
            this.panelAuthorization.Controls.Add(this.checkBoxPassword);
            this.panelAuthorization.Controls.Add(this.buttonEntry);
            this.panelAuthorization.Controls.Add(this.labelPassword);
            this.panelAuthorization.Controls.Add(this.labelLogin);
            this.panelAuthorization.Controls.Add(this.textBoxPassword);
            this.panelAuthorization.Controls.Add(this.pictureBoxPassword);
            this.panelAuthorization.Controls.Add(this.textBoxLogin);
            this.panelAuthorization.Controls.Add(this.pictureBoxLogin);
            this.panelAuthorization.Controls.Add(this.panel2);
            this.panelAuthorization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAuthorization.Location = new System.Drawing.Point(0, 0);
            this.panelAuthorization.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelAuthorization.Name = "panelAuthorization";
            this.panelAuthorization.Size = new System.Drawing.Size(620, 624);
            this.panelAuthorization.TabIndex = 0;
            // 
            // buttonEntry
            // 
            this.buttonEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.buttonEntry.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEntry.Location = new System.Drawing.Point(164, 534);
            this.buttonEntry.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonEntry.Name = "buttonEntry";
            this.buttonEntry.Size = new System.Drawing.Size(294, 67);
            this.buttonEntry.TabIndex = 7;
            this.buttonEntry.Text = "Войти";
            this.buttonEntry.UseVisualStyleBackColor = false;
            this.buttonEntry.Click += new System.EventHandler(this.buttonEntry_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(157, 419);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(90, 29);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(157, 297);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(76, 29);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(330, 429);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(241, 30);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::AvtoatelyeApp.Properties.Resources.Key_login;
            this.pictureBoxPassword.Location = new System.Drawing.Point(57, 399);
            this.pictureBoxPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(83, 89);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPassword.TabIndex = 3;
            this.pictureBoxPassword.TabStop = false;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(330, 308);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(241, 30);
            this.textBoxLogin.TabIndex = 2;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = global::AvtoatelyeApp.Properties.Resources.User_login;
            this.pictureBoxLogin.Location = new System.Drawing.Point(40, 265);
            this.pictureBoxLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(107, 113);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 1;
            this.pictureBoxLogin.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.panel2.Controls.Add(this.labelAuthorization);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 176);
            this.panel2.TabIndex = 0;
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAuthorization.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthorization.ForeColor = System.Drawing.Color.White;
            this.labelAuthorization.Location = new System.Drawing.Point(0, 0);
            this.labelAuthorization.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(620, 176);
            this.labelAuthorization.TabIndex = 0;
            this.labelAuthorization.Text = "Авторизация";
            this.labelAuthorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avtoatelyeBDDataSet7
            // 
            this.avtoatelyeBDDataSet7.DataSetName = "AvtoatelyeBDDataSet7";
            this.avtoatelyeBDDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.avtoatelyeBDDataSet7;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.ForeColor = System.Drawing.Color.White;
            this.checkBoxPassword.Location = new System.Drawing.Point(412, 467);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(159, 27);
            this.checkBoxPassword.TabIndex = 8;
            this.checkBoxPassword.Text = "Показать пароль";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 624);
            this.Controls.Add(this.panelAuthorization);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AuthorizationForm";
            this.Text = "Окно авторизации";
            this.panelAuthorization.ResumeLayout(false);
            this.panelAuthorization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avtoatelyeBDDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAuthorization;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEntry;
        private AvtoatelyeBDDataSet7 avtoatelyeBDDataSet7;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private AvtoatelyeBDDataSet7TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.CheckBox checkBoxPassword;
    }
}