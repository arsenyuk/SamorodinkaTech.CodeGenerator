namespace SamorodinkaTech.CodeGenerator.Templates.Extensions;

public static class StringExtension
{
    /// <summary>
    /// Splitting a string into multiple lines of limited length
    /// </summary>
    /// <param name="str">Text string</param>
    /// <param name="maxLength">Maximum length of splitted string</param>
    public static List<string> SplitText(this string str, int maxLength)
    {
        var result = new List<string>();
        if (string.IsNullOrEmpty(str) || maxLength < 1)
        {
            return result;
        }

        string[] words = str.Split(
            new char[] { ' ', '\t', '\n', '\r' },
            StringSplitOptions.RemoveEmptyEntries
            );

        string currentLine = "";

        foreach (var word in words)
        {
            if (currentLine.Length + word.Length + 1 > maxLength)
            {
                result.Add(currentLine.Trim());
                currentLine = word;
            }
            else
            {
                currentLine += (currentLine.Length > 0 ? " " : "") + word;
            }
        }

        if (!string.IsNullOrEmpty(currentLine))
        {
            result.Add(currentLine.Trim());
        }

        return result;
    }

    /// <summary>
    /// Разбиение текста на строки
    /// </summary>
    /// <param name="str"></param>
    /// <param name="removeEmptyLines"></param>
    public static List<string> GetLines(this string str, bool removeEmptyLines = false)
    {
        return str.Split(new[] { "\r\n", "\r", "\n" },
            removeEmptyLines ? StringSplitOptions.RemoveEmptyEntries : StringSplitOptions.None)
            .ToList();
    }

    /// <summary>
    /// Разбиение строки на значимые части
    /// </summary>
    public static List<string> GetLineParts(this string str)
    {
        return str.Split(new[] { " ", "\t" },
             StringSplitOptions.None)
            .ToList();
    }
}

