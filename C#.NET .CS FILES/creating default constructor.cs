using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_default_constructor
{
    class student
    {
        int rno;
        string name;
        //creating a constructor
        public student()
        {
            rno = 12;
            name = "pranita";
        }
        public void displaydata()
        {

            Console.WriteLine("rno " + rno);
            Console.WriteLine("name " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            student stud1 = new student();// it will call constructor

            stud1.displaydata();
            Console.ReadKey();
        }
    }
}
