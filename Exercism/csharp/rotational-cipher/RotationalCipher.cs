using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public static class RotationalCipher
{
    private static char[] _alphas_lower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    
    public static string Rotate(string text, int shiftKey)
    {        
        var cipher_lower = new List<char>();
        cipher_lower.AddRange(_alphas_lower.ToList().GetRange(shiftKey, _alphas_lower.Count() - shiftKey));
        cipher_lower.AddRange(_alphas_lower.ToList().GetRange(0, shiftKey));

        var cipher = _alphas_lower
            .Zip(cipher_lower, (first, second) => (first, second))
            .ToDictionary(d => d.first, d => d.second);

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