using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        char[] alphas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        List<char> alphas_used = new List<char>();

        foreach (var letter in input.ToUpper())
        {
            if (alphas.Contains(letter) && (!alphas_used.Contains(letter)))
            {
                alphas_used.Add(letter);
            }
        }

        return alphas_used.Count == alphas.Count();
    }
}
