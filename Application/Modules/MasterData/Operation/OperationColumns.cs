#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  OperationColumns.cs
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

    [ColumnsScript("MasterData.Operation")]
    [BasedOnRow(typeof(Entities.OperationRow))]
    public class OperationColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String OpCode { get; set; }
        public String Description { get; set; }
        public bool Suspended { get; set; }
        public String Specifications { get; set; }

        //public String TicketIssued { get; set; }
        //public String ReportRequired { get; set; }
        public String OperType { get; set; }
        public String ProdnMode { get; set; }
        public String WorkCentre { get; set; }
        public String FixedWctr { get; set; }
        //public Decimal MinLotSize { get; set; }
        //public Decimal StdLotSize { get; set; }
        //public Decimal DirectLabor { get; set; }
        //public Decimal MachLoadHr { get; set; }
        //public Decimal ManLoadHr { get; set; }
        //public Decimal MachProcessHr { get; set; }
        //public Decimal ManProcessHr { get; set; }
        //public Decimal MachUnloadHr { get; set; }
        //public Decimal ManUnloadHr { get; set; }
        //public Decimal MachineCost { get; set; }
        //public Decimal EnergyCost { get; set; }
        //public Decimal WaterCost { get; set; }
        //public Decimal RentalCost { get; set; }
        //public Decimal LaborCost { get; set; }
        //public Decimal InlabCost { get; set; }
        //public Decimal InmatCost { get; set; }
        //public Decimal MiscCost { get; set; }
        //public Decimal SubconCost { get; set; }
        //public String SubconVendor { get; set; }
        //public Decimal PieceRate { get; set; }
        //public String AcctMachine { get; set; }
        //public String AcctEnergy { get; set; }
        //public String AcctWater { get; set; }
        //public String AcctRental { get; set; }
        //public String AcctLabor { get; set; }
        //public String AcctInlab { get; set; }
        //public String AcctInmat { get; set; }
        //public String AcctMisc { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime BrevisedDate { get; set; }
        //public String BrevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
    }
}