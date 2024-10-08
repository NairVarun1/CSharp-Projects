using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your password:");
        string original = Console.ReadLine();
        char[] charArray = original.ToCharArray();

        Console.WriteLine("Which operation do you want to perform?");
        Console.WriteLine("1 - Encrypt");
        Console.WriteLine("2 - Decrypt");
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1": // Encryption
                Console.WriteLine("Enter the starting position (0-based index):");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the ending position (exclusive):");
                int end = Convert.ToInt32(Console.ReadLine());

                // Validate positions
                if (start < 0 || end > original.Length || start >= end)
                {
                    Console.WriteLine("Invalid positions. Please ensure start < end and within bounds.");
                }
                else
                {
                    // Reverse the characters between start and end
                    Array.Reverse(charArray, start, end - start);
                    string encrypted = new string(charArray);
                    Console.WriteLine("Encrypted password: " + encrypted);
                }
                break;

            case "2": // Decryption
                Console.WriteLine("Enter the starting position (0-based index):");
                int decStart = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the ending position (exclusive):");
                int decEnd = Convert.ToInt32(Console.ReadLine());

                // Validate positions
                if (decStart < 0 || decEnd > original.Length || decStart >= decEnd)
                {
                    Console.WriteLine("Invalid positions. Please ensure start < end and within bounds.");
                }
                else
                {
                    // Reverse the characters back to original
                    Array.Reverse(charArray, decStart, decEnd - decStart);
                    string decrypted = new string(charArray);
                    Console.WriteLine("Decrypted password: " + decrypted);
                }
                break;

            default:
                Console.WriteLine("Invalid operation. Please select 1 or 2.");
                break;
        }
    }
}
