using System;
using System.Globalization;

namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalHorasViagem, velocidadeMedia, totalPercorrido;
            double gastoCombustivel;

            totalHorasViagem = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            totalPercorrido = totalHorasViagem * velocidadeMedia;

            gastoCombustivel = totalPercorrido / 12.0;

            Console.WriteLine(gastoCombustivel.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
