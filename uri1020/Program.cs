using System;

namespace uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, qtdAnos, qtdMeses, qtdDias;

            valor = int.Parse(Console.ReadLine());

            qtdAnos = valor / 365;
            valor %= 365;

            qtdMeses = valor / 30;
            valor %= 30;

            qtdDias = valor;

            Console.WriteLine(qtdAnos + " ano(s)");
            Console.WriteLine(qtdMeses + " mes(es)");
            Console.WriteLine(qtdDias + " dia(s)");
        }
    }
}
