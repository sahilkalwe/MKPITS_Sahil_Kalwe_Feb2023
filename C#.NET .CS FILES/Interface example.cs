using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interface_example
{
    interface interface1
        {
        void method1();
        }
    class class1 : interface1
    {
    public void method1()
    {
        Console.WriteLine("hello from method 1");
    }
    }
class program1
    {
    static void Main(String[] args)
        {  
            interface1 a1 = new class1();
           a1.method1();
         }
    }

}
 

