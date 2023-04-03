using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int indexer=0;indexer<4;indexer++)
            {
                 for(int JapaneseCalendar=0;JapaneseCalendar<indexer-1;JapaneseCalendar++)
                {
                    Console.WriteLine("*");
                    Console.ReadKey();
                }
            }
        }
    }
}
