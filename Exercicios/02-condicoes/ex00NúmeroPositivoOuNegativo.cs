using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaCSharp.Exercicios._02_condicoes
{
    internal class ex00NúmeroPositivoOuNegativo
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número para verificar se é positivo ou negativo: ");
            int num = int.Parse(Console.ReadLine());

            if(num == 0)
            {
                Console.WriteLine("0 não é positivo nem negativo");
            }
            else if(num > 0)
            {
                Console.WriteLine(num + " é um número positivo");
            }
            else
            {
                Console.WriteLine(num + " é um número negativo");
            }

        }
    }
}
