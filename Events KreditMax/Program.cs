using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_KreditMax
{
    class Program
    {
        static void Main(string[] args)
        {

            Kunde k = new Kunde() { KreditMax = -500 };
            k.KreditOverskredet += (s, e) => { Console.WriteLine("Kredit overskredet "); };

            k.Køb(100);
            k.Køb(500);

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }

        }
    }

    public class Kunde
    {
        // event mangler
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax { get; set; }
        public void Køb(int værdi)
        {
            Console.WriteLine("Kunde {0} køber for {1}", Navn, værdi);
            this.Saldo -= værdi;
            if (Saldo < KreditMax)
            {
                if (KreditOverskredet != null) // kald til event mangler
                    KreditOverskredet(this, new EventArgs());
            }
        }

        public event EventHandler KreditOverskredet;
        
                
    }



}
