using System;
using System.Globalization;

namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] valores;
            int codItem, precoUnitario;
            double total = 0;

            valores = Console.ReadLine().Split(' ');
            codItem = int.Parse(valores[0]);
            precoUnitario = int.Parse(valores[1]);

            switch (codItem)
            {
                case 1:
                    total = precoUnitario * 4.0;
                    break;
                case 2:
                    total = precoUnitario * 4.5;
                    break;
                case 3:
                    total = precoUnitario * 5.0;
                    break;
                case 4:
                    total = precoUnitario * 2.0;
                    break;
                case 5:
                    total = precoUnitario * 1.5;
                    break;
                default:
                    break;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
