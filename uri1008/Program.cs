using System;
using System.Globalization;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int idFuncionario = int.Parse(Console.ReadLine());
            int qtdHorasTrabalhadas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salarioTotal = qtdHorasTrabalhadas * valorHora;

            Console.WriteLine("NUMBER = " + idFuncionario);
            Console.WriteLine("SALARY = U$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
