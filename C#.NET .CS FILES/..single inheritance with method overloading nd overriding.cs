using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_with_method_overloading_nd_overriding
{
    class person
    {
      public  string name;
       public string address;
        public void getdata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaydata()
        {
            Console.WriteLine("name is " + name);
            Console.WriteLine("address is " + address);
        }
        class customer:person
        {
            public int custid;
            public void getdata(int custid, string name, string address)
            {
                this.custid = custid;
                getdata(name,address);
            }
            public void display()
            {
                base.displaydata();
                Console.WriteLine("custid is " + custid);
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                customer cm = new customer();
                cm.getdata(123,"jayesh","nagpur");
                cm.displaydata();
                Console.ReadLine();

            }
        }
    }
}
