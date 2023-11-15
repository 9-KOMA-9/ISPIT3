using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraznanja3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            int c = 1;
            int d = 0;
            for (int i = 0; i < a; i++)
            {
                d = b + c;
                Console.WriteLine(d);
                b = c;
                c = d;
            }
            Console.ReadKey();
        }
    }
}
