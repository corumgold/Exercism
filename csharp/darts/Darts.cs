using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double distance = Math.Sqrt((x * x) + (y * y));

        if (distance <= Math.Abs(1))
        {
            return 10;
        }
        else if (distance <= Math.Abs(5))
        {
            return 5;
        }
        else if (distance <= Math.Abs(10))
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
