using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_wap_to_accept_ch_from_the_user_and_display_wethr_vowel_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter Character");
            ch=Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("Character is Vowel");
                    break;
                default:
                    Console.WriteLine("Character is Not A vowel/ or it is a consonent");
                    break;
            }
            Console.ReadKey();

        }
    }
}
