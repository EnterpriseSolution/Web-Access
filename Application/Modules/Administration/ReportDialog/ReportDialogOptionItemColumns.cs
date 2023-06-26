#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ReportDialogOptionItemColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.EnterpriseSys.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("EnterpriseSys.ReportDialogOptionItem")]
    [BasedOnRow(typeof(Entities.ReportDialogOptionItemRow))]
    public class ReportDialogOptionItemColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public String ReportId { get; set; }
        public Int32 OptionNo { get; set; }
        public Int32 EntryNo { get; set; }
        public String Caption { get; set; }
        public String Value { get; set; }
    }
}