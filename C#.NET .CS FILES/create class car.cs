using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_car
{ 
    class car
    {
       public string carname;
       public string carmodel;
       public int carid;
        public int carprice;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car c1 = new car();
            c1.carname = "ferrari";
            c1.carmodel = "xzv";
            c1.carprice = 1000000;
            c1.carid = 12;
            Console.WriteLine("car name is " + c1.carname);
            Console.WriteLine("car model is " + c1.carmodel);
            Console.WriteLine("car price is " + c1.carprice);
            Console.WriteLine("car id is " + c1.carid);
            Console.ReadKey();
        }
    }
}
