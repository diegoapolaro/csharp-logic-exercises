using System;
namespace LogicaCSharp.Exercicios._03_loops
{
    internal class exDesafioPiramide
    {
        public static void Executar()
        {
            Console.Write("Digite um número para fazer a pirâmide: ");
            int numero;
            while (true)
            {
                string entrada = Console.ReadLine();
                bool deuCerto = int.TryParse(entrada, out numero);

                if(deuCerto && numero > 0)
                {
                    break;
                }

                Console.WriteLine("Digite um número que seja válido: ");
            }

            for (int i = 1; i <= numero; i++) 
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = numero - 1; i != 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
