using System;

class Program
{
    static void Main(string[] args)
    {
        int n1 = 0, n2 = 1, temp = 0;
        Console.WriteLine("Enter the length of the Fibonacci series:");
        int length = Convert.ToInt32(Console.ReadLine());

        if (length <= 0)
        {
            Console.WriteLine("Enter a valid number i.e. greater than 0 !");
        }

        for (int i = 0; i < length; i++)
        {
            Console.Write(n1 + " ");
            temp = n1 + n2;
            n1 = n2;
            n2 = temp;
        }
    }
}