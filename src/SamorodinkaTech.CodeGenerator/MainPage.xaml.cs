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

    private const string LangCSharp = "CSharp";
    private const string LangGo = "Golang";

    private const string CSharp_SystemTextJson = "CSharp_SystemTextJson";
    private const string CSharp_NewtonsoftJson = "CSharp_NewtonsoftJson";
    private const string CSharp_async_method = "CSharp_async_method";
    private const string CSharp_FluentApi = "CSharp_FluentApi";

    private void InitNameTemplatePicker()
    {
        var systemTextJsonCT = new CodeTemplateItem();
        systemTextJsonCT.Language = LangCSharp;
        systemTextJsonCT.Code = CSharp_SystemTextJson;
        systemTextJsonCT.Title = "System Text Json style";
        systemTextJsonCT.Pattern = "<model identifier>\r\n<model description>"
            + "\r\n\r\n(Field\tType\tDescription)?\r\n"
            + "(<prop identifier>\t<prop type>\t<prop description>)*";
        CodeTemplates.Add(systemTextJsonCT);

        var newtonsoftJsonCT = new CodeTemplateItem();
        newtonsoftJsonCT.Language = LangCSharp;
        newtonsoftJsonCT.Code = CSharp_NewtonsoftJson;
        newtonsoftJsonCT.Title = "Newtonsoft Json style";
        newtonsoftJsonCT.Pattern = "<model identifier>\r\n<model description>"
            + "\r\n\r\n(Field\tType\tDescription)?\r\n"
            + "(<prop identifier>\t<prop type>\t<prop description>)*";
        CodeTemplates.Add(newtonsoftJsonCT);

        var asyncMethodCT = new CodeTemplateItem();
        asyncMethodCT.Language = LangCSharp;
        asyncMethodCT.Title = "Async function declaration'n'realization";
        asyncMethodCT.Code = CSharp_async_method;
        asyncMethodCT.Pattern = "<funct identifier>\r\n<funct description>"
            + "\r\n\r\n(Parameter\tType\tRequired\tDescription)?\r\n"
            + "(<param identifier>\t<param type>\t<param required>\t<param description>)*";
        CodeTemplates.Add(asyncMethodCT);

        var fluentApiCT = new CodeTemplateItem();
        fluentApiCT.Language = LangCSharp;
        fluentApiCT.Title = "Fluent application programming interface";
        fluentApiCT.Code = CSharp_FluentApi;
        fluentApiCT.Pattern = "<class identifier>\r\n"
            + "(<method identifier>)*"; ;
        CodeTemplates.Add(fluentApiCT);

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

        if (item.Code == CSharp_SystemTextJson)
        {
            // Recognizing model in text
            var jsonModel = JsonModelBuilder.ParseTextAndCreateModel(inputText);

            // Code generation based on model parameters
            generatedCode = GenerateSystemTextJsonCodeFromParametersAsync(jsonModel).Result;

        }
        else if (item.Code == CSharp_NewtonsoftJson)
        {
            // Recognizing model in text
            var jsonModel = JsonModelBuilder.ParseTextAndCreateModel(inputText);

            // Code generation based on model parameters
            generatedCode = GenerateNewtonsoftJsonCodeFromParametersAsync(jsonModel).Result;

        }
        else if (item.Code == CSharp_async_method)
        {
            // Recognizing model in text
            var methodModel = FunctionModelBuilder.ParseTextAndCreateModel(inputText);

            // Code generation based on model parameters
            generatedCode = GenerateCodeFromParametersAsync(methodModel).Result;
        }
        else if (item.Code == CSharp_FluentApi)
        {
            // Recognizing model in text
            var methodModel = FluentApiModelBuilder.ParseTextAndCreateModel(inputText);

            // Code generation based on model parameters
            generatedCode = GenerateCodeFromParametersAsync(methodModel).Result;
        }

        // Dispzlaying the result

        ResultEditor.Text = generatedCode;
    }


    /// <summary>
    /// Generating code based on model parameters
    /// </summary>
    private async Task<string> GenerateSystemTextJsonCodeFromParametersAsync(JsonModel modelDeclaration)
    {
        try
        {
            var t = new CSharpSystemTextJsonModelCode(modelDeclaration);

            return t.TransformText();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", ex.ToString(), "OK");
        }

        return "";
    }

    /// <summary>
    /// Generating code based on model parameters
    /// </summary>
    private async Task<string> GenerateNewtonsoftJsonCodeFromParametersAsync(JsonModel modelDeclaration)
    {
        try
        {
            var t = new CSharpNewtonsoftJsonModelCode(modelDeclaration);

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
    private async Task<string> GenerateCodeFromParametersAsync(FunctionModel modelDeclaration)
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

    /// <summary>
    /// Code generation based on model parameters
    /// </summary>
    /// <remarks>
    /// TelegramChatBot
    /// Start
    /// InputText
    /// InputContact
    /// InputChoice
    /// Finish
    /// </remarks>
    private async Task<string> GenerateCodeFromParametersAsync(FluentApiModel modelDeclaration)
    {
        try
        {
            var t = new CSharpFluentApiCode(modelDeclaration);

            return t.TransformText();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", ex.ToString(), "OK");
        }

        return "";
    }
}
