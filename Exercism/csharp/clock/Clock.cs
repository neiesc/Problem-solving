using System;

public class Clock
{
    private int _hours;
    private int _minutes;

    public Clock(int hours, int minutes)
    {
        var hoursAndminutes = CalculeMinutesAndHours(hours, minutes);
        
        _hours = hoursAndminutes.Item1;
        _minutes = hoursAndminutes.Item2;
    }

    public Clock Add(int minutesToAdd)
    {
        var hoursAndminutes = CalculeMinutesAndHours(_hours, _minutes += minutesToAdd);

        _hours = hoursAndminutes.Item1;
        _minutes = hoursAndminutes.Item2;

        return this;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        var hoursAndminutes = CalculeMinutesAndHours(_hours, _minutes -= minutesToSubtract);

        _hours = hoursAndminutes.Item1;
        _minutes = hoursAndminutes.Item2;

        return this;
    }

    public override string ToString()
    {
        return $"{_hours.ToString("d2")}:{_minutes.ToString("d2")}";
    }

    private static (int, int) CalculeMinutesAndHours(int hours, int minutes)
    {
        if (minutes >= 60)
        {
            hours = hours + (minutes / 60);
            minutes = minutes % 60;
        }
        else if (minutes < 0)
        {
            var minutesToHours = Math.Abs(minutes / 60);
            hours -= minutesToHours;
            if (minutes < 0)
            {
                minutes += minutesToHours * 60;
            }
            else
            {
                minutes -= minutesToHours * 60;
            }
        }

        hours = hours % 24;
        if (hours < 0)
        {
            hours = 24 - Math.Abs(hours);
        }

        if (minutes < 0)
        {
            hours -= 1;
            if (hours < 0)
            {
                hours = 24 - Math.Abs(hours);
            }
            minutes = 60 - Math.Abs(minutes);
        }

        return (hours, minutes);
    }


   public override bool Equals(Object obj)
   {
      if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
      {
         return false;
      }
      else {
         return ToString() == obj.ToString();
      }
   }
}
