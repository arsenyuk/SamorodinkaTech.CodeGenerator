using SamorodinkaTech.CodeGenerator.Templates.Models;

namespace SamorodinkaTech.CodeGenerator.Templates;

/// <summary>
/// Additional .ctor with JsonModelDeclaration instance
/// </summary>
public partial class CSharpSystemTextJsonModelCode
{
    protected JsonModel _modelDeclaration;

    /// <summary>
    /// .ctor
    /// </summary>
    public CSharpSystemTextJsonModelCode(JsonModel modelDeclartion)
    {
        _modelDeclaration = modelDeclartion;
    }
}