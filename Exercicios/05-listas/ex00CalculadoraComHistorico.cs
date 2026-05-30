using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaCSharp.Exercicios._05_listas
{
    internal class ex00CalculadoraComHistorico
    {
        public static void Executar()
        {
            int opcao;
            List<string> historico = new List<string>();
            do
            {
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Ver histórico");
                Console.WriteLine("0 - Sair");
                string entrada = Console.ReadLine();
                bool deuCerto = int.TryParse(entrada, out opcao);

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite os dois números para a soma");
                        string entrada1 = Console.ReadLine();
                        string entrada2 = Console.ReadLine();
                        bool deuCerto1 = int.TryParse(entrada1, out int num1);
                        bool deuCerto2 = int.TryParse(entrada2, out int num2);
                        if (deuCerto1 && deuCerto2)
                        {
                            int soma = num1 + num2;
                            Console.WriteLine($"Resultado da soma: {soma}");
                            historico.Add($"{num1} + {num2} = {soma}");
                        }
                        else
                        {
                            Console.WriteLine("Digite números válidos!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite os dois números para a subtração");
                        entrada1 = Console.ReadLine();
                        entrada2 = Console.ReadLine();
                        deuCerto1 = int.TryParse(entrada1, out num1);
                        deuCerto2 = int.TryParse(entrada2, out num2);
                        if (deuCerto1 && deuCerto2)
                        {
                            int subtracao = num1 - num2;
                            Console.WriteLine($"Resultado da subtração: {subtracao}");
                            historico.Add($"{num1} - {num2} = {subtracao}");
                        }
                        else
                        {
                            Console.WriteLine("Digite números válidos!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite os dois números para a multiplicação");
                        entrada1 = Console.ReadLine();
                        entrada2 = Console.ReadLine();
                        deuCerto1 = int.TryParse(entrada1, out num1);
                        deuCerto2 = int.TryParse(entrada2, out num2);
                        if (deuCerto1 && deuCerto2)
                        {
                            int multiplicacao = num1 * num2;
                            Console.WriteLine($"Resultado da multiplicação: {multiplicacao}");
                            historico.Add($"{num1} * {num2} = {multiplicacao}");
                        }
                        else
                        {
                            Console.WriteLine("Digite números válidos!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Digite os dois números para a divisão");
                        entrada1 = Console.ReadLine();
                        entrada2 = Console.ReadLine();
                        deuCerto1 = int.TryParse(entrada1, out num1);
                        deuCerto2 = int.TryParse(entrada2, out num2);
                        if (deuCerto1 && deuCerto2)
                        {
                            if(num1 == 0 || num2 == 0)
                            {
                                Console.WriteLine("Não é possivel fazer divisão por 0!");
                                break;
                            }
                            int divisao = num1 / num2;
                            Console.WriteLine($"Resultado da divisão: {divisao}");
                            historico.Add($"{num1} / {num2} = {divisao}");
                        }
                        else
                        {
                            Console.WriteLine("Digite números válidos!");
                        }

                        break;
                    case 5:
                        Console.WriteLine("=======================");
                        Console.WriteLine("HISTÓRICO DE OPERAÇÕES:");
                        foreach (string item in historico)
                        { 
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("=======================");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
