using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {

            double raio, areaCirculo, PI = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            areaCirculo = PI * Math.Pow(raio, 2);

            Console.WriteLine("A=" + areaCirculo.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
