namespace mailClient
{
    partial class SettingsView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hostTb = new System.Windows.Forms.TextBox();
            this.userTb = new System.Windows.Forms.TextBox();
            this.passTb = new System.Windows.Forms.TextBox();
            this.dbTb = new System.Windows.Forms.TextBox();
            this.portTb = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Хост:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Роль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "База данных:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Порт:";
            // 
            // hostTb
            // 
            this.hostTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hostTb.Location = new System.Drawing.Point(78, 6);
            this.hostTb.Name = "hostTb";
            this.hostTb.Size = new System.Drawing.Size(132, 23);
            this.hostTb.TabIndex = 1;
            this.hostTb.Text = "199.199.199.199";
            // 
            // userTb
            // 
            this.userTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTb.Location = new System.Drawing.Point(78, 33);
            this.userTb.Name = "userTb";
            this.userTb.Size = new System.Drawing.Size(132, 23);
            this.userTb.TabIndex = 2;
            this.userTb.Text = "role_user";
            // 
            // passTb
            // 
            this.passTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passTb.Location = new System.Drawing.Point(78, 60);
            this.passTb.Name = "passTb";
            this.passTb.Size = new System.Drawing.Size(132, 23);
            this.passTb.TabIndex = 3;
            this.passTb.Text = "for_use";
            // 
            // dbTb
            // 
            this.dbTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbTb.Location = new System.Drawing.Point(78, 87);
            this.dbTb.Name = "dbTb";
            this.dbTb.Size = new System.Drawing.Size(132, 23);
            this.dbTb.TabIndex = 4;
            this.dbTb.Text = "employees";
            // 
            // portTb
            // 
            this.portTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portTb.Location = new System.Drawing.Point(78, 114);
            this.portTb.Name = "portTb";
            this.portTb.Size = new System.Drawing.Size(132, 23);
            this.portTb.TabIndex = 5;
            this.portTb.Text = "5432";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(4, 143);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(206, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 170);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.portTb);
            this.Controls.Add(this.dbTb);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.userTb);
            this.Controls.Add(this.hostTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsView";
            this.Text = "SettingsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox hostTb;
        private TextBox userTb;
        private TextBox passTb;
        private TextBox dbTb;
        private TextBox portTb;
        private Button SaveBtn;
    }
}