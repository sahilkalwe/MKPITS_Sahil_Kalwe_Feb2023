using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_customer_with_method_having_parameter
{
    class customer
    {
        public int custid;
        public string custname;
        public int custrollno;
        public int custsalary;

        public void getdata(int i,string n,int r,int s)
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
            c1.getdata(12,"akshay",33,56789);
            c1.displaydata();
            Console.ReadKey();
        }
    }
}

