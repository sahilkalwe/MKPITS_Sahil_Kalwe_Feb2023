using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_wap_to_accept_empname_and_designation__using_switch_display_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string empname,designation;
            int bonus = 0;
            Console.WriteLine("Enter employee name");
            empname= Console.ReadLine();
            Console.WriteLine("Enter Employee designation");
            designation= Console.ReadLine();
            switch (designation)
            {

                case "Manager":
                    bonus = 10000;
                    break;
                case "Clerk":
                    bonus = 5000;
                    break;
                case "Peon":
                    bonus = 2000;
                    break;
                default:
                    Console.WriteLine("Invalid Designation");
                    break;
            }
            Console.WriteLine("empname  ={0} , bonus = {1} ", empname, bonus);
            Console.ReadKey();

        }
    }
}
