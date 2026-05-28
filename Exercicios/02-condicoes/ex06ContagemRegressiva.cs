using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaCSharp.Exercicios._02_condicoes
{
    internal class ex06ContagemRegressiva
    {
        public static void Executar()
        {
            Console.Write("Digite um número entre 5 e 20: ");

            int numero = 0;
            while (true)
            {
                string entrada = Console.ReadLine();
                bool deuCerto = int.TryParse(entrada, out numero);
                
                while (numero < 5 || numero > 20)
                {
                    Console.Write("Tem que ser entre 5 e 20: ");
                    entrada = Console.ReadLine();
                    deuCerto = int.TryParse(entrada, out numero);
                }

                if (deuCerto)
                {
                    break;
                }
                Console.WriteLine("Digite um número válido: ");
            }

            Console.WriteLine("====================================");
            Console.WriteLine($"Contagem regressiva a partir de {numero} até 0: ");
            for(int i = numero; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}
