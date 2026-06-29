using System;

namespace LogicaCSharp.Exercicios._05_listas
{
    internal class ex06DuplicadosSemLINQ
    {
        public static void Executar()
        {
            List<int> Numeros = new List<int>();
            List<int> NumerosSemRepeticao = new List<int>();
            Console.WriteLine("Digite 8 números inteiros:");

            for (int i = 0; i < 8; i++)
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

            for (int i = 0; i < Numeros.Count; i++)
            {
                if (NumerosSemRepeticao.Contains(Numeros[i]))
                {
                    continue;
                }
                NumerosSemRepeticao.Add(Numeros[i]);
            }

            Console.Write("Números digitados: [ ");
            foreach(int numero in NumerosSemRepeticao)
            {
                Console.Write($"{numero} ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
