using System;

class Program
{
    static void Main(string[] args)
    {
        var library = new ScriptureLibrary();

        // 📘 Book of Mormon & D&C Scripture Mastery
        library.AddScripture(new Reference("1 Nephi", 3, 7),
            "I will go and do the things which the Lord hath commanded...");
        library.AddScripture(new Reference("Mosiah", 2, 17),
            "When ye are in the service of your fellow beings ye are only in the service of your God.");
        library.AddScripture(new Reference("Alma", 37, 6),
            "By small and simple things are great things brought to pass.");
        library.AddScripture(new Reference("Ether", 12, 27),
            "And if men come unto me I will show unto them their weakness.");
        library.AddScripture(new Reference("Doctrine and Covenants", 18, 10),
            "Remember the worth of souls is great in the sight of God.");
        library.AddScripture(new Reference("Doctrine and Covenants", 58, 26),
            "For behold, it is not meet that I should command in all things...");

        var scripture = library.GetRandomScripture();
        if (scripture == null)
        {
            Console.WriteLine("No scriptures available.");
            return;
        }

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine("Scripture Mastery:");
            Console.WriteLine(scripture.Display());
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
        }

        Console.WriteLine("All the words are hidden and You've Exited Successfully!");
        Console.WriteLine("Press Enter to Exit.");
        Console.ReadLine();
    }
}
