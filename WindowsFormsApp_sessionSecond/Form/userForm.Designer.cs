namespace WindowsFormsApp_sessionSecond
{
    partial class userForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.action_exit = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.header_service = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.Controls.Add(this.action_exit);
            this.panelHeader.Controls.Add(this.logo);
            this.panelHeader.Controls.Add(this.header_service);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 75);
            this.panelHeader.TabIndex = 0;
            // 
            // action_exit
            // 
            this.action_exit.BackColor = System.Drawing.Color.White;
            this.action_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.action_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_exit.Location = new System.Drawing.Point(616, 21);
            this.action_exit.Name = "action_exit";
            this.action_exit.Size = new System.Drawing.Size(162, 42);
            this.action_exit.TabIndex = 16;
            this.action_exit.Text = "Выйти";
            this.action_exit.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 21);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(85, 36);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 14;
            this.logo.TabStop = false;
            // 
            // header_service
            // 
            this.header_service.AutoSize = true;
            this.header_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.header_service.Location = new System.Drawing.Point(103, 26);
            this.header_service.Name = "header_service";
            this.header_service.Size = new System.Drawing.Size(163, 29);
            this.header_service.TabIndex = 15;
            this.header_service.Text = "Наши услуги";
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Cursor = System.Windows.Forms.Cursors.No;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(0, 95);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 355);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "userForm";
            this.Text = "Наши услуги";
            this.Load += new System.EventHandler(this.userForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button action_exit;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label header_service;
        private System.Windows.Forms.Panel panelMain;
    }
}