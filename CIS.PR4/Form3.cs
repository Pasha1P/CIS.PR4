using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBoxSpecifications.Items.Clear();
        }

        private void comboBoxFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            int figure = 0;
            switch (comboBoxFigure.SelectedIndex)
            {
                case 0:
                    comboBoxSpecifications.Visible = true;
                    labelSpecifications.Visible = true;
                    textBoxSpecifications1.Visible = true;
                    figure = 1;
                    comboBoxSpecifications.Items.AddRange(new string[] { "Радиус", "Периметр", "Площадь" });
                    break;
                case 1:
                    comboBoxSpecifications.Visible = true;
                    labelSpecifications.Visible = true;
                    textBoxSpecifications1.Visible = true;
                    figure = 2;
                    comboBoxSpecifications.Items.AddRange(new string[] { "Диогональ", "Сторона", "Периметр", "Площадь" });
                    break;
                case 2:
                    comboBoxSpecifications.Visible = true;
                    textBoxSpecifications1.Visible = true;
                    textBoxSpecifications2.Visible = true;
                    figure = 3;
                    comboBoxSpecifications.Items.AddRange(new string[] { "Площадь", "Периметр", });
                    buttonOk.Visible = true;
                    break;
            }
        }

        private void comboBoxSpecifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            int metod=0;
                switch (comboBoxSpecifications.SelectedIndex)
                {
                    case 0:
                    metod = 1;
                        buttonOk.Visible = true;
                        break;
                    case 1:
                    metod = 2;
                        buttonOk.Visible = true;
                        break;
                    case 2:
                    metod = 3;
                        buttonOk.Visible = true;
                        break;
                    case 3:
                    metod = 4;
                        buttonOk.Visible = true;
                        break;
                }
        }
    }
}
