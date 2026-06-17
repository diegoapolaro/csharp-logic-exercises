using System;

namespace LogicaCSharp.Exercicios._02_condicoes
{
    internal class ex01ParOuImpar
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número para verificar se é par ou impar: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine(num + " é um número par");
            }
            else
            {
                Console.WriteLine(num + " é um número impar");
            }
        }
    }
}
