using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_class_creation
{ class student
    {
        public int rno;
        public string name;
    }
 

     class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.rno = 123;
            s1.name = "amit";
            Console.WriteLine("Roll no is " + s1.rno);
            Console.WriteLine("Name is  " + s1.name);
        Console.ReadKey();


        }
    }
}
