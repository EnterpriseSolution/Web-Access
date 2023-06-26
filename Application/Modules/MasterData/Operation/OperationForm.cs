#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  OperationForm.cs
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

    [FormScript("MasterData.Operation")]
    [BasedOnRow(typeof(Entities.OperationRow))]
    public class OperationForm
    {
        [Tab(TabName.GeneralInformation)]
        [Category(CategoryName.BasicInformation)]
        public String OpCode { get; set; }
        public String Description { get; set; }
        public Boolean Suspended { get; set; }
        public Boolean TicketIssued { get; set; }
        public Boolean ReportRequired { get; set; }

        public String OperType { get; set; }
        public String ProdnMode { get; set; }
        public String WorkCentre { get; set; }
        public String FixedWctr { get; set; }
        public Decimal MinLotSize { get; set; }
        public Decimal StdLotSize { get; set; }
        public Decimal DirectLabor { get; set; }
        public String SubconVendor { get; set; }
        public Decimal PieceRate { get; set; }

        [TextAreaEditor(Rows = 4)]
        public String Specifications { get; set; }

        [Category(CategoryName.ManLoadHr)]
        public Decimal ManLoadHr { get; set; }
        public Decimal ManProcessHr { get; set; }
        public Decimal ManUnloadHr { get; set; }

        [Category(CategoryName.MachineHr)]
        public Decimal MachLoadHr { get; set; }
        public Decimal MachProcessHr { get; set; }
        public Decimal MachUnloadHr { get; set; }

        [Tab(TabName.Costing)]
        [Category(CategoryName.Account)]
        public String AcctMachine { get; set; }
        public String AcctEnergy { get; set; }
        public String AcctWater { get; set; }
        public String AcctRental { get; set; }
        public String AcctLabor { get; set; }
        public String AcctInlab { get; set; }
        public String AcctInmat { get; set; }
        public String AcctMisc { get; set; }

        [Category(CategoryName.Costing)]
        public Decimal MachineCost { get; set; }
        public Decimal EnergyCost { get; set; }
        public Decimal WaterCost { get; set; }
        public Decimal RentalCost { get; set; }
        public Decimal LaborCost { get; set; }
        public Decimal InlabCost { get; set; }
        public Decimal InmatCost { get; set; }
        public Decimal MiscCost { get; set; }
        public Decimal SubconCost { get; set; }

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