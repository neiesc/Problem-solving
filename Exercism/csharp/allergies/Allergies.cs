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
        return myAllergies.HasFlag(allergen);
    }

    public Allergen[] List()
    {
        return Enum.GetValues(typeof(Allergen))
            .Cast<Allergen>()
            .Where(x => IsAllergicTo(x))
            .ToArray();
    }
}