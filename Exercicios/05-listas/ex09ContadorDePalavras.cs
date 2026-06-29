using System;


namespace LogicaCSharp.Exercicios._05_listas
{
    internal class ex09ContadorDePalavras
    {
        public static void Executar()
        {
            Console.Write("Digite uma frase: ");
            string entrada = Console.ReadLine();
            string[] vet = entrada.Split(' ');
            int letrasMaiorPalavra = 0;
            int letrasMenorPalavra = 0;
            string maiorPalavra = vet[0];
            string menorPalavra = vet[0];
            letrasMaiorPalavra = vet[0].Length;
            letrasMenorPalavra = vet[0].Length;


            for (int i = 0; i < vet.Length; i++)
            {
                if(letrasMaiorPalavra < vet[i].Length)
                {
                    letrasMaiorPalavra = vet[i].Length;
                    maiorPalavra = vet[i];
                }

                if(letrasMenorPalavra > vet[i].Length)
                {
                    letrasMenorPalavra = vet[i].Length;
                    menorPalavra = vet[i];
                }
            }
            Console.WriteLine();

            Console.WriteLine("Sua frase tem: ");
            Console.WriteLine($"{vet.Count()} palavras");
            Console.WriteLine($"{maiorPalavra}, é a maior palavra, com {letrasMaiorPalavra} letras!");
            Console.WriteLine($"{menorPalavra}, é a menor palavra, com {letrasMenorPalavra} letras!");
        }
    }
}
