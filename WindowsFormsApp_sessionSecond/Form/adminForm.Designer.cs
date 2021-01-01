namespace WindowsFormsApp_sessionSecond
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.defPanel = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.adminPlace = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.panelService = new System.Windows.Forms.Panel();
            this.defPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // defPanel
            // 
            this.defPanel.Controls.Add(this.buttonAdd);
            this.defPanel.Controls.Add(this.buttonDel);
            this.defPanel.Controls.Add(this.adminPlace);
            this.defPanel.Controls.Add(this.buttonEdit);
            this.defPanel.Controls.Add(this.logoPicture);
            this.defPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.defPanel.Location = new System.Drawing.Point(0, 0);
            this.defPanel.Name = "defPanel";
            this.defPanel.Size = new System.Drawing.Size(800, 72);
            this.defPanel.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.buttonAdd.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(525, 16);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(141, 35);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.buttonDel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F);
            this.buttonDel.Location = new System.Drawing.Point(672, 16);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(107, 35);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // adminPlace
            // 
            this.adminPlace.AutoSize = true;
            this.adminPlace.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPlace.Location = new System.Drawing.Point(153, 25);
            this.adminPlace.Name = "adminPlace";
            this.adminPlace.Size = new System.Drawing.Size(175, 18);
            this.adminPlace.TabIndex = 3;
            this.adminPlace.Text = "Режим администратора";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.buttonEdit.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(369, 16);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(141, 35);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // logoPicture
            // 
            this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
            this.logoPicture.Location = new System.Drawing.Point(15, 13);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(82, 41);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 2;
            this.logoPicture.TabStop = false;
            // 
            // panelService
            // 
            this.panelService.AutoScroll = true;
            this.panelService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelService.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelService.Location = new System.Drawing.Point(0, 90);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(800, 360);
            this.panelService.TabIndex = 1;
            this.panelService.Paint += new System.Windows.Forms.PaintEventHandler(this.panelService_Paint);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelService);
            this.Controls.Add(this.defPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminForm";
            this.Text = "Подай на 16";
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.defPanel.ResumeLayout(false);
            this.defPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel defPanel;
        private System.Windows.Forms.Panel panelService;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label adminPlace;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Button buttonAdd;
    }
}