using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LogicaCSharp.Exercicios._02_condicoes
{
    internal class ex04TryParse
    {
        public static void Executar()
        { 
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();
            bool deuCerto = double.TryParse(entrada, CultureInfo.InvariantCulture, out double resultado);

            if (deuCerto)
            {
                double dobro = resultado * 2.0;
                double quadrado = resultado * resultado;
                Console.WriteLine($"Dobro de {resultado:F2}: {dobro:F2} |" +
                    $" {resultado:F2} ao quadrado: {quadrado:F2}");
            }
            else
            {
                Console.WriteLine("Digite um número valido.");
            }
        }
    }
}
