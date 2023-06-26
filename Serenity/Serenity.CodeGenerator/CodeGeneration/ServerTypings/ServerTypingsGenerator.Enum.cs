using Serenity.ComponentModel;
using System;
using System.Collections;
using System.ComponentModel;

#if COREFX
using System.Reflection;
#endif

namespace Serenity.CodeGeneration
{
    public partial class ServerTypingsGenerator : ServerImportGeneratorBase
    {
        private void GenerateEnum(Type enumType)
        {
            var codeNamespace = GetNamespace(enumType);
            var enumKey = EnumMapper.GetEnumTypeKey(enumType);

            cw.Indented("export enum ");
            var identifier = MakeFriendlyName(enumType, codeNamespace);
            generatedTypes.Add((codeNamespace.IsEmptyOrNull() ? "" : codeNamespace + ".") + identifier);

            cw.InBrace(delegate
            {
                var names = Enum.GetNames(enumType);
                var values = (IList)Enum.GetValues(enumType);

                var inserted = 0;
                for (var i = 0; i < names.Length; i++)
                {
                    var name = names[i];

                    var member = enumType.GetMember(name);
                    if (member != null && member.Length > 0 &&
                        member[0].GetAttribute<IgnoreAttribute>(false) != null)
                        continue;

                    if (inserted > 0)
                        sb.AppendLine(",");

                    cw.Indented(name);
                    sb.Append(" = ");
                    sb.Append(Convert.ToInt32(values[i]));
                    inserted++;
                }

                sb.AppendLine();
            });

            sb.AppendLine();

            //2018/02/14 add option dictionary 
            cw.Indented(string.Format("export class {0} ", identifier + "Option"));
            cw.InBrace(delegate
            {
                string typeDeclaration = "Mapping: KeyedCollection<string>;";
                string ctor = "constructor() {";
                string initialize = "this.Mapping =new KeyedCollection<string>();";

                cw.Indented(typeDeclaration);
                sb.AppendLine();
                cw.Indented(ctor);
                sb.AppendLine();
                cw.Indented(initialize);
                sb.AppendLine();

                var names = Enum.GetNames(enumType);
                var values = (IList)Enum.GetValues(enumType);

                var inserted = 0;
                for (var i = 0; i < names.Length; i++)
                {
                    var name = names[i];

                    var member = enumType.GetMember(name);
                    if (member != null && member.Length > 0 &&
                        member[0].GetAttribute<IgnoreAttribute>(false) != null)
                        continue;

                    if (inserted > 0)
                        sb.AppendLine(",");

                    string description = string.Empty;
                    var attri = member[0].GetAttribute<DescriptionAttribute>(false);
                    if (attri != null && !string.IsNullOrWhiteSpace(attri.Description))
                        description = attri.Description;
                    else
                        description = name;
                    string declar = "this.Mapping.Add(\"{0}\", \"{1}\");   //{2}";
                    string code = string.Format(declar, (char)Convert.ToInt32(values[i]), description, Convert.ToInt32(values[i]));
                    cw.Indented(code);
                    inserted++;
                }
                
                sb.AppendLine();
                cw.Indented("}");
                sb.AppendLine();

            });
            //Enterprise Solution

            sb.AppendLine();
            cw.Indented("Serenity.Decorators.registerEnum(");
            sb.Append(enumType.Name);
            sb.Append(", '");
            sb.Append(enumKey);
            sb.AppendLine("');");

            //2018/02/11 add trace
            //System.Diagnostics.Debug.WriteLine(enumType.Name);
            //System.Diagnostics.Trace.WriteLine(initializer.ToString());
            //Enterprise Solution
        }
    }
}