using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_class_creation
{ 
    class employee
    {
        public int empid;
        public string empname;
         public int empsalary;
    }
     class Program
    {
        static void Main(string[] args)
        {
            employee e1= new employee();
            e1.empid = 12;
            e1.empname= "Tushar";
            e1.empsalary = 26578;
            Console.WriteLine("Empid "+ e1.empid);
            Console.WriteLine("name "+ e1.empname);
            Console.WriteLine("salary"+e1.empsalary);
            Console.ReadKey();
        }
    }
}
