#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PayTermColumns.cs
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

    [ColumnsScript("MasterData.PayTerm")]
    [BasedOnRow(typeof(Entities.PayTermRow))]
    public class PayTermColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String PayTerms { get; set; }
        public String Description { get; set; }
        public bool Suspended { get; set; }

        //public String BaseDate { get; set; }
        //public Decimal DueDays { get; set; }
        //public Decimal DiscDays { get; set; }
        //public Decimal DiscPercent { get; set; }
        //public String AdjustCrlimit { get; set; }
        //public Decimal MinDueDays { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        //public String Phase1PayTerms { get; set; }
        //public String Phase1BaseDate { get; set; }
        //public Decimal Phase1DueDays { get; set; }
        //public Decimal Phase1PayPercent { get; set; }

        //public String Phase2PayTerms { get; set; }
        //public String Phase2BaseDate { get; set; }
        //public Decimal Phase2DueDays { get; set; }
        //public Decimal Phase2PayPercent { get; set; }

        //public String Phase3PayTerms { get; set; }
        //public String Phase3BaseDate { get; set; }
        //public Decimal Phase3DueDays { get; set; }
        //public Decimal Phase3PayPercent { get; set; }

        //public String Phase4PayTerms { get; set; }
        //public String Phase4BaseDate { get; set; }
        //public Decimal Phase4DueDays { get; set; }
        //public Decimal Phase4PayPercent { get; set; }

        //public String Phase5PayTerms { get; set; }
        //public String Phase5BaseDate { get; set; }
        //public Decimal Phase5DueDays { get; set; }
        //public Decimal Phase5PayPercent { get; set; }
    }
}