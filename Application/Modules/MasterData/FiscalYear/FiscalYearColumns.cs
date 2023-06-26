#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  FiscalYearColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MasterData.FiscalYear")]
    [BasedOnRow(typeof(Entities.FiscalYearRow))]
    public class FiscalYearColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [AlignRight]
        public Decimal FiscalYear { get; set; }
        
        public String AllowEntries { get; set; }
        public String Closed { get; set; }
        public Decimal LastPeriod { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime ClosedDate { get; set; }
        //public String ClosedBy { get; set; }
        public Decimal YtdPlCredit { get; set; }
        public Decimal YtdPlDebit { get; set; }
        public Decimal YtdPlNet { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
    }
}