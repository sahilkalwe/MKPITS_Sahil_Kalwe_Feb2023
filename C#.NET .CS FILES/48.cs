using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,result;
            Console.WriteLine("Enter number 1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num 2");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calling addition method");
            result=Addition(num1,num2);
            Console.WriteLine("Additin is " + result);
            Console.WriteLine("Calling Substraction method");
            result = Substraction(num1, num2);
            Console.WriteLine("Substraction is "+result);
            Console.ReadKey();

        }

        static int Addition(int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }
        static int Substraction(int n1,int n2)
        {
            int result = n1 - n2;
            return result;
        }
    }
}
