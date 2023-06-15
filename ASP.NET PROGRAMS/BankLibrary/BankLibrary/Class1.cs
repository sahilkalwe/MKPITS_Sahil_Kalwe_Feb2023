using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLibrary;
namespace BankLibrary
{
    public class Class1
    {
        int bal = 1000;
     public   string deposit(int amount)
        {
            bal = bal + amount;
            return "balance is " + bal;
        }

       public  string withdrawl(int amount)
        {
            bal = bal - amount;
            return "balance is " + bal;
        }
    }
}
