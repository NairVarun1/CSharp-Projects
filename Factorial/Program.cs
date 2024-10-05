using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The factorial of the number is " + (Factorial(n)));
    }
}