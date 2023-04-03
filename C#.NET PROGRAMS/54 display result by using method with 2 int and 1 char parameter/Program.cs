using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_display_result_by_using_method_with_2_int_and_1_char_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
        static void calculate()
        {
            int a,b;
            Console.WriteLine("Enter Num1");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num2");
            b = Convert.ToInt32(Console.ReadLine());
            add(a, b);
            sub(a, b);
            mul(a, b);
            div(a, b);
            Console.ReadKey();
        }
        static void add(int a,int b,char op)
        {
             op = a + b;
            Console.WriteLine("Addition is "+ op);
        }
        static void sub(int a, int b, char result)
        {
            op = a - b;
            Console.WriteLine("Substraction is " + op);
        }
        static void mul(int a, int b, char op)
        {
             op = a * b;
            Console.WriteLine("Multiplication is " + op);
        }
        static void div(int a, int b, char op)
        {
            op = a / b;
            Console.WriteLine("Division is " + op);
        }

    }
}
