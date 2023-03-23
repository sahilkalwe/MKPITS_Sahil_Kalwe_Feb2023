using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19__wap_to_accept_productname_rate_qty___dispaly_tax_and_totalamt
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string pname;
                int rate,qty,total;
            int tax = 0;
            Console.WriteLine("Enter Product Name");
            pname = Console.ReadLine();
            Console.WriteLine("Enter Rate");
            rate=Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("Enter Quantity");
            qty=Convert.ToInt32(Console.ReadLine());
            total = rate * qty;
            Console.WriteLine("Total Amount is " + total);
            if (total >= 10000)
                tax = (18 * total) / 100;
            else if (total >= 5000 && total < 1000)
                tax = (12 * total) / 100;
            else if (total < 5000)
                tax = (5 * total) / 100;
            else
                Console.WriteLine("Invalid Amount");
            Console.WriteLine("tax is "+ tax);
            Console.ReadKey();

        }
    }
}
