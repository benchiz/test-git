namespace WindowsFormsApp_sessionSecond
{
    partial class delAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delAdmin));
            this.label_ID = new System.Windows.Forms.Label();
            this.ID_Place = new System.Windows.Forms.TextBox();
            this.delPlace = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.label_ID.Location = new System.Drawing.Point(263, 179);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 18);
            this.label_ID.TabIndex = 17;
            this.label_ID.Text = "ID";
            // 
            // ID_Place
            // 
            this.ID_Place.Location = new System.Drawing.Point(351, 165);
            this.ID_Place.Multiline = true;
            this.ID_Place.Name = "ID_Place";
            this.ID_Place.Size = new System.Drawing.Size(193, 32);
            this.ID_Place.TabIndex = 16;
            // 
            // delPlace
            // 
            this.delPlace.AutoSize = true;
            this.delPlace.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delPlace.Location = new System.Drawing.Point(327, 59);
            this.delPlace.Name = "delPlace";
            this.delPlace.Size = new System.Drawing.Size(125, 18);
            this.delPlace.TabIndex = 18;
            this.delPlace.Text = "Удаление услуги";
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.delButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F);
            this.delButton.ForeColor = System.Drawing.SystemColors.Control;
            this.delButton.Location = new System.Drawing.Point(330, 293);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(105, 33);
            this.delButton.TabIndex = 19;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.backButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.Control;
            this.backButton.Location = new System.Drawing.Point(666, 49);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 28);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "Вернуться";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // delAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.delPlace);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.ID_Place);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delAdmin";
            this.Text = "Удалить услугу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox ID_Place;
        private System.Windows.Forms.Label delPlace;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button backButton;
    }
}