using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la carluladora de triángulos. \b Introduce el valor de la longitud del lado 1:");

            double lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la longitud del lado 2:");

            double lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la longitud del lado 3");

            double lado3 = int.Parse(Console.ReadLine());

            Triangulo miTriangulo = new Triangulo(lado1, lado2, lado3);

            Console.WriteLine($"El perímetro del triángulo es {miTriangulo.CalcularPerimetro()} y su área es {miTriangulo.CalcularArea()}");

            Console.WriteLine("\b");

            Console.WriteLine("Calculando el área con métodos estáticos quedaría así:");

            Console.WriteLine($"Perímetro: {CalculadoraTriangulo.Perimetro(lado1,lado2,lado3)}; Área: {CalculadoraTriangulo.Area(lado1, lado2, lado3)}");
        }
    }
}
