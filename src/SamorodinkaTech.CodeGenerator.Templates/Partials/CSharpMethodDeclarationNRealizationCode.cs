using SamorodinkaTech.CodeGenerator.Templates.Models;

namespace SamorodinkaTech.CodeGenerator.Templates;

/// <summary>
/// Additional .ctor with MethodModelDeclaration instance
/// </summary>
public partial class CSharpMethodDeclarationNRealizationCode
{
    protected FunctionModel _functionDeclaration;

    /// <summary>
    /// .ctor
    /// </summary>
    public CSharpMethodDeclarationNRealizationCode(FunctionModel functionDeclaration)
    {
        _functionDeclaration = functionDeclaration;
    }
}