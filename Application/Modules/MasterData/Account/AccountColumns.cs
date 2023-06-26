#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountColumns.cs
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

    [ColumnsScript("MasterData.Account")]
    [BasedOnRow(typeof(Entities.AccountRow))]
    public class AccountColumns
    {
       // [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
       // public Decimal Recnum { get; set; }
        [EditLink]
        public String AcctNo { get; set; }
        public String AcctName { get; set; }

       // public String AltAcctNo { get; set; }
        //public String NormalSign { get; set; }
        public bool TypeBs { get; set; }
        public bool TypePl { get; set; }

        //public String TypeDebtor { get; set; }
        //public String TypeCreditor { get; set; }
       // public String TypeMemo { get; set; }
        public String DefaultCcy { get; set; }
        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
        //public String Anlys3 { get; set; }
        //public String Anlys4 { get; set; }
        //public String Suspended { get; set; }
        //public String FixedCurrency { get; set; }
        //public String AutoDist { get; set; }
        //public String BudgetControl { get; set; }
        //public String SupprAnlys3 { get; set; }
        //public String SupprAnlys4 { get; set; }
        //public String SupprAnlys5 { get; set; }
        //public String SupprAnlys6 { get; set; }
        //public String SupprReval { get; set; }
        //public String NoCostCentre { get; set; }
        //public String NoDept { get; set; }
        //public String Oper1 { get; set; }
        //public String Oper2 { get; set; }
        //public String Oper3 { get; set; }
        //public String Oper4 { get; set; }
        //public String Oper5 { get; set; }
        //public Decimal LinesBefPrint { get; set; }
        //public String TranAcct { get; set; }
        //public String SummaryPos { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime ReconLastDate { get; set; }
        //public Decimal ReconLastJrn { get; set; }
        //public Decimal ReconBal { get; set; }
        //public String ReconBalSign { get; set; }
        //public DateTime LastTranDate { get; set; }
        //public Decimal LastJrnNo { get; set; }
        //public Decimal DistTotalPct { get; set; }
        //public Decimal DistLastLine { get; set; }
        //public Decimal ReconCount { get; set; }
        //public Decimal BalanceEnd { get; set; }
        //public String BalanceSign { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        //public String AllowEdit { get; set; }
        //public String Anlys5 { get; set; }
        //public String Anlys6 { get; set; }
        //public String Anlys7 { get; set; }
        //public String Anlys8 { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }
    }
}