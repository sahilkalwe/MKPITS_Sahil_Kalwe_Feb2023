using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_car_with_method_having_parameters
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
            carprice = p;
            carid = i;
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
            c1.getdata("lamborgini","top",45678910,45);
            c1.displaydata();
            Console.ReadKey();
        }
    }
}
