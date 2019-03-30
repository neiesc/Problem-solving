using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        return Array.FindIndex(Colors(), x => x == color);
    }

    public static string[] Colors()
    {
        return new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    }
}