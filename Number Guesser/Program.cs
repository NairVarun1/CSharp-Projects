using System;

class Program
{
    static void Main(string[] args)
    {
        int attempts = 5;

        Random random = new Random();

        Console.WriteLine("Welcome to the Number Guesser Game ! You have 5 attempts to guess a number between 1 and 10 !");

        int randomNumber = random.Next(1, 11);

        for (int i = 0; i < attempts; i++)
        {
            Console.WriteLine("Enter your guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == randomNumber)
            {
                Console.WriteLine("WOW ! You got it right !!");
                break;
            }
            else
            {
                Console.WriteLine("That's not right ! Try Again !!");
            }
        }
    }
}