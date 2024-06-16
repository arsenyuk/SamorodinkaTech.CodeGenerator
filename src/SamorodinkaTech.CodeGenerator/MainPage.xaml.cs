using SamorodinkaTech.CodeGenerator.Templates;
using SamorodinkaTech.CodeGenerator.Templates.Builders;
using SamorodinkaTech.CodeGenerator.Templates.Models;

namespace SamorodinkaTech.CodeGenerator;

public partial class MainPage : ContentPage
{
    public List<CodeTemplateItem> CodeTemplates = new List<CodeTemplateItem>();

    public MainPage()
    {
        InitializeComponent();

        InitLanguagePicker();

        InitNameTemplatePicker();

        SetPatternToInputEntry(CodeTemplates[0]);
    }

    private void InitLanguagePicker()
    {
        LanguagePicker.SelectedIndex = 0;
    }

    private void InitNameTemplatePicker()
    {

        var jsonModelCT = new CodeTemplateItem();
        jsonModelCT.Title = "JSON model";
        jsonModelCT.Code = "CSharp_JSON_model";
        jsonModelCT.Pattern = "<entity identifier>\r\n<entity description>"
            + "\r\n\r\n(Field\tType\tDescription)?\r\n"
            + "(<field identifier>\t<field type>\t<field description>)*";
        CodeTemplates.Add(jsonModelCT);

        var asyncMethodCT = new CodeTemplateItem();
        asyncMethodCT.Title = "Async method declaration'n'realization";
        asyncMethodCT.Code = "CSharp_async_methos";
        asyncMethodCT.Pattern = "<method identifier>\r\n<method description>"
            + "\r\n\r\n(Field\tType\tRequired\tDescription)?\r\n"
            + "(<param identifier>\t<param type>\t<param required>\t<param description>)*";
        CodeTemplates.Add(asyncMethodCT);

        NameTemplatePicker.ItemsSource = CodeTemplates;
        NameTemplatePicker.SelectedIndex = 0;
    }

    private void NameTemplatePicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
        SetPatternToInputEntry((CodeTemplateItem)NameTemplatePicker.SelectedItem);
    }

    private void SetPatternToInputEntry(CodeTemplateItem item)
    {
        InputEntry.Text = item.Pattern;
    }

    private void OnParseAndGenerateCodeClicked(object sender, EventArgs e)
    {
        // Получаем текст с описанием модели
        string inputText = InputEntry.Text;

        var item = (CodeTemplateItem)NameTemplatePicker.SelectedItem;

        string generatedCode = "";

        if (item.Code == "CSharp_JSON_model")
        {
            // Распознаем пераметры модели в тексте
            var jsonModel = JsonModelBuilder.ParseTextAndCreateModel(inputText);

            // Генерируем код на основе параметров модели
            generatedCode = MainPage.GenerateCodeFromParameters(jsonModel);

        }
        else if (item.Code == "CSharp_async_methos")
        {
            // Распознаем пераметры модели в тексте
            var methodModel = MethodModelBuilder.ParseTextAndCreateModel(inputText);

            // Генерируем код на основе параметров модели
            generatedCode = MainPage.GenerateCodeFromParameters(methodModel);
        }

        // Отображаем результат в Editor

        ResultEditor.Text = generatedCode;
    }

    /// <summary>
    /// Генерируем код на основе параметров модели
    /// </summary>
    private static string GenerateCodeFromParameters(JsonModelDeclaration modelDeclaration)
    {
        try
        {
            var t = new CSharpJsonModelCode(modelDeclaration);

            return t.TransformText();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        return "";
    }

    /// <summary>
    /// Генерируем код на основе параметров модели
    /// </summary>
    private static string GenerateCodeFromParameters(MethodModelDeclaration modelDeclaration)
    {
        try
        {
            var t = new CSharpMethodDeclarationNRealizationCode(modelDeclaration);

            return t.TransformText();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        return "";
    }
}
