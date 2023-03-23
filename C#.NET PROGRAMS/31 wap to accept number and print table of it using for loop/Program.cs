using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_wap_to_accept_number_and_print_table_of_it
{
    internal class Program
    {
        static void Main(string[] args)
        {
        0    int num;
            int res = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                res = num * i;
                Console.WriteLine("{0} * {1} = {2}", num, i, res);

            }
            Console.ReadKey();
        }
        }
}
