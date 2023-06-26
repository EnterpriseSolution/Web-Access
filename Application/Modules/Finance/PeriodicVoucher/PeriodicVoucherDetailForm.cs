#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PeriodicVoucherDetailForm.cs
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

    [FormScript("Finance.PeriodicVoucherDetail")]
    [BasedOnRow(typeof(Entities.PeriodicVoucherDetailRow))]
    public class PeriodicVoucherDetailForm
    {
        public String EntryKey { get; set; }
        public Decimal LineNo { get; set; }
        public String AcctNo { get; set; }
        public String AcctName { get; set; }
        public String BranchNo { get; set; }
        public String CostCentre { get; set; }
        public String Dept { get; set; }
        public String LineRef { get; set; }
        public Decimal DebitAmt { get; set; }
        public Decimal CreditAmt { get; set; }
        public String Anlys1 { get; set; }
        public String Anlys2 { get; set; }
        public String Anlys3 { get; set; }
        public String Anlys4 { get; set; }
        public String Anlys5 { get; set; }
        public String Anlys6 { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
        public String Particulars { get; set; }
        public String Anlys15 { get; set; }
        public String Anlys16 { get; set; }
        public String Anlys17 { get; set; }
        public String Anlys18 { get; set; }
        public String Anlys19 { get; set; }
        public String Anlys20 { get; set; }
    }
}