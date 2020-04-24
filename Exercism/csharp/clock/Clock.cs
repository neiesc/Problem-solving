using System;

public class Clock
{
    private int _hours;
    private int _minutes;

    public Clock(int hours, int minutes)
    {
        if (minutes >= 60)
        {
            hours = hours + (minutes / 60);
            minutes = minutes % 60;
        }

        _hours = hours % 24;
        _minutes = minutes;
    }

    public Clock Add(int minutesToAdd)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public Clock Subtract(int minutesToSubtract)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public override string ToString()
    {
        return $"{_hours.ToString("d2")}:{_minutes.ToString("d2")}";
    }
}
