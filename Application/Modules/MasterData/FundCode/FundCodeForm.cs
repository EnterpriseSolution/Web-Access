#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  FundCodeForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Common.Enum;

namespace Matrix.MasterData.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MasterData.FundCode")]
    [BasedOnRow(typeof(Entities.FundCodeRow))]
    public class FundCodeForm
    {
        public String FundCode { get; set; }
        public String Description { get; set; }

      
        public String DefaultCcy { get; set; }

        [DisplayName("Ledger Account No.")]
        public String AcctCash { get; set; }

        [Category(CategoryName.Control)]
        [DisplayName("Receipts Suspended")]
        public bool RcptSuspended { get; set; }

        [DisplayName("Disbursements Suspended")]
        public bool PmntSuspended { get; set; }

        public bool FixedCurrency { get; set; }

        [DisplayName("Bank Account")]
        public bool IsBankAcct { get; set; }
        [DisplayName("Current Account")]
        public bool IsCurrAcct { get; set; }

        [Category(CategoryName.CurrentAccountDetail)]
        public String BankAcctNo { get; set; }
        public Decimal NextChequeNo { get; set; }


        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
    }
}