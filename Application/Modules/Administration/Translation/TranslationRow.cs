#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  TranslationRow.cs
// Date: 2018/04/03 20:51

#endregion

using Microsoft.Enums;

namespace Matrix.Administration.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Administration"), TableName("[dbo].[Language]")]
    [DisplayName("Translation"), InstanceName("Translation"), TwoLevelCached]
    public sealed class TranslationRow : Row, INameRow
    {
        [DisplayName("Language Code"), Column("LANGUAGE_CODE"), Size(1), QuickSearch]
        public TranslationLanguage? LanguageCode
        {
            get { return (TranslationLanguage?)Convert.ToChar(Fields.LanguageCode[this]); }
            set { Fields.LanguageCode[this] =Convert.ToString(value); }
        }

        [DisplayName("Key Text"), Column("KEY_TEXT"), Size(200), PrimaryKey]
        public String KeyText
        {
            get { return Fields.KeyText[this]; }
            set { Fields.KeyText[this] = value; }
        }

        [DisplayName("Display Text"), Column("DISPLAY_TEXT"), Size(200)]
        public String DisplayText
        {
            get { return Fields.DisplayText[this]; }
            set { Fields.DisplayText[this] = value; }
        }
       
        StringField INameRow.NameField
        {
            get { return Fields.DisplayText; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TranslationRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField LanguageCode;
            public StringField KeyText;
            public StringField DisplayText;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Administration.Translation";
            }
        }
    }
}
