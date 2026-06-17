using System;
using System.Linq;
using System.Globalization;

namespace LogicaCSharp.Exercicios._03_loops
{
    internal class ex06MaiorMenorMedia
    {
        public static void Executar()
        {
            List<int> numerosDigitados = new List<int>();
            string entrada;
            int somaDosNumeros = 0;
            int qntDeNumeros = 0;
            Console.WriteLine("Digite quantos números quiser para ver o Maior, menor e média de sequência || Digite - fim para finalizar!");
            
            while (true)
            {
                entrada = Console.ReadLine();
                if(entrada == "fim")
                {
                    break;
                }
                bool deuCerto = int.TryParse(entrada, out int numero);

                if (!deuCerto)
                {
                    Console.WriteLine("Digite um número válido!");
                    continue;
                }

                numerosDigitados.Add(numero);
                somaDosNumeros =+ numero;
                qntDeNumeros++;
            } 

            int maior = numerosDigitados.Max();
            Console.WriteLine($"Maior número: {maior}");

            int menor = numerosDigitados.Min();
            Console.WriteLine($"Menor número: {menor}");

            double media = (double)somaDosNumeros / qntDeNumeros;
            Console.WriteLine($"Media dos números: {media:F2}");
        }
    }
}
