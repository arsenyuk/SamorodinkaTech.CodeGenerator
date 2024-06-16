using SamorodinkaTech.CodeGenerator.Templates.Extensions;

namespace SamorodinkaTech.CodeGenerator.Templates.UnitTest;

[TestClass]
public class StringExtensionUnitTest
{
    [DataTestMethod]
    [DataRow("Unique identifier for the target message thread (topic) of the"
        + " forum; for forum supergroups only",
        50,
        2 )]
    public void SplitText_DataRow(string data, int maxLength, int rowCount)
    {
        var rows = data.SplitText(maxLength);

        Assert.AreEqual(rowCount, rows.Count);
    }
}
