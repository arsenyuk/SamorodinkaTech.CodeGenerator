using SamorodinkaTech.CodeGenerator.Templates.Builders;

namespace SamorodinkaTech.CodeGenerator.Templates.UnitTests;

[TestClass]
public class JsonModelBuilderUnitTest
{
    [TestMethod]
    public void NoExceptionIsThrownByParseFromTextMethod()
    {
        try
        {
            var model = JsonModelBuilder.ParseTextAndCreateModel("");
        }
        catch (Exception ex)
        {
            Assert.Fail("Expected no exception, but got: " + ex.Message);
        }
    }
}