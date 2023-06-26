#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  InventoryMovementForm.cs
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

    [FormScript("Inventory.InventoryMovementReceipt")]
    [BasedOnRow(typeof(Entities.InventoryMovementRow))]
    public class InventoryMovementReceiptForm
    {
        [Tab("GeneralInformation")]
        public String RefNo { get; set; }
        public String MoveType { get; set; }
        public DateTime MoveDate { get; set; }

        public String LocTo { get; set; }
        public String Reference { get; set; }

        public String SourceType { get; set; }
        public String SourceRef { get; set; }

        //public String TranType { get; set; }
        //public String Posted { get; set; }
        //public String PostedStep1 { get; set; }
        //public String FlowType { get; set; }
        //public String LocFrom { get; set; }
        //public String ReceivedFrom { get; set; }
        //public String IssuedTo { get; set; }
      
        [Tab("Details")]
        [InventoryMovementDetailEditor]
        public List<Entities.InventoryMovementDetailRow> DetailList { get; set; }
        
        //[Tab("Costing")]
        //public String Dept { get; set; }

        //[Tab("Addition")]
        //public DateTime ValueDate { get; set; }
        //public Decimal TotalCost { get; set; }
    }

    [FormScript("Inventory.InventoryMovementIssue")]
    [BasedOnRow(typeof(Entities.InventoryMovementRow))]
    public class InventoryMovementIssueForm
    {
        [Tab("GeneralInformation")]
        public String RefNo { get; set; }
        public String MoveType { get; set; }
        public DateTime MoveDate { get; set; }

        public String LocFrom { get; set; }
        public String Reference { get; set; }

        public String SourceType { get; set; }
        public String SourceRef { get; set; }
        
        [Tab("Details")]
        [InventoryMovementDetailEditor]
        public List<Entities.InventoryMovementDetailRow> DetailList { get; set; }
    }

    [FormScript("Inventory.InventoryMovementTransfer")]
    [BasedOnRow(typeof(Entities.InventoryMovementRow))]
    public class InventoryMovementTransferForm
    {
        [Tab("GeneralInformation")]
        public String RefNo { get; set; }
        public String MoveType { get; set; }
        public DateTime MoveDate { get; set; }

        public String LocFrom { get; set; }
        public String LocTo { get; set; }
        public String Reference { get; set; }

        public String SourceType { get; set; }
        public String SourceRef { get; set; }

        [Tab("Details")]
        [InventoryMovementDetailEditor]
        public List<Entities.InventoryMovementDetailRow> DetailList { get; set; }
    }
}