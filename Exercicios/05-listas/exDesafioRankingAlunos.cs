using System;
using System.Globalization;

namespace LogicaCSharp.Exercicios._05_listas
{
    internal class exDesafioRankingAlunos
    {
        public static void Executar()
        {
            List<string> Nomes = new List<string>();
            List<double> Notas = new List<double>();

            Console.WriteLine("Digite o nome e a nota de 5 alunos: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}° Aluno: ");
                string entrada = Console.ReadLine();
                string[] vet = entrada.Split(' ');

                Nomes.Add(vet[0]);
                Notas.Add(double.Parse(vet[1], CultureInfo.InvariantCulture));
            }
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < 5; i++)
            {
                double maiorNota = Notas.Max();
                int indiceMaior = Notas.IndexOf(maiorNota);
                Console.WriteLine($"{i+1}° Lugar: {Nomes[indiceMaior]} - Nota {maiorNota:F2}");
                Notas.RemoveAt(indiceMaior);
                Nomes.RemoveAt(indiceMaior);
            }

        }
    }
}
