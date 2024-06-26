﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SamorodinkaTech.CodeGenerator.Templates {
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using SamorodinkaTech.CodeGenerator.Templates.Extensions;
    using System;
    
    
    public partial class CSharpMethodDeclarationNRealizationCode : CSharpMethodDeclarationNRealizationCodeBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 7 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 8 ""

var parameterCount = _functionDeclaration.Parameters.Count;
var lastIndex = parameterCount - 1;

var _params = _functionDeclaration.Parameters
    .OrderByDescending(x => x.IsRequired)
    .ToList();

var methodDescriptionLines = _functionDeclaration.Description.SplitText(108);

            
            #line default
            #line hidden
            
            #line 18 ""
            this.Write("    /// <summary>\n");
            
            #line default
            #line hidden
            
            #line 19 ""

for (var i=0; i < methodDescriptionLines.Count; i++)
{

            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write("    /// ");
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( methodDescriptionLines[i] ));
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 24 ""

}

            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write("    /// </summary>\n");
            
            #line default
            #line hidden
            
            #line 28 ""

for(var i=0; i<parameterCount; i++)
{
    var p = _params[i];

            
            #line default
            #line hidden
            
            #line 33 ""
            this.Write("    /// <param name=\"");
            
            #line default
            #line hidden
            
            #line 33 ""
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Identifier));
            
            #line default
            #line hidden
            
            #line 33 ""
            this.Write("\">");
            
            #line default
            #line hidden
            
            #line 33 ""
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Description));
            
            #line default
            #line hidden
            
            #line 33 ""
            this.Write("</param>\n");
            
            #line default
            #line hidden
            
            #line 34 ""

}

            
            #line default
            #line hidden
            
            #line 37 ""
            this.Write("    Task<");
            
            #line default
            #line hidden
            
            #line 37 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _functionDeclaration.ResultType ));
            
            #line default
            #line hidden
            
            #line 37 ""
            this.Write("> ");
            
            #line default
            #line hidden
            
            #line 37 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _functionDeclaration.Identifier ));
            
            #line default
            #line hidden
            
            #line 37 ""
            this.Write("Async(");
            
            #line default
            #line hidden
            
            #line 37 ""


for(var i=0; i<parameterCount; i++)
{
    var p = _params[i];

    Write("\r\n");


            
            #line default
            #line hidden
            
            #line 46 ""
            this.Write("           ");
            
            #line default
            #line hidden
            
            #line 46 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( p.ParameterType ));
            
            #line default
            #line hidden
            
            #line 46 ""

    if (!p.IsRequired) {

            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write("?");
            
            #line default
            #line hidden
            
            #line 49 ""

    }

            
            #line default
            #line hidden
            
            #line 52 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 52 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( p.Identifier ));
            
            #line default
            #line hidden
            
            #line 52 ""

    if (!p.IsRequired) {

            
            #line default
            #line hidden
            
            #line 55 ""
            this.Write(" = null");
            
            #line default
            #line hidden
            
            #line 55 ""

    }
    if (i != lastIndex) {

            
            #line default
            #line hidden
            
            #line 59 ""
            this.Write(",");
            
            #line default
            #line hidden
            
            #line 59 ""

    }
}
Write("\r\n");

            
            #line default
            #line hidden
            
            #line 64 ""
            this.Write("    );\n\n===================== Realization =====================\n\n    public async" +
                    " Task<");
            
            #line default
            #line hidden
            
            #line 68 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _functionDeclaration.ResultType ));
            
            #line default
            #line hidden
            
            #line 68 ""
            this.Write("> ");
            
            #line default
            #line hidden
            
            #line 68 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _functionDeclaration.Identifier ));
            
            #line default
            #line hidden
            
            #line 68 ""
            this.Write("Async(");
            
            #line default
            #line hidden
            
            #line 68 ""


for(var i=0; i<parameterCount; i++)
{
    var p = _params[i];

    Write("\r\n");


            
            #line default
            #line hidden
            
            #line 77 ""
            this.Write("        ");
            
            #line default
            #line hidden
            
            #line 77 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( p.ParameterType ));
            
            #line default
            #line hidden
            
            #line 77 ""

    if (!p.IsRequired) {

            
            #line default
            #line hidden
            
            #line 80 ""
            this.Write("?");
            
            #line default
            #line hidden
            
            #line 80 ""

    }

            
            #line default
            #line hidden
            
            #line 83 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 83 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( p.Identifier ));
            
            #line default
            #line hidden
            
            #line 83 ""

    if (!p.IsRequired) {

            
            #line default
            #line hidden
            
            #line 86 ""
            this.Write(" = null");
            
            #line default
            #line hidden
            
            #line 86 ""

    }
    if (i != lastIndex) {

            
            #line default
            #line hidden
            
            #line 90 ""
            this.Write(",");
            
            #line default
            #line hidden
            
            #line 90 ""

    }
}
Write("\r\n");

            
            #line default
            #line hidden
            
            #line 95 ""
            this.Write("    )\n    {\n");
            
            #line default
            #line hidden
            
            #line 97 ""

            foreach(var p in _params)
            {
                if (p.IsRequired && p.ParameterType.Equals("string", StringComparison.OrdinalIgnoreCase)) {

            
            #line default
            #line hidden
            
            #line 102 ""
            this.Write("        if (string.IsNullOrEmpty(");
            
            #line default
            #line hidden
            
            #line 102 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( p.Identifier ));
            
            #line default
            #line hidden
            
            #line 102 ""
            this.Write("))\n            throw new ArgumentNullException(nameof(");
            
            #line default
            #line hidden
            
            #line 103 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( p.Identifier ));
            
            #line default
            #line hidden
            
            #line 103 ""
            this.Write("));\n");
            
            #line default
            #line hidden
            
            #line 104 ""

                    Write("\r\n");
                }
            }

            
            #line default
            #line hidden
            
            #line 109 ""
            this.Write("        var json = await SendGetRequestAndHandleErrorAsync(");
            
            #line default
            #line hidden
            
            #line 109 ""

Write("\r\n");

            
            #line default
            #line hidden
            
            #line 112 ""
            this.Write("            UrlBuilder.BotApiUrl(\"");
            
            #line default
            #line hidden
            
            #line 112 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _functionDeclaration.Name ));
            
            #line default
            #line hidden
            
            #line 112 ""
            this.Write("\"");
            
            #line default
            #line hidden
            
            #line 112 ""


            if (parameterCount > 0) {

            
            #line default
            #line hidden
            
            #line 116 ""
            this.Write(", x => x");
            
            #line default
            #line hidden
            
            #line 116 ""

Write("\r\n");
                foreach(var p in _params)
                {

            
            #line default
            #line hidden
            
            #line 121 ""
            this.Write("                .Add(\"");
            
            #line default
            #line hidden
            
            #line 121 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( p.JsonParameter ));
            
            #line default
            #line hidden
            
            #line 121 ""
            this.Write("\", ");
            
            #line default
            #line hidden
            
            #line 121 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( p.Identifier ));
            
            #line default
            #line hidden
            
            #line 121 ""
            this.Write(")");
            
            #line default
            #line hidden
            
            #line 121 ""

                    Write("\r\n");
                }
Write("\r\n                ");
            }

            
            #line default
            #line hidden
            
            #line 127 ""
            this.Write(")\n        );\n\n        return DeserializeTelegramResponse<");
            
            #line default
            #line hidden
            
            #line 130 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _functionDeclaration.ResultType ));
            
            #line default
            #line hidden
            
            #line 130 ""
            this.Write(">(json);\n    }");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CSharpMethodDeclarationNRealizationCodeBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
