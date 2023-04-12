using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_employee_having_method_with_paramters
{
    class employee
    {
        string empname;
        int empid;
        int empsalary;
        public void getdata(int i, string n, int s)
        {
            empname = n;
            empsalary = s;
            empid = i;
        }
        public void displaydata()
        {
            Console.WriteLine("EMP NAME "+empname);
            Console.WriteLine("emp id "+empid);
            Console.WriteLine("emp salary "+empsalary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e1= new employee();
            e1.getdata(1,"jay",23456);
            e1.displaydata();
            Console.ReadKey();
        }
    }
}
