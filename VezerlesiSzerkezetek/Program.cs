using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezerlesiSzerkezetek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abszolút érték számítás:");
            Console.WriteLine("Adjon meg egy számot:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
                a = -a;
            Console.WriteLine("A szám abszolút értéke: " + a);
            Console.ReadKey();
        }
    }
}
