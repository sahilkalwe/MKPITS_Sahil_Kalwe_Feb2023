using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_accept_character_from_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter Character");
            ch=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Character Is " + ch);
            Console.ReadKey();
        }
    }
}
