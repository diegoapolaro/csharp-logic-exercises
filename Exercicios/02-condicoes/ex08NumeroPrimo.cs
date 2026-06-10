using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaCSharp.Exercicios._02_condicoes
{
    internal class ex08NumeroPrimo
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número para verificar se é número primo");
            int numero = 0;

            //verifica se o usuário digitar algo que não seja número
            while (true)
            {
                string entrada = Console.ReadLine();
                bool deuCerto = int.TryParse(entrada, out numero);

                if (deuCerto)
                {
                    break;
                }
                Console.WriteLine("Digite um número válido: ");
            }

            //verifica se o número digitado é primo ou não, e consequentemente imprime isso
            bool ePrimo = true;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if(numero % i == 0)
                {
                    ePrimo = false;
                    Console.WriteLine($"{numero} -> não é primo (divisivel por {i}");
                    break;
                }
                else
                {
                    Console.WriteLine($"{numero} -> é primo.");
                }
            }

            //imprime todos os números primos até chegar no numero primo digitado
            Console.WriteLine($"Primos de 1 até {numero}:");
            for (int atual = 2; atual <= numero; atual++)
            {
                ePrimo = true;

                for (int divisor = 2; divisor <= Math.Sqrt(atual); divisor++)
                {
                    if (atual % divisor == 0)
                    {
                        ePrimo = false;
                        break;
                    }
                }

                if (ePrimo)
                {
                    Console.WriteLine(atual);
                }
            }
        }
    }
}
