using System;
using System.Collections.Generic;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        char[] alphas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        List<char> wordUsed = new List<char>();

        foreach (var letter in word.ToUpper())
        {
            if (wordUsed.Contains(letter))
            {
                return false;
            }

            if (alphas.Contains(letter))
            {
                wordUsed.Add(letter);
            }
        }

        return true;
    }
}
