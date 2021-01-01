namespace WindowsFormsApp_sessionSecond
{
    partial class AddService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddService));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelAdd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ImagePath = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.inputImagePath = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.inputCost = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.inputDiscount = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.inputTime = new System.Windows.Forms.TextBox();
            this.lableTitle = new System.Windows.Forms.Label();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.buttonExit);
            this.panelHeader.Controls.Add(this.labelAdd);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 82);
            this.panelHeader.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.buttonExit.Location = new System.Drawing.Point(505, 16);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(212, 51);
            this.buttonExit.TabIndex = 31;
            this.buttonExit.Text = "Вернуться";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.labelAdd.Location = new System.Drawing.Point(195, 22);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(241, 29);
            this.labelAdd.TabIndex = 30;
            this.labelAdd.Text = "Добавление услуги";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_ImagePath);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.inputImagePath);
            this.panel1.Controls.Add(this.labelCost);
            this.panel1.Controls.Add(this.inputCost);
            this.panel1.Controls.Add(this.labelDiscount);
            this.panel1.Controls.Add(this.inputDiscount);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.inputTime);
            this.panel1.Controls.Add(this.lableTitle);
            this.panel1.Controls.Add(this.inputTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 368);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_ImagePath
            // 
            this.label_ImagePath.AutoSize = true;
            this.label_ImagePath.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.label_ImagePath.Location = new System.Drawing.Point(512, 110);
            this.label_ImagePath.Name = "label_ImagePath";
            this.label_ImagePath.Size = new System.Drawing.Size(130, 18);
            this.label_ImagePath.TabIndex = 39;
            this.label_ImagePath.Text = "Путь до картинки";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(304, 267);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(212, 52);
            this.buttonAdd.TabIndex = 38;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // inputImagePath
            // 
            this.inputImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.inputImagePath.Location = new System.Drawing.Point(515, 131);
            this.inputImagePath.Name = "inputImagePath";
            this.inputImagePath.Size = new System.Drawing.Size(218, 31);
            this.inputImagePath.TabIndex = 37;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.labelCost.Location = new System.Drawing.Point(512, 50);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(43, 18);
            this.labelCost.TabIndex = 36;
            this.labelCost.Text = "Цена";
            // 
            // inputCost
            // 
            this.inputCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.inputCost.Location = new System.Drawing.Point(515, 71);
            this.inputCost.Name = "inputCost";
            this.inputCost.Size = new System.Drawing.Size(218, 31);
            this.inputCost.TabIndex = 35;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.labelDiscount.Location = new System.Drawing.Point(301, 176);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(60, 18);
            this.labelDiscount.TabIndex = 34;
            this.labelDiscount.Text = "Скидка";
            // 
            // inputDiscount
            // 
            this.inputDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.inputDiscount.Location = new System.Drawing.Point(304, 197);
            this.inputDiscount.Name = "inputDiscount";
            this.inputDiscount.Size = new System.Drawing.Size(212, 31);
            this.inputDiscount.TabIndex = 33;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.labelTime.Location = new System.Drawing.Point(68, 110);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(161, 18);
            this.labelTime.TabIndex = 32;
            this.labelTime.Text = "Время работы (в сек.)";
            // 
            // inputTime
            // 
            this.inputTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.inputTime.Location = new System.Drawing.Point(71, 131);
            this.inputTime.Name = "inputTime";
            this.inputTime.Size = new System.Drawing.Size(234, 31);
            this.inputTime.TabIndex = 31;
            // 
            // lableTitle
            // 
            this.lableTitle.AutoSize = true;
            this.lableTitle.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.lableTitle.Location = new System.Drawing.Point(68, 50);
            this.lableTitle.Name = "lableTitle";
            this.lableTitle.Size = new System.Drawing.Size(111, 18);
            this.lableTitle.TabIndex = 30;
            this.lableTitle.Text = "Наименование";
            // 
            // inputTitle
            // 
            this.inputTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.inputTitle.Location = new System.Drawing.Point(71, 71);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(234, 31);
            this.inputTitle.TabIndex = 29;
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddService";
            this.Text = "Добавить услугу";
            this.Load += new System.EventHandler(this.AddService_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_ImagePath;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox inputImagePath;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox inputCost;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox inputDiscount;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox inputTime;
        private System.Windows.Forms.Label lableTitle;
        private System.Windows.Forms.TextBox inputTitle;
    }
}