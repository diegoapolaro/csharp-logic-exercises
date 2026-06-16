using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaCSharp.Exercicios._03_loops
{
    internal class exDesafio02JogoDeDados
    {
        public static void Executar()
        {
            int rodadasUm = 0;
            int rodadasDois = 0;
            int rodada;

            Random random = new Random();

            int acumuladoJ1 = 0;
            int acumuladoJ2 = 0;
            for (rodada = 1; rodadasUm < 3 && rodadasDois < 3; rodada++)
            {
                int jogadorUm = 0;
                int jogadorDois = 0;
                Console.WriteLine($"{rodada}° RODADA");
                Console.WriteLine("----------------------------------");
                Console.WriteLine();

                Console.WriteLine("JOGADOR 1");
                int dadoJ1Um = random.Next(1, 7);
                int dadoJ1Dois = random.Next(1, 7);
                Console.WriteLine($"1° Dado: {dadoJ1Um}");
                Console.WriteLine($"2° Dado: {dadoJ1Dois}");
                jogadorUm += dadoJ1Um;
                jogadorUm += dadoJ1Dois;
                Console.WriteLine($"Pontuação da rodada do 1° jogador: {jogadorUm}");
                Console.WriteLine("----------------------------------");

                Console.WriteLine();
                Console.WriteLine("JOGADOR 2");

                int dadoJ2Um = random.Next(1, 7);
                int dadoJ2Dois = random.Next(1, 7);
                jogadorDois += dadoJ2Um;
                jogadorDois += dadoJ2Dois;

                Console.WriteLine($"1° Dado: {dadoJ2Um}");
                Console.WriteLine($"2° Dado: {dadoJ2Dois}");
                Console.WriteLine($"Pontuação da rodada do 2°: {jogadorDois}");

                Console.WriteLine();

                if (jogadorUm > jogadorDois)
                {
                    rodadasUm++;
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"VENCEDOR DA {rodada}° RODADA: JOGADOR 1: {jogadorUm} pontos");
                    Console.WriteLine();
                }
                else if (jogadorUm == jogadorDois)
                {
                    Console.WriteLine($"{rodada}° DEU EMPATE");
                }
                else
                {
                    rodadasDois++;
                    Console.WriteLine($"VENCEDOR DA {rodada}° RODADA: JOGADOR 2: {jogadorDois} pontos");
                    Console.WriteLine();
                }

                acumuladoJ1 += jogadorUm;
                acumuladoJ2 += jogadorDois;
            }


            if (rodadasUm > rodadasDois)
            {
                Console.WriteLine("==================================");
                Console.WriteLine("VENCEDOR DO JOGO: JOGADOR 1");
                Console.WriteLine($"Com {acumuladoJ1} pontos");
                Console.WriteLine($"Foram jogadas {rodada} até a vítoria do 1° Jogador");
            }
            else
            {
                Console.WriteLine("==================================");
                Console.WriteLine("VENCEDOR DO JOGO: JOGADOR 2");
                Console.WriteLine($"Com {acumuladoJ2} pontos");
                Console.WriteLine($"Foram jogadas {rodada} rodadas até a vítoria do 2° Jogador");
            }

        }
    }
}
