#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VoucherCancellationForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Finance.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Finance.VoucherCancellation")]
    [BasedOnRow(typeof(Entities.VoucherCancellationRow))]
    public class VoucherCancellationForm
    {
        public String RefNo { get; set; }
        public DateTime PostedDate { get; set; }
        public String PostedBy { get; set; }
        public String Posted { get; set; }
        public String VoucherType { get; set; }
        public String VoucherNo { get; set; }
        public DateTime TranDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Particulars { get; set; }
    }
}