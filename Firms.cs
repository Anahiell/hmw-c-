using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmArr
{
    class FirmsArr
    {
        private List<Firma> firs;

        public FirmsArr()
        {
            firs = new List<Firma>();
        }

        public void AddFirm(Firma firma)
        {
            firs.Add(firma);
        }

        public List<Firma> TakeAll()
        {
            return firs;
        }

        public void TakeFirm_by_name(string some)
        {
            var X = firs.Where(f => f.Name.Contains(some)).ToList();
            foreach (var s in X)
                Console.WriteLine(s);
        }

        public void TakeFirm_by_Type(string tip)
        {
            var X = firs.Where(f => f.Type == tip).ToList();
            foreach (var s in X)
                Console.WriteLine(s);
        }
        public void TakeFirm_by_Type(string tip, string tip2)
        {
            var X = firs.Where(f => f.Type == tip || f.Type == tip2).ToList();
            foreach (var s in X)
                Console.WriteLine(s);
        }

        public void TakeFirm_by_CountWorker(int count)
        {
            var X = firs.Where(f => f.CountWorker > count).ToList();
            foreach (var s in X)
                Console.WriteLine(s);
        }

        public void TakeFirm_by_CountWorker_diap(int min, int max)
        {
            var X = firs.Where(f => f.CountWorker >= min && f.CountWorker <= max).ToList();
            foreach (var s in X)
                Console.WriteLine(s);
        }

        public void TakeFirm_by_Adress(string adress)
        {
            var X = firs.Where(f => f.Adress.Contains(adress)).ToList();
            foreach (var s in X)
                Console.WriteLine(s);
        }
        public void takeFirm_by_DirName(string name)
        {
            var X= firs.Where(f => f.NameDirector.Contains(name)).ToList();
            foreach (var s in X)
                Console.WriteLine(s);
        }

        public void TakeFirm_by_older(int c)
        {
            DateTime N = DateTime.Now.AddYears(-1*c);
            var X=firs.Where(f => f.Date < N).ToList();
            foreach (var s in X)
                Console.WriteLine(s);
        }

        public void TakeFirm_by_older_day(int c)
        {
            DateTime N = DateTime.Now.AddDays(-1*c);
            var X= firs.Where(f => f.Date.Date == N.Date).ToList();
            foreach (var s in X)
                Console.WriteLine(s);
        }

        public void TakeFirm_by_NameDir_and_name(string some1,string some2)
        {
            var X= firs.Where(f => f.NameDirector.Contains(some1) && f.Name.Contains(some2)).ToList();
            foreach (var s in X)
                Console.WriteLine(s);
        }
    }
}

