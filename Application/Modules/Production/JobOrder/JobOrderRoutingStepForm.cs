#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  JobOrderRoutingStepForm.cs
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

    [FormScript("Production.JobOrderRoutingStep")]
    [BasedOnRow(typeof(Entities.JobOrderRoutingStepRow))]
    public class JobOrderRoutingStepForm
    {
        public String JobNo { get; set; }
        public Decimal StepNo { get; set; }
        public String OpCode { get; set; }
        public String Description { get; set; }
        public String ProdnMode { get; set; }
        public String Ticketed { get; set; }
        public String Reported { get; set; }
        public String WorkCentre { get; set; }
        public Decimal HrsPerLot { get; set; }
        public Decimal PieceRate { get; set; }
        public String SubVendorNo { get; set; }
        public String SubContractNo { get; set; }
        public DateTime SubIssueDate { get; set; }
        public DateTime SubDueDate { get; set; }
        public Decimal SubLotRate { get; set; }
        public Decimal CostMachine { get; set; }
        public Decimal CostEnergy { get; set; }
        public Decimal CostWater { get; set; }
        public Decimal CostRental { get; set; }
        public Decimal CostLabor { get; set; }
        public Decimal CostInlab { get; set; }
        public Decimal CostInmat { get; set; }
        public Decimal CostMisc { get; set; }
        public Decimal CostSubcon { get; set; }
        public Decimal CostMachCpd { get; set; }
        public Decimal CostEnergyCpd { get; set; }
        public Decimal CostWaterCpd { get; set; }
        public Decimal CostRentalCpd { get; set; }
        public Decimal CostLaborCpd { get; set; }
        public Decimal CostInlabCpd { get; set; }
        public Decimal CostInmatCpd { get; set; }
        public Decimal CostMiscCpd { get; set; }
        public Decimal CostSubCpd { get; set; }
        public String AcctMachine { get; set; }
        public String AcctEnergy { get; set; }
        public String AcctWater { get; set; }
        public String AcctRental { get; set; }
        public String AcctLabor { get; set; }
        public String AcctInlab { get; set; }
        public String AcctInmat { get; set; }
        public String AcctMisc { get; set; }
        public String Specifications { get; set; }
        public DateTime Eod { get; set; }
        public DateTime Edd { get; set; }
        public String Anlys1 { get; set; }
        public String Anlys2 { get; set; }
        public Decimal HrsPerLot1 { get; set; }
        public Decimal TotalManHrs { get; set; }
        public Decimal TotalMachHrs { get; set; }
        public String Anlys18 { get; set; }
        public String Anlys19 { get; set; }
        public String Anlys20 { get; set; }
    }
}