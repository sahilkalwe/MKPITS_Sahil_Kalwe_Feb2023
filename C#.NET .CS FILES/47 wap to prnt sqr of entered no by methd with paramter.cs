using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_wap_to_prnt_sqr_of_entered_no_by_methd_with_paramter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int result = calculate(n1);
            Console.WriteLine("Square "+result);
            Console.ReadKey();

        }
        static int calculate(int num)
        { 
            int square = num *num;
        return square;

        }
    }
}
