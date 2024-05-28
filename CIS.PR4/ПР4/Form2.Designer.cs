namespace ПР4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonDown = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.labelSpecial = new System.Windows.Forms.Label();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelProgramm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonDown.Image = global::ПР4.Properties.Resources.вернуться;
            this.buttonDown.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDown.Location = new System.Drawing.Point(337, 218);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(94, 38);
            this.buttonDown.TabIndex = 40;
            this.buttonDown.Text = "Назад";
            this.buttonDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(11, 224);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 17);
            this.labelEmail.TabIndex = 44;
            this.labelEmail.Text = "E-mail:";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(68, 228);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(145, 13);
            this.linkLabel.TabIndex = 39;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "pavel121120062@gmail.com";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // labelSpecial
            // 
            this.labelSpecial.AutoSize = true;
            this.labelSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecial.Location = new System.Drawing.Point(11, 193);
            this.labelSpecial.Name = "labelSpecial";
            this.labelSpecial.Size = new System.Drawing.Size(443, 17);
            this.labelSpecial.TabIndex = 43;
            this.labelSpecial.Text = "Специальность: Информационные Системы и Программирование";
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeveloper.Location = new System.Drawing.Point(11, 166);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(238, 17);
            this.labelDeveloper.TabIndex = 42;
            this.labelDeveloper.Text = "Разработал: студент Погудин П.Д.";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(118, 57);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(207, 95);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 41;
            this.pictureBox.TabStop = false;
            // 
            // labelProgramm
            // 
            this.labelProgramm.AutoSize = true;
            this.labelProgramm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProgramm.Location = new System.Drawing.Point(29, 11);
            this.labelProgramm.Name = "labelProgramm";
            this.labelProgramm.Size = new System.Drawing.Size(391, 24);
            this.labelProgramm.TabIndex = 38;
            this.labelProgramm.Text = "Программа \"Практическая работа №1\"";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 266);
            this.ControlBox = false;
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.labelSpecial);
            this.Controls.Add(this.labelDeveloper);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelProgramm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label labelSpecial;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelProgramm;
    }
}