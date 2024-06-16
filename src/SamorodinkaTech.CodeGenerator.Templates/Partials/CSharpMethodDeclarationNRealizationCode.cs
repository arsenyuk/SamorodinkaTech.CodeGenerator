using SamorodinkaTech.CodeGenerator.Templates.Models;

namespace SamorodinkaTech.CodeGenerator.Templates;

/// <summary>
/// Additional .ctor with MethodModelDeclaration instance
/// </summary>
public partial class CSharpMethodDeclarationNRealizationCode
{
    protected MethodModelDeclaration _methodDeclaration;

    /// <summary>
    /// .ctor
    /// </summary>
    public CSharpMethodDeclarationNRealizationCode(MethodModelDeclaration methodDeclaration)
    {
        _methodDeclaration = methodDeclaration;
    }
}