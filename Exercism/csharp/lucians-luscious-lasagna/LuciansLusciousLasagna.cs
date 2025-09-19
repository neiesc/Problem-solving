class Lasagna
{
    private const int MinutesInOven = 40;

    public int ExpectedMinutesInOven() => MinutesInOven;

    public int RemainingMinutesInOven(int actualMinutes) => MinutesInOven - actualMinutes;

    public int PreparationTimeInMinutes(int preparationSteps) => preparationSteps * 2;

    public int ElapsedTimeInMinutes(int preparationSteps, int actualMinutes) => PreparationTimeInMinutes(preparationSteps) + actualMinutes;
}
