namespace ПР4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFigure = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.Figure = new System.Windows.Forms.ToolStripMenuItem();
            this.XY = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDell = new System.Windows.Forms.ToolStripMenuItem();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelInf = new System.Windows.Forms.Label();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemInfo,
            this.ToolStripMenuItemFigure});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemInfo
            // 
            this.ToolStripMenuItemInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemProgramm});
            this.ToolStripMenuItemInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItemInfo.Name = "ToolStripMenuItemInfo";
            this.ToolStripMenuItemInfo.Size = new System.Drawing.Size(108, 29);
            this.ToolStripMenuItemInfo.Text = "Сведения";
            // 
            // ToolStripMenuItemProgramm
            // 
            this.ToolStripMenuItemProgramm.Name = "ToolStripMenuItemProgramm";
            this.ToolStripMenuItemProgramm.Size = new System.Drawing.Size(200, 30);
            this.ToolStripMenuItemProgramm.Text = "О программе";
            this.ToolStripMenuItemProgramm.Click += new System.EventHandler(this.ToolStripMenuItemProgramm_Click);
            // 
            // ToolStripMenuItemFigure
            // 
            this.ToolStripMenuItemFigure.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAdd,
            this.ToolStripMenuItemEdit,
            this.ToolStripMenuItemDell});
            this.ToolStripMenuItemFigure.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItemFigure.Name = "ToolStripMenuItemFigure";
            this.ToolStripMenuItemFigure.Size = new System.Drawing.Size(89, 29);
            this.ToolStripMenuItemFigure.Text = "Фигуры";
            // 
            // ToolStripMenuItemAdd
            // 
            this.ToolStripMenuItemAdd.Name = "ToolStripMenuItemAdd";
            this.ToolStripMenuItemAdd.Size = new System.Drawing.Size(169, 30);
            this.ToolStripMenuItemAdd.Text = "Добавить";
            this.ToolStripMenuItemAdd.Click += new System.EventHandler(this.ToolStripMenuItemAdd_Click);
            // 
            // ToolStripMenuItemEdit
            // 
            this.ToolStripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Figure,
            this.XY});
            this.ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit";
            this.ToolStripMenuItemEdit.Size = new System.Drawing.Size(169, 30);
            this.ToolStripMenuItemEdit.Text = "Изменить";
            // 
            // Figure
            // 
            this.Figure.Name = "Figure";
            this.Figure.Size = new System.Drawing.Size(410, 30);
            this.Figure.Text = "Фигуру";
            this.Figure.Click += new System.EventHandler(this.Figure_Click);
            // 
            // XY
            // 
            this.XY.Name = "XY";
            this.XY.Size = new System.Drawing.Size(410, 30);
            this.XY.Text = "Положение на плоскости или наклон";
            this.XY.Click += new System.EventHandler(this.XY_Click);
            // 
            // ToolStripMenuItemDell
            // 
            this.ToolStripMenuItemDell.Name = "ToolStripMenuItemDell";
            this.ToolStripMenuItemDell.Size = new System.Drawing.Size(169, 30);
            this.ToolStripMenuItemDell.Text = "Удалить";
            this.ToolStripMenuItemDell.Click += new System.EventHandler(this.ToolStripMenuItemDell_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(128, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(101, 24);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Фигура №";
            this.labelName.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoEllipsis = true;
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(22, 174);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(95, 24);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "1 2 3 4 5 6";
            this.labelInfo.Visible = false;
            // 
            // labelInf
            // 
            this.labelInf.AutoSize = true;
            this.labelInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInf.Location = new System.Drawing.Point(128, 130);
            this.labelInf.Name = "labelInf";
            this.labelInf.Size = new System.Drawing.Size(102, 24);
            this.labelInf.TabIndex = 8;
            this.labelInf.Text = "Свойства:";
            this.labelInf.Visible = false;
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPrevious.Location = new System.Drawing.Point(0, 364);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(150, 36);
            this.ButtonPrevious.TabIndex = 9;
            this.ButtonPrevious.Text = "Предыдуюшая";
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Visible = false;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNext.Location = new System.Drawing.Point(194, 364);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(134, 36);
            this.ButtonNext.TabIndex = 10;
            this.ButtonNext.Text = "Следуюшая";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Visible = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(340, 412);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonPrevious);
            this.Controls.Add(this.labelInf);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПР 4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInfo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemProgramm;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFigure;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDell;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelInf;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.ToolStripMenuItem Figure;
        private System.Windows.Forms.ToolStripMenuItem XY;
    }
}

