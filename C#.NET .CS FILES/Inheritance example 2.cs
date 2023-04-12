using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_of_single_inheritance_2
{
    class khansir
    {
        public int age;
        public string caste;
    }
    class students:khansir
    {
       public int count;
       public string batch;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            students s1=new students();
            s1.age = 48;
            s1.caste = "muslim ";
            s1.count = 13;
            s1.batch = "dotnet";
            Console.WriteLine("age is "+s1.age);
            Console.WriteLine("caste is " + s1.caste);
            Console.WriteLine("count is " + s1.count);
            Console.WriteLine("batch is " + s1.batch);
            Console.ReadKey();
        }
    }
}
