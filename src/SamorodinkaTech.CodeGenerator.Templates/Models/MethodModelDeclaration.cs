namespace SamorodinkaTech.CodeGenerator.Templates.Models;

/// <summary>
/// Модель для декларации асинхронного метода
/// </summary>
public class MethodModelDeclaration
{
    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Имя метода
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Идентификатор функции
    /// </summary>
    public string Identifier { get; set; } = string.Empty;

    /// <summary>
    /// Тип результата
    /// </summary>
    public string ResultType { get; set; } = string.Empty;

    /// <summary>
    /// Параметры метода
    /// </summary>
    public List<MethodModelParameter> Parameters { get; set; } = new List<MethodModelParameter>();
}

