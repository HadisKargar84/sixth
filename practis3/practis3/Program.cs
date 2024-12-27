using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practis3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("pleas enter one number");
            string num1 = Console.ReadLine();
            Console.Write("please enter another number");
            string num2 = Console.ReadLine();
            int num3 = int.Parse(num1);
            int num4 = int.Parse(num2);
            int sum = num3 + num4;
            int avg = sum / 2;
            Console.Write(avg);
 	    Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}