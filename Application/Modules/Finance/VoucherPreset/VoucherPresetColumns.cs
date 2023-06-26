#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VoucherPresetColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Finance.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Finance.VoucherPreset")]
    [BasedOnRow(typeof(Entities.VoucherPresetRow))]
    public class VoucherPresetColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String VoucherType { get; set; }
        [AlignRight]
        public Decimal SeqNo { get; set; }
        public String AcctNo { get; set; }
        public String Ccy { get; set; }
        [AlignRight]
        public Decimal ExchRate { get; set; }
        [AlignRight]
        public Decimal DebitAmt { get; set; }
        [AlignRight]
        public Decimal CreditAmt { get; set; }
        [AlignRight]
        public Decimal BaseLineNo { get; set; }
        public String BaseEntry { get; set; }
        [AlignRight]
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
        public String Particulars { get; set; }
    }
}