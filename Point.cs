using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_struct_class
{
    class Point
    {
        public int Y { get; set; }
        public int X { get; set; }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
        public static bool operator >(Point obj, Point obj1)
        {
            int f = obj.Y + obj.X;
            int s = obj1.X + obj1.Y;
            if (f > s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Point obj, Point obj1)
        {
            int f = obj.Y + obj.X;
            int s = obj1.X + obj1.Y;
            if (s > f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Point obj, Point obj1)
        {
            int f = obj.Y + obj.X;
            int s = obj1.X + obj1.Y;
            if (s == f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Point obj, Point obj1)
        {
            int f = obj.Y + obj.X;
            int s = obj1.X + obj1.Y;
            if (s != f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Point operator +(Point obj, Point obj1)
        {
            obj.X += obj1.X;
            obj.Y += obj1.Y;
            return obj;
        }
        public static Point operator -(Point obj, Point obj1)
        {
            obj.X -= obj1.X;
            obj.Y -= obj1.Y;
            return obj;
        }
        public static bool operator false(Point v)
        {
            if ((v.X == 0) && (v.Y == 0))
                return true;
            else
                return false;
        }
        public static bool operator true(Point v)
        {
            if ((v.X != 0) || (v.Y != 0))
                return true;
            else
                return false;
        }
    }
}
