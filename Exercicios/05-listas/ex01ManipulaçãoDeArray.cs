using LogicaCSharp.Exercicios._01_basico;
using System;
using System.Collections.Concurrent;

namespace LogicaCSharp.Exercicios._05_listas
{
    internal class ex01Manipulaçãodearray
    {
        public static void Executar()
        {
            int[] notas = new int[5];
            int somaDasNotas = 0;
            int maiorQue7 = 0;
            Console.WriteLine("Digite as 5 notas: ");

            for(int i = 0; i <= 4; i++)
            {
                string entrada = Console.ReadLine();
                bool deuCerto = int.TryParse(entrada, out int nota);
                while (!deuCerto)
                {
                    Console.Write("Digite um número válido: ");
                    entrada = Console.ReadLine();
                    deuCerto = int.TryParse(entrada, out nota);

                    if (!deuCerto)
                    {
                        Console.WriteLine("Número inválido!");
                    }
                }
                notas[i] = nota;
                somaDasNotas += nota;
                if (nota > 7)
                {
                    maiorQue7++;
                }
            }
            int maiorNota = 0;
            int menorNota = 10;
            for(int i = 0; i<= 4; i++)
            {
                if (notas[i] > maiorNota)
                {
                    maiorNota = notas[i];
                }
                if (notas[i] < menorNota)
                {
                    menorNota = notas[i];
                }
            }
            double media = somaDasNotas / notas.Length;
            Console.WriteLine($"Maior nota: {maiorNota}");
            Console.WriteLine($"Menor nota: {menorNota}");
            Console.WriteLine($"Média: {media}");
            Console.WriteLine($"Quantidade de notas maiores que 7: {maiorQue7}");

        }
    }
}
