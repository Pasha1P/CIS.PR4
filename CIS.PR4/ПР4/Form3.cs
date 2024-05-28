using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР4
{
    public partial class Form3 : Form
    {
        public string Figure { get; private set; }
        public string Specification { get; private set; }
        public float Tilt { get; private set; }
        public double X { get; private set; }
        public double Y { get; private set; }
        public int Specifications1 { get; private set; }
        public int Specifications2 { get; private set; }
        public Form3()
        {
            InitializeComponent();
        }
        /// <summary>
        /// визуализация Visible = true
        /// </summary>
        private void SpecificationsT()
        {
            labelSpecifications1.Visible = true;
            textBoxSpecifications1.Visible = true;
            labelTilt.Visible = true;
            textBoxTilt.Visible = true;
            labelX.Visible = true;
            textBoxX.Visible = true;
            labelY.Visible = true;
            textBoxY.Visible = true;
        }
        /// <summary>
        /// визуализация Visible = false
        /// </summary>
        private void SpecificationsF()
        {
            labelSpecifications.Visible = false;
            comboBoxSpecifications.Visible = false;
            labelSpecifications1.Text = "";
            labelSpecifications1.Visible = false;
            textBoxSpecifications1.Visible = false;
            labelSpecifications2.Visible = false;
            textBoxSpecifications2.Visible = false;
            labelTilt.Visible = false;
            textBoxTilt.Visible = false;
            labelX.Visible = false;
            textBoxX.Visible = false;
            labelY.Visible = false;
            textBoxY.Visible = false;
            textBoxX.Text = "";
            textBoxY.Text = "";
            textBoxTilt.Text = "";
            textBoxSpecifications1.Text = "";
            textBoxSpecifications2.Text = "";
        }
        /// <summary>
        /// изменение характеристие у comboBoxSpecifications при выборефигуры
        /// </summary>
        private void ComboBoxFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecificationsF();
            switch (comboBoxFigure.SelectedIndex)
            {
                case 0:
                    comboBoxSpecifications.Visible = true;
                    labelSpecifications.Visible = true;
                    comboBoxSpecifications.Items.Clear();
                    comboBoxSpecifications.Items.AddRange(new string[] { "Радиус", "Длина окружности", "Площадь" });
                    break;
                case 1:
                    comboBoxSpecifications.Visible = true;
                    labelSpecifications.Visible = true;
                    comboBoxSpecifications.Items.Clear();
                    comboBoxSpecifications.Items.AddRange(new string[] { "Сторона", "Периметр", "Площадь" });
                    break;
                case 2:
                    textBoxSpecifications2.Visible = true;
                    labelSpecifications2.Visible = true;
                    SpecificationsT();
                    labelSpecifications1.Text = "Введите ширину";
                    buttonOk.Visible = true;
                    break;
            }
        }
        /// <summary>
        /// изменение label при изменении comboBoxSpecifications
        /// </summary>
        private void ComboBoxSpecifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSpecifications.SelectedIndex)
            {
                case 0:
                    buttonOk.Visible = true;
                    if (comboBoxFigure.SelectedIndex == 0)
                        labelSpecifications1.Text = "Введите радиус";
                    else
                        labelSpecifications1.Text = "Введите длину стороны";
                    SpecificationsT();
                    break;
                case 1:
                    buttonOk.Visible = true;
                    if (comboBoxFigure.SelectedIndex == 0)
                        labelSpecifications1.Text = "Введите длину окружности";
                    else
                        labelSpecifications1.Text = "Введите периметр";
                    SpecificationsT();
                    break;
                case 2:
                    buttonOk.Visible = true;
                    labelSpecifications1.Text = "Введите площадь";
                    SpecificationsT();
                    break;
            }
        }
        /// <summary>
        /// запрет всех кнопок кроме чисел , -
        /// </summary>
        private void TextBoxSpecifications1_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// запрет всех кнопок кроме чисел , -
        /// </summary>
        private void TextBoxSpecifications2_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// запрет всех кнопок кроме чисел , -
        /// </summary>
        private void TextBoxX_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// запрет всех кнопок кроме чисел , -
        /// </summary>
        private void TextBoxY_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// запрет всех кнопок кроме чисел , -
        /// </summary>
        private void TextBoxTilt_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// кнопка ок
        /// </summary>
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            bool exit, exit1 = true;
            if (String.IsNullOrEmpty(textBoxSpecifications1.Text))
            {
                errorProvider1.SetError(textBoxSpecifications1, "Поле должно быть заполненно");
                exit = false;
            }
            else if ((textBoxSpecifications1.Text == "0") || (textBoxSpecifications1.Text == "-0"))
            {
                errorProvider1.SetError(textBoxSpecifications1, "Поле не может быть равно 0");
                exit = false;
            }
            else
            {
                exit = true;
            }
            if (comboBoxFigure.SelectedIndex == 2)
            {
                errorProvider1.Clear();
                if ((String.IsNullOrEmpty(textBoxSpecifications2.Text)) || (textBoxSpecifications2.Text == "-"))
                {
                    errorProvider2.SetError(textBoxSpecifications2, "Поле должно быть заполненно");
                    exit1 = false;
                }
                else if ((textBoxSpecifications2.Text == "0") || (textBoxSpecifications2.Text == "-0"))
                {
                    errorProvider2.SetError(textBoxSpecifications2, "Поле не может быть равно 0");
                    exit1 = false;
                }
                else if ((textBoxSpecifications2.Text == textBoxSpecifications1.Text))
                {
                    errorProvider2.SetError(textBoxSpecifications2, "Сторона не может быть равна первой стороне");
                    exit1 = false;
                }
                else
                {
                    exit1 = true;
                }
            }
            if (exit && exit1)
            {
                try
                {
                    Figure = comboBoxFigure.Text;
                    Specification = comboBoxSpecifications.Text;
                    Specifications1 = Convert.ToInt32(textBoxSpecifications1.Text);
                    if (String.IsNullOrEmpty(textBoxTilt.Text))
                        Tilt = 0;
                    else
                        Tilt = Factorial(float.Parse(textBoxTilt.Text));

                    if (String.IsNullOrEmpty(textBoxY.Text))
                        Y = 0;
                    else
                        Y = Convert.ToDouble(textBoxY.Text);

                    if (String.IsNullOrEmpty(textBoxX.Text))
                        X = 0;
                    else
                        X = Convert.ToDouble(textBoxX.Text);

                    if (String.IsNullOrEmpty(textBoxSpecifications2.Text))
                        Specifications2 = 0;
                    else
                        Specifications2 = Convert.ToInt32(textBoxSpecifications2.Text);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// факториал
        /// </summary>
        private float Factorial(float tilts)
        {
            while (tilts <= -180 || tilts > 180)
            {
                if (180 < tilts)
                    tilts -= 180;
                else if (tilts < -180)
                    tilts += 180;
                if (tilts == -180)
                    tilts = 180;
            }
            return tilts;
        }
        /// <summary>
        /// кнопка закрытия
        /// </summary>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Figure = null;
            Close();
        }
    }
}
