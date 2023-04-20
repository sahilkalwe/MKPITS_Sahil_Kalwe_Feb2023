using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_example_3
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
    class current:account
    {
        public override void deposit(int amt)
        {
            balance = balance+amt;
            Console.WriteLine("deposited amt without intrest " + balance);
                }
    }
    class program
    {
        static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("Enter amount");
            amount=Convert.ToInt32(Console.ReadLine());
            account act = null;
            string Acttype;
            Console.WriteLine("Enter account type saving  or current");
            Acttype = Console.ReadLine();
            if (Acttype=="saving")
            {
                act = new saving();
            }
            else if (Acttype=="current")
            {
                act=new current();  
            }
            act.deposit(amount);    
        }
    }
}
 