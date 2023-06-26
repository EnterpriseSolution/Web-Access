#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VoucherTypeForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MasterData.VoucherType")]
    [BasedOnRow(typeof(Entities.VoucherTypeRow))]
    public class VoucherTypeForm
    {
        public String VoucherType { get; set; }
        public String Description { get; set; }
        public String Suspended { get; set; }
        public String DirectEntry { get; set; }
        public String AllowEdit { get; set; }
        public String MultiCurrency { get; set; }
        public String BatchedPosting { get; set; }
        public String CostCtrOpt { get; set; }
        public String DeptOpt { get; set; }
        public String Anlys1Opt { get; set; }
        public String Anlys2Opt { get; set; }
        public String Anlys3DrOpt { get; set; }
        public String Anlys4DrOpt { get; set; }
        public String Anlys5DrOpt { get; set; }
        public String Anlys6DrOpt { get; set; }
        public String Anlys3CrOpt { get; set; }
        public String Anlys4CrOpt { get; set; }
        public String Anlys5CrOpt { get; set; }
        public String Anlys6CrOpt { get; set; }
        public String SeriesCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
        public Decimal BatchCount { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
        public String Remarks { get; set; }
        public String Anlys7Opt { get; set; }
        public String Anlys8Opt { get; set; }
        public String Anlys9Opt { get; set; }
        public String Anlys10Opt { get; set; }
        public String Anlys11Opt { get; set; }
        public String Anlys12Opt { get; set; }
        public String Anlys13Opt { get; set; }
        public String Anlys14Opt { get; set; }
        public String Anlys15DrOpt { get; set; }
        public String Anlys16DrOpt { get; set; }
        public String Anlys17DrOpt { get; set; }
        public String Anlys18DrOpt { get; set; }
        public String Anlys19DrOpt { get; set; }
        public String Anlys20DrOpt { get; set; }
        public String Anlys15CrOpt { get; set; }
        public String Anlys16CrOpt { get; set; }
        public String Anlys17CrOpt { get; set; }
        public String Anlys18CrOpt { get; set; }
        public String Anlys19CrOpt { get; set; }
        public String Anlys20CrOpt { get; set; }
    }
}