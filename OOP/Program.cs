using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p = new Point();
            //p.Input();
            //p.Print();
            //Point p2 = new Point();
            //p2.Input();
            //p2.Print();
            //double c = p.KhoangCach(p2);
            //Console.WriteLine("Khoang cach 2 diem la: " + c);
            Point p = new Point();
            p.Input(1, 5);
            Circle circle = new Circle(p,10);
            Point p2 = new Point(5, 12);
            Circle.Posittion position = circle.GetPosittion(p2);
            Console.WriteLine(position);
        }
    }
}
