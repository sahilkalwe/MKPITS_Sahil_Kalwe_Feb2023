﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_block_examplee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            int res;
            try
            {
                res = a / b;
                Console.WriteLine("result= " + res);
            }
            catch (DivideByZeroException  ex) 
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}