using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_wap_to_accept_no___print_table_of_that_number_using_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i = 1;
            int res = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                res = num * i;
                Console.WriteLine("{0} * {1} = {2}", num, i, res);
                i++;

            } while (i <= 10);
            Console.ReadKey();
        }
    }
}
