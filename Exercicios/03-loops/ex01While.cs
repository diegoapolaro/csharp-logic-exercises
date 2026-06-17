using System;
namespace LogicaCSharp.Exercicios._03_loops
{
    internal class ex01While
    {
        public static void Executar()
        {
            Random random = new Random();
            int secreto = random.Next(1, 101);
            int tentativas = 0;
            int numero = 0;

            while (numero != secreto)
            {
                Console.Write("Tente acertar o número de 1 a 100: ");
                string entrada = Console.ReadLine();

                bool deuCerto = int.TryParse(entrada, out numero);

                if (!deuCerto)
                {
                    Console.WriteLine("Isso não é um número! Digite um número.");
                    continue;
                }

                if (numero < 0 || numero > 100)
                {
                    Console.WriteLine("O número certo está entre 1 e 100 !!!");
                    continue;
                }
                if (numero > secreto)
                {
                    Console.WriteLine("Muito alto!");
                }
                else if( numero < secreto)
                {
                    Console.WriteLine("Muito baixo!");
                }

                tentativas++;
            }
            Console.WriteLine($"Você acertou o número!! foram feitas {tentativas} tentativas!");
        }
    }
}
