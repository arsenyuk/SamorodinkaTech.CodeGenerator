namespace SamorodinkaTech.CodeGenerator.Templates.Models;

public class FluentApiModel
{
    /// <summary>
    /// Identifier
    /// </summary>
    public string Identifier { get; set; } = string.Empty;

    /// <summary>
    /// Method names
    /// </summary>
    public List<string> MethodNames { get; } = new List<string>();

    /// <summary>
    /// .ctor
    /// </summary>
    public FluentApiModel()
    {
    }
}

