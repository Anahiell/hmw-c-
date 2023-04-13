using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin_Dis
{
    class PlayT:IDisposable
    {
        private string Name_Pl { get; set; }
        //{
        //    get
        //    {
        //        return " ";
        //    }
        //    set
        //    {
        //        if (Name_Pl == null)
        //        {
        //            Console.WriteLine("Wrong name!!!");
        //            Name_Pl = "Wrong name Poem";
        //        }
        //        else
        //        {
        //            Name_Pl = value;
        //        }
        //    }
        //}
        private string Creator { get; set; }
        //{
        //    get
        //    {
        //        return Creator;
        //    }
        //    set
        //    {
        //        if (Creator == null)
        //        {
        //            Creator = "Anonimus";
        //        }
        //        else
        //        {
        //            Creator = value;
        //        }
        //    }
        //}
        private string Genre { get; set; }
//        {
//            get
//            {
//                return Genre;
//            }
//    set
//            {
//                if(Genre==null)
//                {
//                    Genre = "Abstractiv";
//                }
//                else
//{
//    Genre = value;
//}
//            }
//        }
        private int Year { get; set; }
        public PlayT()
        {
            Name_Pl = "Noname";
            Creator = "Nobody";
            Genre = "None";
            Year = 0;
        }
        public PlayT(string Name, string Creator, string Genre, int Year)
        {
            Name_Pl = Name;
            this.Creator = Creator;
            this.Genre = Genre;
            this.Year = Year;
        }
        public override string ToString()
        {
           string Inf="Name of play:" + Name_Pl + "\nCreator:" + Creator + "\nGenre and Year:" + Genre + "(" + Year + ")";
            return Inf;
        }
        public void Dispose()
        {
            Console.WriteLine($"THIS IS Disposeble for PlayT {Name_Pl}");
            
        }
        ~PlayT()
        {
            Console.WriteLine($"its not Destructor, THIS IS FINALIZATOR for PlayT {Name_Pl}");
        }
    }
}
