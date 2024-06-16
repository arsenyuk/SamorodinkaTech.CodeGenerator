namespace SamorodinkaTech.CodeGenerator.Templates.Models;

/// <summary>
/// Function parameter
/// </summary>
public class FunctionModelParameter
{
    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Parameter type
    /// </summary>
    public string ParameterType { get; set; } = string.Empty;

    /// <summary>
    /// Json parameter name
    /// </summary>
    public string JsonParameter { get; set; } = string.Empty;

    /// <summary>
    /// Parameter identifier
    /// </summary>
    public string Identifier { get; set; } = string.Empty;

    /// <summary>
    /// Required parameter
    /// </summary>
    public bool IsRequired { get; set; } = true;
}

