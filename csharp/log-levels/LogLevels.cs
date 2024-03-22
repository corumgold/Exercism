using System;
static class LogLine
{
    public static string Message(string log) => log.Substring(log.IndexOf(":") + 2).Trim();

    public static string LogLevel(string log)
    {
        int openBracketIndex = log.IndexOf("[") + 1;
        int closeBracketIndex = log.IndexOf("]");
        return log.Substring(openBracketIndex, closeBracketIndex - openBracketIndex).ToLower();
    }

    public static string Reformat(string log) => $"{Message(log)} ({LogLevel(log)})";
}

