namespace WindowsFormsApp1
{
    partial class Form3
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
            this.comboBoxFigure = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecifications = new System.Windows.Forms.ComboBox();
            this.labelFigure = new System.Windows.Forms.Label();
            this.labelSpecifications = new System.Windows.Forms.Label();
            this.textBoxSpecifications1 = new System.Windows.Forms.TextBox();
            this.textBoxSpecifications2 = new System.Windows.Forms.TextBox();
            this.labelSpeaifications1 = new System.Windows.Forms.Label();
            this.labelSpeaifications2 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxFigure
            // 
            this.comboBoxFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFigure.FormattingEnabled = true;
            this.comboBoxFigure.Items.AddRange(new object[] {
            "Круг",
            "Квадрат",
            "Прямоугольник"});
            this.comboBoxFigure.Location = new System.Drawing.Point(15, 25);
            this.comboBoxFigure.Name = "comboBoxFigure";
            this.comboBoxFigure.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFigure.TabIndex = 0;
            this.comboBoxFigure.SelectedIndexChanged += new System.EventHandler(this.comboBoxFigure_SelectedIndexChanged);
            // 
            // comboBoxSpecifications
            // 
            this.comboBoxSpecifications.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecifications.FormattingEnabled = true;
            this.comboBoxSpecifications.Location = new System.Drawing.Point(12, 65);
            this.comboBoxSpecifications.Name = "comboBoxSpecifications";
            this.comboBoxSpecifications.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpecifications.TabIndex = 1;
            this.comboBoxSpecifications.Visible = false;
            this.comboBoxSpecifications.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpecifications_SelectedIndexChanged);
            // 
            // labelFigure
            // 
            this.labelFigure.AutoSize = true;
            this.labelFigure.Location = new System.Drawing.Point(12, 9);
            this.labelFigure.Name = "labelFigure";
            this.labelFigure.Size = new System.Drawing.Size(95, 13);
            this.labelFigure.TabIndex = 3;
            this.labelFigure.Text = "Выберите фигуру";
            // 
            // labelSpecifications
            // 
            this.labelSpecifications.AutoSize = true;
            this.labelSpecifications.Location = new System.Drawing.Point(12, 49);
            this.labelSpecifications.Name = "labelSpecifications";
            this.labelSpecifications.Size = new System.Drawing.Size(153, 13);
            this.labelSpecifications.TabIndex = 4;
            this.labelSpecifications.Text = "Что вам известно о фигуре?";
            this.labelSpecifications.Visible = false;
            // 
            // textBoxSpecifications1
            // 
            this.textBoxSpecifications1.Location = new System.Drawing.Point(176, 25);
            this.textBoxSpecifications1.Name = "textBoxSpecifications1";
            this.textBoxSpecifications1.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpecifications1.TabIndex = 5;
            this.textBoxSpecifications1.Visible = false;
            // 
            // textBoxSpecifications2
            // 
            this.textBoxSpecifications2.Location = new System.Drawing.Point(176, 66);
            this.textBoxSpecifications2.Name = "textBoxSpecifications2";
            this.textBoxSpecifications2.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpecifications2.TabIndex = 6;
            this.textBoxSpecifications2.Visible = false;
            // 
            // labelSpeaifications1
            // 
            this.labelSpeaifications1.AutoSize = true;
            this.labelSpeaifications1.Location = new System.Drawing.Point(173, 9);
            this.labelSpeaifications1.Name = "labelSpeaifications1";
            this.labelSpeaifications1.Size = new System.Drawing.Size(10, 13);
            this.labelSpeaifications1.TabIndex = 7;
            this.labelSpeaifications1.Text = " ";
            // 
            // labelSpeaifications2
            // 
            this.labelSpeaifications2.AutoSize = true;
            this.labelSpeaifications2.Location = new System.Drawing.Point(173, 50);
            this.labelSpeaifications2.Name = "labelSpeaifications2";
            this.labelSpeaifications2.Size = new System.Drawing.Size(10, 13);
            this.labelSpeaifications2.TabIndex = 8;
            this.labelSpeaifications2.Text = " ";
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Image = global::WindowsFormsApp1.Properties.Resources.ок;
            this.buttonOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOk.Location = new System.Drawing.Point(78, 113);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(131, 39);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Готово";
            this.buttonOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(293, 166);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelSpeaifications2);
            this.Controls.Add(this.labelSpeaifications1);
            this.Controls.Add(this.textBoxSpecifications2);
            this.Controls.Add(this.textBoxSpecifications1);
            this.Controls.Add(this.labelSpecifications);
            this.Controls.Add(this.labelFigure);
            this.Controls.Add(this.comboBoxSpecifications);
            this.Controls.Add(this.comboBoxFigure);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Добавление фигуры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFigure;
        private System.Windows.Forms.ComboBox comboBoxSpecifications;
        private System.Windows.Forms.Label labelFigure;
        private System.Windows.Forms.Label labelSpecifications;
        private System.Windows.Forms.TextBox textBoxSpecifications1;
        private System.Windows.Forms.TextBox textBoxSpecifications2;
        private System.Windows.Forms.Label labelSpeaifications1;
        private System.Windows.Forms.Label labelSpeaifications2;
        private System.Windows.Forms.Button buttonOk;
    }
}