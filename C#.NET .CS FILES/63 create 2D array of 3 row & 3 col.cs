﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_create_2D_array_of_3_row___3_col
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[ , ] arr = new int[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {

                    Console.WriteLine("enter numbers");
                    arr[row,col] = Convert.ToInt32(Console.ReadLine());
                }
            }
                //display values
                for (int row = 0; row < 3; row++)
                {
                    for (int  col = 0; col < 3; col++)
                    {
                        Console.Write(arr[row,col] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
        

        }
    }
    
}
