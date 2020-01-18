using System;
using System.Globalization;

namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdPeca1, qtdPeca2;
            double valorUnitarioPeca1, valorUnitarioPeca2, valorTotal;

            String[] valores = Console.ReadLine().Split(' ');
            qtdPeca1 = int.Parse(valores[1]);
            valorUnitarioPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            qtdPeca2 = int.Parse(valores[1]);
            valorUnitarioPeca2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valorTotal = qtdPeca1 * valorUnitarioPeca1 + qtdPeca2 * valorUnitarioPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
