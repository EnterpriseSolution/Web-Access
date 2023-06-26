#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CommodityColumns.cs
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

    [ColumnsScript("MasterData.Commodity")]
    [BasedOnRow(typeof(Entities.CommodityRow))]
    public class CommodityColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String CustomProdCode { get; set; }
        public String CustomSerialNo { get; set; }
        public String CustomProdDesc { get; set; }
        public String CustomProdNo { get; set; }
        public String CustomEng { get; set; }
        public String CustomEngNo { get; set; }
        public String CustomMeasUom { get; set; }
        public String CustomCcy { get; set; }
        [AlignRight]
        public Decimal CustomPrice { get; set; }
        public String CustomExempt { get; set; }
        [AlignRight]
        public Decimal CustomFee { get; set; }
        public String CustomRemark { get; set; }
        public bool Suspended { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
    }
}