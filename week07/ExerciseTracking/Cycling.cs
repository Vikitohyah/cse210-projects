public class Cycling : Exercise
{
    private double _speed; // kph

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * GetMinutes() / 60;
    }

    public override double GetPace()
    {
       return 60 / _speed;
    }
}
