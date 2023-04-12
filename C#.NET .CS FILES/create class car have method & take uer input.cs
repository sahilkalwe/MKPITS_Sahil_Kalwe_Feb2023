using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_car_have_method___take_uer_input
{
    class car
    {
        public string carname;
        public string carmodel;
        public int carid;
        public int carprice;
        public void getdata(string n,string m,int i,int p)
        {
            carname = n;
            carmodel = m;
            carprice = i;
            carid = p;
        }
        public void displaydata()
        {
            Console.WriteLine("car name is " + carname);
            Console.WriteLine("car model is " + carmodel);
            Console.WriteLine("car price is " + carprice);
            Console.WriteLine("car id is " + carid);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car c1 = new car();
            Console.WriteLine("enter car name");
            string carname=Console.ReadLine();
            Console.WriteLine("enter car model");
            string carmodel = Console.ReadLine();
            Console.WriteLine("enter car price");
            int carprice =Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("enter car id");
            int carid = Convert.ToInt32(Console.ReadLine());
            c1.getdata(carname,carmodel,carprice,carid);
            c1.displaydata();

            Console.ReadKey();
        }
    }
}
