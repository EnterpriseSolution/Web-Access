#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  TranslationForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Common;
using Microsoft.Enums;

namespace Matrix.Administration.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Administration.Translation")]
    [BasedOnRow(typeof(Entities.TranslationRow))]
    public class TranslationForm
    {
        [EnumSelectFormatter(EnumKey = "Enum.TranslationFormTranslationLanguage", AllowClear = false)]
        public TranslationLanguage LanguageCode { get; set; }

        public String KeyText { get; set; }
        
        public String DisplayText { get; set; }
    }
}