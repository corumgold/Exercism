class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int minutesElapsed)
    {
        var lasagna = new Lasagna();
        return lasagna.ExpectedMinutesInOven() - minutesElapsed;
    }

    public int PreparationTimeInMinutes(int layers) => layers * 2;
  
    public int ElapsedTimeInMinutes(int layers, int timeInOven) {
        var lasagna = new Lasagna();
        return lasagna.PreparationTimeInMinutes(layers) + timeInOven;
    }
}

