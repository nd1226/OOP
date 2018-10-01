using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Book
    {
        public int IDSach { get; set; }
        public string TenSach { get; set; }
        public DateTime NamXuatBan { get; set; }
        public User TacGia { get; set; }
        public Book() { }

        public Book(User user,int iDSach, string tenSach, DateTime namXuatBan)
        {
            TacGia = user;
            IDSach = iDSach;
            TenSach = tenSach;
            NamXuatBan = namXuatBan;
        }

        public Book(int idUser,string userName,DateTime birthDay, int iDSach, string tenSach, DateTime namXuatBan)
        {
            TacGia = new User(idUser, userName, birthDay);
            IDSach = iDSach;
            TenSach = tenSach;
            NamXuatBan = namXuatBan;
        }

        //public void InItBook(int idUser, string userName, DateTime birthDay, int iDSach, string tenSach, DateTime namXuatBan)
        //{
        //    TacGia = new User(idUser, userName, birthDay);
        //    IDSach = iDSach;
        //    TenSach = tenSach;
        //    NamXuatBan = namXuatBan;
        //}

        public void Print()
        {
            Console.WriteLine("Thon Tin Tac Gia :");
            TacGia.Print();
            Console.WriteLine("Thong Tin Sach :");
            Console.WriteLine("IDSach:" + IDSach);
            Console.WriteLine("Ten Sach:" + TenSach);
            Console.WriteLine("Nam Xuat Ban:" + NamXuatBan);
        }
        }
    }
}
