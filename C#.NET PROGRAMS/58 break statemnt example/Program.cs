﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                if(i==5)
                {
                    break;
                }
                Console.WriteLine("Counter "+i);
                Console.ReadKey();
            }
        }
    }
}
