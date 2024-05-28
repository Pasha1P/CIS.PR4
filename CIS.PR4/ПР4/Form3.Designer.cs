namespace ПР4
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
            this.components = new System.ComponentModel.Container();
            this.labelSpecifications2 = new System.Windows.Forms.Label();
            this.labelSpecifications1 = new System.Windows.Forms.Label();
            this.textBoxSpecifications2 = new System.Windows.Forms.TextBox();
            this.textBoxSpecifications1 = new System.Windows.Forms.TextBox();
            this.labelSpecifications = new System.Windows.Forms.Label();
            this.labelFigure = new System.Windows.Forms.Label();
            this.comboBoxSpecifications = new System.Windows.Forms.ComboBox();
            this.comboBoxFigure = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelTilt = new System.Windows.Forms.Label();
            this.textBoxTilt = new System.Windows.Forms.TextBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSpecifications2
            // 
            this.labelSpecifications2.AutoSize = true;
            this.labelSpecifications2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecifications2.Location = new System.Drawing.Point(289, 71);
            this.labelSpecifications2.Name = "labelSpecifications2";
            this.labelSpecifications2.Size = new System.Drawing.Size(264, 24);
            this.labelSpecifications2.TabIndex = 22;
            this.labelSpecifications2.Text = "Введите соседнюю сторону";
            this.labelSpecifications2.Visible = false;
            // 
            // labelSpecifications1
            // 
            this.labelSpecifications1.AutoSize = true;
            this.labelSpecifications1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecifications1.Location = new System.Drawing.Point(289, 9);
            this.labelSpecifications1.Name = "labelSpecifications1";
            this.labelSpecifications1.Size = new System.Drawing.Size(15, 24);
            this.labelSpecifications1.TabIndex = 21;
            this.labelSpecifications1.Text = " ";
            // 
            // textBoxSpecifications2
            // 
            this.textBoxSpecifications2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSpecifications2.Location = new System.Drawing.Point(453, 101);
            this.textBoxSpecifications2.Name = "textBoxSpecifications2";
            this.textBoxSpecifications2.Size = new System.Drawing.Size(100, 29);
            this.textBoxSpecifications2.TabIndex = 17;
            this.textBoxSpecifications2.Visible = false;
            this.textBoxSpecifications2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSpecifications2_TextChanged);
            // 
            // textBoxSpecifications1
            // 
            this.textBoxSpecifications1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSpecifications1.Location = new System.Drawing.Point(453, 39);
            this.textBoxSpecifications1.Name = "textBoxSpecifications1";
            this.textBoxSpecifications1.Size = new System.Drawing.Size(100, 29);
            this.textBoxSpecifications1.TabIndex = 16;
            this.textBoxSpecifications1.Visible = false;
            this.textBoxSpecifications1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSpecifications1_TextChanged);
            // 
            // labelSpecifications
            // 
            this.labelSpecifications.AutoSize = true;
            this.labelSpecifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecifications.Location = new System.Drawing.Point(12, 71);
            this.labelSpecifications.Name = "labelSpecifications";
            this.labelSpecifications.Size = new System.Drawing.Size(267, 24);
            this.labelSpecifications.TabIndex = 15;
            this.labelSpecifications.Text = "Что вам известно о фигуре?";
            this.labelSpecifications.Visible = false;
            // 
            // labelFigure
            // 
            this.labelFigure.AutoSize = true;
            this.labelFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFigure.Location = new System.Drawing.Point(12, 9);
            this.labelFigure.Name = "labelFigure";
            this.labelFigure.Size = new System.Drawing.Size(168, 24);
            this.labelFigure.TabIndex = 14;
            this.labelFigure.Text = "Выберите фигуру";
            // 
            // comboBoxSpecifications
            // 
            this.comboBoxSpecifications.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSpecifications.FormattingEnabled = true;
            this.comboBoxSpecifications.Location = new System.Drawing.Point(16, 98);
            this.comboBoxSpecifications.Name = "comboBoxSpecifications";
            this.comboBoxSpecifications.Size = new System.Drawing.Size(197, 32);
            this.comboBoxSpecifications.TabIndex = 13;
            this.comboBoxSpecifications.Visible = false;
            this.comboBoxSpecifications.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSpecifications_SelectedIndexChanged);
            // 
            // comboBoxFigure
            // 
            this.comboBoxFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFigure.FormattingEnabled = true;
            this.comboBoxFigure.Items.AddRange(new object[] {
            "Круг",
            "Квадрат",
            "Прямоугольник"});
            this.comboBoxFigure.Location = new System.Drawing.Point(16, 36);
            this.comboBoxFigure.Name = "comboBoxFigure";
            this.comboBoxFigure.Size = new System.Drawing.Size(197, 32);
            this.comboBoxFigure.TabIndex = 12;
            this.comboBoxFigure.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFigure_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(12, 133);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(201, 24);
            this.labelX.TabIndex = 24;
            this.labelX.Text = " Положение по оси X";
            this.labelX.Visible = false;
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.Location = new System.Drawing.Point(16, 160);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 29);
            this.textBoxX.TabIndex = 23;
            this.textBoxX.Visible = false;
            this.textBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxX_TextChanged);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(289, 133);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(194, 24);
            this.labelY.TabIndex = 26;
            this.labelY.Text = "Положение по оси Y";
            this.labelY.Visible = false;
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxY.Location = new System.Drawing.Point(453, 160);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 29);
            this.textBoxY.TabIndex = 25;
            this.textBoxY.Visible = false;
            this.textBoxY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxY_TextChanged);
            // 
            // labelTilt
            // 
            this.labelTilt.AutoSize = true;
            this.labelTilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTilt.Location = new System.Drawing.Point(169, 180);
            this.labelTilt.Name = "labelTilt";
            this.labelTilt.Size = new System.Drawing.Size(212, 24);
            this.labelTilt.TabIndex = 28;
            this.labelTilt.Text = "Какой наклон фигуры?";
            this.labelTilt.Visible = false;
            // 
            // textBoxTilt
            // 
            this.textBoxTilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTilt.Location = new System.Drawing.Point(225, 207);
            this.textBoxTilt.Name = "textBoxTilt";
            this.textBoxTilt.Size = new System.Drawing.Size(100, 29);
            this.textBoxTilt.TabIndex = 27;
            this.textBoxTilt.Visible = false;
            this.textBoxTilt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxTilt_TextChanged);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Image = global::ПР4.Properties.Resources.ex;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.Location = new System.Drawing.Point(422, 229);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(131, 39);
            this.buttonClose.TabIndex = 29;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Image = global::ПР4.Properties.Resources.ок;
            this.buttonOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOk.Location = new System.Drawing.Point(16, 229);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(131, 39);
            this.buttonOk.TabIndex = 20;
            this.buttonOk.Text = "Готово";
            this.buttonOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Visible = false;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(569, 278);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelTilt);
            this.Controls.Add(this.textBoxTilt);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelSpecifications2);
            this.Controls.Add(this.labelSpecifications1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxSpecifications2);
            this.Controls.Add(this.textBoxSpecifications1);
            this.Controls.Add(this.labelSpecifications);
            this.Controls.Add(this.labelFigure);
            this.Controls.Add(this.comboBoxSpecifications);
            this.Controls.Add(this.comboBoxFigure);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление фигуры";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSpecifications2;
        private System.Windows.Forms.Label labelSpecifications1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxSpecifications2;
        private System.Windows.Forms.TextBox textBoxSpecifications1;
        private System.Windows.Forms.Label labelSpecifications;
        private System.Windows.Forms.Label labelFigure;
        private System.Windows.Forms.ComboBox comboBoxSpecifications;
        private System.Windows.Forms.ComboBox comboBoxFigure;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelTilt;
        private System.Windows.Forms.TextBox textBoxTilt;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button buttonClose;
    }
}