using System;
namespace LogicaCSharp.Exercicios._03_loops
{
    internal class ex00TernarioAndSwitchExpression
    {
        public static void Executar()
        {
            Console.Write("Me diga sua nota: ");
            string entrada = Console.ReadLine();
            bool deuCerto = int.TryParse(entrada, out int nota);

            if (deuCerto)
            {
                string status = nota >= 5 ? "Você passou!" : "Você reprovou!";

                string letraDaNota = nota switch
                {
                    >= 0 and <= 4 => "D",
                    5 or 6 => "C",
                    7 or 8 => "B",
                    9 or 10 => "A",
                    _ => "nota inválida"
                };
                Console.WriteLine(status);
                Console.WriteLine($"Você tirou {nota}, logo ficou com {letraDaNota}");
            }
            else
            {
                Console.WriteLine("Digite uma nota válida!");
            }
        }
    }
}
    