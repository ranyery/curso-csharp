using System;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] valores;
            int horaInicial, horaFinal, duracaoJogo;

            valores = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(valores[0]);
            horaFinal = int.Parse(valores[1]);

            if (horaInicial > horaFinal)
            {
                duracaoJogo = 24 - horaInicial + horaFinal;
            } else if (horaInicial < horaFinal)
            {
                duracaoJogo = horaFinal - horaInicial;
            } else
            {
                duracaoJogo = 24;
            }

            Console.WriteLine("O JOGO DUROU " + duracaoJogo + " HORA(S)");
        }
    }
}
