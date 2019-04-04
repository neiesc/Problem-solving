using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> listOfScores = new List<int>();
    public HighScores(List<int> listOfScores)
    {
        this.listOfScores.AddRange(listOfScores);
    }

    public List<int> Scores()
    {
        return this.listOfScores;
    }

    public int Latest()
    {
        return this.listOfScores.Where(x => x != 0).OrderBy(i => i).ToList()[0];
    }

    public int PersonalBest()
    {
        return this.listOfScores.OrderByDescending(i => i).ToList()[0];
    }

    public List<int> PersonalTopThree()
    {
        return this.listOfScores.OrderByDescending(i => i).Take(3).ToList();
    }
}