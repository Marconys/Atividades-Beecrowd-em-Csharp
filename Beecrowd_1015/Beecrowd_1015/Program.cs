using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Beecrowd_1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ponto1 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(ponto1[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(ponto1[1], CultureInfo.InvariantCulture);

            string[] ponto2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(ponto2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(ponto2[1], CultureInfo.InvariantCulture);

            double Distancia = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            Distancia = Math.Sqrt(Distancia);

            Console.WriteLine($"{Distancia.ToString("F4", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
