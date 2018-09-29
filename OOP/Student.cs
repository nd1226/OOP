using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Student
    {
        //State (1) + (2)

        // field - data (1)
        private int studentID;
        public string StudentName { get; private set; }

        //property (2)
        public int StudentID
        {
            get => studentID;
            set => studentID = value;
        }

        public Student(int id)
        {
            StudentID = id;
        }
        //Constructor
        public Student() { }

        public Student(int id, string name) : this(id)
        {
            StudentName = name;
        }
        //Behavior
        public void Print()
        {
            Console.WriteLine("ID: " + studentID);
            Console.WriteLine("Name: " + StudentName);
        }
        
    }
}
