using SamorodinkaTech.CaseTransmogrifier;
using SamorodinkaTech.CodeGenerator.Templates.Extensions;
using SamorodinkaTech.CodeGenerator.Templates.Models;

namespace SamorodinkaTech.CodeGenerator.Templates.Builders;

/// <summary>
/// FluentApiModel instance builder
/// </summary>
public static class FluentApiModelBuilder
{
    /// <summary>
    /// Parse text and create FluentApiModel model
    /// </summary>
    /// <param name="text">Text for pasing</param>
    public static FluentApiModel ParseTextAndCreateModel(string text)
    {
        var lines = text.GetLines();

        var model = new FluentApiModel();

        if (lines.Count == 0)
            return model;

        model.Identifier = lines[0].PascalCase();

        if (lines.Count == 1)
            return model;

        var i = 1;

        while (i < lines.Count)
        {
            var parts = lines[i].GetLineParts();

            i++;

            if (parts.Count == 0)
                continue;

            model.MethodNames.Add(parts[0]);
        }

        return model;
    }
}

