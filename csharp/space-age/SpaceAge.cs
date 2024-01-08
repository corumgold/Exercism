using System;

public class SpaceAge
{
    private double seconds;
    private int earthYearInSeconds = 31557600;
    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth() => this.seconds / earthYearInSeconds;

    public double OnMercury() => this.seconds / (earthYearInSeconds * 0.2408467);

    public double OnVenus() => this.seconds / (earthYearInSeconds * 0.61519726);

    public double OnMars() => this.seconds / (earthYearInSeconds * 1.8808158);

    public double OnJupiter() => this.seconds / (earthYearInSeconds * 11.862615);
    public double OnSaturn() => this.seconds / (earthYearInSeconds * 29.447498);

    public double OnUranus() => this.seconds / (earthYearInSeconds * 84.016846);

    public double OnNeptune() => this.seconds / (earthYearInSeconds * 164.79132);
}