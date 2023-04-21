using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3d
{
    public class Point3D:Point2D<int>
    {
        public int Z { get; set; }
        public Point3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Point3D(int X,int Y,int Z)
        {
            this.X=X;
            this.Y = Y;
            this.Z = Z;
        }
        public override string ToString()
        {
            return $"X:{X}; Y:{Y}; Z:{Z};";
        }
    }
}
