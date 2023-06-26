#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PanelColumns.cs
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

    [ColumnsScript("MasterData.Panel")]
    [BasedOnRow(typeof(Entities.PanelRow))]
    public class PanelColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Int32 Recnum { get; set; }
        [EditLink]
        public String PanelCode { get; set; }
        public String Description { get; set; }
        public Decimal Length { get; set; }
        public Decimal Width { get; set; }
        public String DimUom { get; set; }
        public bool Suspended { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        public String ItemGroup { get; set; }
    }
}