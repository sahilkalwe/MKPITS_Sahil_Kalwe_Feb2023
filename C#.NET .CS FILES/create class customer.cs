using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_customer
{
    class customer
    {
        public int custid;
        public string custname;
        public int custrollno;
        public int custsalary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer c1=new customer();
            c1.custid = 1;
            c1.custname = "sahil";
            c1.custrollno = 14;
            c1.custsalary = 56789;
            Console.WriteLine("customer id is " + c1.custid);
            Console.WriteLine("customer name is " + c1.custname);
            Console.WriteLine("customer rollno is " + c1.custrollno);
            Console.WriteLine("customer salary is " + c1.custsalary);
            Console.ReadKey();

        }
    }
}
