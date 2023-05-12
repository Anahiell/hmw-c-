using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmArr
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            DateTime[] D = new DateTime[4];
            
            for(int i=0;i<4;i++)
            {
                D[i] = D[i].AddDays(r.Next(1,20));
                D[i] = D[i].AddYears(2022-i*2);
            }
            FirmsArr F = new FirmsArr();
            F.AddFirm(new Firma("FoodDelight", D[0], "Харчова індустрія", "John Smith", 50, "вул.Main, 123, Лондон"));
            F.AddFirm(new Firma("IT Solutions Ltd", D[1], "ІТ - консалтинг", "Sarah Johnson", 200, "вул.Tech Park, 456, Сан - Франциско"));
            F.AddFirm(new Firma("MarketingPlus", D[2], "Маркетингові послуги", "Michael White", 120, "вул.Marketing Avenue, 789, Лондон"));
            F.AddFirm(new Firma("TechWare", D[3], "Розробка програмного забезпечення", "Emily Black", 80, "вул.Innovation Road, 234, Сан - Франциско"));
            for(int i=0;i<4;i++)
            {
                Console.WriteLine( F.TakeAll()[i].ToString());
                Console.WriteLine("========================================");
            }
            /*Отримати інформацію про всі фірми. */
            //Firma Some=F.TakeFirm_by_name("Food");
            /* Отримати фірми, які мають у назві слово «Food».*/
            Console.WriteLine("________________task_#1__________________");
            Console.WriteLine("Отримати фірми, які мають у назві слово «Food».");
            F.TakeFirm_by_name("Food");
            /*. Отримати фірми, які працюють у галузі маркетингу. */
            Console.WriteLine("________________task_#2__________________");
            Console.WriteLine("Отримати фірми, які працюють у галузі маркетингу.");
            F.TakeFirm_by_Type("Маркетингові послуги");
            /* Отримати фірми, які працюють у галузі маркетингу або IT.*/
            Console.WriteLine("________________task_#3__________________");
            Console.WriteLine("Отримати фірми, які працюють у галузі маркетингу або IT.");
            F.TakeFirm_by_Type("ІТ - консалтинг", "Маркетингові послуги");
            /* Отримати фірми з кількістю працівників більшою, ніж 100.*/
            Console.WriteLine("________________task_#4__________________");
            Console.WriteLine("Отримати фірми з кількістю працівників більшою, ніж 100.");
            F.TakeFirm_by_CountWorker(100);
            /* Отримати фірми з кількістю працівників у діапазоні від 100 до 300. */
            Console.WriteLine("________________task_#5__________________");
            Console.WriteLine("Отримати фірми з кількістю працівників у діапазоні від 100 до 300.");
            F.TakeFirm_by_CountWorker_diap(100, 300);
            /* Отримати фірми, які знаходяться в Лондоні. */
            Console.WriteLine("________________task_#6__________________");
            Console.WriteLine("Отримати фірми, які знаходяться в Лондоні.");
            F.TakeFirm_by_Adress("Лондон");

            /* Отримати фірми, в яких прізвище директора White. */
            Console.WriteLine("________________task_#7__________________");
            Console.WriteLine("Отримати фірми, в яких прізвище директора White.");
            F.takeFirm_by_DirName("White");
            /* Отримати фірми, які засновані більше двох років тому. */
            Console.WriteLine("________________task_#8__________________");
            Console.WriteLine("Отримати фірми, які засновані більше двох років тому.");
            F.TakeFirm_by_older(2);
            /* Отримати фірми з дня заснування яких минуло 123 дні.*/
            Console.WriteLine("________________task_#9__________________");
            Console.WriteLine("Отримати фірми з дня заснування яких минуло 123 дні.");
            F.TakeFirm_by_older_day(123);
            /* Отримати фірми, в яких прізвище директора Black і мають у назві фірми слово «White». */
            Console.WriteLine("________________task_#10__________________");
            Console.WriteLine("Отримати фірми, в яких прізвище директора Black і мають у назві фірми слово «White».");
            F.TakeFirm_by_NameDir_and_name("Black", "White");
        }
    }
}
