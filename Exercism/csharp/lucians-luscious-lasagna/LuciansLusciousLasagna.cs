class Lasagna
{
    private const int MinutesInOven = 40;

    public int ExpectedMinutesInOven()
    {
        return MinutesInOven;
    }

    public int RemainingMinutesInOven(int actualMinutes)
    {
        return MinutesInOven - actualMinutes;
    }

    public int PreparationTimeInMinutes(int preparationSteps)
    {
        return preparationSteps * 2;
    }

    public int ElapsedTimeInMinutes(int preparationSteps, int actualMinutes)
    {
        return PreparationTimeInMinutes(preparationSteps) + actualMinutes;
    }
}
