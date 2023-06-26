#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ReportDialogOptionItemForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.EnterpriseSys.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("EnterpriseSys.ReportDialogOptionItem")]
    [BasedOnRow(typeof(Entities.ReportDialogOptionItemRow))]
    public class ReportDialogOptionItemForm
    {
        public Int32 OptionNo { get; set; }
        public Int32 EntryNo { get; set; }
        public String Caption { get; set; }
        public String Value { get; set; }
    }
}