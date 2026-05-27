using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaCSharp.Exercicios._03_loops
{
    internal class ex04FizzBuzzComLoop
    {
        public static void Executar()
        {
            int fizz = 0;
            int buzz = 0;
            int fizzBuzz = 0;
            for (int i = 1; i <= 50; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    fizz++;
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    buzz++;
                }
                else if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    fizzBuzz++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Quantidade de Fizz: {fizz} | Buzz: {buzz} | FizzBuzz: {fizzBuzz}");
        }
    }
}
