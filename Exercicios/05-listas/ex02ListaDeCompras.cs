using System;

namespace LogicaCSharp.Exercicios._05_listas
{
    internal class ex02ListaDeCompras
    {
        public static void Executar()
        {
            List<string> itens = new List<string>();
            int opcao;
            string itemAdd;
            Console.WriteLine("-----------LISTA DE COMPRAS---------------");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            do
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1 - Adicionar item");
                Console.WriteLine("2 - Remover item");
                Console.WriteLine("3 - Listar itens");
                Console.WriteLine("0 - Sair");

                string entrada = (Console.ReadLine());
                bool deuCerto = int.TryParse(entrada, out opcao);

                if (opcao < 0 || opcao > 3)
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }

                if (opcao == 1)
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Digite o item a adicionar a lista");
                    itens.Add(Console.ReadLine());

                    continue;
                }

                if (opcao == 2)
                {
                    Console.WriteLine("----------------------------------");
                    Console.Write("Nome do item para remover: ");
                    string nome = Console.ReadLine();

                    bool removeu = itens.Remove(nome);

                    if (removeu)
                    {
                        Console.WriteLine("Item removido!");
                    }
                    else
                    {
                        Console.WriteLine("Esse item não existe na lista.");
                    }

                    continue;
                }

                if (opcao == 3)
                {
                    Console.WriteLine("----------------------------------");
                    if (itens.Count == 0)
                    {
                        Console.WriteLine("A lista está vazia!");
                        continue;
                    }
                    foreach (string item in itens)
                    {
                        Console.WriteLine(item);
                    }
                    continue;
                }

                

            } while (opcao != 0);

            Console.WriteLine("----------------------------------");
            if (itens.Count == 0)
            {
                Console.WriteLine("Você não adicionou nenhum item a lista! ");
            }
            else
            {
                Console.WriteLine("Sua lista final: ");


                foreach (string item in itens)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }
    }
}
