using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



namespace Beecrowd_1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string[] compra = Console.ReadLine().Split(' ');
            int codProd = Int32.Parse(compra[0]);
            int qtdProd = Int32.Parse(compra[1]);
            double valorProd = double.Parse(compra[2], CultureInfo.InvariantCulture);

            string[] compra1 = Console.ReadLine().Split(' ');
            int codProd1 = Int32.Parse(compra1[0]);
            int qtdProd1 = Int32.Parse(compra1[1]);
            double valorProd1 = double.Parse(compra1[2], CultureInfo.InvariantCulture);

            double total = (qtdProd * valorProd) + (qtdProd1 * valorProd1);

            Console.WriteLine("VALOR A PAGAR: R$ {0}",total.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
