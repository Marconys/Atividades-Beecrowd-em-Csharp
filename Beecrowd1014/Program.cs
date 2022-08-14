using System;
using System.Globalization;

namespace Beecrowd1014
{  
    class Consumo
    {
        public int Km;
        public double Lt;

        public Consumo()
        {

        }

        public double CalcularConsumo()
        {
            return Km / Lt;
        }

        public override string ToString()
        {
            return CalcularConsumo().ToString("F3", CultureInfo.InvariantCulture) + " km/l"; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Consumo consumo = new Consumo();

            consumo.Km = int.Parse(Console.ReadLine());
            consumo.Lt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(consumo);

            Console.ReadKey();
        }
    }
}
