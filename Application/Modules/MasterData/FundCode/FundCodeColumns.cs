#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  FundCodeColumns.cs
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

    [ColumnsScript("MasterData.FundCode")]
    [BasedOnRow(typeof(Entities.FundCodeRow))]
    public class FundCodeColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String FundCode { get; set; }
        public String Description { get; set; }
        //public String RcptSuspended { get; set; }
        //public String PmntSuspended { get; set; }
        public String DefaultCcy { get; set; }
        public bool FixedCurrency { get; set; }
        //public String IsBankAcct { get; set; }
        //public String IsCurrAcct { get; set; }
        public String BankAcctNo { get; set; }
        public String AcctCash { get; set; }

        //public Decimal NextChequeNo { get; set; }

        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
    }
}