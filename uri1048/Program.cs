using System;
using System.Globalization;

namespace uri1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, valorReajuste, percentualReajuste, novoSalario;
            
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.0)
            {
                valorReajuste = salario * 0.15;
            } else if (salario <= 800.0)
            {
                valorReajuste = salario * 0.12;
            } else if (salario <= 1200.0)
            {
                valorReajuste = salario * 0.10;
            } else if (salario <= 2000.0)
            {
                valorReajuste = salario * 0.07;
            } else
            {
                valorReajuste = salario * 0.04;
            }

            novoSalario = salario + valorReajuste;
            percentualReajuste = (valorReajuste / salario) * 100.0;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + valorReajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentualReajuste.ToString("F0") + " %");
        }
    }
}
