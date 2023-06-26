#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  BomColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Production.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Production.Bom")]
    [BasedOnRow(typeof(Entities.BomRow))]
    public class BomColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String BomNo { get; set; }
        public String Suspended { get; set; }
        public String AssmItemNo { get; set; }
        public String Description { get; set; }
        public String Uom { get; set; }
        public Decimal StdOutput { get; set; }
        public DateTime EffectFrom { get; set; }
        public DateTime EffectTo { get; set; }
        public String PartsVerified { get; set; }
        public String ProcVerified { get; set; }
        public String EcnRequired { get; set; }
        public String BranchNo { get; set; }
        public String AssemblyLine { get; set; }
        public String FixedAsmLine { get; set; }
        public String WorkEstBasis { get; set; }
        public Decimal StdLotSize { get; set; }
        public Decimal MinLotSize { get; set; }
        public Decimal MaxLotSize { get; set; }
        public Decimal ScrapRate { get; set; }
        public Decimal LastLineNo { get; set; }
        public Decimal LastLogNo { get; set; }
        public Decimal PartsCount { get; set; }
        public Decimal RouteCount { get; set; }
        public Decimal ByproCount { get; set; }
        public Decimal ByproShare { get; set; }
        public Decimal MnproShare { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
        public String LockType { get; set; }
        public String LockRefNo { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
        public String LastEcnNo { get; set; }
        public String MassCngId { get; set; }
        public String AllowChgJob { get; set; }
        public Decimal NetWt { get; set; }
        public String NetWtUom { get; set; }
        public String BomRevision { get; set; }
        public String Flag { get; set; }
        public String HoldBy { get; set; }
        public Decimal LastPartsSeqNo { get; set; }
        public String IsApproved { get; set; }
        public String ApprovedBy { get; set; }
        public String Preapprove { get; set; }
        public DateTime ApprovedDate { get; set; }
        public String Remarks { get; set; }
        public String IssueRunnerWaste { get; set; }
        public Decimal RunnerWasteWt { get; set; }
        public String RunnerWasteUom { get; set; }
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
        public Boolean AllowRohsMatOnly { get; set; }
        public Boolean IssueExtraRunnerWaste { get; set; }
        public Boolean Phantom { get; set; }
        public Decimal DieCutter { get; set; }
    }
}