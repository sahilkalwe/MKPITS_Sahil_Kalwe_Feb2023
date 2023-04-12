using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_employee_with_method___take_user_input
{
    class employee
    {
        int empid;
        string empname;
        int empsalary;
        public void getdata(int i,string n,int s)
        {
            empid =i;
            empsalary=s;
            empname = n;
        }
        public void displaydata()
        {
            Console.WriteLine("empid " + empid);
            Console.WriteLine("empname " + empname);
            Console.WriteLine("empsalary " + empsalary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
            employee e1=new employee();
            Console.WriteLine("enter empid");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter empname");
            string empname = Console.ReadLine();
            Console.WriteLine("enter empsalary");
            int empsalary = Convert.ToInt32(Console.ReadLine());
            e1.getdata(empid,empname,empsalary);
            e1.displaydata();
            Console.ReadKey();
        }
    }
}
