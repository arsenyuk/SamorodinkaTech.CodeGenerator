namespace SamorodinkaTech.CodeGenerator.Templates.Builders;

/// <summary>
/// C# type builder
/// </summary>
public static class CSharpTypeBuilder
{
    private static readonly string BoolType = "bool";
    private static readonly string IntType = "int";
    private static readonly string LongType = "long";
    private static readonly string StringType = "string";

    /// <summary>
    /// Name of the type to calculate
    /// </summary>
    /// <param name="source">Name of the type</param>
    public static string CalculateDataType(string source)
    {
        if (source.StartsWith(IntType, StringComparison.InvariantCultureIgnoreCase))
            return IntType;

        if (source.StartsWith(BoolType, StringComparison.InvariantCultureIgnoreCase))
            return BoolType;

        if (source.Equals(StringType, StringComparison.InvariantCultureIgnoreCase))
            return StringType;

        if (source.Equals(LongType, StringComparison.InvariantCultureIgnoreCase))
            return LongType;

        return source;
    }

    /// <summary>
    /// Name of the type to calculate
    /// </summary>
    /// <param name="source">Name of the type</param>
    /// <param name="description">Additional info</param>
    public static string CalculateDataType(string source, string description)
    {
        var dataType = CalculateDataType(source);

        if (dataType == IntType)
        {
            if (description.Contains("US$"))
                return LongType;

            return IntType;
        }

        return source;
    }
}

