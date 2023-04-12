using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_parameterised_constructor
{

    class student
    {
        int rno;
        string name;
        //creating a default constructor
        public student()
        {
            rno = 123;
            name = "shanaya";
        }
        //creating constructor with parameters
        public student(int rno, string name)
        {
            this.rno = rno;
            this.name = name;

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
            student stud1 = new student();// it will call constructor with no parameters

            stud1.displaydata();

            Console.WriteLine("Enter Rno");
            int rno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            student stud2 = new student(rno, name);//will call constructor with parameters
            stud2.displaydata();
            Console.ReadKey();
        }
    }
}
