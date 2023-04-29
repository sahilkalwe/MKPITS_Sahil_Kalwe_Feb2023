using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finally_example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 10;
                int b = 2;
                int res;
                try
                {
                    res = a / b;
                    Console.WriteLine("result= " + res);
                }
                catch (DivideByZeroException ee)
                {
                    Console.WriteLine(ee.ToString());
                }
                finally
                {
                    Console.WriteLine("Finally Executed");
                }
                Console.WriteLine("bye");
            }
        }
    }
}
