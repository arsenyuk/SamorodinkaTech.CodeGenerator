namespace SamorodinkaTech.CodeGenerator.Templates.Models;

/// <summary>
/// Model for function declaration
/// </summary>
public class FunctionModel
{
    /// <summary>
    /// Declaration
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Function identifier
    /// </summary>
    public string Identifier { get; set; } = string.Empty;

    /// <summary>
    /// Result type
    /// </summary>
    public string ResultType { get; set; } = string.Empty;

    /// <summary>
    /// Function paramters
    /// </summary>
    public List<FunctionModelParameter> Parameters { get; set; } = new List<FunctionModelParameter>();
}

