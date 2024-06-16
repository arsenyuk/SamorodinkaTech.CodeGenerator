using SamorodinkaTech.CodeGenerator.Templates.Builders;

namespace SamorodinkaTech.CodeGenerator.Templates.UnitTests;

[TestClass]
public class MethodModelBuilderUnitTest
{
    [TestMethod]
    public void NoExceptionIsThrownByParseFromTextMethod()
    {
        try
        {
            var model = MethodModelBuilder.ParseTextAndCreateModel("");
        }
        catch (Exception ex)
        {
            Assert.Fail("Expected no exception, but got: " + ex.Message);
        }
    }
}