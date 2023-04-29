using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_interface_example
{
    interface interface1
        {
        void method1();
        }
    class baseclass
    {
        public void basemethod()
        {
            Console.WriteLine("hello from base method");
        }
    }
    class class1:baseclass,interface1
    {
        public void method1()
        {
            Console.WriteLine("hello from method 1");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            class1 a1=new class1();
            a1.method1();
            a1.basemethod();

        }
    }
}
