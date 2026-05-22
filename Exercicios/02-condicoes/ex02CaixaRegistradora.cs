using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LogicaCSharp.Exercicios._02_condicoes
{
    internal class ex02CaixaRegistradora
    {
        public static void Executar()
        {
            Console.WriteLine("Valor do primeiro produto: ");
            double primeiroProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor do segundo produto: ");
            double segundoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Terceiro produto: ");
            double terceiroProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = primeiroProduto + segundoProduto + terceiroProduto;

            if (total > 100.00)
            {

                total += 0.90;
                Console.WriteLine($"Valor total: {total:C} ({0.10:P0} de desconto)");
            }
            else
            {
                Console.WriteLine($"Valor total: {total:C}");
            }
        }
    }
}
