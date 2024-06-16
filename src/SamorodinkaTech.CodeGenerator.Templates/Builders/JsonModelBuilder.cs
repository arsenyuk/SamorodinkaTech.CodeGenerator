using SamorodinkaTech.CaseTransmogrifier;
using SamorodinkaTech.CodeGenerator.Templates.Extensions;
using SamorodinkaTech.CodeGenerator.Templates.Models;

namespace SamorodinkaTech.CodeGenerator.Templates.Builders;

/// <summary>
/// JsonModelDeclaration instance builder
/// </summary>
public static class JsonModelBuilder
{
    /// <summary>
    /// Parse text and create JsonModelDeclaration model
    /// </summary>
    /// <param name="text">Text for pasing</param>
    public static JsonModelDeclaration ParseTextAndCreateModel(string text)
    {
        var lines = text.GetLines();

        var model = new JsonModelDeclaration();

        if (lines.Count == 0)
            return model;
        
        model.Identifier = lines[0].PascalCase();

        if (lines.Count == 1)
            return model;

        model.Description = lines[1];

        var i = 2;
        while (i < lines.Count &&
            (string.IsNullOrWhiteSpace(lines[i])
                || lines[i].StartsWith("Property") && lines[i].Contains("Type"))
            )
        {
            i++;
        }

        while (i < lines.Count)
        {
            var parts = lines[i].GetLineParts();

            i++;

            if (parts.Count == 0)
                continue;

            var modelProperty = new JsonModelProperty();

            modelProperty.JsonProperty = parts[0];
            modelProperty.Identifier = modelProperty.JsonProperty.PascalCase();

            if (parts.Count == 1)
                continue;

            modelProperty.PropertyType = CSharpTypeBuilder.CalculateDataType(parts[1]);

            if (parts.Count == 2)
                continue;

            var description = parts.GetRange(2, parts.Count - 2);

            if (description.Count > 0 && description[0] == "Optional.")
            {
                modelProperty.IsRequired = false;
            }
            modelProperty.Description = string.Join(" ", description);

            modelProperty.PropertyType = CSharpTypeBuilder.CalculateDataType(
                modelProperty.PropertyType,
                modelProperty.Description
                );

            model.Properties.Add(modelProperty);
        }

        return model;
    }
}

