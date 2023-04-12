using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_product
{
    class product
    {
       public int proid;
        public string proname;
      public  int prorate;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            product p1 = new product();
            p1.proid = 12;
            p1.proname = "jay";
            p1.prorate = 1234;
            Console.WriteLine("Proid "+p1.proid);
            Console.WriteLine("Proname " + p1.proname);
            Console.WriteLine("Prorate " + p1.prorate);
            Console.ReadLine();
        }
    }
}
