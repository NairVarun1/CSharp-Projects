using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<string> todo = new List<string>();
        string userInput = "";

        Console.WriteLine("Welcome to the ToDo List Application !");

        while (true)
        {
            Console.WriteLine("Please enter the appropaite number to perform the operation:");
            Console.WriteLine("1. To ADD a task");
            Console.WriteLine("2. To VIEW the list");
            Console.WriteLine("3. To Edit a task");
            Console.WriteLine("4. To DELETE a task");
            Console.WriteLine("Exit - To exit the application");

            userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                Console.WriteLine("Exiting the Application ... ");
                break;
            }

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Enter the task that you want to add !");
                    string input = Console.ReadLine();
                    todo.Add(input);
                    Console.WriteLine("Task added successfully !");
                    break;

                case "2":
                    Console.WriteLine("Here is your ToDo List :");
                    for (int i = 0; i < todo.Count; i++)
                    {
                        Console.WriteLine(todo[i]);
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter the task number that you would like to edit:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the new task description !");
                    string newTask = Console.ReadLine();
                    todo[num - 1] = newTask;
                    Console.WriteLine("Task updated successfully");
                    break;

                case "4":
                    Console.WriteLine("Enter the task number that you would like to delete :");
                    int n = Convert.ToInt32(Console.ReadLine());
                    todo.RemoveAt(n - 1);
                    Console.WriteLine("Task Deleted Successfully");
                    break;

                default:
                    Console.WriteLine("Enter a valid operation !");
                    break;

            }
        }
    }
}