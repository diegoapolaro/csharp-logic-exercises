using System;
namespace LogicaCSharp.Exercicios._03_loops
{
    internal class ex05SomaComLoop
    {
        public static void Executar()
        {
            Console.Write("Sair = 0 || Vai digitando os números para a soma final: ");
            int numero;
            string entrada;
            bool deuCerto;
            while (true)
            {
                entrada = Console.ReadLine();
                deuCerto = int.TryParse(entrada, out numero);
                if (deuCerto)
                {
                    break;
                }
                Console.WriteLine("Tem que ser número, para poder colocar na soma");
            }
            int soma = 0;
            int qntdDeNumeros = 0;
            while (numero != 0)
            {
                soma += numero;
                entrada = Console.ReadLine();
                deuCerto = int.TryParse(entrada, out numero);
                qntdDeNumeros++;
            }
            int media = soma / qntdDeNumeros;
            Console.WriteLine($"Total somado: {soma} || Quantidade de números digitados para a soma: {qntdDeNumeros} || Media: {media}");
        }
    }
}
