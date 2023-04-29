namespace abstract_method__and_abstract_class
{
    abstract class account
    {
        public int balance = 1000;
        public abstract void deposit(int amt);
        public string showbalance ()
        {
            return "bal is" + balance;
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
    class current : account
    {
        public override void deposit(int amt)
        {
            balance = balance + amt;
            Console.WriteLine("deposited amt without intrest " + balance);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("Enter amount");
            amount = Convert.ToInt32(Console.ReadLine());
            account act = null;
            string Acttype;
            Console.WriteLine("Enter account type saving  or current");
            Acttype = Console.ReadLine();
            if (Acttype == "saving")
            {
                act = new saving();
            }
            else if (Acttype == "current")
            {
                act = new current();
            }

            act.deposit(amount);
            string res = act.showbalance();
            Console.WriteLine(res);
        }
    }
}