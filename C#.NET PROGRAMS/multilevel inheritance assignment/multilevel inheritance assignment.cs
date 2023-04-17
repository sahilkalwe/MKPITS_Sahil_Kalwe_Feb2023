using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance_assignment
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
    public class student : Person
    {
        int stdno;
        String collegename;

        public void getstudentData(int stdno, String collegename)
        {
            // getPersonData("arifa", "nagpur"); //calling base class method from derieved class
            this.stdno = stdno;
            this.collegename = collegename;
        }
        public void displaystudentData()
        {
            // displayPersonData(); //calling base class method from derieved class
            Console.WriteLine("student number : " + stdno);
            Console.WriteLine("college name is : " + collegename);

        }
    }

    public class child : student
    {
        int age;
        public void getchild(int age)
        {
            // getPersonData("arifa", "nagpur"); //calling base class method from derieved class
            this.age =age;

        }
        public void displaychild()
        {
            // displayPersonData(); //calling base class method from derieved class
            Console.WriteLine("child age is : " + age);

        }
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            child p1 = new child();//creating object of child class\

            p1.getPersonData("arifa", "nagpur");
            p1.getstudentData(11, "fergussion");
            p1.getchild(2);
            p1.displayPersonData();
            p1.displaystudentData();
            p1.displaychild();

        }
    }
}
