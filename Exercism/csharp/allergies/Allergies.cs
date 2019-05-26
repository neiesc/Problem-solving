using System;
using System.Collections.Generic;
using System.Linq;

[Flags]
public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private readonly Allergen myAllergies;

    public Allergies(int mask)
    {
        myAllergies = (Allergen)mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (myAllergies & allergen) == allergen;
    }

    public Allergen[] List()
    {
        IList<Allergen> result = new List<Allergen>();
        foreach (Allergen actualAllergen in Enum.GetValues(typeof(Allergen)))
        {
            if ((myAllergies & actualAllergen) != 0) result.Add(actualAllergen);
        }
        return result.ToArray();
    }
}