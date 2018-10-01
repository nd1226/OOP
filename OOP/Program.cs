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
            /// Point
            //Point p = new Point();
            //p.Input();
            //p.Print();
            //Point p2 = new Point();
            //p2.Input();
            //p2.Print();
            //double c = p.KhoangCach(p2);
            //Console.WriteLine("Khoang cach 2 diem la: " + c);

            ///Circle
            //Point p = new Point();
            //p.Input(1, 5);
            //Circle circle = new Circle(p,10);
            //Point p2 = new Point(5, 12);
            //Circle.Posittion position = circle.GetPosittion(p2);
            //Console.WriteLine(position);

            ///Tam Giac
            //Point p1 = new Point(1, 1);
            //Point p2 = new Point(2, 6);
            //Point p3 = new Point(-2, 4);
            //double AB = p1.KhoangCach(p2);
            //double AC = p1.KhoangCach(p3);
            //double BC = p2.KhoangCach(p3);
            //if(AB + AC > BC || AB+BC > AC || AC + BC > AB)
            //{
            //    Console.WriteLine("Khong phai tam giac");
            //}
            //else
            //{
            //    TamGiac tamGiac = new TamGiac(p1, p2, p3);
            //    Console.WriteLine("Dien tich cua tam giac la :" + tamGiac.DienTich());
            //    Console.WriteLine("Chu vi cua tam giac la :" + tamGiac.ChuVi());
            //}

            // User
            DateTime birth = new DateTime(1990, 01, 12);
            User user = new User(1, "Nhan", birth);
            user.Print();
            DateTime birth2 = new DateTime(1980, 01, 12);
            User user2 = new User(2, "Doan", birth2);
            user2.Print();
            user.CompareAge(user2);

            ///Book
            DateTime birthTacGia = new DateTime(1995, 01, 12);
            DateTime namXuatBan = new DateTime(2000, 01, 12);
            Book book = new Book(3, "Nhan ABC", birthTacGia, 2, "Sach A", namXuatBan);
            book.Print();


        }
    }
}
