namespace SamorodinkaTech.CodeGenerator.Templates.Models;

/// <summary>
/// Json model property
/// </summary>
public class JsonModelProperty
{
    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Property type
    /// </summary>
    public string PropertyType { get; set; } = string.Empty;

    /// <summary>
    /// Json property name 
    /// </summary>
    public string JsonProperty { get; set; } = string.Empty;

    /// <summary>
    /// Identifier
    /// </summary>
    public string Identifier { get; set; } = string.Empty;

    /// <summary>
    /// Is required
    /// </summary>
    public bool IsRequired { get; set; } = true;
}

