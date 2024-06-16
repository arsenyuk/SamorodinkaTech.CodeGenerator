namespace SamorodinkaTech.CodeGenerator.Templates.Models;

/// <summary>
/// Json model declaration
/// </summary>
public class JsonModelDeclaration
{
    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Identifier
    /// </summary>
    public string Identifier { get; set; } = string.Empty;

    /// <summary>
    /// Property list
    /// </summary>
    public List<JsonModelProperty> Properties { get; } = new List<JsonModelProperty>();
}

