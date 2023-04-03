using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_wap_to_create_method_calculatesquare_by_returning_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling method here");
            int Result = CalculateSquare();
            Console.WriteLine("Square is "+Result);
            Console.ReadKey();


        }
        static int CalculateSquare()
        {
            int num;
            Console.WriteLine("Enter any Number");
            num = Convert.ToInt32(Console.ReadLine());
            int Square = num * num;
            return Square;
         
        }
        
    }
}
