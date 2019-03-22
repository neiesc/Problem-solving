using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        char[] alphas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        foreach (var alpha in alphas)
        {
            if (!input.Contains(alpha))
            {
                return false;
            }
        }
        return true;
    }
}
