using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration_program
{//making enumerator month
    enum month
    {
        jan, feb, march, april, may
    }
    class Program
    {
        static void Main(string[] args)
        {
            //getting integer value to data members
            Console.WriteLine("the value of jan in month " + "enum is " + (int)month.jan);
            Console.WriteLine("the value of feb in month " + "enum is " + (int)month.feb);
            Console.WriteLine("the value of march in month " + "enum is " + (int)month.march);
            Console.WriteLine("the value of april in month " + "enum is " + (int)month.april);
            Console.WriteLine("the value of may in month " + "enum is " + (int)month.may);
        }
    }
}
