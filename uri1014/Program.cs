using System;
using System.Globalization;

namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaTotalPercorrida = int.Parse(Console.ReadLine());
            double totalCombustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumoMedio = distanciaTotalPercorrida / totalCombustivelGasto;

            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
