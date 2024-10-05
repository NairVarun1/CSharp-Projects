using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the operation you would like to perform:");
        Console.WriteLine("1 for Addition, 2 for Subtraction, 3 for Multiplication, 4 for Division.");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("The sum of the two numbers is: " + (n1 + n2));  // Corrected
                break;
            case 2:
                Console.WriteLine("The difference of the two numbers is: " + (n1 - n2));
                break;
            case 3:
                Console.WriteLine("The product of the two numbers is: " + (n1 * n2));
                break;
            case 4:
                if (n2 == 0)
                {
                    Console.WriteLine("This operation is invalid. A number cannot be divided by 0.");
                }
                else
                {
                    Console.WriteLine("The result of division is: " + (n1 / n2));
                }
                break;
            default:
                Console.WriteLine("Enter a valid operation!");
                break;
        }
    }
}
