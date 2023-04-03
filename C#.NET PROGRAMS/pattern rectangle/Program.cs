using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Rows");
            int row=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Columns");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which Symbol");
            String Symbol = Console.ReadLine();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(Symbol);
                }
                Console.WriteLine();
        
            }
            Console.ReadKey();
        }
    }
}
