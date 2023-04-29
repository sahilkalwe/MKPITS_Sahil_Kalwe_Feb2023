using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_catch_block_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
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
            catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
        }
    }
}
