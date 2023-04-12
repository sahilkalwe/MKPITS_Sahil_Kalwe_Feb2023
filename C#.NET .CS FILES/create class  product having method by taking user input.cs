using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace create_class__product_having_method_by_taking_user_input
{
        class product
        {
            int proid;
            int prorate;
            string proname;
            public void getdata(int i, int r, string n)
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
                product p1 = new product();
            Console.WriteLine("Enter Product Id");
            int proid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Rate");
            int prorate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            string proname =Console.ReadLine();
            p1.getdata(proid, prorate, proname);
            p1.displaydata();
                Console.ReadKey();
            }
        }
    }
