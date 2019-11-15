using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public static class RotationalCipher
{
    private static char[] _alphas_lower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    
    public static string Rotate(string text, int shiftKey)
    {
        var cipher = new Dictionary<char, char>();
        
        var cipher_lower = new List<char>();
        cipher_lower.AddRange(_alphas_lower.ToList().GetRange(shiftKey, _alphas_lower.Count() - shiftKey));
        cipher_lower.AddRange(_alphas_lower.ToList().GetRange(0, shiftKey));

        for (int i = 0; i < _alphas_lower.Length; i++)
        {
            cipher.Add(_alphas_lower[i], cipher_lower[i]);
        }

        StringBuilder text_cipher = new StringBuilder();
        foreach (var c in text)
        {
            if (cipher.TryGetValue(Char.ToLowerInvariant(c), out var value))
            {
                value = Char.IsLower(c) ? value : Char.ToUpperInvariant(value);
                text_cipher.Append(value);
            }
            else
            {
                text_cipher.Append(c);
            }
        }

        return text_cipher.ToString();
    }
}