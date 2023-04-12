using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_wap_to_accept_character_and_display_it_whether_it_is_vowel_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter Character");
            ch=Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Character is Vowel");
            }
            else
            {
                Console.WriteLine("Character is Not Vowel Or it is a Consonent");
            }
                Console.ReadKey();

        }
    }
}
