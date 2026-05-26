using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaCSharp.Exercicios._03_loops
{
    internal class ex02MenuLanchonete
    {
        public static void Executar()
        {
            Console.WriteLine("Selecione a opção: ");
            Console.WriteLine("1-Pizza R$35,00");
            Console.WriteLine("2-Hambúrguer R$25,00");
            Console.WriteLine("3-Suco R$10,00");
            Console.WriteLine("0-Sair");
            int opcao;
            int total = 0;
            do
            { 
                string entrada = Console.ReadLine();
                bool deuCerto = int.TryParse(entrada, out opcao);
                if (!deuCerto)
                {
                    Console.WriteLine("Digite uma opção válida!");
                    continue;
                }
                if (opcao < 0 || opcao > 3)
                {
                    Console.WriteLine("Digite uma opção válida! ");
                    Console.WriteLine("1-Pizza R$35,00");
                    Console.WriteLine("2-Hambúrguer R$25,00");
                    Console.WriteLine("3-Suco R$10,00");
                    Console.WriteLine("0-Sair");
                    continue;
                }

                int valor = opcao switch
                {
                    1 => 35,
                    2 => 25,
                    3 => 10,
                    0 => 0
                };
                if (opcao == 0)
                {
                    break;
                }

                total += valor;
                    Console.WriteLine($"Valor atual do pedido: {total:C}");
                    Console.WriteLine("Gostaria de adicionar mais itens? ");
                    Console.WriteLine("1-Pizza R$35,00");
                    Console.WriteLine("2-Hambúrguer R$25,00");
                    Console.WriteLine("3-Suco R$10,00");
                    Console.WriteLine("0-Sair");
                } while (opcao != 0);
            Console.WriteLine($"Seu pedido ficou no total: R${total:C}");
        }
    }
}
