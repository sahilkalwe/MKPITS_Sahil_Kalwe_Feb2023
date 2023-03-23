using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_wap_to_accept_empno__empname___designation___dispaly_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno;
            long bonus = 0;
            string empname, empdesignation;
            Console.WriteLine("Enter emp Number");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter emp Name");
            empname = Console.ReadLine();
            Console.WriteLine("Enter Emp designation  manager,clerk,peon");
            empdesignation =Console.ReadLine();

            if (empdesignation == "manager")
                bonus = 10000;
            else if (empdesignation == "clerk")
                bonus = 5000;
            else if (empdesignation == "peon")
                bonus = 2000;
            else
                Console.WriteLine("Invalid Designation");
            Console.WriteLine("Your Bonus Is  "+bonus);
            Console.ReadKey();

        }
    }
}
