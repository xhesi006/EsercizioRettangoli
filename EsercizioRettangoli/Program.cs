using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioRettangoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo r1 = new Rettangolo(2, 3);
            Rettangolo r2 = new Rettangolo(3, 5);
            if (true)
                Console.WriteLine("rettangoli uguali");
            else
                Console.WriteLine("rettangoli diversi");
            Console.ReadLine();
        }
    }
}
