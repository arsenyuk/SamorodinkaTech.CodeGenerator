using SamorodinkaTech.CodeGenerator.Templates.Models;

namespace SamorodinkaTech.CodeGenerator.Templates;

/// <summary>
/// Additional .ctor with MethodModelDeclaration instance
/// </summary>
public partial class CSharpMethodDeclarationNRealizationCode
{
    protected FunctionModelDeclaration _functionDeclaration;

    /// <summary>
    /// .ctor
    /// </summary>
    public CSharpMethodDeclarationNRealizationCode(FunctionModelDeclaration functionDeclaration)
    {
        _functionDeclaration = functionDeclaration;
    }
}