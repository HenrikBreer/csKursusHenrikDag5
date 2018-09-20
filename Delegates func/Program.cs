using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_func
{
  
        class Program
        {
            //public delegate int Beregn(int a, int b); Erstattes af generisk delegate 

            public static Func<int, int, int> tilfældigBeregner()
            {
                int t = System.DateTime.Now.Millisecond % 4;
                if (t == 0) { return Plus; }
                else if (t == 1) { return Minus; }
                else if (t == 2) { return Divider; }
                else { return Gange; }


            }


            static void Main(string[] args)
            {

                Func<int,int,int> f = tilfældigBeregner();

                Console.WriteLine(f(1, 2));
                Console.ReadKey();
            }


            public static int Plus(int a, int b)
            {
                return a + b;
            }
            public static int Minus(int a, int b)
            {
                return a - b;
            }

            public static int Divider(int a, int b)
            {
                return a / b;
            }

            public static int Gange(int a, int b)
            {
                return a * b;
            }



        }



    
}
