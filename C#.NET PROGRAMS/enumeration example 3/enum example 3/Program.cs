using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_example_3
{
    // enum declaration
    enum days
    {

        // enum data members
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }

    // enum declaration
    enum color
    {

        // enum data members
        Red,
        Yellow,
        Blue,

        // assigning value yellow(1) + 5
        Green = Yellow + 5,
        Brown,

        // assigning value Green(6) + 3
        Black = Green + 3

    }

    class Program
    {

        // Main Method
        static void Main(string[] args)
        {

            Console.WriteLine("Demonstrating the difference " +
            "between Special Initialisation" +
            "cases and non-initialisation cases\n\n");

            // first of all non-initialized enum
            // 'days' will be displayed
            // as mentioned already, the first
            // member is initialized to 0
            // hence the output will numbers
            // from 0 1 2 3 4 5 6

            Console.WriteLine("Value of Monday is " +
            (int)days.monday);
            Console.WriteLine("Value of Tuesday is " +
            (int)days.tuesday);
            Console.WriteLine("Value of Wednesday is " +
            (int)days.wednesday);
            Console.WriteLine("Value of Thursday is " +

            (int)days.thursday);
            Console.WriteLine("Value of Friday is " +
            (int)days.friday);
            Console.WriteLine("Value of Saturday is " +
            (int)days.saturday);
            Console.WriteLine("Value of Sunday is " +
            (int)days.sunday);

            // Now the use of special initialisation
            // cases is demonstrated as expected Red
            // will be assigned 0 value similarly
            // yellow will be 1 and blue will be 2
            // however, green will be assigned the
            // value 1+5=6 similarly is the case
            // with brown and black

            Console.WriteLine("\n\nColor Enum");

            Console.WriteLine("Value of Red Color is " +

            (int)color.Red);

            Console.WriteLine("Value of Yellow Color is " +

            (int)color.Yellow);
            Console.WriteLine("Value of Blue Color is " +

            (int)color.Blue);

            Console.WriteLine("Value of Green Color is " +

            (int)color.Green);

            Console.WriteLine("Value of Brown Color is " +

            (int)color.Brown);
            Console.WriteLine("Value of Black Color is " +

            (int)color.Black);

        }
    }
}
