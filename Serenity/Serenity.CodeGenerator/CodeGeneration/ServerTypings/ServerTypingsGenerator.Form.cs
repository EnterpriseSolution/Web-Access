﻿using Serenity.ComponentModel;
using Serenity.Services;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Serenity.CodeGeneration
{
    public partial class ServerTypingsGenerator : ServerImportGeneratorBase
    {
        const string requestSuffix = "Request";

        private void GenerateForm(Type type, FormScriptAttribute formScriptAttribute)
        {
            var codeNamespace = GetNamespace(type);

            cw.Indented("export class ");

            var identifier = type.Name;
            if (identifier.EndsWith(requestSuffix) &&
                type.IsSubclassOf(typeof(ServiceRequest)))
            {
                identifier = identifier.Substring(0,
                    identifier.Length - requestSuffix.Length) + "Form";
                this.fileIdentifier = identifier;
            }

            sb.Append(identifier);

            generatedTypes.Add((codeNamespace.IsEmptyOrNull() ? "" : codeNamespace + ".") + identifier);

            sb.Append(" extends Serenity.PrefixedContext");
            cw.InBrace(delegate
            {
                cw.Indented("static formKey = '");
                sb.Append(formScriptAttribute.Key);
                sb.AppendLine("';");
                sb.AppendLine();
            });

            sb.AppendLine();

            cw.Indented("export interface ");
            sb.Append(identifier);

            StringBuilder initializer = new StringBuilder("[");

            cw.InBrace(delegate
            {
                int j = 0;
                foreach (var item in Serenity.PropertyGrid.PropertyItemHelper.GetPropertyItemsFor(type))
                {
                    var editorType = item.EditorType ?? "String";

                    ExternalType scriptType = null;

                    foreach (var rootNamespace in RootNamespaces)
                    {
                        string wn = rootNamespace + "." + editorType;
                        if ((scriptType = (GetScriptType(wn) ?? GetScriptType(wn + "Editor"))) != null)
                            break;
                    }

                    if (scriptType == null &&
                        (scriptType = (GetScriptType(editorType) ?? GetScriptType(editorType + "Editor"))) == null)
                        continue;

                    var fullName = ShortenFullName(scriptType, codeNamespace);

                    if (j++ > 0)
                        initializer.Append("   , ");
                    
                    initializer.Append("['");
                    initializer.Append(item.Name);
                    initializer.Append("', () => ");
                    initializer.Append(fullName);
                    //initializer.Append("]");
                    initializer.AppendLine("]");

                    cw.Indented(item.Name);
                    sb.Append(": ");
                    sb.Append(fullName);
                    sb.AppendLine(";");
                }
            });

            initializer.Append("].forEach(x => Object.defineProperty(");
            initializer.Append(identifier);
            initializer.Append(".prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));");

            sb.AppendLine();
            cw.IndentedLine(initializer.ToString());

            //System.Diagnostics.Debug.WriteLine(initializer.ToString());
            //System.Diagnostics.Trace.WriteLine(initializer.ToString());

            //OutputDebugString("Write this to Output window in VS14.");
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern void OutputDebugString(string message);
    }
}