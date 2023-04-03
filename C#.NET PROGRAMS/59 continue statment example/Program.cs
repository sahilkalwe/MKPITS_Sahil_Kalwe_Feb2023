using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_continue_statment_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine("Counter " + i);
                Console.ReadKey();
            }
        }
    }
}
