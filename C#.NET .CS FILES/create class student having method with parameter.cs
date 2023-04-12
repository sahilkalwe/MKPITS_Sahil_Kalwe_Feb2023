using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_student_having_method_with_parameter
{
    class student
    {
       public int rno;
      public string name;
    
    public void getdata(int r,string n)
    {
        rno = r;
        name = n;
    }
    public void displaydata()
    {
        Console.WriteLine("Roll number is "+ rno);
        Console.WriteLine("Name is " + name);
    }

    }
     class Program
    {
        static void Main(string[] args)
        {
        student s1 = new student();
        s1.getdata(123,"amit");
        s1.displaydata();
        Console.ReadKey();    
        }
     }
}
