using System;

public static class Bob
{

    private static bool IsEmptyOrWhitespace(string statement)
    {
        if (string.IsNullOrEmpty(statement))
        {
            return true;
        }
        else
        {
            foreach (char c in statement)
            {
                if (!char.IsWhiteSpace(c))
                {
                    return false;
                }
            }

            return true;
        }
    }

    private static bool IsAllCaps(string statement)
    {

        string caps = "";

        foreach (char c in statement)
        {

            if (char.IsLower(c))
            {
                return false;
            }

            // ignore white space, puncs, and numbers
            else if (char.IsWhiteSpace(c) || char.IsPunctuation(c) || char.IsNumber(c))
            {
                continue;
            }

            else caps += c;
        }

        return caps.Length > 0;
    }


    public static string Response(string statement)
    {
        if (IsAllCaps(statement.Trim()))
        {
            if (statement.EndsWith("?"))
            {
                return "Calm down, I know what I'm doing!";
            }
            else return "Whoa, chill out!";
        }
        else if (statement.Trim().EndsWith("?"))
        {
            return "Sure.";
        }
        else if (IsEmptyOrWhitespace(statement.Trim()))
        {
            return "Fine. Be that way!";
        }
        else
        {
            return "Whatever.";
        }
    }
}