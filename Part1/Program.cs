/// Lab 5
/// File Name: Guessing Game
/// @author: Dakota Durst
/// Date: October 2, 2020
///
/// Problem Statement: 
/// Code will produce a random number between 1-100. User will try to guess number while machine says if number is lower or higher then the guess. 
///
///
/// Overall Plan:
/// 1) 
/// 2)
/// 3) 
/// 4) 
/// 5) 

using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int randomNumber = dice.Next(100);
            int guess = 0;
            int counter = 0;
            // Console.WriteLine(randomNumber); making sure number is assinged correctly
            while (guess != randomNumber)
            {
                Console.WriteLine("Please try and guess the number I am thinking of between 0-100 then press the enter key to input your guess");
                guess = int.Parse(Console.ReadLine());
                if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess is larger then the number I am thinking of, please try again.");
                    counter++;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess is smaller then the number I am thinking of, please try again.");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Congrates! Your guess was the number I was thinking of. It took you: " + counter + " tries to guess the number I was thinking of");
                }
            }// end of while loop
        }
    }
}
