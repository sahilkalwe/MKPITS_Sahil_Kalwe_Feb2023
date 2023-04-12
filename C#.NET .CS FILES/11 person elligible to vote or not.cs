using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_person_elligible_to_vote_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program to accept a age from the user and print whether eligible to vote or not
            int age;
            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your age is " + age);
            if (age < 18)
            {
                Console.WriteLine("You are not elligible to vote");

            }
            else
                Console.WriteLine("You are elligible to vote");

            Console.ReadKey();

        }
    }
}
