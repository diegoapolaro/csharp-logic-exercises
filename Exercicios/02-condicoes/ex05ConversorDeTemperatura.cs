using System;
using System.Globalization;

namespace LogicaCSharp.Exercicios._02_condicoes
{
    internal class ex05ConversorDeTemperatura
    {
        public static void Executar()
        {
            Console.Write("Digite a temperatura em Celsius: ");
            string entrada = Console.ReadLine();
            bool deuCerto = double.TryParse(entrada, CultureInfo.InvariantCulture, out double resultado);

            if (deuCerto)
            {
                double fahrenheit = (resultado * 9 / 5) + 32;
                double kelvin = resultado + 273.15;

                Console.WriteLine($"Temperatura em Celsius: {resultado:F2}°C");
                Console.WriteLine($"convertida para Fahrenheit: {fahrenheit:F2}°F");
                Console.WriteLine($"convertida para Kelvin: {kelvin:F2}K");
            }
            else
            {
                Console.WriteLine("Digite uma temperatura valida.");
            }
        }
    }
}
