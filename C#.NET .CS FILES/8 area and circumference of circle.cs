using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_area_and_circumference_of_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            Console.WriteLine("Enter Radius");
            radius = Convert.ToInt32(Console.ReadLine());
            float area = 3.14f * radius * radius;
            Console.WriteLine("Area is " + area);
            float cir = 2 * 3.14 * radius;


        }

    }
}
