#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ChargeTypeColumns.cs
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

    [ColumnsScript("MasterData.ChargeType")]
    [BasedOnRow(typeof(Entities.ChargeTypeRow))]
    public class ChargeTypeColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String ChargeType { get; set; }
        public String Description { get; set; }
        public String Suspended { get; set; }
        public String Deduction { get; set; }
        public String UseInSales { get; set; }
        public String UseInPurchase { get; set; }
        public String SlsAcctNo { get; set; }
        public String PurAcctNo { get; set; }
        public String FixedRate { get; set; }
        public String FixedBasis { get; set; }
        public Decimal FixedPercent { get; set; }
        public Decimal FixedAmt { get; set; }
        public String Step01 { get; set; }
        public String Oper01 { get; set; }
        public String Step02 { get; set; }
        public String Oper02 { get; set; }
        public String Step03 { get; set; }
        public String Oper03 { get; set; }
        public String Step04 { get; set; }
        public String Oper04 { get; set; }
        public String Step05 { get; set; }
        public String Oper05 { get; set; }
        public String Step06 { get; set; }
        public String Oper06 { get; set; }
        public String Step07 { get; set; }
        public String Oper07 { get; set; }
        public String Step08 { get; set; }
        public String Oper08 { get; set; }
        public String Step09 { get; set; }
        public String Oper09 { get; set; }
        public String Step10 { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
        public String UseInProduction { get; set; }
        public String ProdAcctNo { get; set; }
    }
}