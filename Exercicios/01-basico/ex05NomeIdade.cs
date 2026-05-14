using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace LogicaCSharp.Exercicios._01_basico
{
    internal class ex05NomeIdade
    {
        public static void Executar()
        {
            Console.Write("Qual o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Qual a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Olá " + nome + " você tem " + idade + " anos");
        }
    }
}
