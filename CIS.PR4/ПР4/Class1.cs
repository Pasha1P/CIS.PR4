using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР4
{
    internal class Figures<T>
    {
        delegate void FiguresDelegate();
        T next;
        T previous;
        public string figure;
        public string specification;
        public double X, Y, side, perimeter, square;
        public float tilt;
        public int specifications1, specifications2;
        public Figures(string figure, string specification, float tilt, double X, double Y, int specifications1, int specifications2, T next, T previous)
        {
            this.figure = figure;
            this.specification = specification;
            this.tilt = tilt;
            this.X = X;
            this.Y = Y;
            this.specifications1 = specifications1;
            this.specifications2 = specifications2;
            this.next = next;
            this.previous = previous;
            FiguresDelegate fg = new FiguresDelegate(MathSide); fg += MathPerimeter; fg += MathSquare;
            fg();
        }
        public void Order(bool direction, T value)
        {
            if (direction)
                next = value;
            else
                previous = value;
        }
        public void XY(bool direction, double value)
        {
            if (direction)
                X = value;
            else
                Y = value;
        }
        public void Tilt(float value)
        {
            tilt = value;
        }
        public T Inf(bool b)
        {
            if (b)
                return next;
            else
                return previous;
        }
        /// <summary>
        /// площадь
        /// </summary>
        void MathSquare()
        {
            if (figure == "Круг")
                if (specification == "Радиус")
                    square = specifications1 * specifications1 * 3.14;
                else if (specification == "Длина окружности")
                    square = Math.Pow(specifications1 / 2 / 3.14, 2) * 3.14;
                else square = specifications1;
            else if (figure == "Квадрат")
                if (specification == "Периметр")
                    square = Math.Pow(specifications1 / 4, 2);
                else if (specification == "Площадь")
                    square = specifications1;
                else square = Math.Pow(specifications1, 2);
            else
                square = specifications1 * specifications2;
            square = Math.Round(square, 3);
        }
        /// <summary>
        /// периметр
        /// </summary>
        void MathPerimeter()
        {
            if (figure == "Круг")
                if (specification == "Радиус")
                    perimeter = specifications1 * 2 * 3.14;
                else if (specification == "Длина окружности")
                    perimeter = specifications1;
                else perimeter = Math.Sqrt(specifications1 / 3.14) * 2 * 3.14;
            else if (figure == "Квадрат")
                if (specification == "Периметр")
                    perimeter = specifications1;
                else if (specification == "Площадь")
                    perimeter = Math.Sqrt(specifications1) * 4;
                else perimeter = specifications1 * 4;
            else
                perimeter = (specifications1 + specifications2) * 2;
            perimeter = Math.Round(perimeter, 3);
        }
        /// <summary>
        /// сторона
        /// </summary>
        void MathSide()
        {
            if (figure == "Круг")
                if (specification == "Радиус")
                    side = -1;
                else if (specification == "Длина окружности")
                    side = specifications1 / 2 / 3.14;
                else side = Math.Sqrt(specifications1 / 3.14);
            else if (figure == "Квадрат")
                if (specification == "Периметр")
                    side = specifications1 / 4;
                else if (specification == "Площадь")
                    side = Math.Sqrt(specifications1);
                else side = specifications1;
            else
                side = 0;
            side = Math.Round(side, 3);
        }
    }
}
