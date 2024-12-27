using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practis4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("pleas enter one number");
            string num1 = Console.ReadLine();
            Console.Write("please enter another number");
            string num2 = Console.ReadLine();
            int temp;
            int num3 = int.Parse(num1);
            int num4 = int.Parse(num2);
            temp = num3;
            num3 = num4;
            num4 = temp;
            Console.WriteLine("num1: " +num3+" num2: " +num4);
            Console.Write("press any key to exit");
            Console.ReadKey();
            
        }
    }
}
