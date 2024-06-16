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
    
    
    public partial class CSharpJsonModelCode : CSharpJsonModelCodeBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 7 ""
            this.Write("\nusing System.Text.Json.Serialization;\n\nnamespace /*namespace*/.Models;\n\n");
            
            #line default
            #line hidden
            
            #line 12 ""

var modelDescriptionLines = _modelDeclaration.Description.SplitText(108);

            
            #line default
            #line hidden
            
            #line 15 ""
            this.Write("/// <summary>\n");
            
            #line default
            #line hidden
            
            #line 16 ""

for (var i=0; i < modelDescriptionLines.Count; i++)
{

            
            #line default
            #line hidden
            
            #line 20 ""
            this.Write("/// ");
            
            #line default
            #line hidden
            
            #line 20 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( modelDescriptionLines[i] ));
            
            #line default
            #line hidden
            
            #line 20 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 21 ""

}

            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write("/// </summary>\npublic class ");
            
            #line default
            #line hidden
            
            #line 25 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( _modelDeclaration.Identifier ));
            
            #line default
            #line hidden
            
            #line 25 ""
            this.Write("\n{\n");
            
            #line default
            #line hidden
            
            #line 27 ""

var parameterCount = _modelDeclaration.Properties.Count;
var lastIndex = parameterCount - 1;

for (var i=0; i<parameterCount; i++)
{
    var p = _modelDeclaration.Properties[i];

    var propertyDescriptionLines = p.Description.SplitText(104);


            
            #line default
            #line hidden
            
            #line 38 ""
            this.Write("    /// <summary>\n");
            
            #line default
            #line hidden
            
            #line 39 ""

for (var j=0; j < propertyDescriptionLines.Count; j++)
{

            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write("    /// ");
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( propertyDescriptionLines[j] ));
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 44 ""

}

            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write("    /// </summary>\n    [JsonPropertyName(\"");
            
            #line default
            #line hidden
            
            #line 48 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( p.JsonProperty ));
            
            #line default
            #line hidden
            
            #line 48 ""
            this.Write("\")]\n    public ");
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( p.PropertyType ));
            
            #line default
            #line hidden
            
            #line 49 ""


    if (!p.IsRequired) {
        Write("?");
    }

            
            #line default
            #line hidden
            
            #line 55 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 55 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( p.Identifier ));
            
            #line default
            #line hidden
            
            #line 55 ""
            this.Write(" { get; set; }");
            
            #line default
            #line hidden
            
            #line 55 ""

    Write("\r\n");
    if (i != lastIndex) {
        Write("\r\n");
    }
}

            
            #line default
            #line hidden
            
            #line 62 ""
            this.Write("}\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CSharpJsonModelCodeBase {
        
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
