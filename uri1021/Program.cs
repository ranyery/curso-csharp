using System;
using System.Globalization;

namespace uri1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int qtdNotas100, qtdNotas50, qtdNotas20, qtdNotas10, qtdNotas5, qtdNotas2;
            int qtdMoedas1, qtdMoedas50c, qtdMoedas25c, qtdMoedas10c, qtdMoedas5c, qtdMoedas1c;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            qtdNotas100 = (int)valor / 100;
            valor %= 100.0;

            qtdNotas50 = (int)valor / 50;
            valor %= 50.0;

            qtdNotas20 = (int)valor / 20;
            valor %= 20.0;

            qtdNotas10 = (int)valor / 10;
            valor %= 10.0;

            qtdNotas5 = (int)valor / 5;
            valor %= 5.0;

            qtdNotas2 = (int)valor / 2;
            valor %= 2.0;

            // A fim de facilitar o cálculo, as moedas serão tratadas como notas
            valor *= 100;

            qtdMoedas1 = (int)valor / 100;
            valor %= 100.0;

            qtdMoedas50c = (int)valor / 50;
            valor %= 50.0;

            qtdMoedas25c = (int)valor / 25;
            valor %= 25.0;

            qtdMoedas10c = (int)valor / 10;
            valor %= 10.0;

            qtdMoedas5c = (int)valor / 5;
            valor %= 5.0;

            qtdMoedas1c = (int)valor;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(qtdNotas100 + " nota(s) de R$ 100.00");
            Console.WriteLine(qtdNotas50 + " nota(s) de R$ 50.00");
            Console.WriteLine(qtdNotas20 + " nota(s) de R$ 20.00");
            Console.WriteLine(qtdNotas10 + " nota(s) de R$ 10.00");
            Console.WriteLine(qtdNotas5 + " nota(s) de R$ 5.00");
            Console.WriteLine(qtdNotas2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(qtdMoedas1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(qtdMoedas50c + " moeda(s) de R$ 0.50");
            Console.WriteLine(qtdMoedas25c + " moeda(s) de R$ 0.25");
            Console.WriteLine(qtdMoedas10c + " moeda(s) de R$ 0.10");
            Console.WriteLine(qtdMoedas5c + " moeda(s) de R$ 0.05");
            Console.WriteLine(qtdMoedas1c + " moeda(s) de R$ 0.01");
        }
    }
}
