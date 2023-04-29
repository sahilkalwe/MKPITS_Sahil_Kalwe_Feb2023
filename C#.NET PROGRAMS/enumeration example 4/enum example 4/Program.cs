using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_example_4
{
    // changing the type to byte using :
    enum Button : byte
    {

        // OFF denotes the Button is
        // switched Off... with value 0
        OFF,

        // ON denotes the Button is
        // switched on.. with value 1
        ON

    }

    class Program
    {

        // Main Method
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 0 or 1 to know the " +
            "state of electric switch!");

            byte i = Convert.ToByte(Console.ReadLine());

            if (i == (byte)Button.OFF)
            {

                Console.WriteLine("The electric switch is Off");
            }

            else if (i == (byte)Button.ON)
            {
                Console.WriteLine("The electric switch is ON");
            }

            else
            {
                Console.WriteLine("byte cannot hold such" +

                " large value");

            }
        }
    }


}

