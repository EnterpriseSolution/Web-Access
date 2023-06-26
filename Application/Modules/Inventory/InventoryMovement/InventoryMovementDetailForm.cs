#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  InventoryMovementDetailForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Inventory.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Inventory.InventoryMovementDetail")]
    [BasedOnRow(typeof(Entities.InventoryMovementDetailRow))]
    public class InventoryMovementDetailForm
    {
        public String RefNo { get; set; }
        public Decimal LineNo { get; set; }
        public String ItemNo { get; set; }
        public String Description { get; set; }
        public String Uom { get; set; }
        public Decimal LotSize { get; set; }
        public String LineRef { get; set; }
        public Decimal Qty { get; set; }
        public Decimal UnitCost { get; set; }
        public Decimal TotalCost { get; set; }
        public Decimal QtyPerRec { get; set; }
        public Decimal QtyPerCount { get; set; }
        public Decimal BinQtyIn { get; set; }
        public Decimal BinQtyOut { get; set; }
        public String Anlys1 { get; set; }
        public String Anlys2 { get; set; }
        public String Anlys3 { get; set; }
        public String Anlys4 { get; set; }
        public String Anlys5 { get; set; }
        public String Anlys6 { get; set; }
        public Decimal BaseQty { get; set; }
        public Decimal BaseUnitCost { get; set; }
        public Decimal QtyCommitted { get; set; }
        public Decimal QtyRequired { get; set; }
        public Decimal QtyIssued { get; set; }
        public Decimal QtyBalance { get; set; }
        public Decimal QtyPer { get; set; }
        public String Final { get; set; }
        public String DebitAcct { get; set; }
        public String CreditAcct { get; set; }
        public String AllocMethod { get; set; }
        public String SourceType { get; set; }
        public String SourceRefNo { get; set; }
        public Decimal SourceEntryNo { get; set; }
        public Decimal SourcePartNo { get; set; }
        public String Particulars { get; set; }
        public Decimal RevisedCost { get; set; }
        public Decimal CostDiff { get; set; }
        public String FlowType { get; set; }
        public String LocFrom { get; set; }
        public String LocTo { get; set; }
        public String TempStubNo { get; set; }
        public String TempLoc { get; set; }
        public Decimal TempReserved { get; set; }
        public DateTime TempDateNeeded { get; set; }
        public String TempRemarks { get; set; }
        public String Anlys15 { get; set; }
        public String Anlys16 { get; set; }
        public String Anlys17 { get; set; }
        public String Anlys18 { get; set; }
        public String Anlys19 { get; set; }
        public String Anlys20 { get; set; }
        public Decimal AllocatedQty { get; set; }
        public Decimal AllocatedCost { get; set; }
        public Decimal QtyPick { get; set; }
        public Decimal Weight { get; set; }
        public Decimal TotalWeight { get; set; }
        public Decimal QtyFollowList { get; set; }
        public Decimal QuotationScrapQty { get; set; }
        public Decimal QuotationScrapRate { get; set; }
    }
}