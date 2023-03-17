using System;
namespace 4_square_of_number
{
    class Program
    {
        static void Main()
        {
        int num,square;
        Console.WriteLine("Enter any number");
        num=Convert.ToInt32(Console.ReadLine());
        square = num * num;
        Console.WriteLine("square is " + square);
        Console.ReadKey();
    }

    }
}
