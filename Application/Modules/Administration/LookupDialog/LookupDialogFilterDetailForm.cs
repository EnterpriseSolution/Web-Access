#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LookupDialogFilterDetailForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Administration.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Administration.LookupDialogFilterDetail")]
    [BasedOnRow(typeof(Entities.LookupDialogFilterDetailRow))]
    public class LookupDialogFilterDetailForm
    {
        public String FilterName { get; set; }
        public Int32 EntryNo { get; set; }
        public String EntityName { get; set; }
        public String FieldName { get; set; }
        public String FieldValue { get; set; }
        public Int32 Operator { get; set; }
    }
}