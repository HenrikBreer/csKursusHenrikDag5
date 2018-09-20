using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.SqlServer.Server;

namespace Using_Oprydning
{
    class Program
    {


        static void Main(string[] args)
        {

            
            using (StreamReader stream = System.IO.File.OpenText(@"c:\temp\dyrenavne.txt"))
            { 

                while (stream.Peek() != -1)
                {
                    string navn = stream.ReadLine();
                    Console.WriteLine(navn);
                }
            stream.Close();
            //stream = null;

            Console.ReadKey();
            }
        }
                     
    }

}
