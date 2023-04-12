using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_customer_with_method
{
    class customer
    {
        public int custid;
        public string custname;
        public int custrollno;
        public int custsalary;

        public void getdata()
        {
            custid = 1;
            custname = "sahil";
            custrollno = 13;
            custsalary = 56789;
        }
        public void displaydata()
        {
            Console.WriteLine("customer id is " + custid);
            Console.WriteLine("customer name is " + custname);
            Console.WriteLine("customer rollno is " + custrollno);
            Console.WriteLine("customer salary is " + custsalary);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer c1 = new customer();
            c1.getdata();
            c1.displaydata();
            Console.ReadKey();
        }
    }
}
