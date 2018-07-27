using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GitCalc.Calculations;

namespace GitCalc
{
    class Program
    {
        private static double returned = 0;
        private static bool flag = false;
        static void Main(string[] args)
        {
            double a;
            double b;
            string dzial;

            flag = false;

           // do
           // {
                Console.WriteLine("Hello, please insert first number");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("insert second number");
                b = double.Parse(Console.ReadLine());
            //} while (flag);



            Console.WriteLine("select equation: \n 1. Addition\n 2. Minus\n 3. Multiplication ");

            dzial = Console.ReadLine();

            if (dzial.Equals("1"))
            {
                returned = Calculations.Add(a, b);
            }

             else if (dzial.Equals("2"))
            {
                returned = Calculations.Minus(a, b);
            }

            else if (dzial.Equals("3"))
            {
                returned = Calculations.Times(a, b);
            }

            else
            {
                returned = -99.99;
                Console.WriteLine("not valid equation");
            }

            Console.WriteLine("here is your calculated value");
            Console.WriteLine(returned.ToString());
            Console.ReadKey();
        }
    }
}
