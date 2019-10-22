using System;

namespace Rectangle
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter the length of the rectangle: ");

            int rectangleLength = int.Parse(Console.ReadLine());
            // Get input from the user and save it to a variable.

            Console.Write("Enter the width of the rectangle: ");
            int rectangleWidth = int.Parse(Console.ReadLine());

            int rectangleArea = rectangleLength * rectangleWidth;
            // Get input from the user and save it to a second variable.

            // Output - The area of the rectangle is (computed value)
            Console.WriteLine(rectangleArea);
           
        }

    }
}
