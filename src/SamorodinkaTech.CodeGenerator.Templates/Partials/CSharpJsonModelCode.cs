using SamorodinkaTech.CodeGenerator.Templates.Models;

namespace SamorodinkaTech.CodeGenerator.Templates;

/// <summary>
/// Additional .ctor with JsonModelDeclaration instance
/// </summary>
public partial class CSharpJsonModelCode
{
    protected JsonModelDeclaration _modelDeclaration;

    /// <summary>
    /// .ctor
    /// </summary>
    public CSharpJsonModelCode(JsonModelDeclaration modelDeclartion)
    {
        _modelDeclaration = modelDeclartion;
    }
}