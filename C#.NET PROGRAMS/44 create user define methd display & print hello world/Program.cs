using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_create_user_define_method_display
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling method display");
            display();
        
        }
        //creating user define  method display
        static void display()
        {
            Console.WriteLine("Hello world");
            Console.ReadKey();
        }
        
    }
}
