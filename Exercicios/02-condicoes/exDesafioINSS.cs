using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LogicaCSharp.Exercicios._02_condicoes
{
    internal class exDesafioINSS
    {
        public static void Executar()
        {
            Console.Write("Salário bruto: ");
            string entrada = Console.ReadLine();

            bool deuCerto = double.TryParse(entrada, CultureInfo.InvariantCulture, out double saida);

            if (deuCerto)
            {
                double inss = saida * 0.11;
                double baseIR = saida - inss;
                double ir = baseIR * 0.15;
                double salarioFinal = saida - inss - baseIR;

                Console.WriteLine($"Salário bruto: {saida:C}");
                Console.WriteLine($"INSS (11%): {inss:C}");
                Console.WriteLine($"Salário após desconto INSS: {baseIR:C}");
                Console.WriteLine($"IR (15%): {ir:C}");
                Console.WriteLine($"Líquido: {salarioFinal:C}");
            }
            else
            {
                Console.WriteLine("Digite um salário valido!");
            }
        }
    }
}
