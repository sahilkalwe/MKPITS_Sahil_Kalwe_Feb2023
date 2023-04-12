using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace create_class_order
{
    class order
    {
       public int oid;
       public int oqty;
        public string ocolor;
        public string oname;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            order o1=new order();
            o1.oid = 2;
            o1.oqty=500;
            o1.ocolor="red";
            o1.oname="nagpur";
            Console.WriteLine("order id is "+o1.oid);
            Console.WriteLine("order quantity is " + o1.oqty);
            Console.WriteLine("order color is " + o1.ocolor);
            Console.WriteLine("order name is " + o1.oname);
            Console.ReadKey();  
        }
    }
}
