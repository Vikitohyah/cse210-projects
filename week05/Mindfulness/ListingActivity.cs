public class ListingActivity : Activity
{
    private List<string> prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
        "\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void Run()
    {
        Start();
        Random rand = new();
        string prompt = prompts[rand.Next(prompts.Count)];

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.Write("You may begin in: ");
        CountDown(5);


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        List<string> responses = new();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                continue;

            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                responses.Add(input);
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        End();
    }
}