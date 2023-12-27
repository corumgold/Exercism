using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] arrayedInput = input.ToCharArray();
        Array.Reverse(arrayedInput);
        return new string(arrayedInput);
    }
}