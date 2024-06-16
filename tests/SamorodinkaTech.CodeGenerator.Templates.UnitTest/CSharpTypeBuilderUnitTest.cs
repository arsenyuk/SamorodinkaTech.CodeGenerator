using SamorodinkaTech.CodeGenerator.Templates.Builders;

namespace SamorodinkaTech.CodeGenerator.Templates.UnitTests;

[TestClass]
public class CSharpTypeBuilderUnitTest
{
    [DataTestMethod]
    [DataRow("string", "string")]
    [DataRow("int", "integer")]
    public void CalculateDataType_DataRow(string expected, string text)
    {
        var result = CSharpTypeBuilder.CalculateDataType(text);

        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow("string", "string", "US$")]
    [DataRow("long", "integer", "US$")]
    public void CalculateDataTypeWithDescription_DataRow(string expected, string text, string description)
    {
        var result = CSharpTypeBuilder.CalculateDataType(text, description);

        Assert.AreEqual(expected, result);
    }
}