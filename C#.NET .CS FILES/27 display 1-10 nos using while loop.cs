
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_display_1_10_nos_using_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while(n<=10)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.ReadKey();
        }
    }
}
