using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wap_to_accept_productname__rate__qty_calculate_totalamt___discount
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pname;
            int rate, qty, total;
            int discount = 0;
            Console.WriteLine("Enter Product Name");
            pname = Console.ReadLine();
            Console.WriteLine("Enter Rate");
            rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Quantity");
            qty = Convert.ToInt32(Console.ReadLine());
            total = rate * qty;
            Console.WriteLine("Total Amount is " + total);

            if (total >2000)
                discount = (50 * total) / 100;
            else if (total<=2000)
                discount = (10 * total) / 100;
            else
                Console.WriteLine("No Dioscount");
            Console.WriteLine("DISCOUNT IS " + discount);
            Console.ReadKey();
        }
    }
}
