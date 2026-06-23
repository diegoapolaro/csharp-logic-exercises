using System;

namespace LogicaCSharp.Exercicios._05_listas
{
    internal class ex03Idades
    {
        public static void Executar()
        {
            List<int> idades = new List<int>();
            Console.WriteLine("Escreva 8 idades: ");
            for (int i = 0; i < 8; i++)
            {
                string entrada = Console.ReadLine();
                bool deuCerto = int.TryParse(entrada, out int idade);

                while (!deuCerto)
                {
                    Console.WriteLine("Idade inválida! Digite outra: ");
                    entrada = Console.ReadLine();
                    deuCerto = int.TryParse(entrada, out idade);
                    Console.WriteLine();
                }
                idades.Add(idade);
                Console.WriteLine();
            }
            int menoresDeIdade = 0;
            int adultos = 0;
            int idosos = 0;

            Console.WriteLine();
            Console.WriteLine("Menores de idade: ");
            foreach (int Idade in idades)
            {
                if (Idade < 18)
                {
                    Console.WriteLine(Idade);
                    menoresDeIdade++;
                }
            }
            if (menoresDeIdade == 0)
            {
                Console.WriteLine("Não há nenhum menor de idade");
            }



            Console.WriteLine("--------------------------------");
            Console.WriteLine("Adultos: ");
            foreach (int Idade in idades)
            {
                if (Idade >= 18 && Idade < 60)
                {
                    Console.WriteLine(Idade);
                    adultos++;
                }
            }

            if (adultos == 0)
            {
                Console.WriteLine("Não há nenhum adulto");
            }



            Console.WriteLine("--------------------------------");
            Console.WriteLine("Idosos:");
            foreach (int Idade in idades)
            {
                if (Idade >= 60)
                {
                    Console.WriteLine(Idade);
                    idosos++;
                }
            }
            if (idosos == 0)
            {
                Console.WriteLine("Não há nenhum idoso");
            }


            Console.WriteLine($"Menores de idade: {menoresDeIdade} | Adultos: {adultos} | Idosos: {idosos}");
        }
    }
}
