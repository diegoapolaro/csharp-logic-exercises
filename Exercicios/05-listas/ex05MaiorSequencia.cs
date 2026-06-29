using System;
using System.Collections.Generic;

namespace LogicaCSharp.Exercicios._03_loops
{
    internal class ex05MaiorSequencia
    {
        public static void Executar()
        {
            List<int> numeros = new List<int>();

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
                        numeros.Add(numero);
                        break;
                    }

                    Console.WriteLine("Digite um número válido!");
                }
            }

            int sequenciaAtual = 0;
            int maiorSequencia = 0;

            int inicioAtual = 0;
            int inicioMaior = 0;

            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] > 0)
                {
                    if (sequenciaAtual == 0)
                    {
                        inicioAtual = i;
                    }

                    sequenciaAtual++;

                    if (sequenciaAtual > maiorSequencia)
                    {
                        maiorSequencia = sequenciaAtual;
                        inicioMaior = inicioAtual;
                    }
                }
                else
                {
                    sequenciaAtual = 0;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Maior sequência de positivos: {maiorSequencia}");

            Console.Write("Sequência encontrada: ");

            for (int i = inicioMaior; i < inicioMaior + maiorSequencia; i++)
            {
                Console.Write($"{numeros[i]} ");
            }

            Console.WriteLine();
        }
    }
}