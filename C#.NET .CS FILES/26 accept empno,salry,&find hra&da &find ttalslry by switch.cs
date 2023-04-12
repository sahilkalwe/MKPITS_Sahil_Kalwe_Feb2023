using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_accept_empno_salary_and_calculate_hra__da_and_display_total_salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno, salary;
            Console.WriteLine("enter empno");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter salary");
            salary = Convert.ToInt32(Console.ReadLine());
            float hra = 0;
            float da = 0;
            switch (salary)
            {
                case 25000:
                    hra = salary * 0.32f;
                    da = salary * 0.45f;
                    break;
                case 50000:
                    hra = salary * 0.22f;
                    da = salary * 0.55f;
                    break;
            }
            float total = salary + hra + da;
            Console.WriteLine("empno " + empno);
            Console.WriteLine("hra " + hra);
            Console.WriteLine("da " + da);
            Console.WriteLine("total salary " + total);
            Console.ReadKey();

        }
    }
}
