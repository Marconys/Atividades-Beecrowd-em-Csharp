using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Distancia = Int32.Parse(Console.ReadLine());

            int tempo = Distancia * 2;

            Console.WriteLine($"{tempo} minutos");
            Console.ReadKey();
        }
    }
}
