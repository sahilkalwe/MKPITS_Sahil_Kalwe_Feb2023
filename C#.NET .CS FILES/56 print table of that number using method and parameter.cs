using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_print_table_of_that_number_using_method_and_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;

                Console.WriteLine("enter number");
                n1 = Convert.ToInt32(Console.ReadLine());
                square(n1);
                Console.ReadKey();
        }
            static void square(int num)
            {
                int i = 1;
            while (i <= 10)
               {
                int res = num * i;
                Console.WriteLine(res);
                i++;


                }

         }
    }
}
