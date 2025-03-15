using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to the Journal Program.");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following using its number E.g 3:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal entries to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                journal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                journal.DisplayAllEntry();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved.");
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Journal has loaded.");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye! See you again soon");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }
    }
}