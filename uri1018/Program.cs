using System;

namespace uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, 
                resto, 
                qtdNotas100, 
                qtdNotas50, 
                qtdNotas20, 
                qtdNotas10, 
                qtdNotas5, 
                qtdNotas2, 
                qtdNotas1;

            valor = int.Parse(Console.ReadLine());

            qtdNotas100 = valor / 100;
            resto = valor % 100;

            qtdNotas50 = resto / 50;
            resto %= 50;

            qtdNotas20 = resto / 20;
            resto %= 20;

            qtdNotas10 = resto / 10;
            resto %= 10;

            qtdNotas5 = resto / 5;
            resto %= 5;

            qtdNotas2 = resto / 2;
            resto %= 2;

            qtdNotas1 = resto;

            Console.WriteLine(valor);
            Console.WriteLine(qtdNotas100 + " nota(s) de R$ 100,00");
            Console.WriteLine(qtdNotas50 + " nota(s) de R$ 50,00");
            Console.WriteLine(qtdNotas20 + " nota(s) de R$ 20,00");
            Console.WriteLine(qtdNotas10 + " nota(s) de R$ 10,00");
            Console.WriteLine(qtdNotas5 + " nota(s) de R$ 5,00");
            Console.WriteLine(qtdNotas2 + " nota(s) de R$ 2,00");
            Console.WriteLine(qtdNotas1 + " nota(s) de R$ 1,00");
        }
    }
}
