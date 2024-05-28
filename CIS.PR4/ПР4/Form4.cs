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
    public partial class Form4 : Form
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public float Tilt { get; private set; }
        public bool Stop { get; private set; }

        public Form4()
        {
            InitializeComponent();
        }
        /// <summary>
        /// выход
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Stop = false;
            Close();
        }
        /// <summary>
        /// кнопка ок
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            bool exit = true;
            if (String.IsNullOrEmpty(textBoxX.Text))
            {
                errorProvider1.SetError(textBoxX, "Поле должно быть заполненно");
                exit = false;
            }
            if (String.IsNullOrEmpty(textBoxY.Text))
            {
                errorProvider1.SetError(textBoxY, "Поле должно быть заполненно");
                exit = false;
            }
            if (String.IsNullOrEmpty(textBoxTilt.Text))
            {
                errorProvider1.SetError(textBoxTilt, "Поле должно быть заполненно");
                exit = false;
            }
            if (exit)
            {
                X = Convert.ToDouble(textBoxX.Text);
                Y = Convert.ToDouble(textBoxY.Text);
                Tilt = Factorial(float.Parse(textBoxTilt.Text));
                Stop = true;
                Close();
            }
        }
        /// <summary>
        /// факториал
        /// </summary>
        private float Factorial(float tilts)
        {
            if (180 < tilts)
                return Factorial(tilts - 180);
            else if (tilts < -180)
                return Factorial(tilts + 180);
            else return tilts;
        }
        /// <summary>
        /// запрет всех кнопок кроме чисел , -
        /// </summary>
        private void textBoxX_TextChanged(object sender, KeyPressEventArgs e)
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
        private void textBoxY_TextChanged(object sender, KeyPressEventArgs e)
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
        private void textBoxTilt_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }
    }
}
