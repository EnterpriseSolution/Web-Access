#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VoucherColumns.cs
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

    [ColumnsScript("Finance.Voucher")]
    [BasedOnRow(typeof(Entities.VoucherRow))]
    public class VoucherColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String VoucherNo { get; set; }

        public String VoucherType { get; set; }
        //public String Posted { get; set; }
        //public String Hold { get; set; }
        public DateTime VoucherDate { get; set; }
        public String Period { get; set; }
        //public Decimal FiscalYear { get; set; }
        //public Decimal PeriodNo { get; set; }
        public String Reference { get; set; }
        //public Decimal LastLineNo { get; set; }
        //public Decimal LineCount { get; set; }
        public String SourceType { get; set; }
        public String SourceRef { get; set; }
        public Decimal TotalDebit { get; set; }
        public Decimal TotalCredit { get; set; }

        public String Remark { get; set; }

        //public Decimal Balance { get; set; }
        //public String BalanceSign { get; set; }
        //public Decimal JournalNo { get; set; }

        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
        //public String BatchSelect { get; set; }
        //public String LocalCcyOnly { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String PostedBy { get; set; }
        //public DateTime PostedDate { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        //public String Particulars { get; set; }
        //public String AiLink { get; set; }
        //public String AiLinkType { get; set; }
        //public String AiLinkNo { get; set; }
        //public String Anlys7 { get; set; }
        //public String Anlys8 { get; set; }
        //public DateTime ExportedDate { get; set; }
        //public Decimal Fserialno { get; set; }
        //public Decimal Fnum { get; set; }
        //public Decimal RoundNo { get; set; }
        //public String NewVoucherNo { get; set; }
        //public String Fgroup { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }
        //public String Anlys11 { get; set; }
        //public String Anlys12 { get; set; }
        //public String Anlys13 { get; set; }
        //public String Anlys14 { get; set; }
        //public Boolean ManualEdited { get; set; }
        //
    }
}