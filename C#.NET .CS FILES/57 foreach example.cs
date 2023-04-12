using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_foreach_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] name = { "amit", "raj", "rani", "taj" };
            foreach(String val in name)
            {
                Console.WriteLine("name "+val);
                Console.ReadKey();
            }
        }
    }
}
