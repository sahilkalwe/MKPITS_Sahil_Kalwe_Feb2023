using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64
{
    internal class Program
    {
        static int gnum = 20;
        static void display()
        {
            int num = 5;
            Console.WriteLine("num inside method " + num);
            Console.WriteLine("num inside method " + gnum);
        }
        static void Main(string[] args)
        {
            display();
            // Console.WriteLine("num = " + num); error since num is local variable
            Console.WriteLine("num inside main" + gnum);
            Console.ReadKey();
        }
    }
}
