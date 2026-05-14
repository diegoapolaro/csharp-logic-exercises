using System;

namespace LogicaCSharp.Exercicios._01_basico
{
    internal class ex04SomaInput
    {
        public static void Executar()
        {
            Console.Write("Digite o primeiro número para a soma: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número pra a soma: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            Console.WriteLine("Soma: " + soma);
        }
    }
}
