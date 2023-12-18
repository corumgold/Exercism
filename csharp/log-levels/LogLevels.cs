using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int indexOfColon = logLine.IndexOf(':') + 1;
        string message = logLine.Substring(indexOfColon, logLine.Length - indexOfColon);
        return message.Trim();
    }

    public static string LogLevel(string logLine)
    {
        int indexOfOpenBracket = logLine.IndexOf("[") + 1;
        int indexOfCloseBracket = logLine.IndexOf("]") - 1;
        string logLevel = logLine.Substring(indexOfOpenBracket, indexOfCloseBracket);
        return logLevel.ToLower();
    }

    public static string Reformat(string logLine)
    {
        string logLevel = LogLevel(logLine);
        string message = Message(logLine);
        return $"{message} ({logLevel})";
    }
}
