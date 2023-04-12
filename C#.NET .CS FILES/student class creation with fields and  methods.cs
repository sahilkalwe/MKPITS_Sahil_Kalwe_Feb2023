using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace student_class_creation_with_fields_and__methods
{
    class student
    {
       public int rno;
       public string name;
        //creating member function
        public void getdata()
        {
            rno=143;
           name="amit";

         }
     
       public void displaydata()
        {
        Console.WriteLine("roll no is "+rno);
        Console.WriteLine("Name is "+name);

        }
    }
    class Program
       {
    static void Main(string[] args)
    {
        student s1 = new student();
        s1.getdata();
        s1.displaydata();
            Console.ReadLine();

    }


}

}

