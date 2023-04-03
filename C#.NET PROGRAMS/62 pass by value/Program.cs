using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_pass_by_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine("value of num inside main before passing " + num);
            Display(num);
            Console.WriteLine("value of num after calling in main " + num);
            Display(num);
            Console.ReadKey();
        }
        static void Display(int num) 
        {
            num = num + 2;
            Console.WriteLine("Value of num inside display "+num);
           
        }
    }
}
