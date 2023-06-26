#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  JobOrderForm.cs
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

    [FormScript("Production.JobOrder")]
    [BasedOnRow(typeof(Entities.JobOrderRow))]
    public class JobOrderForm
    {
        public String JobNo { get; set; }
        public String Posted { get; set; }
        public String Closed { get; set; }
        public String Issued { get; set; }
        public String Finished { get; set; }
        public String AssemblyType { get; set; }
        public String SourceSubjob { get; set; }
        public String SourceSales { get; set; }
        public String SourceAssort { get; set; }
        public String SourceRefNo { get; set; }
        public Decimal SourceLineNo { get; set; }
        public Decimal SourcePartNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime StartDate { get; set; }
        public String ItemNo { get; set; }
        public String Description { get; set; }
        public String Uom { get; set; }
        public Decimal TotalQty { get; set; }
        public String SpecNo { get; set; }
        public String BomNo { get; set; }
        public Decimal StdOutput { get; set; }
        public Decimal ProdLotSize { get; set; }
        public Decimal NoOfLots { get; set; }
        public Decimal BatchedLots { get; set; }
        public Decimal HrsPerLot { get; set; }
        public Decimal HrsPerLotCpd { get; set; }
        public String BranchNo { get; set; }
        public String AssemblyLine { get; set; }
        public String JobCategory { get; set; }
        public Decimal JobPriority { get; set; }
        public String HeaderVerified { get; set; }
        public String ByprodVerified { get; set; }
        public String BatchVerified { get; set; }
        public String BomVerified { get; set; }
        public String RoutingVerifed { get; set; }
        public String MatschVerified { get; set; }
        public String WrkschVerified { get; set; }
        public String CostVerified { get; set; }
        public Decimal ByprCostShare { get; set; }
        public String TicketNeeded { get; set; }
        public String TicketClosed { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
        public DateTime PostedDate { get; set; }
        public String PostedBy { get; set; }
        public Decimal LastLineNo { get; set; }
        public Decimal LastByprodNo { get; set; }
        public Decimal BatchCount { get; set; }
        public Decimal LastLogNo { get; set; }
        public String LockType { get; set; }
        public String LockRefNo { get; set; }
        public String FgLoc { get; set; }
        public String RmLoc { get; set; }
        public Decimal CostMaterial { get; set; }
        public Decimal CostLabor { get; set; }
        public Decimal CostSubcon { get; set; }
        public Decimal CostMachine { get; set; }
        public Decimal CostEnergy { get; set; }
        public Decimal CostWater { get; set; }
        public Decimal CostRental { get; set; }
        public Decimal CostInlab { get; set; }
        public Decimal CostInmat { get; set; }
        public Decimal CostMisc { get; set; }
        public Decimal CostOverhead { get; set; }
        public Decimal CostEstimate { get; set; }
        public Decimal CostFinished { get; set; }
        public Decimal CostScrapped { get; set; }
        public Decimal CostCharged { get; set; }
        public Decimal CoacRmConsu { get; set; }
        public Decimal CoacRmScrap { get; set; }
        public Decimal CoacMaterial { get; set; }
        public Decimal CoacLabor { get; set; }
        public Decimal CoacSubcon { get; set; }
        public Decimal CoacMachine { get; set; }
        public Decimal CoacEnergy { get; set; }
        public Decimal CoacWater { get; set; }
        public Decimal CoacRental { get; set; }
        public Decimal CoacInlab { get; set; }
        public Decimal CoacInmat { get; set; }
        public Decimal CoacMisc { get; set; }
        public Decimal CoacOverhead { get; set; }
        public Decimal CostActual { get; set; }
        public Decimal CostVariance { get; set; }
        public Decimal CostWip { get; set; }
        public String AcctWip { get; set; }
        public String AcctPvar { get; set; }
        public String AcctProdCost { get; set; }
        public String CanEdit { get; set; }
        public Decimal LastSubNo { get; set; }
        public String SubjobVerified { get; set; }
        public Decimal LotsIssued { get; set; }
        public Decimal LotsFinished { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
        public String FinishedType { get; set; }
        public DateTime FinishedDate { get; set; }
        public String Specifications { get; set; }
        public Decimal QtyNeeded { get; set; }
        public Decimal ScrapRate { get; set; }
        public Decimal ScrapQty { get; set; }
        public Decimal QtyAdjusted { get; set; }
        public Decimal NetWt { get; set; }
        public String NetWtUom { get; set; }
        public String Anlys1 { get; set; }
        public String Anlys2 { get; set; }
        public String BlowThru { get; set; }
        public String Comments1 { get; set; }
        public String Comments2 { get; set; }
        public String Comments3 { get; set; }
        public String Comments4 { get; set; }
        public Decimal LastTextNo { get; set; }
        public String BomRevision { get; set; }
        public String Anlys7 { get; set; }
        public String Anlys8 { get; set; }
        public Decimal LastLinkNo { get; set; }
        public String Flag { get; set; }
        public String HoldBy { get; set; }
        public String IncludeScrapRate { get; set; }
        public String UseItemMasterScrap { get; set; }
        public String WcBackflush { get; set; }
        public String Reorder { get; set; }
        public Decimal CostRework { get; set; }
        public String MoldJob { get; set; }
        public String MoldDesc { get; set; }
        public String Anlys9 { get; set; }
        public String Anlys10 { get; set; }
        public String Anlys11 { get; set; }
        public String Anlys12 { get; set; }
        public String Anlys13 { get; set; }
        public String Anlys14 { get; set; }
        public String ProjectNo { get; set; }
        public String SourceMrpNo { get; set; }
    }
}