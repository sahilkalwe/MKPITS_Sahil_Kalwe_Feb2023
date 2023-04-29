using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_example_2
{
    class account
    {
        public int balance = 1000;
        public virtual void deposit(int amt)
        {
            Console.WriteLine("deposited method of account class");
        }
    }
    class saving : account
    {
        public int intrest = 500;
        public override void deposit(int amt)
        {
            balance = balance + amt + intrest;
            Console.WriteLine("deposited amount is " + balance); ;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            account act = new saving();
            act.deposit(200);

        }
    }
}
