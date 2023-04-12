using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wap_to_print_repeating_characters_of_a_given_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int maxCHARS = 256;
        
            String s = "Welcometomywebsite!";

            int[] cal = new int[maxCHARS];
             calculate(s, cal);

            for (int i = 0; i < maxCHARS; i++)
                if (cal[i] > 1)
                {
                    Console.WriteLine("Character " + (char)i);
                    Console.WriteLine("Occurrence = " + cal[i] + " times");
                }
        }
    }
}
