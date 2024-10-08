using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num <= 1)
        {
            Console.WriteLine("Enter a valid number !");
            return;
        }

        bool isPrime = true;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
            else
            {
                isPrime = true;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine("It is a prime number !");
        }
        else
        {
            Console.Write("It is not a prime number !");
        }
    }
}