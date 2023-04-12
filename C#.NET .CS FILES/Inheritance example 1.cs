using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_example_1
{   class grandfather
    {
       public int age;

    }
    class father:grandfather
    {
        public string name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           father g1=new father();
            g1.name = "kavya";
            g1.age = 18;
            Console.WriteLine("name is "+g1.name);
            Console.WriteLine("age is "+g1.age);
            Console.ReadKey();

        }
    }
}
