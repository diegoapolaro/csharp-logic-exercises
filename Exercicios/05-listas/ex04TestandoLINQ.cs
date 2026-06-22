using System;
using System.Linq;

namespace LogicaCSharp.Exercicios._05_listas
{
    internal class ex04TestandoLINQ
    {
        public static void Executar()
        {
            List<int> Numbers = new List<int>();
            Console.WriteLine("Digite 10 números inteiros: ");
            Console.WriteLine("----------------------------");
            for (int i = 0; i < 10; i++) 
            {
                string entrada = Console.ReadLine();
                bool deuCerto = int.TryParse(entrada, out int numero);

                while (!deuCerto)
                {
                    Console.WriteLine("Número inválido! Digite outro: ");
                    entrada = Console.ReadLine();
                    deuCerto = int.TryParse(entrada, out numero);
                }

                Numbers.Add(numero);
            }
            Console.WriteLine("----------------------------");

            int soma = Numbers.Sum();
            Console.WriteLine($"Soma dos números: {soma}");
            Console.WriteLine();

            double media = Numbers.Average();
            Console.WriteLine($"Média dos números: {media}");
            Console.WriteLine();

            int maior = Numbers.Max();
            int menor = Numbers.Min();
            Console.WriteLine($"Maior número da lista: {maior} || Menor número da lista: {menor}");
            Console.WriteLine();

            int Pares = 0;
            List<int> pares = Numbers
                .Where(n => n % 2 == 0)
                .OrderBy(n => n).ToList();

            int Impares = 0;
            List<int> impares = Numbers
                .Where(n => n %2 != 0)
                .OrderByDescending(n => n).ToList();

            Console.Write("Pares ordenados crescente: ");
            foreach(int n in pares)
            {
                Console.Write($"{n}, ");
                Pares++;
            }

            Console.WriteLine();

            Console.Write("Ímpares ordenados decrescente: ");
            foreach (int n in impares)
            {
                Console.Write($"{n}, ");
                Impares++;
            }

            List<int> multiplosDeTres = Numbers
                .Where(n => n % 3 == 0)
                .ToList();

            Console.WriteLine();


            int MultiplosDeTres = 0;
            Console.Write("Multiplos de 3: ");
            foreach (int n in multiplosDeTres)
            {
                Console.Write($"{n}, ");
                MultiplosDeTres++;
            }

            Console.WriteLine();

            Console.WriteLine($"Quantidade de números pares: {Pares} | Ímpares: {Impares} | Multiplos de 3: {MultiplosDeTres}");
        }
    }
}
