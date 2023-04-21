using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3d
{
    class Program
    {
        static void Main(string[] args)
        {
            object A = new Point2D<int>(2, 3);
            object B = new Point2D<int>(7, 6);
            object A3 = new Point3D(1, 2, 3);
            Console.WriteLine(A3);
            Console.WriteLine("///////////");
            object Line = new Line(A, B);
            Console.WriteLine(Line);
            Console.WriteLine("///////////");
            string Text = @"            Some Text
            Peter Piper picked a peck of pickled peppers.
            A peck of pickled peppers Peter Piper picked.
            If Peter Piper picked a peck of pickled peppers,
            Where's the peck of pickled peppers Peter Piper picked?";
            Console.WriteLine(Text);
            string[] Words = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            Dictionary<string, int> Repeat = new Dictionary<string, int>();

            Repeat.Add("Peter", 0);
            Repeat.Add("peppers", 0);
            Repeat.Add("Piper", 0);
            foreach (string s in Words)
            {
                if (s.Contains("Peter"))
                {
                    Repeat["Peter"]++;
                }
                if (s.Contains("peppers"))
                {
                    Repeat["peppers"]++;
                }
                if (s.Contains("Piper"))
                {
                    Repeat["Piper"]++;
                }
            }
            foreach (var s in Repeat)
            {
                Console.WriteLine("{0} in text have {1}", s.Key, s.Value);
            }

        }
    }
}
