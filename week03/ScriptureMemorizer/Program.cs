using System;

class Program
{
    static void Main(string[] args)
    {
        var library = new ScriptureLibrary();

        // Scripture Mastery
        library.AddScripture(new Reference("Matthew", 5, 14, 16),
            "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.");
        library.AddScripture(new Reference("James", 1, 5, 6),
            "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");
        library.AddScripture(new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        library.AddScripture(new Reference("Job", 19, 24, 25),
            "For I know that my redeemer liveth, and that he shall stand at the latter day upon the earth: And though after my skin worms destroy this body, yet in my flesh shall I see God:");    
        library.AddScripture(new Reference("1 Nephi", 3, 7),
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        library.AddScripture(new Reference("Mosiah", 2, 17),
            "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");
        library.AddScripture(new Reference("Alma", 37, 6, 7),
            "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise. And the Lord God doth work by means to bring about his great and eternal purposes; and by very small means the Lord doth confound the wise and bringeth about the salvation of many souls.");
        library.AddScripture(new Reference("Ether", 12, 27),
            "And if men come unto me I will show unto them their weakness.");
        library.AddScripture(new Reference("Doctrine and Covenants", 18, 10),
            "Remember the worth of souls is great in the sight of God.");
        library.AddScripture(new Reference("Doctrine and Covenants", 58, 26, 27),
            "For behold, it is not meet that I should command in all things; for he that is compelled in all things, the same is a slothful and not a wise servant; wherefore he receiveth no reward. Verily I say, men should be anxiously engaged in a good cause, and do many things of their own free will, and bring to pass much righteousness;");

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
            Console.WriteLine(scripture.DisplayScripture());
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
        }

        Console.WriteLine("All the words are hidden and You've Exited Successfully!");
        Console.ReadLine();
    }
}
