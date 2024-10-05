using System;

class Program
{
    static void Main(string[] args)
    {
        int pin = 1904;
        int balance = 0;

        Console.WriteLine("Welcome to Unlimited Paisa ATM!");
        Console.WriteLine("Enter your PIN to continue:");
        int input = Convert.ToInt32(Console.ReadLine());

        // Check if the entered PIN is correct
        if (input != pin)
        {
            Console.WriteLine("Invalid PIN!");
            Console.WriteLine("Thank you for banking with us!");
            return; // Exit the program
        }

        while (true)
        {
            // Display options for the user
            Console.WriteLine("Which operation would you like to perform?");
            Console.WriteLine("1. Deposit Money");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Change PIN");
            Console.WriteLine("5. Exit");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Enter the amount you would like to deposit:");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    balance += deposit;
                    Console.WriteLine("Your updated balance is: " + balance);
                    break;

                case "2":
                    Console.WriteLine("Enter the amount you would like to withdraw:");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    if (withdraw > balance)
                    {
                        Console.WriteLine("Insufficient Balance!");
                    }
                    else
                    {
                        balance -= withdraw;
                        Console.WriteLine("Your updated balance is: " + balance);
                    }
                    break;

                case "3":
                    Console.WriteLine("Your account balance is: " + balance);
                    break;

                case "4":
                    Console.WriteLine("Enter your new PIN:");
                    int new_pin = Convert.ToInt32(Console.ReadLine());
                    pin = new_pin;
                    Console.WriteLine("Your PIN has been changed successfully!");
                    break;

                case "5":
                    Console.WriteLine("Thank you for banking with us!");
                    return;

                default:
                    Console.WriteLine("Enter a valid operation!");
                    break;
            }
        }
    }
}
