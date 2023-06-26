#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LookupDialogFilterColumnDetailColumns.cs
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

    [ColumnsScript("Administration.LookupDialogFilterColumnDetail")]
    [BasedOnRow(typeof(Entities.LookupDialogFilterColumnDetailRow))]
    public class LookupDialogFilterColumnDetailColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String LookupName { get; set; }
        public String FilterName { get; set; }
        public Int32 EntryNo { get; set; }
        public String FieldName { get; set; }
    }
}