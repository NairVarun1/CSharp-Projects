using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Dictionary to store candidate names and their vote counts
        Dictionary<string, int> candidates = new Dictionary<string, int>()
        {
            { "Alice", 0 },
            { "Bob", 0 },
            { "Charlie", 0 }
        };

        string userInput = "";
        Console.WriteLine("Welcome to the Voting System!");

        while (true)
        {
            Console.WriteLine("\nAvailable candidates to vote for:");
            foreach (var candidate in candidates)
            {
                Console.WriteLine(candidate.Key);
            }

            Console.WriteLine("\nEnter the name of the candidate you want to vote for (or type 'results' to see results and exit):");
            userInput = Console.ReadLine().Trim();  // Trim to remove any extra spaces

            if (userInput.ToLower() == "results")
            {
                // Exit the loop and display results
                break;
            }
            else
            {
                // Find if a candidate matches (case insensitive)
                bool validCandidate = false;

                foreach (var candidate in candidates.Keys)
                {
                    if (string.Equals(candidate, userInput, StringComparison.OrdinalIgnoreCase))
                    {
                        candidates[candidate]++;  // Increment the vote for the matched candidate
                        Console.WriteLine($"Vote cast for {candidate}!");
                        validCandidate = true;
                        break;
                    }
                }

                if (!validCandidate)
                {
                    Console.WriteLine("Invalid candidate! Please enter a valid name.");
                }
            }
        }

        // Display the voting results
        Console.WriteLine("\nVoting Results:");
        foreach (var candidate in candidates)
        {
            Console.WriteLine($"{candidate.Key}: {candidate.Value} votes");
        }
    }
}
