using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_wap_to_print_nos_betwween_5_to_25_using_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=5;
            while(num <= 25)
            {
                Console.WriteLine(num);
                num++;
            }
            Console.ReadKey();
        }
    }
}
