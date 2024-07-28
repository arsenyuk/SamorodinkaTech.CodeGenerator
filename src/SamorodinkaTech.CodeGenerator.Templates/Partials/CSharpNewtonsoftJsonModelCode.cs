using SamorodinkaTech.CodeGenerator.Templates.Models;

namespace SamorodinkaTech.CodeGenerator.Templates;

/// <summary>
/// Additional .ctor with JsonModelDeclaration instance
/// </summary>
public partial class CSharpNewtonsoftJsonModelCode
{
    protected JsonModel _modelDeclaration;

    /// <summary>
    /// .ctor
    /// </summary>
    public CSharpNewtonsoftJsonModelCode(JsonModel modelDeclartion)
    {
        _modelDeclaration = modelDeclartion;
    }
}