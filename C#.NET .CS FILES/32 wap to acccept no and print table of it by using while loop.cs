using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_wap_to_acccept_no_and_print_table_of_it_by_using_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
                int i=1;
            int res = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            while (i <= 10)
            {
                res = num * i;
                Console.WriteLine("{0} * {1} = {2}", num, i, res);
                i++;

            }
            Console.ReadKey();
        }
    }
}
