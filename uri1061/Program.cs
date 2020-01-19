using System;

namespace uri1061
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] dia, horario;
            int diaInicial, diaFinal,
                horaInicial, minutoInicial, segundoInicial,
                horaFinal, minutoFinal, segundoFinal,
                qtdDias, qtdHoras, qtdMinutos, qtdSegundos,
                totalSegundosDiaInicial, totalSegundosDiaFinal, totalSegundos;

            dia = Console.ReadLine().Split(' ');
            diaInicial = int.Parse(dia[1]);
            horario = Console.ReadLine().Split(':');
            horaInicial = int.Parse(horario[0]);
            minutoInicial = int.Parse(horario[1]);
            segundoInicial = int.Parse(horario[2]);

            dia = Console.ReadLine().Split(' ');
            diaFinal = int.Parse(dia[1]);
            horario = Console.ReadLine().Split(':');
            horaFinal = int.Parse(horario[0]);
            minutoFinal = int.Parse(horario[1]);
            segundoFinal = int.Parse(horario[2]);

            totalSegundosDiaInicial = horaInicial * 3600 + minutoInicial * 60 + segundoInicial;
            totalSegundosDiaFinal = horaFinal * 3600 + minutoFinal * 60 + segundoFinal;
            totalSegundos = ((diaFinal - diaInicial) * 86400) - totalSegundosDiaInicial + totalSegundosDiaFinal;

            qtdDias = totalSegundos / 86400;
            totalSegundos %= 86400;

            qtdHoras = totalSegundos / 3600;
            totalSegundos %= 3600;

            qtdMinutos = totalSegundos / 60;
            totalSegundos %= 60;

            qtdSegundos = totalSegundos;

            Console.WriteLine(qtdDias + " dia(s)");
            Console.WriteLine(qtdHoras + " hora(s)");
            Console.WriteLine(qtdMinutos + " minuto(s)");
            Console.WriteLine(qtdSegundos + " segundo(s)");
        }
    }
}
