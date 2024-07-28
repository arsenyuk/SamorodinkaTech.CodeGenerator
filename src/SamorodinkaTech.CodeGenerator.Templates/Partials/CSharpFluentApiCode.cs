using SamorodinkaTech.CodeGenerator.Templates.Models;

namespace SamorodinkaTech.CodeGenerator.Templates;

/// <summary>
/// Additional .ctor with JsonModelDeclaration instance
/// </summary>
public partial class CSharpFluentApiCode
{
    protected FluentApiModel _fluentApiModel;

    /// <summary>
    /// .ctor
    /// </summary>
    public CSharpFluentApiCode(FluentApiModel modelDeclartion)
    {
        _fluentApiModel = modelDeclartion;
    }
}