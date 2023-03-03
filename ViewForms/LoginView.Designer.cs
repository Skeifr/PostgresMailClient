namespace mailClient
{
    partial class LoginView
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
            this.label1 = new System.Windows.Forms.Label();
            this.usersCB = new System.Windows.Forms.ComboBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SurnameTb = new System.Windows.Forms.TextBox();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.PatronymicTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadPb = new System.Windows.Forms.PictureBox();
            this.postgresSettingsBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoadPb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете Ваш адрес эл.почты\r\n(или введите его вручную)";
            // 
            // usersCB
            // 
            this.usersCB.FormattingEnabled = true;
            this.usersCB.Location = new System.Drawing.Point(6, 70);
            this.usersCB.Name = "usersCB";
            this.usersCB.Size = new System.Drawing.Size(175, 23);
            this.usersCB.TabIndex = 3;
            this.usersCB.SelectedIndexChanged += new System.EventHandler(this.usersCB_SelectedIndexChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(6, 99);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(149, 23);
            this.LoginBtn.TabIndex = 8;
            this.LoginBtn.Text = "Войти";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // SurnameTb
            // 
            this.SurnameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTb.Location = new System.Drawing.Point(257, 12);
            this.SurnameTb.Name = "SurnameTb";
            this.SurnameTb.Size = new System.Drawing.Size(231, 23);
            this.SurnameTb.TabIndex = 4;
            // 
            // NameTb
            // 
            this.NameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTb.Location = new System.Drawing.Point(257, 41);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(231, 23);
            this.NameTb.TabIndex = 5;
            // 
            // PatronymicTb
            // 
            this.PatronymicTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatronymicTb.Location = new System.Drawing.Point(257, 70);
            this.PatronymicTb.Name = "PatronymicTb";
            this.PatronymicTb.Size = new System.Drawing.Size(231, 23);
            this.PatronymicTb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отчество:";
            // 
            // PasswordTb
            // 
            this.PasswordTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTb.Location = new System.Drawing.Point(257, 99);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(231, 23);
            this.PasswordTb.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Пароль:";
            // 
            // LoadPb
            // 
            this.LoadPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoadPb.Image = global::mailClient.Properties.Resources.loading_gif;
            this.LoadPb.Location = new System.Drawing.Point(155, 100);
            this.LoadPb.Name = "LoadPb";
            this.LoadPb.Size = new System.Drawing.Size(25, 22);
            this.LoadPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadPb.TabIndex = 12;
            this.LoadPb.TabStop = false;
            // 
            // postgresSettingsBtn
            // 
            this.postgresSettingsBtn.Location = new System.Drawing.Point(98, 8);
            this.postgresSettingsBtn.Name = "postgresSettingsBtn";
            this.postgresSettingsBtn.Size = new System.Drawing.Size(83, 23);
            this.postgresSettingsBtn.TabIndex = 13;
            this.postgresSettingsBtn.Text = "PostgresSQL";
            this.postgresSettingsBtn.UseVisualStyleBackColor = true;
            this.postgresSettingsBtn.Click += new System.EventHandler(this.postgresSettingsBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Настроить БД:";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 129);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.postgresSettingsBtn);
            this.Controls.Add(this.LoadPb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.PatronymicTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.SurnameTb);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.usersCB);
            this.Controls.Add(this.label1);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация отправителя";
            this.VisibleChanged += new System.EventHandler(this.LoginView_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.LoadPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox usersCB;
        private Button LoginBtn;
        private TextBox SurnameTb;
        private TextBox NameTb;
        private TextBox PatronymicTb;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox PasswordTb;
        private Label label5;
        private PictureBox LoadPb;
        private Button postgresSettingsBtn;
        private Label label6;
    }
}