namespace mailClient
{
    partial class ContactView
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.contactsDGV = new System.Windows.Forms.DataGridView();
            this.EmailAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберете контакт из списка:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(207, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(136, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(5, 3);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(92, 23);
            this.acceptBtn.TabIndex = 3;
            this.acceptBtn.Text = "ОК";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.acceptBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 31);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // contactsDGV
            // 
            this.contactsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmailAdress,
            this.FullName,
            this.id});
            this.contactsDGV.Location = new System.Drawing.Point(0, 18);
            this.contactsDGV.Name = "contactsDGV";
            this.contactsDGV.RowTemplate.Height = 25;
            this.contactsDGV.Size = new System.Drawing.Size(354, 259);
            this.contactsDGV.TabIndex = 4;
            // 
            // EmailAdress
            // 
            this.EmailAdress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmailAdress.HeaderText = "Адрес эл. почты";
            this.EmailAdress.Name = "EmailAdress";
            this.EmailAdress.Width = 112;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            this.FullName.ToolTipText = "Необязательно для заполнения";
            this.FullName.Width = 59;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ContactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 311);
            this.Controls.Add(this.contactsDGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ContactView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контакты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactView_FormClosing);
            this.Load += new System.EventHandler(this.ContactView_Load);
            this.VisibleChanged += new System.EventHandler(this.ContactView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contactsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button cancelBtn;
        private Button acceptBtn;
        private Panel panel1;
        private Button button1;
        private DataGridView contactsDGV;
        private DataGridViewTextBoxColumn EmailAdress;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn id;
    }
}