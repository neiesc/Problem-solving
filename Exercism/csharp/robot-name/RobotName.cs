using System;
using System.Collections.Generic;

public class Robot
{
    private string _name { get; set; }
    private static HashSet<string> _names = new HashSet<string>();
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

    #region Helpers

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
        var random = new Random();

        var newName = GenerateCharAlphabetUpperCaseRandom() + GenerateCharAlphabetUpperCaseRandom() + random.Next(100, 999).ToString();
        return newName;
    }

    private string GenerateCharAlphabetUpperCaseRandom()
    {
        var random = new Random();
        return Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
    }

    #endregion Helpers
}