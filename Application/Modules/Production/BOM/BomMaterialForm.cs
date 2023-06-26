#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  BomMaterialForm.cs
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

    [FormScript("Production.BomMaterial")]
    [BasedOnRow(typeof(Entities.BomMaterialRow))]
    public class BomMaterialForm
    {
        public String BomNo { get; set; }
        public Decimal SeqNo { get; set; }
        public String PartItemNo { get; set; }
        public String Description { get; set; }
        public String Uom { get; set; }
        public Decimal QtyPer { get; set; }
        public String WithAltern { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
        public Decimal EntrySeqNo { get; set; }
        public String AssmItemNo { get; set; }
        public Decimal ScrapRate { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
        public Decimal LocCount { get; set; }
        public String BlowThruBomNo { get; set; }
        public String Remarks { get; set; }
        public Decimal LastAltSeqNo { get; set; }
        public String LastEcnNo { get; set; }
        public String RunnerWaste { get; set; }
        public Decimal RunnerWasteRate { get; set; }
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
        public Boolean RohsCompliance { get; set; }
        public Boolean Approved { get; set; }
        public String Uom2 { get; set; }
        public Decimal QtyPer2 { get; set; }
        public String WorkCentre { get; set; }
        public Decimal QuotationScrapQty { get; set; }
        public Decimal QuotationScrapRate { get; set; }
        public Decimal QuotationQty { get; set; }
        public Boolean ShowCost { get; set; }
        public Decimal QtyBeforeConversion { get; set; }
    }
}