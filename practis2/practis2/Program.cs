using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace practis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNum;//define int
            string num;//define string
            num = Console.ReadLine();//get num
            userNum = int.Parse(num);//type cast
            int res;

            if (userNum % 2 == 0)
            {
                res = (userNum * 2);
            }
            else
            {
                res = (userNum%2);
            }
            Console.Write(res);
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}