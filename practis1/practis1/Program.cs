using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float userPoint;//define float
            string Point;//define string
            Point = Console.ReadLine();//get point
            userPoint = float.Parse(Point);//type cast
            string res;

            if (userPoint > 10)
            {
                res = "pass";
            }
            else
            {
                res = "fail";
            }
            Console.Write(res);
             Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
