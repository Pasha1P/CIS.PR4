using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ПР4
{
    public partial class Form1 : Form
    {
        int count;
        Pen pen=new Pen(Color.Black,3);
        Point point0 = new Point(178, 95);
        List<Figures<int>> list = new List<Figures<int>>();
        public Form1()
        {
            InitializeComponent();
            labelName.Visible = true;
            this.Width = 224;
            this.Height = 107;
            labelName.Text = $"Фигур нет";
            labelName.Location = new Point(50, 35);
        }
        /// <summary>
        /// добавление фигуры
        /// </summary>
        private void ToolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            if (form3.Figure != null)
            {
                Figures<int> figures = new Figures<int>(form3.Figure, form3.Specification, form3.Tilt, form3.X, form3.Y, form3.Specifications1, form3.Specifications2, 0, 0);
                if (list.Count != 0)
                {
                    figures.Order(false, list.Count - 1);
                    list[0].Order(false, list.Count);
                    list[list.Count - 1].Order(true, list.Count);
                }
                list.Add(figures);
                ButtonNext.Visible = true;
                ButtonPrevious.Visible = true;
                count = list.Count;
                labelName.Location = new Point(128, 35);
                this.Width = 356;
                Visibles();
                Visibles();
            }
        }
        /// <summary>
        /// о программе
        /// </summary>
        private void ToolStripMenuItemProgramm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        /// <summary>
        /// удаление фигуры
        /// </summary>
        private void ToolStripMenuItemDell_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Невозможно удалить, из-за отсутствия фигуры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (list.Count > 1)
                {
                    int nextEL = list[count - 1].Inf(true);
                    int previousEL = list[count - 1].Inf(false);
                    list[nextEL].Order(false, previousEL);
                    list[previousEL].Order(true, nextEL);
                    count = previousEL + 1;
                }
                list.RemoveAt(count - 1);
                Visibles();
            }
        }
        /// <summary>
        /// кнопка предыдущая фигура
        /// </summary>
        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            count = list[count - 1].Inf(false) + 1;
            Visibles();
        }
        /// <summary>
        /// кнопка следующая фигура
        /// </summary>
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            count = list[count - 1].Inf(true) + 1;
            Visibles();
        }
        /// <summary>
        /// метод визуализации
        /// </summary>
        private void Visibles()
        {
            Graphics g;
            g = CreateGraphics();
            g.Clear(BackColor);
            if (list.Count > 1)
            {
                ButtonNext.Visible = true;
                ButtonPrevious.Visible = true;
                this.Height = 451;
            }
            else
            {
                this.Height = 416;
                ButtonNext.Visible = false;
                ButtonPrevious.Visible = false;
            }
            labelName.Visible = true;
            labelName.Location = new Point(128, 35);
            if (list.Count != 0)
            {
                float x;
                labelName.Text = $"Фигура №{count}";
                labelInf.Visible = true;
                labelInfo.Visible = true;
                string text1, text2;
                if (list[count - 1].figure == "Квадрат")
                    text1 = "Сторона равна: " + list[count - 1].side + ".\n";
                else if (list[count - 1].figure == "Круг")
                    text1 = "Радиус равен: " + list[count - 1].specifications1 + ".\n";
                else
                    text1 = $"Сторона 1 равна: {list[count - 1].specifications1},\n сторона 2 равна: {list[count - 1].specifications2}.\n";
                if (list[count - 1].figure == "Круг")
                {
                    text2 = $"Длина окружности равна: {list[count - 1].perimeter}.\n";
                    x = Width / 2 - list[count - 1].specifications1 * 34;
                    g.DrawEllipse(Pens.Black, point0.X- (int)(list[count - 1].specifications1*34), point0.Y - (int)(list[count - 1].specifications1 * 34), (int)(list[count - 1].specifications1 * 68), (int)(list[count - 1].specifications1 * 68));
                }
                else
                {
                    x = Width / 2 - list[count - 1].specifications1 * 34;
                    text2 = $"Периметр равен: {list[count - 1].perimeter}.\n";
                    if (list[count - 1].specifications2 == 0)
                    {
                        Point point1 = new Point(point0.X + (int)(list[count - 1].specifications1 * 17), point0.Y + (int)(list[count - 1].specifications1 * 17));
                        Point point2 = new Point(point0.X + (int)(list[count - 1].specifications1 * 17), point0.Y - (int)(list[count - 1].specifications1 * 17));
                        Point point4 = new Point(point0.X - (int)(list[count - 1].specifications1 * 17), point0.Y + (int)(list[count - 1].specifications1 * 17));
                        Point point3 = new Point(point0.X - (int)(list[count - 1].specifications1 * 17), point0.Y - (int)(list[count - 1].specifications1 * 17));
                        Point[] points = { point1, point2, point3, point4 };
                        g.TranslateTransform(point0.X, point0.Y);   // перемещаемся на нужную точку
                        g.RotateTransform(list[count - 1].tilt);     // поворачиваем элемент
                        g.TranslateTransform(-point0.X, -point0.Y); // возвращаемся назад
                        g.DrawPolygon(pen, points);
                    }
                    else
                    {
                        Point point1 = new Point(point0.X + (int)(list[count - 1].specifications1 * 17), point0.Y + (int)(list[count - 1].specifications2 * 17));
                        Point point2 = new Point(point0.X + (int)(list[count - 1].specifications1 * 17), point0.Y - (int)(list[count - 1].specifications2 * 17));
                        Point point4 = new Point(point0.X - (int)(list[count - 1].specifications1 * 17), point0.Y + (int)(list[count - 1].specifications2 * 17));
                        Point point3 = new Point(point0.X - (int)(list[count - 1].specifications1 * 17), point0.Y - (int)(list[count - 1].specifications2 * 17));
                        Point[] points = { point1, point2, point3, point4 };
                        g.TranslateTransform(point0.X, point0.Y);
                        g.RotateTransform(list[count - 1].tilt);
                        g.DrawPolygon(pen, points);
                    }
                }
                labelInfo.Text = $"Фигура: {list[count - 1].figure}.\nПоложение: X={list[count - 1].X}, Y={list[count - 1].Y}\nНаклон {list[count - 1].tilt} градусов.\n{text1 + text2}Площадь равна: {list[count - 1].square}.";
            }
            else
            {
                this.Width = 184;
                this.Height = 86;
                labelName.Text = $"Фигур нет";
                labelName.Location = new Point(50, 35);
                labelInfo.Visible = false;
                ButtonPrevious.Visible = false;
                ButtonNext.Visible = false;
                labelInf.Visible = false;
            }
            CenterToScreen();
        }
        /// <summary>
        /// изменение фигуры
        /// </summary>
        private void Figure_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
                if (form3.Figure != null)
                {
                    Figures<int> figures = new Figures<int>(form3.Figure, form3.Specification, form3.Tilt, form3.X, form3.Y, form3.Specifications1, form3.Specifications2, list.Count, list.Count);
                    figures.Order(true, list[count - 1].Inf(true));
                    figures.Order(false, list[count - 1].Inf(false));
                    list[count - 1] = figures;
                    Visibles();
                }
            }
            else
            {
                MessageBox.Show("Невозможно изменить, из-за отсутствия фигуры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// изменение наклона и позции фигуры
        /// </summary>
        private void XY_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
                if (form4.Stop)
                {
                    list[count - 1].XY(true, form4.X);
                    list[count - 1].XY(false, form4.Y);
                    list[count - 1].Tilt(form4.Tilt);
                    Visibles();
                }
            }
            else
            {
                MessageBox.Show("Невозможно изменить, из-за отсутствия фигуры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
