using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Circle
    {
        public enum Posittion
        {
            IN,
            OUT,
            ON
        };
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle() { }

        public Circle(Point center, double banKinh)
        {
            Center = center;
            Radius = banKinh;
        }
        public Circle(int x,int y, double banKinh)
        {
            Center = new Point(x, y);
            Radius = banKinh;
        }


        public void Input(Point point,double radaius)
        {
            Center = point;
            Radius = radaius;
        }

        public void Input(int x, int y, double radius)
        {
            Center = new Point(x, y);
            Radius = radius;
        }

        public void Print()
        {
            Console.WriteLine("Center :");
            Center.Print();
            Console.Write("Radius :" + Radius);
        }
        public Posittion GetPosittion(Point p)
        {
            double khoangCach = Center.KhoangCach(p);
            if (khoangCach > Radius)
            {
                return Posittion.OUT;
            }
            else if (khoangCach < Radius)
            {
                return Posittion.IN;
            }
            return Posittion.ON;
        }
    }
}
