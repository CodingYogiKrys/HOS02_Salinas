using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;
// Create enumeration for Priority: Low, Medium, High and Critical

namespace ConsoleApplication1
{
    internal class Program
    {
        enum Priority
        {
            Low,
            Medium,
            High,
            Critical
        }
        // Create an array inside out Main function to stores all the tasks, another array to store the priority.

        static void Main(string[] args)
        {
            string[] tasks = { "Complete homework", "Go to the grocery store", "Prepare for the meeting", "Fix the bug in the program " };
            Priority[] priorities = { Priority.Medium, Priority.Low, Priority.High, Priority.Critical };

            // Print out All tasks using for loop below Priority array, display all task with their priorities.
            Console.WriteLine("All Tasks:");
            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine($"{tasks[i]} - Priority: {priorities[i]}");
            }
            Console.WriteLine("\nCitical Priority Tasks: ");
            for (int i = 0; i < tasks.Length; i++)
            {
                if (priorities[i] == Priority.Critical)
                {
                    Console.WriteLine(tasks[i]);
                }
            }
        }
    }
}




