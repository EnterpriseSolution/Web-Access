#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  BalanceSheetLayoutForm.cs
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

    [FormScript("MasterData.BalanceSheetLayout")]
    [BasedOnRow(typeof(Entities.BalanceSheetLayoutRow))]
    public class BalanceSheetLayoutForm
    {
        public Decimal LineNo { get; set; }
        public String LineType { get; set; }
        public Decimal LineSkip { get; set; }
        public String Description { get; set; }
        public String AcctFrom { get; set; }
        public String AcctTo { get; set; }
        public String AcctOperator { get; set; }
        public Decimal TotalLevel { get; set; }
        public String NormalSign { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        //public String Report { get; set; }
        //public Decimal CellLineNo { get; set; }
        //public String CellValueBegin { get; set; }
        //public String CellValueEnd { get; set; }
    }
}