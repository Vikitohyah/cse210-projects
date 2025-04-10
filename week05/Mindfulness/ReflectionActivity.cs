public class ReflectionActivity : Activity
{
    private List<string> prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity",
        "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public void Run()
    {
        Start();
        Console.WriteLine($"\nConsider the following prompt");
        
        Random rand = new();

        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"\n--- {prompt} ---");


        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now, ponder on each of the following questions.");
        Console.Write("You may begin in: ");
        CountDown(4);

        List<string> tempQuestions = new List<string>(questions);
        int elapsed = 0;
        while (elapsed < GetDuration())
        {
            if (tempQuestions.Count == 0) //To help reset the list of questions after all questions have been asked with no repetition while there is still time
            {
                tempQuestions = new List<string>(questions);
            }
            int index = rand.Next(tempQuestions.Count);
            string question = tempQuestions[index];
            Console.Write($"\n> {question} ");
            ShowSpinner(5);

            tempQuestions.RemoveAt(index); //To help remove questions that are already asked and avoid repetition 
            elapsed += 5;

        }

        End();
    }
}