using System;

namespace NumberAnalyzerDecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for the users name
            Console.Write("To get started provide your name: "); 
            string userName = Console.ReadLine();

            Console.WriteLine();

            //Ask the user to insert a number
            Console.Write("Enter a integer between 1 and 100: "); 
            int userInput = int.Parse(Console.ReadLine());


            do
            {
                //Create if statement for conditions
                if (userInput % 2 != 0 && userInput < 60 && userInput >= 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Output: {userInput}, Odd and less than 60.");
                    Console.WriteLine();
                    Console.WriteLine($"See you next time {userName}."); 
                    break;
                }
                else if (userInput % 2 == 0 && userInput >= 2 && userInput <= 24)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Output: {userInput}, Even and less than 25.");
                    Console.WriteLine();
                    Console.WriteLine($"See you next time {userName}.");
                    break; 
                }
                else if (userInput % 2 == 0 && userInput >= 26 && userInput <= 60)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Output: {userInput}, Even and between 26 and 60 inclusive.");
                    Console.WriteLine();
                    Console.WriteLine($"See you next time {userName}.");
                    break; 
                }
                else if (userInput % 2 == 0 && userInput > 60 && userInput <= 100)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{userInput}, Even and greater than 60.");
                    Console.WriteLine();
                    Console.WriteLine($"See you next time {userName}.");
                    break; 
                }
                else if (userInput % 2 != 0 && userInput > 60 && userInput <= 100)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{userInput}, Odd and greater than 60.");
                    Console.WriteLine();
                    Console.WriteLine($"See you next time {userName}.");
                    break; 
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Please enter a number between 1 and 100, {userName}."); 
                    break; 
                }
                
            }
            while (userInput >= 1 && userInput <= 100);

            
        }
    }
}
