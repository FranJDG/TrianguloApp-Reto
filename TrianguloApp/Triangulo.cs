using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloApp
{
    internal class Triangulo
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public double CalcularPerimetro()
        {
            return lado1 + lado2 +lado3;
        }

        public double CalcularArea()
        {
            double s = CalcularPerimetro()/2;
            return Math.Sqrt(s*(s-lado1)*(s-lado2)*(s-lado3));
        }
    }
}
