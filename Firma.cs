using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmArr
{
    class Firma
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string NameDirector { get; set; }
        public int CountWorker { get; set; }
        public string Adress { get; set; }
        public Firma(string Name,DateTime Date,string Type,string NameD,int Count,string Adress)
        {
            this.Name = Name;
            this.Date = Date;
            this.Type = Type;
            NameDirector = NameD;
            CountWorker = Count;
            this.Adress = Adress;
        }
        public override string ToString()
        {
            return $"Named Firm:{Name}\nDate of creation:{Date}\nType:{Type}\nDirector name:{NameDirector}\nWorkers:{CountWorker}\nAdress:{Adress}";
        }
    }
}
