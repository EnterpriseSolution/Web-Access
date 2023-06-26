#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VoucherPresetForm.cs
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

    [FormScript("Finance.VoucherPreset")]
    [BasedOnRow(typeof(Entities.VoucherPresetRow))]
    public class VoucherPresetForm
    {
        public String VoucherType { get; set; }
        public Decimal SeqNo { get; set; }
        public String AcctNo { get; set; }
        public String Ccy { get; set; }
        public Decimal ExchRate { get; set; }
        public Decimal DebitAmt { get; set; }
        public Decimal CreditAmt { get; set; }
        public Decimal BaseLineNo { get; set; }
        public String BaseEntry { get; set; }
        public Decimal ResultPercent { get; set; }
        public String ResultSign { get; set; }
        public String CostCentre { get; set; }
        public String Dept { get; set; }
        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
        //public String Anlys3 { get; set; }
        //public String Anlys4 { get; set; }
        //public String Anlys5 { get; set; }
        //public String Anlys6 { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Particulars { get; set; }
    }
}