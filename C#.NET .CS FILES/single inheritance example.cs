using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_example
{
    class gatisir
    {
        public string designation= "Solution Architect";

    }
    class khansir:gatisir
    {
       public float salary=750000;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            khansir k1= new khansir();
            Console.WriteLine("designation is "+k1.designation);
            Console.WriteLine("salary is " + k1.salary);
            Console.ReadKey();
        }
    }
}
