using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate();
        }
            static void Calculate()
            {
                int num1, num2, result;
                Console.WriteLine("Enter number 1");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter num 2");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Calling addition method");
               Addition(num1, num2);
                Console.WriteLine("Calling Substraction method");
                Substraction(num1, num2);
                Console.ReadKey();

            }

            static void Addition(int n1, int n2)
            {
                int result = n1 + n2;
               Console.WriteLine("Addition is "+ result);
            }
            static void Substraction(int n1, int n2)
            {
                int result = n1 - n2;
                Console.WriteLine("Substraction is " +result);

            }
    }

}
