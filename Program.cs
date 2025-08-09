using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] ages = new int[5];

            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.Write($"Enter age for customer {i + 1}: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int age) && age >= 10 && age <= 99)
                    {
                        ages[i] = age;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid age. Please enter a value between 10 and 99.");
                    }
                }
            }
            Console.WriteLine("\nList of valid ages: " + string.Join(", ", ages));

            int teenagerCount = 0;
            foreach (int age in ages)
            {
                if (age >= 13 && age <= 19)
                {
                    teenagerCount++;
                }
            }
            Console.WriteLine("Number of teenagers (ages 13-19): " + teenagerCount);
        }
    }
}
      
