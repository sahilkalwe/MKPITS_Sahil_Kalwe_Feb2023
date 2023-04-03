using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n1;
            Console.WriteLine("enter number");
            n1 = Convert.ToInt32(Console.ReadLine());
            int res=factorial(n1);
            Console.WriteLine("fact = " +  res);
            Console.ReadKey();

        }
        static int factorial(int num)
        {
            int fact = 1;
            do
            {
                fact = fact * num;
                num = num - 1;
            } while (num > 0);
            return fact;


        }
        
    }
}
