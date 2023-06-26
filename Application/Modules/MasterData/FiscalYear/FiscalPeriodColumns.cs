#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  FiscalPeriodColumns.cs
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

    [ColumnsScript("MasterData.FiscalPeriod")]
    [BasedOnRow(typeof(Entities.FiscalPeriodRow))]
    public class FiscalPeriodColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
       
        [AlignRight]
        public Decimal PeriodNo { get; set; }
        [EditLink]
        public String Period { get; set; }
        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool AllowEntries { get; set; }

        [DisplayName("Sales")]
        public bool ClosedSl { get; set; }
        [DisplayName("Purchase")]
        public bool ClosedPu { get; set; }
        [DisplayName("Production")]
        public bool ClosedPr { get; set; }
        [DisplayName("Inventory")]
        public bool ClosedIc { get; set; }
        [DisplayName("Account Receivable")]
        public bool ClosedAr { get; set; }
        [DisplayName("Account Payable")]
        public bool ClosedAp { get; set; }
        [DisplayName("General Ledger")]
        public bool ClosedGl { get; set; }

        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime ClosedDate { get; set; }
        //public String ClosedBy { get; set; }
        //public Decimal BalBeg { get; set; }
        //public String BalBegSign { get; set; }
        //public Decimal TotalDebit { get; set; }
        //public Decimal TotalCredit { get; set; }
        //public Decimal BalEnd { get; set; }
        //public String BalEndSign { get; set; }
        //public Decimal ArBalBeg { get; set; }
        //public Decimal ArInvoAmt { get; set; }
        //public Decimal ArMemoAmt { get; set; }
        //public Decimal ArAdjAmt { get; set; }
        //public Decimal ArPayAmt { get; set; }
        //public Decimal ArBalEnd { get; set; }
        //public Decimal ApBalBeg { get; set; }
        //public Decimal ApInvoAmt { get; set; }
        //public Decimal ApMemoAmt { get; set; }
        //public Decimal ApAdjAmt { get; set; }
        //public Decimal ApPayAmt { get; set; }
        //public Decimal ApBalEnd { get; set; }
        //public String ActiveGl { get; set; }
        //public String ActiveAp { get; set; }
        //public String ActiveAr { get; set; }
        //public String ActiveIc { get; set; }
        //public String ActivePr { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        //public Decimal ArDiscAmt { get; set; }
        //public Decimal ArDiffAmt { get; set; }
        //public Decimal ApDiscAmt { get; set; }
        //public Decimal ApDiffAmt { get; set; }
        //public Decimal ApRfdAmt { get; set; }
        //public Decimal ArRfdAmt { get; set; }
    }
}