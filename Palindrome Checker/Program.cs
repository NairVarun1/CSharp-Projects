using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a word or a sentence :");
        string original = Console.ReadLine().ToLower();

        char[] charArray = original.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        if (reversed == original)
        {
            Console.WriteLine("It is a Palindrome");
        }
        else
        {
            Console.WriteLine("It is not a Palindrome !");
        }
    }
}