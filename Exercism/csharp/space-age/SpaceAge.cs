using System;
using System.Collections.Generic;

public class SpaceAge
{
    private const double EarthOrbitalPeriodSecondsPerYear = 365.25 * 24 * 60 * 60;

    private int secondsTotal { get; set; }
    private Dictionary<string, double> planetsOrbitalPeriodSecondsPerYear = new Dictionary<string, double>() {
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
        secondsTotal = seconds;
    }

    public double OnEarth()
    {
        return secondsTotal / EarthOrbitalPeriodSecondsPerYear;
    }

    public double OnMercury()
    {
        return secondsTotal / planetsOrbitalPeriodSecondsPerYear.GetValueOrDefault("Mercury");
    }

    public double OnVenus()
    {
        return secondsTotal / planetsOrbitalPeriodSecondsPerYear.GetValueOrDefault("Venus");
    }

    public double OnMars()
    {
        return secondsTotal / planetsOrbitalPeriodSecondsPerYear.GetValueOrDefault("Mars");
    }

    public double OnJupiter()
    {
        return secondsTotal / planetsOrbitalPeriodSecondsPerYear.GetValueOrDefault("Jupiter");
    }

    public double OnSaturn()
    {
        return secondsTotal / planetsOrbitalPeriodSecondsPerYear.GetValueOrDefault("Saturn");
    }

    public double OnUranus()
    {
        return secondsTotal / planetsOrbitalPeriodSecondsPerYear.GetValueOrDefault("Uranus");
    }

    public double OnNeptune()
    {
        return secondsTotal / planetsOrbitalPeriodSecondsPerYear.GetValueOrDefault("Neptune");
    }
}