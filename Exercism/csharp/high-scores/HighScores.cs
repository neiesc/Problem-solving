using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> listOfScores = new List<int>();
    public HighScores(List<int> listOfScores)
    {
        this.listOfScores.AddRange(listOfScores);
    }

    public List<int> Scores()
    {
        return listOfScores.Select(item => item).ToList();
    }

    public int Latest()
    {
        return listOfScores.Last();
    }

    public int PersonalBest()
    {
        return listOfScores.Max();
    }

    public List<int> PersonalTopThree()
    {
        return listOfScores.OrderByDescending(i => i).Take(3).ToList();
    }
}