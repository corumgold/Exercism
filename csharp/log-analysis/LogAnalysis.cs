using System;

public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        int indexOfDelimiter = str.IndexOf(delimiter) + delimiter.Length;
        return str.Substring(indexOfDelimiter, str.Length - indexOfDelimiter);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string firstDelimiter, string secondDelimiter)
    {
        int indexOfFirstDelimiter = str.IndexOf(firstDelimiter) + firstDelimiter.Length;
        int indexOfSecondDelimiter = str.IndexOf(secondDelimiter);
        int substringLength = indexOfSecondDelimiter - indexOfFirstDelimiter;
        return str.Substring(indexOfFirstDelimiter, substringLength);
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}