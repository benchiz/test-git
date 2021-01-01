namespace WindowsFormsApp_sessionSecond
{
    partial class EditAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAdmin));
            this.backButton = new System.Windows.Forms.Button();
            this.editPlace = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelImagePath = new System.Windows.Forms.Label();
            this.titlePlace = new System.Windows.Forms.TextBox();
            this.timePlace = new System.Windows.Forms.TextBox();
            this.costPlace = new System.Windows.Forms.TextBox();
            this.discountPlace = new System.Windows.Forms.TextBox();
            this.imgpathPlace = new System.Windows.Forms.TextBox();
            this.saveeditButton = new System.Windows.Forms.Button();
            this.ID_Place = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.backButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.Control;
            this.backButton.Location = new System.Drawing.Point(665, 392);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 28);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Вернуться";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // editPlace
            // 
            this.editPlace.AutoSize = true;
            this.editPlace.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPlace.Location = new System.Drawing.Point(303, 30);
            this.editPlace.Name = "editPlace";
            this.editPlace.Size = new System.Drawing.Size(172, 18);
            this.editPlace.TabIndex = 1;
            this.editPlace.Text = "Редактирование услуги";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.labelTitle.Location = new System.Drawing.Point(12, 114);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(160, 18);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Наименование услуги";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.labelCost.Location = new System.Drawing.Point(36, 286);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(92, 18);
            this.labelCost.TabIndex = 4;
            this.labelCost.Text = "Цена услуги";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.labelDiscount.Location = new System.Drawing.Point(460, 114);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(60, 18);
            this.labelDiscount.TabIndex = 5;
            this.labelDiscount.Text = "Скидка";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.labelTime.Location = new System.Drawing.Point(11, 195);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(161, 18);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Длительность (в сек.)";
            // 
            // labelImagePath
            // 
            this.labelImagePath.AutoSize = true;
            this.labelImagePath.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.labelImagePath.Location = new System.Drawing.Point(460, 195);
            this.labelImagePath.Name = "labelImagePath";
            this.labelImagePath.Size = new System.Drawing.Size(130, 18);
            this.labelImagePath.TabIndex = 7;
            this.labelImagePath.Text = "Путь до картинки";
            // 
            // titlePlace
            // 
            this.titlePlace.Location = new System.Drawing.Point(226, 97);
            this.titlePlace.Multiline = true;
            this.titlePlace.Name = "titlePlace";
            this.titlePlace.Size = new System.Drawing.Size(193, 35);
            this.titlePlace.TabIndex = 8;
            // 
            // timePlace
            // 
            this.timePlace.Location = new System.Drawing.Point(226, 178);
            this.timePlace.Multiline = true;
            this.timePlace.Name = "timePlace";
            this.timePlace.Size = new System.Drawing.Size(193, 35);
            this.timePlace.TabIndex = 9;
            // 
            // costPlace
            // 
            this.costPlace.Location = new System.Drawing.Point(226, 269);
            this.costPlace.Multiline = true;
            this.costPlace.Name = "costPlace";
            this.costPlace.Size = new System.Drawing.Size(193, 35);
            this.costPlace.TabIndex = 10;
            // 
            // discountPlace
            // 
            this.discountPlace.Location = new System.Drawing.Point(595, 97);
            this.discountPlace.Multiline = true;
            this.discountPlace.Name = "discountPlace";
            this.discountPlace.Size = new System.Drawing.Size(193, 35);
            this.discountPlace.TabIndex = 11;
            // 
            // imgpathPlace
            // 
            this.imgpathPlace.Location = new System.Drawing.Point(595, 181);
            this.imgpathPlace.Multiline = true;
            this.imgpathPlace.Name = "imgpathPlace";
            this.imgpathPlace.Size = new System.Drawing.Size(193, 32);
            this.imgpathPlace.TabIndex = 12;
            // 
            // saveeditButton
            // 
            this.saveeditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.saveeditButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.saveeditButton.ForeColor = System.Drawing.SystemColors.Control;
            this.saveeditButton.Location = new System.Drawing.Point(378, 344);
            this.saveeditButton.Name = "saveeditButton";
            this.saveeditButton.Size = new System.Drawing.Size(105, 33);
            this.saveeditButton.TabIndex = 13;
            this.saveeditButton.Text = "Сохранить";
            this.saveeditButton.UseVisualStyleBackColor = false;
            this.saveeditButton.Click += new System.EventHandler(this.saveeditButton_Click);
            // 
            // ID_Place
            // 
            this.ID_Place.Location = new System.Drawing.Point(595, 269);
            this.ID_Place.Multiline = true;
            this.ID_Place.Name = "ID_Place";
            this.ID_Place.Size = new System.Drawing.Size(193, 32);
            this.ID_Place.TabIndex = 14;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.label_ID.Location = new System.Drawing.Point(462, 286);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 18);
            this.label_ID.TabIndex = 15;
            this.label_ID.Text = "ID";
            // 
            // EditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.ID_Place);
            this.Controls.Add(this.saveeditButton);
            this.Controls.Add(this.imgpathPlace);
            this.Controls.Add(this.discountPlace);
            this.Controls.Add(this.costPlace);
            this.Controls.Add(this.timePlace);
            this.Controls.Add(this.titlePlace);
            this.Controls.Add(this.labelImagePath);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.editPlace);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditAdmin";
            this.Text = "Редактировать услугу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label editPlace;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelImagePath;
        private System.Windows.Forms.TextBox titlePlace;
        private System.Windows.Forms.TextBox timePlace;
        private System.Windows.Forms.TextBox costPlace;
        private System.Windows.Forms.TextBox discountPlace;
        private System.Windows.Forms.TextBox imgpathPlace;
        private System.Windows.Forms.Button saveeditButton;
        private System.Windows.Forms.TextBox ID_Place;
        private System.Windows.Forms.Label label_ID;
    }
}