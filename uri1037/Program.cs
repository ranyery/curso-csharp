using System;
using System.Globalization;

namespace uri1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string intervalo;

            if (valor >= 0 && valor <= 25) {
                intervalo = "Intervalo [0,25]";
            } else if (valor > 25 && valor <= 50) {
                intervalo = "Intervalo (25,50]";
            } else if (valor > 50 && valor <= 75) {
                intervalo = "Intervalo (50,75]";
            } else if (valor > 75 && valor <= 100) {
                intervalo = "Intervalo (75,100]";
            } else {
                intervalo = "Fora de intervalo";
            }

            Console.WriteLine(intervalo);
        }
    }
}
