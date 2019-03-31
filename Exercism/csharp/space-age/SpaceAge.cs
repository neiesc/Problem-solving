using System;

public class SpaceAge
{
    public const double EarthOrbitalPeriodSecondsPerYear = 365.25 * 24 * 60 * 60;
    public int SecondsTotal { get; set; }

    public SpaceAge(int seconds)
    {
        SecondsTotal = seconds;
    }

    public double OnEarth()
    {
        return SecondsTotal / EarthOrbitalPeriodSecondsPerYear;
    }

    public double OnMercury()
    {
        return SecondsTotal / (0.2408467 * EarthOrbitalPeriodSecondsPerYear);
    }

    public double OnVenus()
    {
        return SecondsTotal / (0.61519726 * EarthOrbitalPeriodSecondsPerYear);
    }

    public double OnMars()
    {
        return SecondsTotal / (1.8808158 * EarthOrbitalPeriodSecondsPerYear);
    }

    public double OnJupiter()
    {
        return SecondsTotal / (11.862615 * EarthOrbitalPeriodSecondsPerYear);
    }

    public double OnSaturn()
    {
        return SecondsTotal / (29.447498 * EarthOrbitalPeriodSecondsPerYear);
    }

    public double OnUranus()
    {
        return SecondsTotal / (84.016846 * EarthOrbitalPeriodSecondsPerYear);
    }

    public double OnNeptune()
    {
        return SecondsTotal / (164.79132 * EarthOrbitalPeriodSecondsPerYear);
    }
}