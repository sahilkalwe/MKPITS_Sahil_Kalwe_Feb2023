using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_product_having_method_with_parameters
{
    class product
    {
        int proid;
        int prorate;
        string proname;
        public void getdata(int i,int r,string n)
        {
            proid = i;
            prorate = r;
            proname = n;


        }
        public void displaydata()
        {
            Console.WriteLine("proid is " + proid);
            Console.WriteLine("prorate is " + prorate);
            Console.WriteLine("proname is " + proname);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product p1= new product();
            p1.getdata(11,19876,"jay");
            p1.displaydata();
            Console.ReadKey();
        }
    }
}
