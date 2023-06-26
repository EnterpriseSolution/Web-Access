#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PeriodicVoucherColumns.cs
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

    [ColumnsScript("Finance.PeriodicVoucher")]
    [BasedOnRow(typeof(Entities.PeriodicVoucherRow))]
    public class PeriodicVoucherColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String EntryKey { get; set; }
        public String Description { get; set; }
        public String VoucherType { get; set; }
        public String SeriesCode { get; set; }
        public String Ccy { get; set; }
        public bool Suspended { get; set; }

        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }

        //public Decimal LastLineNo { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
      
        public Decimal TotalDebit { get; set; }
        public Decimal TotalCredit { get; set; }

        public String Particulars { get; set; }
        public String Reference { get; set; }

        //public String Anlys7 { get; set; }
        //public String Anlys8 { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }
        //public String Anlys11 { get; set; }
        //public String Anlys12 { get; set; }
        //public String Anlys13 { get; set; }
        //public String Anlys14 { get; set; }
    }
}