using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin_Dis
{
    class Market:IDisposable
    {
        private string NameMarket { get; set; }
        private string Adress { get; set; }
        private Type TypeMarket { get; set; }
        private enum Type
        {
            Food,
            Domestic,
            Cloth,
            Shoes
        }
        public Market()
        {
        }
        public Market(string Name, string Adress,int x )
        {
            NameMarket = Name;
            this.Adress = Adress;
            if (x > 3)
            {
                Console.WriteLine("Wrong Type market");
            }
            TypeMarket = (Type)x;
        }
        public override string ToString()
        {
            return "Name:"+NameMarket+"\nAdress:"+Adress+"\nType:"+TypeMarket.ToString();
        }
        public void Dispose()
        {
            Console.WriteLine($"This is Disposeble for Market {NameMarket}");
        }
        ~Market()
        {
            Console.WriteLine($"This is Finalizator for Market {NameMarket}");
        }
    }
}
