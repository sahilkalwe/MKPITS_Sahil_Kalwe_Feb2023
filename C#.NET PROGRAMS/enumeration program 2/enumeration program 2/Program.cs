using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace enumeration_program_2
{
    class Perimeter
    {
        public enum shapes
        {
            circle, square
        }
        public void peri(int val, shapes s1)
        {
            if (s1 == 0)
            {
                //output thecircumference 
                Console.WriteLine("Circumference of the circle is" + 2 * 3.14 *val);
            }
            else
            {

                //output the perimeter
                Console.WriteLine("perimeter of the square is" + 4 * val);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Perimeter p1=new Perimeter();
            p1.peri(3, Perimeter.shapes.circle);
            p1.peri(4, Perimeter.shapes.square);
            
        }
    }
}
