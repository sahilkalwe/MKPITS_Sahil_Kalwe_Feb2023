using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_with_inheritance_example
{
    interface interface1
    {
        void method1();
      
    }
    interface interface2 
    {
        void method2(); 
    }  
    class class1:interface2
    {
       public void method1()
        {
            Console.WriteLine("hello from method 1");

        }
        public void method2() 
        {
            Console.WriteLine("hello from method 2");
        }
    }

    class program
    {
        static void Main(String[]args)
        {
            class1 a1= new class1();
            a1.method1();
            a1.method2();
        }
    }
}
