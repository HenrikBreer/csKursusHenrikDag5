using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    public delegate void MinDelegate1(string t);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*");
            MinDelegate1 f1 = new MinDelegate1(Console.WriteLine);
            f1 += MinSkriv;
            f1.Invoke("*");
            f1("*");

            Console.ReadKey();
            f1 -= MinSkriv;
            f1 -= Console.WriteLine;

        }


        static void MinSkriv(string txt)
        {
            Console.WriteLine("********** " + txt + " ***********");
        }
    }
}
