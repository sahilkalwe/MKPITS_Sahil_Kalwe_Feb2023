using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17__wap_to_accept_empno__empname___basicsalary___calculate_da___hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            int empno,hra,da,total;
            string empname;
            int empsalary;
            Console.WriteLine("Enter emp Number");
            empno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter emp Name");
            empname=Console.ReadLine();
            Console.WriteLine("Enter Emp salary");
            empsalary=Convert.ToInt32(Console.ReadLine());
            hra = (32 * empsalary) /100;
            da = (45 * empsalary) /100;
            total = empsalary + hra + da;

            Console.WriteLine("employee no is " + empno);
            Console.WriteLine("employee name is " + empname);
            Console.WriteLine("employee salary is " + empsalary);
            Console.WriteLine("employee hra is " + hra);
            Console.WriteLine("employee da is " + da);
            Console.WriteLine("employee  total salary is " + total);
            Console.ReadKey();
        }
    }
}
