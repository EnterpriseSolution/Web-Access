#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  FiscalPeriodForm.cs
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

    [FormScript("MasterData.FiscalPeriod")]
    [BasedOnRow(typeof(Entities.FiscalPeriodRow))]
    public class FiscalPeriodForm
    {
        public Decimal FiscalYear { get; set; }
        public Decimal PeriodNo { get; set; }
        public String Period { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String AllowEntries { get; set; }
        public String ClosedSl { get; set; }
        public String ClosedPu { get; set; }
        public String ClosedPr { get; set; }
        public String ClosedIc { get; set; }
        public String ClosedAr { get; set; }
        public String ClosedAp { get; set; }
        public String ClosedGl { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
        public DateTime ClosedDate { get; set; }
        public String ClosedBy { get; set; }
        public Decimal BalBeg { get; set; }
        public String BalBegSign { get; set; }
        public Decimal TotalDebit { get; set; }
        public Decimal TotalCredit { get; set; }
        public Decimal BalEnd { get; set; }
        public String BalEndSign { get; set; }
        public Decimal ArBalBeg { get; set; }
        public Decimal ArInvoAmt { get; set; }
        public Decimal ArMemoAmt { get; set; }
        public Decimal ArAdjAmt { get; set; }
        public Decimal ArPayAmt { get; set; }
        public Decimal ArBalEnd { get; set; }
        public Decimal ApBalBeg { get; set; }
        public Decimal ApInvoAmt { get; set; }
        public Decimal ApMemoAmt { get; set; }
        public Decimal ApAdjAmt { get; set; }
        public Decimal ApPayAmt { get; set; }
        public Decimal ApBalEnd { get; set; }
        public String ActiveGl { get; set; }
        public String ActiveAp { get; set; }
        public String ActiveAr { get; set; }
        public String ActiveIc { get; set; }
        public String ActivePr { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
        public Decimal ArDiscAmt { get; set; }
        public Decimal ArDiffAmt { get; set; }
        public Decimal ApDiscAmt { get; set; }
        public Decimal ApDiffAmt { get; set; }
        public Decimal ApRfdAmt { get; set; }
        public Decimal ArRfdAmt { get; set; }
    }
}