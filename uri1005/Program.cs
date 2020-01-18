using System;
using System.Globalization;

namespace uri1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            MEDIA = (A * 3.5 + B * 7.5) / 11.0;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
