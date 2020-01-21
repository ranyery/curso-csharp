using System;
using System.Globalization;

namespace uri1036
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] valores;
            double a, b, c, delta, x1, x2;

            valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
