#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PeriodicVoucherScheduleColumns.cs
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

    [ColumnsScript("Finance.PeriodicVoucherSchedule")]
    [BasedOnRow(typeof(Entities.PeriodicVoucherScheduleRow))]
    public class PeriodicVoucherScheduleColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String EntryKeyDescription { get; set; }
        public String Period { get; set; }
        public String Suspended { get; set; }
        public String VoucherNo { get; set; }
        public DateTime VoucherDate { get; set; }
        public Decimal ExchRate { get; set; }
        public Decimal DebitTotal { get; set; }
        public Decimal CreditTotal { get; set; }
        public DateTime SourceDate { get; set; }
        public String SourceBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
    }
}