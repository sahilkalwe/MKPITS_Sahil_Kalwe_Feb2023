using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_area_of_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int area, l,b;
            Console.WriteLine("Enter length");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            b = Convert.ToInt32(Console.ReadLine());
            area = l* b;
            Console.WriteLine("Area  is " + area);
            Console.ReadKey();
        }
    }
}
