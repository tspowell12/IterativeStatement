/*
    Author: Tyler Powell
    Date: 9/10/2019
    Comments: This C# Console application demonstrates the use of
              iterative statements after getting input from users.
 */
    
using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user for input
            Console.Write("Enter an integer value between 1 and 100: ");
            /*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and display a message
             */
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This varialbe will be used to perform an iterative statement and is parsed as an int
                int value_of_input = int.Parse(input);
                /*
                   This IF/ELSE statement is used to test the values of user input.
                   If the user enters a value between 1 and 100, the IF loop will execute,
                   also executing the FOR iterative statement.
                 */
                // If the value of user input is between 1 and 100, execute a For Loop
                if ((value_of_input >= 1) && (value_of_input <= 100))
                {
                    /* Here is the FOR loop using the structure of: 
                       (initalizer; condition; iterator)
                       body
                     */
                    for (int i = 1; i <= value_of_input; i ++)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString()
                                          + ". This is the current integer value in the loop: " 
                                          + i.ToString()); 
                    }
                    Console.WriteLine("Loop Completed!");
                    Console.WriteLine("Press any key to exit the program ...");
                    // Pause the program and await the user to press a key to end the program
                    Console.ReadKey(true);
                }
                // If the user does not enter a value between 1 and 100, display a message
                else
                {
                    Console.WriteLine("Please enter an integer value between 1 and 100 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            }
            // End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
            // End of catch
        } // End of Main
    } // End of class
} // End of namespace