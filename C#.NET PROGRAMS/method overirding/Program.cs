using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace method_overirding
{
    class account
    {
        public int balance=1000;
            public void deposit (int amt)
        {
            Console.WriteLine("deposited method of account class");
        }
        }
   class saving:account
    {
        public int intrest = 500;
        public void deposit(int amt)
        {
            balance = balance + amt + intrest;
            Console.WriteLine("deposited amount is " + balance); ;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
      
           saving s=new saving();
           s.deposit(200);
        } 
    }
}
