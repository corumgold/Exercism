using System;

public static class Pangram
{
    private static string alphabet = "abcdefghijklmnopqrstuvwxyz";
    public static bool IsPangram(string input)
    {
        foreach (char c in alphabet)
        {
            if (!input.ToLower().Contains(c))
            {
                return false;
            }
        }
        return true;
    }
}
