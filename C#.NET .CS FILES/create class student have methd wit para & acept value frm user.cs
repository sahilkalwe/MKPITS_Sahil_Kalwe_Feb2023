using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_student_have_methd_wit_para___acept_value_frm_user
{
    class student
    {
        public int rno;
         public string name;
        public void getdata(int r,string n)
        {
            rno = r;
            name= n;
        }
        public void displaydata()
        {
            Console.WriteLine("ROLL NO "+rno);
            Console.WriteLine("name " + name);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            Console.WriteLine("Enter Roll no");
            int  rno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            s1.getdata(rno,name);
            s1.displaydata();
            Console.ReadKey();

        }
    }
}
