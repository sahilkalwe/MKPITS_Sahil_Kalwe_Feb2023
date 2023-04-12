using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_customer_have_method_by_take_user_input
{
    class customer
    {
        public int custid;
        public string custname;
        public int custrollno;
        public int custsalary;

        public void getdata(int i, string n, int r, int s)
        {
            custid = i;
            custname = n;
            custrollno = r;
            custsalary = s;
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
            Console.WriteLine("Enter customer id");
            int custid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer name");
            string custname = Console.ReadLine();
            Console.WriteLine("Enter customer roll number");
            int custrollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer salary");
            int custsalary = Convert.ToInt32(Console.ReadLine());
            c1.getdata(custid, custname, custrollno, custsalary);
            c1.displaydata();
            Console.ReadKey();
        }
    }
}