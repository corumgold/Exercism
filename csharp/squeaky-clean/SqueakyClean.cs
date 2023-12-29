using System;
using System.Linq;

public static class Identifier
{
    private static bool IsNotLowerCaseGreekLetter(char character)
    {
        var greekRanges = new[]
        {
            new { Start = '\u03B1', End = '\u03C9' },
        };

        return !greekRanges.Any(range => character >= range.Start && character <= range.End);
    }

    public static string Clean(string identifier)
    {
        string replacedSpacesAndControls = identifier.Replace(" ", "_").Replace("\0", "CTRL");

        char[] arrayedRemovedSpacesAndControls = replacedSpacesAndControls.ToCharArray();

        for (int i = 0; i < arrayedRemovedSpacesAndControls.Length; i++)
        {
            if (arrayedRemovedSpacesAndControls[i] == '-')
            {
                char charAfter = arrayedRemovedSpacesAndControls[i + 1];
                arrayedRemovedSpacesAndControls[i + 1] = Char.ToUpper(charAfter);
            }
        }

        char[] removedHyphens = arrayedRemovedSpacesAndControls.Where(c => c != '-').ToArray();
        char[] onlyLetters = removedHyphens.Where(c => !Char.IsNumber(c)).ToArray();
        char[] removeEmojis = onlyLetters.Where(c => Char.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.Surrogate).ToArray();
        char[] removeLowerCaseGreek = removeEmojis.Where(c => IsNotLowerCaseGreekLetter(c)).ToArray();

        return new string(removeLowerCaseGreek);

    }
}
