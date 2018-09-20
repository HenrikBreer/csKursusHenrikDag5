using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_log
{
    class Program
    {

        static void AppendLog(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        }

        static void Main(string[] args)
        {

            Maskine m = new Maskine();
            m.Log = Console.WriteLine;

            m.Start();
            m.Stop();


            Console.ReadKey();



            m.Log = AppendLog;

            m.Start();
            m.Stop();


            Console.ReadKey();





        }
    }

    public delegate void LogDelegate(string txt);

    class Maskine
    {
        public LogDelegate Log { get; set; }
        //Eller :  public Action<string> Log { get; set; }



        public void Start()

        {

            Log(DateTime.Now.ToLongTimeString() + " Starter");

        }

        public void Stop()

        {

            Log(DateTime.Now.ToLongTimeString() + " Stopper");

        }




    }

}
