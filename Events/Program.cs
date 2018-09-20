using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher f = new System.IO.FileSystemWatcher(@"c:\temp\");
            f.EnableRaisingEvents = true;
            f.Created += (s, e) => { Console.WriteLine("Oprettet" + e.FullPath); };
            f.Deleted += (s,e) => { Console.WriteLine("Slettet" + e.FullPath); };
            f.Changed += (s, e) => { Console.WriteLine("Ændret" + e.FullPath); };
            
            f.Changed += (s, e) => {
                
                Console.WriteLine(System.IO.File.ReadAllText(e.FullPath)); };
            
            do
            {

            } while (true);
        }
    }
}
