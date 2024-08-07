﻿using SamorodinkaTech.CaseTransmogrifier;
using SamorodinkaTech.CodeGenerator.Templates.Extensions;
using SamorodinkaTech.CodeGenerator.Templates.Models;

namespace SamorodinkaTech.CodeGenerator.Templates.Builders;

/// <summary>
/// FunctionModelDeclaration instance builder
/// </summary>
public static class FunctionModelBuilder
{
    /// <summary>
    /// Parse text and create FunctionModelDeclaration model
    /// </summary>
    /// <param name="text">Text for pasing</param>
    public static FunctionModel ParseTextAndCreateModel(string text)
    {
        var lines = text.GetLines();

        var model = new FunctionModel();

        if (lines.Count == 0)
            return model;

        model.Name = lines[0];
        model.Identifier = model.Name.PascalCase();

        if (lines.Count == 1)
            return model;

        model.ResultType = lines[1];

        if (lines.Count == 2)
            return model;

        model.Description = lines[2];

        var i = 3;
        while (i < lines.Count &&
            (string.IsNullOrWhiteSpace(lines[i])
                || lines[i].StartsWith("Parameter")
                && lines[i].Contains("Type")
                && lines[i].Contains("Description"))
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

            var modelParameter = new FunctionModelParameter();

            modelParameter.JsonParameter = parts[0];
            modelParameter.Identifier = modelParameter.JsonParameter.CamelCase();

            if (parts.Count == 1)
                continue;

            modelParameter.ParameterType = CSharpTypeBuilder.CalculateDataType(
                parts[1].ToLower()
                );

            if (parts.Count == 2)
                continue;

            modelParameter.IsRequired = parts[2].Equals(
                "Yes",
                StringComparison.InvariantCultureIgnoreCase
                );

            if (parts.Count == 3)
                continue;

            var description = parts.GetRange(3, parts.Count - 3);
            modelParameter.Description = string.Join(" ", description);

            modelParameter.ParameterType = CSharpTypeBuilder.CalculateDataType(
                modelParameter.ParameterType,
                modelParameter.Description
            );

            model.Parameters.Add(modelParameter);
        }

        return model;
    }
}
