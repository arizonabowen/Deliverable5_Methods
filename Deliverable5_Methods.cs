/*
 Author: Jacquelyn Bowen
 Date: 02/16/2023
 Description: C# console application for testing methods
*/

using System;

namespace RandomArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = GetUserInput();
            int[] randomArray = RandomArrayPopulated(userInput);
            ReturnArray(randomArray);
            int arraySum = SumArray(randomArray);
            Console.WriteLine("The sum is: " + arraySum);
            Console.ReadKey();
        }

        static int GetUserInput()
        {
            int input = 0;
            bool validInput = false;

            while (!validInput)
            {
                try
                {
                    Console.Write("Please enter a number between 5 and 15: ");
                    input = int.Parse(Console.ReadLine());
                    if (input >= 5 && input <= 15)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Number must be between 5 and 15. Please try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }

            return input;
        }

        static int[] RandomArrayPopulated(int arrayLength)
        {
            int[] randomArray = new int[arrayLength];
            Random random = new Random();

            for (int i = 0; i < arrayLength; i++)
            {
                randomArray[i] = random.Next(10, 51);
            }

            return randomArray;
        }

        static void ReturnArray(int[] array)
        {
            Console.Write("The elements of the array are: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static int SumArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}