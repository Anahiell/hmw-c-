using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3d
{
    public class Line
    {
       private Point2D<int> A { get; set; }
       private Point2D<int> B { get; set; }
        public Line(object A,object B)
        {
            this.A = (Point2D<int>)A;
            this.B = (Point2D<int>)B;
        }
        public Line(int Xa,int Ya,int Xb,int Yb)
        {
            A.X = Xa;
            A.Y = Ya;
            B.X = Xb;
            B.Y = Yb;
        }
        public override string ToString()
        {
            return $"Line bilding...\nFirst point:{A}\nLast point:{B}";
        }
    }
}
