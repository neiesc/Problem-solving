using System;
using System.Linq;
using System.Collections.Generic;

public static class RotationalCipher
{
    private static char[] _alphas_lower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    private static char[] _alphas_upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    public static string Rotate(string text, int shiftKey)
    {
        var cipher_lower = new List<char>();
        cipher_lower.AddRange(_alphas_lower.ToList().GetRange(shiftKey, _alphas_lower.Count() - shiftKey));
        cipher_lower.AddRange(_alphas_lower.ToList().GetRange(0, shiftKey));

        var cipher_upper = new List<char>();
        cipher_upper.AddRange(_alphas_upper.ToList().GetRange(shiftKey, _alphas_upper.Count() - shiftKey));
        cipher_upper.AddRange(_alphas_upper.ToList().GetRange(0, shiftKey));

        var text_cipher = "";
        foreach (var c in text)
        {
            var index = _alphas_lower.ToList().IndexOf(c);
            if (index >= 0)
            {
                text_cipher += cipher_lower[index];                
            }
            else
            {
                index = _alphas_upper.ToList().IndexOf(c);
                if (index >= 0)
                {
                    text_cipher += cipher_upper[index];
                }
                else
                {
                    text_cipher += c;
                }
            }
        }

        return text_cipher;
    }
}