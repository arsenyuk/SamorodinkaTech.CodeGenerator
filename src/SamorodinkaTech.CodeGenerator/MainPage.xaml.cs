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
        jsonModelCT.Pattern = "<model identifier>\r\n<model description>"
            + "\r\n\r\n(Property\tType\tDescription)?\r\n"
            + "(<prop identifier>\t<prop type>\t<prop description>)*";
        CodeTemplates.Add(jsonModelCT);

        var asyncMethodCT = new CodeTemplateItem();
        asyncMethodCT.Title = "Async function declaration'n'realization";
        asyncMethodCT.Code = "CSharp_async_methos";
        asyncMethodCT.Pattern = "<funct identifier>\r\n<funct description>"
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
        // Get text with a description of the model
        string inputText = InputEntry.Text;

        var item = (CodeTemplateItem)NameTemplatePicker.SelectedItem;

        string generatedCode = "";

        if (item.Code == "CSharp_JSON_model")
        {
            // Recognizing model in text
            var jsonModel = JsonModelBuilder.ParseTextAndCreateModel(inputText);

            // Code generation based on model parameters
            generatedCode = GenerateCodeFromParametersAsync(jsonModel).Result;

        }
        else if (item.Code == "CSharp_async_methos")
        {
            // Recognizing model in text
            var methodModel = FunctionModelBuilder.ParseTextAndCreateModel(inputText);

            // Code generation based on model parameters
            generatedCode = GenerateCodeFromParametersAsync(methodModel).Result;
        }

        // Displaying the result

        ResultEditor.Text = generatedCode;
    }

    /// <summary>
    /// Generating code based on model parameters
    /// </summary>
    private async Task<string> GenerateCodeFromParametersAsync(JsonModelDeclaration modelDeclaration)
    {
        try
        {
            var t = new CSharpJsonModelCode(modelDeclaration);

            return t.TransformText();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", ex.ToString(), "OK");
        }

        return "";
    }

    /// <summary>
    /// Code generation based on model parameters
    /// </summary>Ï
    private async Task<string> GenerateCodeFromParametersAsync(FunctionModelDeclaration modelDeclaration)
    {
        try
        {
            var t = new CSharpMethodDeclarationNRealizationCode(modelDeclaration);

            return t.TransformText();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", ex.ToString(), "OK");
        }

        return "";
    }
}
