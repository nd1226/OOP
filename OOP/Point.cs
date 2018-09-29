using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP
{
    public class Point
    {

        public int X { get; private set; }
        public int Y { get; private set; }
        //Constructor
        public Point() { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Input(int x,int y)
        {
            X = x;
            Y = y;
        }

        public void Print()
        {
            Console.WriteLine("Toa Do :({0},{1})", X, Y);
        }
        public double KhoangCach(Point p)
        {
            return Math.Sqrt(Math.Pow((X - p.X), 2) + Math.Pow((Y - p.Y), 2));
        }
    }
}
