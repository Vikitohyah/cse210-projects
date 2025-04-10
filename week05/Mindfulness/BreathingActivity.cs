public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        Start();

        int elapsed = 0;
        while (elapsed < GetDuration())
        {
            Console.Write("\nBreathe in... ");
            CountDown(4);
            elapsed += 4;

            Console.Write("\n Now breathe out... ");
            CountDown(6);
            elapsed += 6;
        }

        End();
    }
}