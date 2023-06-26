#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ExchangeRateColumns.cs
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

    [ColumnsScript("MasterData.ExchangeRate")]
    [BasedOnRow(typeof(Entities.ExchangeRateRow))]
    public class ExchangeRateColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Decimal Recnum { get; set; }
        //[EditLink]
        //public String CcyDescription { get; set; }
        [AlignRight]
        public Decimal EntryNo { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        [AlignRight]
        public Decimal ExchRate { get; set; }

        public bool Suspended { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
    }
}