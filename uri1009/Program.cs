using System;
using System.Globalization;

namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeFuncionario;
            double salarioFixo, totalVendas, comissao, salarioTotal;

            nomeFuncionario = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            comissao = totalVendas * 0.15;
            salarioTotal = salarioFixo + comissao;

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
