using System;

namespace LogicaCSharp.Exercicios._01_basico
{
    internal class ex07IdadeDias
    {
        public static void Executar()
        {
            Console.Write("Sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int idadeEmDias = idade * 365;
            Console.WriteLine("Sua idade em dias é: " + idadeEmDias);
        }
    }
}
