using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace single_inheritance_example_2
{
    class car
    {
        public string name;

    }
    class model : car
    {
        public int quantity;
        public void getdata(string name,int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }
        public void displaydata()
        {
            Console.WriteLine("Name is "+ name);
            Console.WriteLine("quantity is " + quantity);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            model m1= new model();
            m1.getdata("hyundai",16);
            m1.displaydata();
            Console.ReadKey();

        }
    }
}
