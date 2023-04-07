using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalc Cl = new MyArray(5);
            MyArray Array = new MyArray();
            Console.WriteLine("Task #1 ICalc:");
            Console.WriteLine("Have Array:"+Cl.ToString());
            Console.WriteLine($"Have {Cl.Less(50)} elements smoller then 50");
            Console.WriteLine($"Have {Cl.Greater(40)} elements Bigger then 40");
            Console.WriteLine("Task #2 IOutput2:");
            Console.WriteLine("Have Array:" + Array.ToString());
            Console.WriteLine("Show Even:");
            Array.ShowEven();
            Console.WriteLine("Show Odd:");
            Array.ShowOdd();
            Console.WriteLine("Task #3 ICalc2:");
            Console.WriteLine("Have Array:" + Array.ToString());
            Console.WriteLine($"Have {Array.CountDistinct()} elements unique");
            Console.WriteLine($"Have {Array.EqualToValue(35)} elements equals then 35");

        }
    }
}
