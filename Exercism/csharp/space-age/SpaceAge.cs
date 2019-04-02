using System;
using System.Collections.Generic;

public class SpaceAge
{
    private int SecondsTotal { get; set; }
    private const double EarthOrbitalPeriodSecondsPerYear = 365.25 * 24 * 60 * 60;
    private Dictionary<string, double> PlanetsOrbitalPeriodSecondsPerYear = new Dictionary<string, double>() {
        {"Mercury", 0.2408467 * EarthOrbitalPeriodSecondsPerYear},
        {"Venus", 0.61519726 * EarthOrbitalPeriodSecondsPerYear},
        {"Mars", 1.8808158 * EarthOrbitalPeriodSecondsPerYear},
        {"Jupiter", 11.862615 * EarthOrbitalPeriodSecondsPerYear},
        {"Saturn", 29.447498 * EarthOrbitalPeriodSecondsPerYear},
        {"Uranus", 84.016846 * EarthOrbitalPeriodSecondsPerYear},
        {"Neptune", 164.79132 * EarthOrbitalPeriodSecondsPerYear},
    };

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
        return SecondsTotal / PlanetsOrbitalPeriodSecondsPerYear.GetValueOrDefault("Mercury");
    }

    public double OnVenus()
    {
        return SecondsTotal / PlanetsOrbitalPeriodSecondsPerYear.GetValueOrDefault("Venus");
    }

    public double OnMars()
    {
        return SecondsTotal / PlanetsOrbitalPeriodSecondsPerYear.GetValueOrDefault("Mars");
    }

    public double OnJupiter()
    {
        return SecondsTotal / PlanetsOrbitalPeriodSecondsPerYear.GetValueOrDefault("Jupiter");
    }

    public double OnSaturn()
    {
        return SecondsTotal / PlanetsOrbitalPeriodSecondsPerYear.GetValueOrDefault("Saturn");
    }

    public double OnUranus()
    {
        return SecondsTotal / PlanetsOrbitalPeriodSecondsPerYear.GetValueOrDefault("Uranus");
    }

    public double OnNeptune()
    {
        return SecondsTotal / PlanetsOrbitalPeriodSecondsPerYear.GetValueOrDefault("Neptune");
    }
}