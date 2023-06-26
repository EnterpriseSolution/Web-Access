#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  MoldColumns.cs
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

    [ColumnsScript("MasterData.Mold")]
    [BasedOnRow(typeof(Entities.MoldRow))]
    public class MoldColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String MoldNo { get; set; }
        public String Description { get; set; }
        public Int32 TotalSet { get; set; }
        public Int32 StdOutput { get; set; }
        public String Suspended { get; set; }
        public Decimal Length { get; set; }
        public Decimal Width { get; set; }
        public Decimal Thickness { get; set; }
        public Decimal Weight { get; set; }
        public Decimal SetWeight { get; set; }
        public Decimal Shrink { get; set; }
        public Decimal ShotSize { get; set; }
        public String CavityFinish { get; set; }
        public Decimal TempCtrlZone { get; set; }
        public Decimal WtrFlowA { get; set; }
        public Decimal WtrFlowB { get; set; }
        public String Qmc { get; set; }
        public String HyCores { get; set; }
        public Decimal MoldCost { get; set; }
        public String EjectorRtn { get; set; }
        public String Remarks { get; set; }
        public String PictureFile { get; set; }
        public Int32 CavSets { get; set; }
        public Int32 CavSqInch { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        public Decimal LifeTime { get; set; }
        public Decimal JobQty { get; set; }
        public Decimal FinQty { get; set; }
        public Decimal BalQty { get; set; }
        public Decimal RepQty { get; set; }
    }
}