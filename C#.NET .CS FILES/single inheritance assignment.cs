using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_assignment
{
    public class Person
    {
        public String name;
        public String address;
    }
    public class employee : Person
    {
        public int empno;
        public int salary;
        public string designation;
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            employee p1 = new employee();//creating object of child class\
            p1.empno = 123;
            p1.name = "amitabh";
            p1.address = "mumbai";
            p1.salary = 88888;
            p1.designation = "manager";

            Console.WriteLine("rno: " + p1.empno);
            Console.WriteLine("name: " + p1.name);
            Console.WriteLine("address: " + p1.address);
            Console.WriteLine("salry: " + p1.salary);
            Console.WriteLine("Designation: " + p1.designation);

        }
    }
}
