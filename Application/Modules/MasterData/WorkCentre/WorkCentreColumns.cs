#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  WorkCentreColumns.cs
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

    [ColumnsScript("MasterData.WorkCentre")]
    [BasedOnRow(typeof(Entities.WorkCentreRow))]
    public class WorkCentreColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String WorkCentre { get; set; }
        public String Description { get; set; }
        public bool Suspended { get; set; }
        public bool Critical { get; set; }

        [AlignRight]
        public Decimal NoOfPersons { get; set; }
        [AlignRight]
        public Decimal NoOfShifts { get; set; }

        public String CapacityUnit { get; set; }

        //public String BranchNo { get; set; }
        //public Decimal FirstSetupHr { get; set; }
        //public Decimal FirstCleanHr { get; set; }
        //public Decimal OtherSetupHr { get; set; }
        //public Decimal OtherCleanHr { get; set; }
        //public Decimal QueueHr { get; set; }
        //public String MachineUnit { get; set; }
        //public Decimal MachineCost { get; set; }
        //public String EnergyUnit { get; set; }
        //public Decimal EnergyCost { get; set; }
        //public String WaterUnit { get; set; }
        //public Decimal WaterCost { get; set; }
        //public String RentalUnit { get; set; }
        //public Decimal RentalCost { get; set; }
        //public String LaborUnit { get; set; }
        //public Decimal LaborCost { get; set; }
        //public String InlabUnit { get; set; }
        //public Decimal InlabCost { get; set; }
        //public String InmatUnit { get; set; }
        //public Decimal InmatCost { get; set; }
        //public String MiscUnit { get; set; }
        //public Decimal MiscCost { get; set; }
        //public String Restrict0 { get; set; }
        //public String Restrict1 { get; set; }
        //public String Restrict2 { get; set; }
        //public String Restrict3 { get; set; }
        //public String Restrict4 { get; set; }
        //public String Restrict5 { get; set; }
        //public String Restrict6 { get; set; }
        //public String Restrict7 { get; set; }
        //public String Restrict8 { get; set; }
        //public String Restrict9 { get; set; }
        //public String Require0 { get; set; }
        //public String Require1 { get; set; }
        //public String Require2 { get; set; }
        //public String Require3 { get; set; }
        //public String Require4 { get; set; }
        //public String Require5 { get; set; }
        //public String Require6 { get; set; }
        //public String Require7 { get; set; }
        //public String Require8 { get; set; }
        //public String Require9 { get; set; }
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
        //public String OperHrsBasis { get; set; }
        //public Decimal NoOfMachines { get; set; }
    }
}