using System;
namespace LogicaCSharp.Exercicios._05_listas
{
    internal class ex07InverterLista
    {
        public static void Executar()
        {
            List<int> Numeros = new List<int>();
            List<int> NumerosInvertidos = new List<int>();

            Console.WriteLine("Digite 6 números inteiros: ");

            for (int i = 0; i < 6; i++)
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

            for (int i = Numeros.Count - 1; i >= 0; i--)
            {
                NumerosInvertidos.Add(Numeros[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Lista digitada: ");
            foreach(int numero in Numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine();

            Console.WriteLine("Lista invertida: ");
            foreach(int numero in NumerosInvertidos)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
