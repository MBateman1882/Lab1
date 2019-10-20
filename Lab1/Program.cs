using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, area, perimeter, height, volume;
            string choice;

            Console.WriteLine("Welcome! Please enter all values as number of feet.");

            do
            {
                Console.WriteLine("Please enter the room's length.");
                length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the room's width.");
                width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the room's height.");
                height = double.Parse(Console.ReadLine());

                area = length * width;
                perimeter = 2 * length + 2 * width;
                volume = length * width * height;

                Console.WriteLine($"Length = {length} feet");
                Console.WriteLine($"Width = { width} feet");
                Console.WriteLine($"Height = {height} feet");
                Console.WriteLine($"Area = {area} square feet");
                Console.WriteLine($"Perimeter = {perimeter} feet");
                Console.WriteLine($"Volume = {volume} cubic feet");

                Console.WriteLine("Would you like to run this program again? (y/n)");
                choice = Console.ReadLine().ToLower();

                while (choice != "y" && choice != "n")
                {
                    Console.WriteLine("Invalid input");
                    choice = Console.ReadLine().ToLower();
                }
            } while (choice == "y");

            Console.WriteLine("Goodbye!");
            return;

        }
    }
}
