public class Activity
{
    private string _activityName;
    private string _description;
    private int  _timeDuration;



    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"--- Welcome to the {_activityName} ---");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session ? ");
        _timeDuration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void End()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_activityName} for {_timeDuration} seconds.");
        ShowSpinner(3);

    }

    protected void ShowSpinner(int seconds)
    {
        List<string> animationSpinner = new List<string>();
        animationSpinner.Add("|");
        animationSpinner.Add("/");
        animationSpinner.Add("-");
        animationSpinner.Add("\\");
        animationSpinner.Add("|");
        animationSpinner.Add("/");
        animationSpinner.Add("-");
        animationSpinner.Add("\\");


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationSpinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationSpinner.Count)
            {
                i = 0;
            }
        }

    }

    protected void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }

    public int GetDuration()
    {
        return _timeDuration;
    }

}
