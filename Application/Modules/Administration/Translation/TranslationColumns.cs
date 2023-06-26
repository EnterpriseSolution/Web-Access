#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  TranslationColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Administration.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Administration.Translation")]
    [BasedOnRow(typeof(Entities.TranslationRow))]
    public class TranslationColumns
    {
        [Width(400),EditLink]
        public String KeyText { get; set; }

        //[Width(Int32.MaxValue)]
        [Width(600)]
        public String DisplayText { get; set; }
    }
}