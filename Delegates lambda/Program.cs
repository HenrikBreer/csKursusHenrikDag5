using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_lambda
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };

            int i1 = a.FindIndex(find);
            Console.WriteLine(i1.ToString());
            int i2 = a.FindIndex(i => i == 51);
            Console.WriteLine(i2.ToString());
            Console.ReadKey();

            a.ForEach(ListVærdi);
            a.ForEach(i => Console.WriteLine(i));



            Console.ReadKey();

        }


        public static bool find(int a) { return a==51; }

        public static void ListVærdi(int i)
        {
            Console.WriteLine(i);
        }
    }
}
