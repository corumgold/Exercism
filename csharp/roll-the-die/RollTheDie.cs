using System;

public class Player
{
    Random randomNum = new Random();
    public int RollDie()
    {
        return randomNum.Next(1, 18);
    }

    public double GenerateSpellStrength()
    {
        return randomNum.NextDouble() * (100.0 - 0.0) + 0.0;
    }
}
