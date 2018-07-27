using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCalc
{
    class Program
    {
        private static int a;
        static void Main(string[] args)
        {



            Console.WriteLine("Hello please insert number");
            a = Int32.Parse(Console.ReadLine());
            a = a * 4;
            Console.WriteLine("your number multiplied by 4 equals:\r\n {0}", a.ToString());
            Console.ReadKey();
        }
    }
}
