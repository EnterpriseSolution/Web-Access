#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LookupDialogFilterColumns.cs
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

    [ColumnsScript("Administration.LookupDialogFilter")]
    [BasedOnRow(typeof(Entities.LookupDialogFilterRow))]
    public class LookupDialogFilterColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String LookupNameDescription { get; set; }
        public String FilterName { get; set; }
        public String Description { get; set; }
        public String Filter { get; set; }
    }
}