using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_wap_to_dispaly_1_10_nos_using_do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            do
            {
                Console.WriteLine(n);
                n++;
            } while (n <= 10);
            Console.ReadKey();
        }
    }
}
