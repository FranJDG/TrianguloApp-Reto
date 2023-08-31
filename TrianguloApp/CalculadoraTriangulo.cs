using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloApp
{
    internal class CalculadoraTriangulo
    {
        public static double Perimetro(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 + lado3;
        }

        public static double Area(double lado1, double lado2, double lado3)
        {
            double s = (lado1+lado2+lado3) / 2;
            return Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
        }
    }
}
