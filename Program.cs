using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin_Dis
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                PlayT Poem = new PlayT("Romeo & Julietta", "Shekspier", "Drama", 1594);
                Console.WriteLine(Poem);
                Poem = null;
                Console.WriteLine("!Start Garbeg collector to start work Finalizator!");
                System.GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            Console.WriteLine("\n////////////////////////////////\n");
            {
                PlayT Soem = new PlayT("Hamlet", "Shekspier", "Drama", 1604);
                Console.WriteLine(Soem.ToString());
                Console.WriteLine("!!!!!!!!!!");
                Soem.Dispose();
                Console.WriteLine("!!!!!!!!!!");
            }
            Console.WriteLine("\n|||||||||||||||||||||||||||||||\n");
            {
                Market Mar = new Market("Tavria","Pushkinskaya 7",0);
                Console.WriteLine(Mar);
                Console.WriteLine("!!!!!!!!!!");
                Mar.Dispose();
                Console.WriteLine("!!!!!!!!!!");
            }
            Console.WriteLine("\n////////////////////////////////\n");
            {
                Market Gar = new Market("Silpo", "Pantera 8a", 0);
                Console.WriteLine(Gar);
                Gar = null;
                Console.WriteLine("!Start Garbeg collector to start work Finalizator!");
                GC.WaitForPendingFinalizers();
            }
        }
    }
}
