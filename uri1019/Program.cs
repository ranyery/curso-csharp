using System;

namespace uri1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, qtdHoras, qtdMinutos, qtdSegundos;
                
            N = int.Parse(Console.ReadLine());

            qtdHoras = N / 3600;
            N %= 3600;

            qtdMinutos = N / 60;
            N %= 60;

            qtdSegundos = N;

            Console.WriteLine(qtdHoras + ":" + qtdMinutos + ":" + qtdSegundos);
        }
    }
}
