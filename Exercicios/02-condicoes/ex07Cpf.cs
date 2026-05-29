using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace LogicaCSharp.Exercicios._02_condicoes
{
    internal class ex07Cpf
    {
        public static void Executar()
        {
            Console.Write("Digite seu CPF: ");
            while (true)
            { 
                string cpf = Console.ReadLine();

                bool todosNumeros = true;
                int tamanho = cpf.Length;

                foreach (char c in cpf)
                {
                    if (!char.IsDigit(c))
                    {
                        todosNumeros = false;
                        Console.WriteLine($"{c} não é um número");
                    }
                }
                
                if(todosNumeros == true && tamanho == 11)
                {
                    Console.WriteLine("CPF No formato correto!");
                    break;
                }


                if(todosNumeros == false  && tamanho != 11)
                {
                    Console.WriteLine("Tem caracteres inválidos e o tamanho do CPF está incorreto! ");
                }
                else if(todosNumeros == false)
                {
                    Console.WriteLine($"Tem caracteres inválidos no CPF");
                }
                else if(tamanho != 11)
                {
                    Console.WriteLine("CPF está com tamanho inválido! ");
                }
                Console.Write("Digite novamente: ");
            }
        }
    }
}