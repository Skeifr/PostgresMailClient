namespace mailClient
{
    partial class MessageView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.recipientTb = new System.Windows.Forms.TextBox();
            this.RecipierLb = new System.Windows.Forms.Label();
            this.CopyRecipierLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.copyRecipientTb = new System.Windows.Forms.TextBox();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.recipientContactsPb = new System.Windows.Forms.PictureBox();
            this.copyRecipientContactsPb = new System.Windows.Forms.PictureBox();
            this.messageTb = new System.Windows.Forms.RichTextBox();
            this.LoadPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.recipientContactsPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyRecipientContactsPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadPb)).BeginInit();
            this.SuspendLayout();
            // 
            // recipientTb
            // 
            this.recipientTb.Location = new System.Drawing.Point(106, 7);
            this.recipientTb.Name = "recipientTb";
            this.recipientTb.Size = new System.Drawing.Size(745, 23);
            this.recipientTb.TabIndex = 0;
            // 
            // RecipierLb
            // 
            this.RecipierLb.AutoSize = true;
            this.RecipierLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecipierLb.Location = new System.Drawing.Point(36, 15);
            this.RecipierLb.Name = "RecipierLb";
            this.RecipierLb.Size = new System.Drawing.Size(45, 15);
            this.RecipierLb.TabIndex = 1;
            this.RecipierLb.Text = "Кому...";
            this.RecipierLb.Click += new System.EventHandler(this.recipientContactsPb_Click);
            this.RecipierLb.MouseEnter += new System.EventHandler(this.RecipierLb_MouseEnter);
            this.RecipierLb.MouseLeave += new System.EventHandler(this.RecipierLb_MouseLeave);
            // 
            // CopyRecipierLb
            // 
            this.CopyRecipierLb.AutoSize = true;
            this.CopyRecipierLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyRecipierLb.Location = new System.Drawing.Point(36, 44);
            this.CopyRecipierLb.Name = "CopyRecipierLb";
            this.CopyRecipierLb.Size = new System.Drawing.Size(50, 15);
            this.CopyRecipierLb.TabIndex = 2;
            this.CopyRecipierLb.Text = "Копия...";
            this.CopyRecipierLb.Click += new System.EventHandler(this.copyRecipientContactsPb_Click);
            this.CopyRecipierLb.MouseEnter += new System.EventHandler(this.RecipierLb_MouseEnter);
            this.CopyRecipierLb.MouseLeave += new System.EventHandler(this.RecipierLb_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тема (название):";
            // 
            // sendButton
            // 
            this.sendButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendButton.Location = new System.Drawing.Point(0, 479);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(854, 32);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // copyRecipientTb
            // 
            this.copyRecipientTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyRecipientTb.Location = new System.Drawing.Point(106, 36);
            this.copyRecipientTb.Name = "copyRecipientTb";
            this.copyRecipientTb.Size = new System.Drawing.Size(745, 23);
            this.copyRecipientTb.TabIndex = 5;
            // 
            // titleTb
            // 
            this.titleTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTb.Location = new System.Drawing.Point(106, 65);
            this.titleTb.Name = "titleTb";
            this.titleTb.Size = new System.Drawing.Size(745, 23);
            this.titleTb.TabIndex = 6;
            // 
            // recipientContactsPb
            // 
            this.recipientContactsPb.BackgroundImage = global::mailClient.Properties.Resources.contact_icon_png_8;
            this.recipientContactsPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.recipientContactsPb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recipientContactsPb.Location = new System.Drawing.Point(0, 12);
            this.recipientContactsPb.Name = "recipientContactsPb";
            this.recipientContactsPb.Size = new System.Drawing.Size(39, 18);
            this.recipientContactsPb.TabIndex = 7;
            this.recipientContactsPb.TabStop = false;
            this.recipientContactsPb.Click += new System.EventHandler(this.recipientContactsPb_Click);
            // 
            // copyRecipientContactsPb
            // 
            this.copyRecipientContactsPb.BackgroundImage = global::mailClient.Properties.Resources.contact_icon_png_8;
            this.copyRecipientContactsPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copyRecipientContactsPb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyRecipientContactsPb.Location = new System.Drawing.Point(0, 41);
            this.copyRecipientContactsPb.Name = "copyRecipientContactsPb";
            this.copyRecipientContactsPb.Size = new System.Drawing.Size(39, 18);
            this.copyRecipientContactsPb.TabIndex = 8;
            this.copyRecipientContactsPb.TabStop = false;
            this.copyRecipientContactsPb.Click += new System.EventHandler(this.copyRecipientContactsPb_Click);
            // 
            // messageTb
            // 
            this.messageTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTb.Location = new System.Drawing.Point(2, 94);
            this.messageTb.Name = "messageTb";
            this.messageTb.Size = new System.Drawing.Size(849, 379);
            this.messageTb.TabIndex = 10;
            this.messageTb.Text = "";
            // 
            // LoadPb
            // 
            this.LoadPb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoadPb.Image = global::mailClient.Properties.Resources.loading_gif;
            this.LoadPb.Location = new System.Drawing.Point(775, 7);
            this.LoadPb.Name = "LoadPb";
            this.LoadPb.Size = new System.Drawing.Size(76, 81);
            this.LoadPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadPb.TabIndex = 11;
            this.LoadPb.TabStop = false;
            this.LoadPb.Visible = false;
            this.LoadPb.VisibleChanged += new System.EventHandler(this.LoadPb_VisibleChanged);
            // 
            // MessageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 511);
            this.Controls.Add(this.LoadPb);
            this.Controls.Add(this.messageTb);
            this.Controls.Add(this.copyRecipientContactsPb);
            this.Controls.Add(this.recipientContactsPb);
            this.Controls.Add(this.titleTb);
            this.Controls.Add(this.copyRecipientTb);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CopyRecipierLb);
            this.Controls.Add(this.RecipierLb);
            this.Controls.Add(this.recipientTb);
            this.Name = "MessageView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправка сообщения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessageView_FormClosing);
            this.Load += new System.EventHandler(this.MessageView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipientContactsPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyRecipientContactsPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox recipientTb;
        private Label RecipierLb;
        private Label CopyRecipierLb;
        private Label label3;
        private Button sendButton;
        private TextBox copyRecipientTb;
        private TextBox titleTb;
        private PictureBox recipientContactsPb;
        private PictureBox copyRecipientContactsPb;
        private RichTextBox messageTb;
        private PictureBox LoadPb;
    }
}