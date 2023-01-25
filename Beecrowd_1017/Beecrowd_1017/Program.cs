using System;
using System.Globalization;

namespace Beecrowd_1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            double distancia = (horas * velocidade);
            double qtdLitros = (distancia / 12);

            Console.WriteLine(qtdLitros.ToString("F3",CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
