using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace LogicaCSharp.Exercicios._01_basico
{
    internal class Interpolação
    {
        public static void Executar()
        {
            Console.WriteLine("Seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Sua altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Olá {nome}! você tem {idade} anos, e {altura.ToString("F2")}m de altura");
        }
    }
}
