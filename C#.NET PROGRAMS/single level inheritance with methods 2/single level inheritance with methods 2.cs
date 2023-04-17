using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_level_inheritance_with_methods_2
{
    public class Person
    {
        String name;
        String address;
        public void getPersonData(String name, String address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address : " + address);

        }
    }
    public class Student : Person
    {
        int rno;
        int marks;
        public void getStudentData(int rno, int marks)
        {
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            Console.WriteLine("rno : " + rno);
            Console.WriteLine("marks : " + marks);

        }
    }

    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Student p1 = new Student();//creating object of child class\
            p1.getPersonData("arifa", "nagpur");
            p1.getStudentData(11, 99);
            p1.displayStudentData();
            p1.displayPersonData();

        }
    }
}
