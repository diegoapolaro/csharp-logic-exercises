using System;

namespace LogicaCSharp.Exercicios._02_condicoes
{
    internal class ex03ParOuImparDivisivel
    {
        public static void Executar()
        {
            Console.Write("Digite um número para verificar se é par ou impar. E se é divisivel por 3 e 5: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.Write(num + ": É um número par");
            }
            else
            {
                Console.Write(num + ": É um número ímpar");
            }

            if (num % 3 == 0 && num % 5 == 0) 
            {
                Console.WriteLine(", divisivel por 3 e 5.");
            }
            else if(num % 3 == 0)
            {
                Console.WriteLine(", divisivel por 3.");
            }
            else if(num % 5 == 0)
            {
                Console.WriteLine(", divisivel por 5.");
            }
            else
            {
                Console.WriteLine(".");
            }

        }
        
    }
}
