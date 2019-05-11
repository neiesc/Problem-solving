using System;
using System.Collections.Generic;

public class Robot
{
    private string _name { get; set; }
    private static HashSet<string> _names = new HashSet<string>();
    private static readonly Random random = new Random();
    private const int MinNumberOfName = 100;
    private const int MaxNumberOfName = 999;
    private const int MinASCIIOfAlphabetUpperCase = 65;
    private const int MaxASCIIOfAlphabetUpperCase = 90;

    public Robot()
    {
        GenerateName();
    }

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public void Reset()
    {
        GenerateName();
    }

    private void GenerateName()
    {
        _name = GenerateNewName();
        while (!_names.Add(_name))
        {
            _name = GenerateNewName();
        }
    }

    private string GenerateNewName()
    {
        return GenerateLetterOfAlphabetUpperCaseRandom() + GenerateLetterOfAlphabetUpperCaseRandom() + random.Next(MinNumberOfName, MaxNumberOfName).ToString();
    }

    private string GenerateLetterOfAlphabetUpperCaseRandom()
    {
        return Convert.ToChar(random.Next(MinASCIIOfAlphabetUpperCase, MaxASCIIOfAlphabetUpperCase)).ToString();
    }
}