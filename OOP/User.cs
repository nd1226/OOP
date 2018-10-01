using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public DateTime BirthDay { get; set; }
        public User() { }
        public User(int userID, string userName, DateTime birthDay)
        {
            UserID = userID;
            UserName = userName;
            BirthDay = birthDay;
        }

        public void InIt(int userID, string userName, DateTime birthDay)
        {
            UserID = userID;
            UserName = userName;
            BirthDay = birthDay;
        }
        public void Print()
        {
            Console.WriteLine("User ID:" + UserID);
            Console.WriteLine("UserName:" + UserName);
            Console.WriteLine("BirthDay :" + string.Format("{0:dd/MM/yyyy}", BirthDay));
            Console.WriteLine("Age:" + GetAge());
        }
        public int GetAge()
        {
            return DateTime.Now.Year - BirthDay.Year;
        }
        public void CompareAge(User user)
        {
            if (user.GetAge() > GetAge())
            {
                Console.WriteLine(user.UserName + " lon tuoi hon "  + UserName);
            }
            else if (user.GetAge() == GetAge())
            {
                Console.WriteLine(UserName + " bang tuoi " + user.UserName);
            }
            else
            {
                Console.WriteLine(UserName + " nho tuoi hon " + user.UserName);
            }
        }
    }
}
