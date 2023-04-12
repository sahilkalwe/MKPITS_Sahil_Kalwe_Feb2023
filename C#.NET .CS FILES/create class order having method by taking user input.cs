using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace create_class_order_having_method_by_taking_user_input
{
    class order
    {
        public int oid;
        public int oqty;
        public string ocolor;
        public string oname;
        public void getdata(int i, int q, string c, string n)
        {
            oid = i;
            oqty = q;
            ocolor = c;
            oname = n;
        }
        public void displaydata()
        {
            Console.WriteLine("order id is " + oid);
            Console.WriteLine("order quantity is " + oqty);
            Console.WriteLine("order color is " + ocolor);
            Console.WriteLine("order name is " + oname);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            order o1 = new order();
            Console.WriteLine("Enter order id ");
            int oid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter order qty ");
           int  oqty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter order color ");
           string ocolor =Console.ReadLine();
            Console.WriteLine("Enter order name ");
           string oname =Console.ReadLine();
            o1.getdata(oid,oqty,ocolor,oname);
            o1.displaydata();
            Console.ReadKey();
        }
    }
}
