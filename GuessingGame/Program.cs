using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This file is made by EmJey
// Project: GuessingGame
// FileName: GuessingGame
// Date: 2023/02/06
// Email: emjeydev@gmail.com
// Github: emjeydev

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                Console.Write("Enter your guess: ");
                guess = Console.ReadLine();
                guessCount++;
                } else
                {
                    outOfGuesses = true;
                }

            }

            if (outOfGuesses)
            {
                Console.WriteLine("You Lost!");
            } else
            {
                Console.WriteLine("You Won!");
            }

            Console.ReadLine();
        }
    }
}
