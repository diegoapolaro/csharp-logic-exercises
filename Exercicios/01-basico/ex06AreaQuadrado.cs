using System;
using System.Globalization;

namespace LogicaCSharp.Exercicios._01_basico
{
    internal class ex06AreaQuadrado
    {
        public static void Executar()
        {
            Console.Write("Primeiro lado do quadrado: ");
            double lado1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Segundo lado do quadrado: ");
            double lado2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = lado1 * lado2;

            Console.WriteLine("A área o quadrado é " + area.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
