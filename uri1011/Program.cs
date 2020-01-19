using System;
using System.Globalization;

namespace uri1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.14159;
            int raio = int.Parse(Console.ReadLine());
            double volumeEsfera = 4 / 3.0 * PI * Math.Pow(raio, 3);
            Console.WriteLine("VOLUME = " + volumeEsfera.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
