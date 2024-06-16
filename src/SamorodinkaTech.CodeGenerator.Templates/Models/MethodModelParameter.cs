namespace SamorodinkaTech.CodeGenerator.Templates.Models;

/// <summary>
/// Параметр метода
/// </summary>
public class MethodModelParameter
{
    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Тип параметра
    /// </summary>
    public string ParameterType { get; set; } = string.Empty;

    /// <summary>
    /// Имя параметра
    /// </summary>
    public string JsonParameter { get; set; } = string.Empty;

    /// <summary>
    /// Имя параметра
    /// </summary>
    public string Identifier { get; set; } = string.Empty;

    /// <summary>
    /// Обязательность параметра
    /// </summary>
    public bool IsRequired { get; set; } = true;
}

