using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_product_having_method
{
    class product
    {
        string proname;
        int proid;
        int prorate;
        public void getdata()
        {
            proname = "jay";
            prorate = 45678;
            proid= 10;
        }
        public void displaydata()
        {
            Console.WriteLine("proid "+proid);
            Console.WriteLine("proname " + proname);
            Console.WriteLine("prorate " + prorate);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            product p1 = new product();
            p1.getdata();
            p1.displaydata();
            Console.ReadKey();
        }
    }
}
