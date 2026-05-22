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
            Console.WriteLine("Primeiro produto: ");
            double primeiroProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Segundo produto: ");
            double segundoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Terceiro produto: ");
            double terceiroProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = primeiroProduto + segundoProduto + terceiroProduto;

            if (total > 100.00)
            {
                double desconto = total * 0.10;
                total = total - desconto;
                Console.WriteLine($"Valor total: {total:C} ({0.10:P0} de desconto)");
            }
            else
            {
                Console.WriteLine($"Valor total: {total:C}");
            }
        }
    }
}
