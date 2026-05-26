using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LogicaCSharp.Exercicios._03_loops
{
    internal class ex03TabuadaFormatada
    {
        public static void Executar()
        {
            int numero;
            Console.WriteLine("Digite um número para mostrar sua tabuada!");
            while (true)
            {
                

                string entrada = Console.ReadLine();
                bool deuCerto = int.TryParse(entrada, out numero);

                if (deuCerto)
                {
                    break;
                }
                Console.WriteLine("Digite um número válido!");
            }

            for (int i = 0; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}

