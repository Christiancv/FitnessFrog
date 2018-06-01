using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            int runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {

                // Prompt the user for minutes excersiced
                Console.Write("Enter how many minutes you exercised or type \"QUIT\": ");
                string entry = Console.ReadLine();

                if (entry == "QUIT")
                {
                    keepGoing = false;

                }
                else
                {

                    int minutes = int.Parse(entry);

                    // Add minutes exercised to total
                    runningTotal = runningTotal + minutes;

                    // Display total minutes exercised to the screen
                    Console.WriteLine("You've entered " + runningTotal + " minutes");

                   
                }
            }
            Console.WriteLine("Goodbye");

        }
    }
}
