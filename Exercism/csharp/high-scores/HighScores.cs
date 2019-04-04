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
        return listOfScores;
    }

    public int Latest()
    {
        return listOfScores.Where(x => x != 0).OrderBy(i => i).ToList()[0];
    }

    public int PersonalBest()
    {
        return PersonalTopThree()[0];
    }

    public List<int> PersonalTopThree()
    {
        return listOfScores.OrderByDescending(i => i).Take(3).ToList();
    }
}