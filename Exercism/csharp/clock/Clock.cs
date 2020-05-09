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
        else if (minutes < 0)
        {
            hours -= 1;
        }

        _hours = hours % 24;
        if (_hours < 0)
        {
            _hours = 24 - Math.Abs(_hours);
        }

        _minutes = minutes;
        if (_minutes < 0)
        {
            _minutes = 60 - Math.Abs(_minutes);
        }
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
