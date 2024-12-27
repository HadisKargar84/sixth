using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("please enter your age");
            string age1 = Console.ReadLine();
            int age = int.Parse(age1);
            if ( age <30 && age>20)
            {
                Console.Write("hello");
            }
            else
            {
                Console.Write("bye");
            }
	    Console.WriteLine("press any key to exit");
            Console.ReadKey();
            
        }
    }
}
