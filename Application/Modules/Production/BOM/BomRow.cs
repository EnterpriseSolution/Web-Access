#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  BomRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Production.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Production"), TableName("[dbo].[PRSBOM]")]
    [DisplayName("Bom"), InstanceName("Bom"), TwoLevelCached]   
    public sealed class BomRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Bom No"), Column("BOM_NO"), Size(30), PrimaryKey, QuickSearch]
        public String BomNo
        {
            get { return Fields.BomNo[this]; }
            set { Fields.BomNo[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        public String Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Assm Item No"), Column("ASSM_ITEM_NO"), Size(30), NotNull]
        public String AssmItemNo
        {
            get { return Fields.AssmItemNo[this]; }
            set { Fields.AssmItemNo[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(60)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Uom"), Column("UOM"), Size(4)]
        public String Uom
        {
            get { return Fields.Uom[this]; }
            set { Fields.Uom[this] = value; }
        }

        [DisplayName("Std Output"), Column("STD_OUTPUT"), Size(12), Scale(4)]
        public Decimal? StdOutput
        {
            get { return Fields.StdOutput[this]; }
            set { Fields.StdOutput[this] = value; }
        }

        [DisplayName("Effect From"), Column("EFFECT_FROM"), NotNull]
        public DateTime? EffectFrom
        {
            get { return Fields.EffectFrom[this]; }
            set { Fields.EffectFrom[this] = value; }
        }

        [DisplayName("Effect To"), Column("EFFECT_TO")]
        public DateTime? EffectTo
        {
            get { return Fields.EffectTo[this]; }
            set { Fields.EffectTo[this] = value; }
        }

        [DisplayName("Parts Verified"), Column("PARTS_VERIFIED"), Size(1)]
        public String PartsVerified
        {
            get { return Fields.PartsVerified[this]; }
            set { Fields.PartsVerified[this] = value; }
        }

        [DisplayName("Proc Verified"), Column("PROC_VERIFIED"), Size(1)]
        public String ProcVerified
        {
            get { return Fields.ProcVerified[this]; }
            set { Fields.ProcVerified[this] = value; }
        }

        [DisplayName("Ecn Required"), Column("ECN_REQUIRED"), Size(1)]
        public String EcnRequired
        {
            get { return Fields.EcnRequired[this]; }
            set { Fields.EcnRequired[this] = value; }
        }

        [DisplayName("Branch No"), Column("BRANCH_NO"), Size(4)]
        public String BranchNo
        {
            get { return Fields.BranchNo[this]; }
            set { Fields.BranchNo[this] = value; }
        }

        [DisplayName("Assembly Line"), Column("ASSEMBLY_LINE"), Size(6)]
        public String AssemblyLine
        {
            get { return Fields.AssemblyLine[this]; }
            set { Fields.AssemblyLine[this] = value; }
        }

        [DisplayName("Fixed Asm Line"), Column("FIXED_ASM_LINE"), Size(1)]
        public String FixedAsmLine
        {
            get { return Fields.FixedAsmLine[this]; }
            set { Fields.FixedAsmLine[this] = value; }
        }

        [DisplayName("Work Est Basis"), Column("WORK_EST_BASIS"), Size(1)]
        public String WorkEstBasis
        {
            get { return Fields.WorkEstBasis[this]; }
            set { Fields.WorkEstBasis[this] = value; }
        }

        [DisplayName("Std Lot Size"), Column("STD_LOT_SIZE"), Size(10), Scale(4)]
        public Decimal? StdLotSize
        {
            get { return Fields.StdLotSize[this]; }
            set { Fields.StdLotSize[this] = value; }
        }

        [DisplayName("Min Lot Size"), Column("MIN_LOT_SIZE"), Size(10), Scale(4)]
        public Decimal? MinLotSize
        {
            get { return Fields.MinLotSize[this]; }
            set { Fields.MinLotSize[this] = value; }
        }

        [DisplayName("Max Lot Size"), Column("MAX_LOT_SIZE"), Size(10), Scale(4)]
        public Decimal? MaxLotSize
        {
            get { return Fields.MaxLotSize[this]; }
            set { Fields.MaxLotSize[this] = value; }
        }

        [DisplayName("Scrap Rate"), Column("SCRAP_RATE"), Size(6), Scale(2)]
        public Decimal? ScrapRate
        {
            get { return Fields.ScrapRate[this]; }
            set { Fields.ScrapRate[this] = value; }
        }

        [DisplayName("Last Line No"), Column("LAST_LINE_NO"), Size(8)]
        public Decimal? LastLineNo
        {
            get { return Fields.LastLineNo[this]; }
            set { Fields.LastLineNo[this] = value; }
        }

        [DisplayName("Last Log No"), Column("LAST_LOG_NO"), Size(8)]
        public Decimal? LastLogNo
        {
            get { return Fields.LastLogNo[this]; }
            set { Fields.LastLogNo[this] = value; }
        }

        [DisplayName("Parts Count"), Column("PARTS_COUNT"), Size(8)]
        public Decimal? PartsCount
        {
            get { return Fields.PartsCount[this]; }
            set { Fields.PartsCount[this] = value; }
        }

        [DisplayName("Route Count"), Column("ROUTE_COUNT"), Size(8)]
        public Decimal? RouteCount
        {
            get { return Fields.RouteCount[this]; }
            set { Fields.RouteCount[this] = value; }
        }

        [DisplayName("Bypro Count"), Column("BYPRO_COUNT"), Size(4)]
        public Decimal? ByproCount
        {
            get { return Fields.ByproCount[this]; }
            set { Fields.ByproCount[this] = value; }
        }

        [DisplayName("Bypro Share"), Column("BYPRO_SHARE"), Size(6), Scale(2)]
        public Decimal? ByproShare
        {
            get { return Fields.ByproShare[this]; }
            set { Fields.ByproShare[this] = value; }
        }

        [DisplayName("Mnpro Share"), Column("MNPRO_SHARE"), Size(6), Scale(2)]
        public Decimal? MnproShare
        {
            get { return Fields.MnproShare[this]; }
            set { Fields.MnproShare[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE")]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10)]
        public String CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Revised Date"), Column("REVISED_DATE")]
        public DateTime? RevisedDate
        {
            get { return Fields.RevisedDate[this]; }
            set { Fields.RevisedDate[this] = value; }
        }

        [DisplayName("Revised By"), Column("REVISED_BY"), Size(10)]
        public String RevisedBy
        {
            get { return Fields.RevisedBy[this]; }
            set { Fields.RevisedBy[this] = value; }
        }

        [DisplayName("Lock Type"), Column("LOCK_TYPE"), Size(12)]
        public String LockType
        {
            get { return Fields.LockType[this]; }
            set { Fields.LockType[this] = value; }
        }

        [DisplayName("Lock Ref No"), Column("LOCK_REF_NO"), Size(16)]
        public String LockRefNo
        {
            get { return Fields.LockRefNo[this]; }
            set { Fields.LockRefNo[this] = value; }
        }

        [DisplayName("Owner Branch"), Column("OWNER_BRANCH"), Size(4)]
        public String OwnerBranch
        {
            get { return Fields.OwnerBranch[this]; }
            set { Fields.OwnerBranch[this] = value; }
        }

        [DisplayName("Source Branch"), Column("SOURCE_BRANCH"), Size(4)]
        public String SourceBranch
        {
            get { return Fields.SourceBranch[this]; }
            set { Fields.SourceBranch[this] = value; }
        }

        [DisplayName("Last Ecn No"), Column("LAST_ECN_NO"), Size(16)]
        public String LastEcnNo
        {
            get { return Fields.LastEcnNo[this]; }
            set { Fields.LastEcnNo[this] = value; }
        }

        [DisplayName("Mass Cng Id"), Column("MASS_CNG_ID"), Size(16)]
        public String MassCngId
        {
            get { return Fields.MassCngId[this]; }
            set { Fields.MassCngId[this] = value; }
        }

        [DisplayName("Allow Chg Job"), Column("ALLOW_CHG_JOB"), Size(1)]
        public String AllowChgJob
        {
            get { return Fields.AllowChgJob[this]; }
            set { Fields.AllowChgJob[this] = value; }
        }

        [DisplayName("Net Wt"), Column("NET_WT"), Size(12), Scale(4)]
        public Decimal? NetWt
        {
            get { return Fields.NetWt[this]; }
            set { Fields.NetWt[this] = value; }
        }

        [DisplayName("Net Wt Uom"), Column("NET_WT_UOM"), Size(4)]
        public String NetWtUom
        {
            get { return Fields.NetWtUom[this]; }
            set { Fields.NetWtUom[this] = value; }
        }

        [DisplayName("Bom Revision"), Column("BOM_REVISION"), Size(8)]
        public String BomRevision
        {
            get { return Fields.BomRevision[this]; }
            set { Fields.BomRevision[this] = value; }
        }

        [DisplayName("Flag"), Column("FLAG"), Size(1)]
        public String Flag
        {
            get { return Fields.Flag[this]; }
            set { Fields.Flag[this] = value; }
        }

        [DisplayName("Hold By"), Column("HOLD_BY"), Size(15)]
        public String HoldBy
        {
            get { return Fields.HoldBy[this]; }
            set { Fields.HoldBy[this] = value; }
        }

        [DisplayName("Last Parts Seq No"), Column("LAST_PARTS_SEQ_NO"), Size(6)]
        public Decimal? LastPartsSeqNo
        {
            get { return Fields.LastPartsSeqNo[this]; }
            set { Fields.LastPartsSeqNo[this] = value; }
        }

        [DisplayName("Is Approved"), Column("IS_APPROVED"), Size(1)]
        public String IsApproved
        {
            get { return Fields.IsApproved[this]; }
            set { Fields.IsApproved[this] = value; }
        }

        [DisplayName("Approved By"), Column("APPROVED_BY"), Size(20)]
        public String ApprovedBy
        {
            get { return Fields.ApprovedBy[this]; }
            set { Fields.ApprovedBy[this] = value; }
        }

        [DisplayName("Preapprove"), Column("PREAPPROVE"), Size(1)]
        public String Preapprove
        {
            get { return Fields.Preapprove[this]; }
            set { Fields.Preapprove[this] = value; }
        }

        [DisplayName("Approved Date"), Column("APPROVED_DATE")]
        public DateTime? ApprovedDate
        {
            get { return Fields.ApprovedDate[this]; }
            set { Fields.ApprovedDate[this] = value; }
        }

        [DisplayName("Remarks"), Column("REMARKS"), Size(1073741823)]
        public String Remarks
        {
            get { return Fields.Remarks[this]; }
            set { Fields.Remarks[this] = value; }
        }

        [DisplayName("Issue Runner Waste"), Column("ISSUE_RUNNER_WASTE"), Size(1)]
        public String IssueRunnerWaste
        {
            get { return Fields.IssueRunnerWaste[this]; }
            set { Fields.IssueRunnerWaste[this] = value; }
        }

        [DisplayName("Runner Waste Wt"), Column("RUNNER_WASTE_WT"), Size(10), Scale(4)]
        public Decimal? RunnerWasteWt
        {
            get { return Fields.RunnerWasteWt[this]; }
            set { Fields.RunnerWasteWt[this] = value; }
        }

        [DisplayName("Runner Waste Uom"), Column("RUNNER_WASTE_UOM"), Size(4)]
        public String RunnerWasteUom
        {
            get { return Fields.RunnerWasteUom[this]; }
            set { Fields.RunnerWasteUom[this] = value; }
        }

        [DisplayName("User Defined Field 1"), Column("USER_DEFINED_FIELD_1"), Size(100)]
        public String UserDefinedField1
        {
            get { return Fields.UserDefinedField1[this]; }
            set { Fields.UserDefinedField1[this] = value; }
        }

        [DisplayName("User Defined Field 2"), Column("USER_DEFINED_FIELD_2"), Size(100)]
        public String UserDefinedField2
        {
            get { return Fields.UserDefinedField2[this]; }
            set { Fields.UserDefinedField2[this] = value; }
        }

        [DisplayName("User Defined Field 3"), Column("USER_DEFINED_FIELD_3"), Size(100)]
        public String UserDefinedField3
        {
            get { return Fields.UserDefinedField3[this]; }
            set { Fields.UserDefinedField3[this] = value; }
        }

        [DisplayName("User Defined Field 4"), Column("USER_DEFINED_FIELD_4"), Size(100)]
        public String UserDefinedField4
        {
            get { return Fields.UserDefinedField4[this]; }
            set { Fields.UserDefinedField4[this] = value; }
        }

        [DisplayName("User Defined Field 5"), Column("USER_DEFINED_FIELD_5"), Size(100)]
        public String UserDefinedField5
        {
            get { return Fields.UserDefinedField5[this]; }
            set { Fields.UserDefinedField5[this] = value; }
        }

        [DisplayName("User Defined Field 6"), Column("USER_DEFINED_FIELD_6"), Size(100)]
        public String UserDefinedField6
        {
            get { return Fields.UserDefinedField6[this]; }
            set { Fields.UserDefinedField6[this] = value; }
        }

        [DisplayName("User Defined Field 7"), Column("USER_DEFINED_FIELD_7"), Size(100)]
        public String UserDefinedField7
        {
            get { return Fields.UserDefinedField7[this]; }
            set { Fields.UserDefinedField7[this] = value; }
        }

        [DisplayName("User Defined Field 8"), Column("USER_DEFINED_FIELD_8"), Size(100)]
        public String UserDefinedField8
        {
            get { return Fields.UserDefinedField8[this]; }
            set { Fields.UserDefinedField8[this] = value; }
        }

        [DisplayName("User Defined Field 9"), Column("USER_DEFINED_FIELD_9"), Size(100)]
        public String UserDefinedField9
        {
            get { return Fields.UserDefinedField9[this]; }
            set { Fields.UserDefinedField9[this] = value; }
        }

        [DisplayName("User Defined Field 10"), Column("USER_DEFINED_FIELD_10"), Size(100)]
        public String UserDefinedField10
        {
            get { return Fields.UserDefinedField10[this]; }
            set { Fields.UserDefinedField10[this] = value; }
        }

        [DisplayName("User Defined Field 11"), Column("USER_DEFINED_FIELD_11"), Size(100)]
        public String UserDefinedField11
        {
            get { return Fields.UserDefinedField11[this]; }
            set { Fields.UserDefinedField11[this] = value; }
        }

        [DisplayName("User Defined Field 12"), Column("USER_DEFINED_FIELD_12"), Size(100)]
        public String UserDefinedField12
        {
            get { return Fields.UserDefinedField12[this]; }
            set { Fields.UserDefinedField12[this] = value; }
        }

        [DisplayName("User Defined Field 13"), Column("USER_DEFINED_FIELD_13"), Size(100)]
        public String UserDefinedField13
        {
            get { return Fields.UserDefinedField13[this]; }
            set { Fields.UserDefinedField13[this] = value; }
        }

        [DisplayName("User Defined Field 14"), Column("USER_DEFINED_FIELD_14"), Size(100)]
        public String UserDefinedField14
        {
            get { return Fields.UserDefinedField14[this]; }
            set { Fields.UserDefinedField14[this] = value; }
        }

        [DisplayName("User Defined Field 15"), Column("USER_DEFINED_FIELD_15"), Size(100)]
        public String UserDefinedField15
        {
            get { return Fields.UserDefinedField15[this]; }
            set { Fields.UserDefinedField15[this] = value; }
        }

        [DisplayName("User Defined Field 16"), Column("USER_DEFINED_FIELD_16"), Size(100)]
        public String UserDefinedField16
        {
            get { return Fields.UserDefinedField16[this]; }
            set { Fields.UserDefinedField16[this] = value; }
        }

        [DisplayName("User Defined Field 17"), Column("USER_DEFINED_FIELD_17"), Size(100)]
        public String UserDefinedField17
        {
            get { return Fields.UserDefinedField17[this]; }
            set { Fields.UserDefinedField17[this] = value; }
        }

        [DisplayName("User Defined Field 18"), Column("USER_DEFINED_FIELD_18"), Size(100)]
        public String UserDefinedField18
        {
            get { return Fields.UserDefinedField18[this]; }
            set { Fields.UserDefinedField18[this] = value; }
        }

        [DisplayName("User Defined Field 19"), Column("USER_DEFINED_FIELD_19"), Size(100)]
        public String UserDefinedField19
        {
            get { return Fields.UserDefinedField19[this]; }
            set { Fields.UserDefinedField19[this] = value; }
        }

        [DisplayName("User Defined Field 20"), Column("USER_DEFINED_FIELD_20"), Size(100)]
        public String UserDefinedField20
        {
            get { return Fields.UserDefinedField20[this]; }
            set { Fields.UserDefinedField20[this] = value; }
        }

        [DisplayName("Allow Rohs Mat Only"), Column("ALLOW_ROHS_MAT_ONLY")]
        public Boolean? AllowRohsMatOnly
        {
            get { return Fields.AllowRohsMatOnly[this]; }
            set { Fields.AllowRohsMatOnly[this] = value; }
        }

        [DisplayName("Issue Extra Runner Waste"), Column("ISSUE_EXTRA_RUNNER_WASTE")]
        public Boolean? IssueExtraRunnerWaste
        {
            get { return Fields.IssueExtraRunnerWaste[this]; }
            set { Fields.IssueExtraRunnerWaste[this] = value; }
        }

        [DisplayName("Phantom"), Column("PHANTOM")]
        public Boolean? Phantom
        {
            get { return Fields.Phantom[this]; }
            set { Fields.Phantom[this] = value; }
        }

        [DisplayName("Die Cutter"), Column("DIE_CUTTER"), Size(16), Scale(2)]
        public Decimal? DieCutter
        {
            get { return Fields.DieCutter[this]; }
            set { Fields.DieCutter[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.BomNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public BomRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField BomNo;
            public StringField Suspended;
            public StringField AssmItemNo;
            public StringField Description;
            public StringField Uom;
            public DecimalField StdOutput;
            public DateTimeField EffectFrom;
            public DateTimeField EffectTo;
            public StringField PartsVerified;
            public StringField ProcVerified;
            public StringField EcnRequired;
            public StringField BranchNo;
            public StringField AssemblyLine;
            public StringField FixedAsmLine;
            public StringField WorkEstBasis;
            public DecimalField StdLotSize;
            public DecimalField MinLotSize;
            public DecimalField MaxLotSize;
            public DecimalField ScrapRate;
            public DecimalField LastLineNo;
            public DecimalField LastLogNo;
            public DecimalField PartsCount;
            public DecimalField RouteCount;
            public DecimalField ByproCount;
            public DecimalField ByproShare;
            public DecimalField MnproShare;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField LockType;
            public StringField LockRefNo;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField LastEcnNo;
            public StringField MassCngId;
            public StringField AllowChgJob;
            public DecimalField NetWt;
            public StringField NetWtUom;
            public StringField BomRevision;
            public StringField Flag;
            public StringField HoldBy;
            public DecimalField LastPartsSeqNo;
            public StringField IsApproved;
            public StringField ApprovedBy;
            public StringField Preapprove;
            public DateTimeField ApprovedDate;
            public StringField Remarks;
            public StringField IssueRunnerWaste;
            public DecimalField RunnerWasteWt;
            public StringField RunnerWasteUom;
            public StringField UserDefinedField1;
            public StringField UserDefinedField2;
            public StringField UserDefinedField3;
            public StringField UserDefinedField4;
            public StringField UserDefinedField5;
            public StringField UserDefinedField6;
            public StringField UserDefinedField7;
            public StringField UserDefinedField8;
            public StringField UserDefinedField9;
            public StringField UserDefinedField10;
            public StringField UserDefinedField11;
            public StringField UserDefinedField12;
            public StringField UserDefinedField13;
            public StringField UserDefinedField14;
            public StringField UserDefinedField15;
            public StringField UserDefinedField16;
            public StringField UserDefinedField17;
            public StringField UserDefinedField18;
            public StringField UserDefinedField19;
            public StringField UserDefinedField20;
            public BooleanField AllowRohsMatOnly;
            public BooleanField IssueExtraRunnerWaste;
            public BooleanField Phantom;
            public DecimalField DieCutter;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Production.Bom";
            }
        }
    }
}
