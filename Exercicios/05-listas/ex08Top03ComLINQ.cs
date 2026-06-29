using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaCSharp.Exercicios._05_listas
{
    internal class ex08Top03ComLINQ
    {
        public static void Executar()
        {
            List<int> Numeros = new List<int>();
            Console.WriteLine("Digite 10 números inteiros:");

            for (int i = 0; i < 10; i++)
            {
                int numero;

                while (true)
                {
                    Console.Write($"{i + 1}º número: ");

                    string entrada = Console.ReadLine();

                    if (int.TryParse(entrada, out numero))
                    {
                        Numeros.Add(numero);
                        break;
                    }

                    Console.WriteLine("Digite um número válido!");
                }
            }

            List<int> Maiores3 = Numeros.OrderByDescending(x => x)
                .Take(3)
                .ToList();

            List<int> Menores3 = Numeros.OrderBy(n => n)
                .Take(3)
                .ToList();

            Console.Write("3 Maiores em ordem decrescente: [ ");
            foreach (int numeros in Maiores3)
            {
                Console.Write($"{numeros} ");
            }
            Console.Write("]");

            Console.WriteLine();

            Console.Write("3 Menores em ordem crescente: [ ");
            foreach (int numeros in Menores3)
            {
                Console.Write($"{numeros} ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}

