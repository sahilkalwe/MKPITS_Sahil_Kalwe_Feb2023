using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_student_info
{
    class Program
    {
        static void Main()
        {

            Double mno;
            int rno,age;
            string name, course;
            Console.WriteLine("Enter Roll number");
            rno = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Your Name");
            name = Console.ReadLine();
           
            Console.WriteLine("Enter your course");
            course= Console.ReadLine();
            
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter your mobile number");
            mno = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your Roll number is " + rno);
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your course is " + course);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your Mobile  number is " + mno);

            Console.ReadKey();
        }
    }
}
