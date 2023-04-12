using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_3_subject_marks_and_print_total_percentage_and_grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  s1,s2,s3,total;
            float per;
            string grade = "";
            Console.WriteLine("Enter Subject 1 marks");
            s1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Subject 2 marks");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Subject 3 marks");
            s3 = Convert.ToInt32(Console.ReadLine());
            total = s1 + s2 + s3;
            Console.WriteLine("Total is "+total);
            per = total / (300f) * 100f;
            Console.WriteLine("percentage is "+per);
            if (per > 75)
            {
                grade = "Distinction";
            }
            else if (per > 60 && per < 75)
            {
                grade = "First Grade";
            }
            else
                grade = "fail";
            Console.WriteLine("Grade Is " + grade);
            Console.ReadKey();


        }
    }
}
