#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  BomRoutingStepForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Production.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Production.BomRoutingStep")]
    [BasedOnRow(typeof(Entities.BomRoutingStepRow))]
    public class BomRoutingStepForm
    {
        public String BomNo { get; set; }
        public Decimal SeqNo { get; set; }
        public String OpCode { get; set; }
        public String Description { get; set; }
        public String Ticketed { get; set; }
        public String Reported { get; set; }
        public String ProdnMode { get; set; }
        public String WorkCentre { get; set; }
        public String FixedWcentre { get; set; }
        public Decimal NoOfWorkers { get; set; }
        public Decimal PieceRate { get; set; }
        public String SubconVendor { get; set; }
        public Decimal SubconRate { get; set; }
        public String FixedVendor { get; set; }
        public Decimal MachLoadHr { get; set; }
        public Decimal ManLoadHr { get; set; }
        public Decimal MachProcessHr { get; set; }
        public Decimal ManProcessHr { get; set; }
        public Decimal MachUnloadHr { get; set; }
        public Decimal ManUnloadHr { get; set; }
        public Decimal MachineCost { get; set; }
        public Decimal EnergyCost { get; set; }
        public Decimal WaterCost { get; set; }
        public Decimal RentalCost { get; set; }
        public Decimal LaborCost { get; set; }
        public Decimal InlabCost { get; set; }
        public Decimal InmatCost { get; set; }
        public Decimal MiscCost { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
        public String Specifications { get; set; }
        public Decimal DependTo { get; set; }
        public String Dependency { get; set; }
        public Decimal LagHour { get; set; }
        public String MachineNo { get; set; }
        public String MoldNo { get; set; }
        public String UserDefinedField1 { get; set; }
        public String UserDefinedField2 { get; set; }
        public String UserDefinedField3 { get; set; }
        public String UserDefinedField4 { get; set; }
        public String UserDefinedField5 { get; set; }
        public String UserDefinedField6 { get; set; }
        public String UserDefinedField7 { get; set; }
        public String UserDefinedField8 { get; set; }
        public String UserDefinedField9 { get; set; }
        public String UserDefinedField10 { get; set; }
        public String UserDefinedField11 { get; set; }
        public String UserDefinedField12 { get; set; }
        public String UserDefinedField13 { get; set; }
        public String UserDefinedField14 { get; set; }
        public String UserDefinedField15 { get; set; }
        public String UserDefinedField16 { get; set; }
        public String UserDefinedField17 { get; set; }
        public String UserDefinedField18 { get; set; }
        public String UserDefinedField19 { get; set; }
        public String UserDefinedField20 { get; set; }
    }
}