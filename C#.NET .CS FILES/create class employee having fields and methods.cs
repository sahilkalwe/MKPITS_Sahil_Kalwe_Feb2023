using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_employee_having_fields_and_methods
{
    class employee
    {
        int empno;
        int empsalary;
        string empname;
        public void getdata()
        {
            empno = 12;
            empsalary = 23456;
            empname = "david";
        }
        public void displaydata()
        {
            Console.WriteLine("empno "+empno);
            Console.WriteLine("empsalary " + empsalary);
            Console.WriteLine("empnname " + empname);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e1= new employee();
            e1.getdata();
            e1.displaydata();
            Console.ReadKey();
        }
    }
}
