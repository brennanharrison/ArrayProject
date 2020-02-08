// Programmer: Brennan Harrison
// Date: 02/04/2020
// Project: Class Project Deliverable 3- Arrays.

using System;

namespace ArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a message to the console.
            Console.WriteLine("This program will iterate through a loop!");

            // Integer arrary.
            int[] arrayName = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            // Iterate through each element in the array.
            foreach (int i in arrayName)
            {
                // Write a message to the console.
                Console.WriteLine("Element value = " + i);
            }
        }
    }
}
