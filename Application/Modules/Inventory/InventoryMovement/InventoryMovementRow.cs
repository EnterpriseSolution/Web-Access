#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  InventoryMovementRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Inventory.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Inventory"), TableName("[dbo].[ICMOVH]")]
    [DisplayName("Inventory Movement"), InstanceName("Inventory Movement"), TwoLevelCached]   
    public sealed class InventoryMovementRow : Row, IIdRow, INameRow
    {
        //public string InstanceName
        //{
        //    get { return "Inventory Movement"; }
        //}

        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Ref No"), Column("REF_NO"), Size(16), PrimaryKey, QuickSearch]
        public String RefNo
        {
            get { return Fields.RefNo[this]; }
            set { Fields.RefNo[this] = value; }
        }

        [DisplayName("Tran Type"), Column("TRAN_TYPE"), Size(4), NotNull]
        public String TranType
        {
            get { return Fields.TranType[this]; }
            set { Fields.TranType[this] = value; }
        }

        [DisplayName("Move Date"), Column("MOVE_DATE"), NotNull]
        public DateTime? MoveDate
        {
            get { return Fields.MoveDate[this]; }
            set { Fields.MoveDate[this] = value; }
        }

        [DisplayName("Value Date"), Column("VALUE_DATE"), NotNull]
        public DateTime? ValueDate
        {
            get { return Fields.ValueDate[this]; }
            set { Fields.ValueDate[this] = value; }
        }

        [DisplayName("Posted"), Column("POSTED"), Size(1), NotNull]
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Posted Step1"), Column("POSTED_STEP1"), Size(1)]
        public String PostedStep1
        {
            get { return Fields.PostedStep1[this]; }
            set { Fields.PostedStep1[this] = value; }
        }

        [DisplayName("Flow Type"), Column("FLOW_TYPE"), Size(1), NotNull]
        public String FlowType
        {
            get { return Fields.FlowType[this]; }
            set { Fields.FlowType[this] = value; }
        }

        [DisplayName("Move Type"), Column("MOVE_TYPE"), Size(6), NotNull]
        public String MoveType
        {
            get { return Fields.MoveType[this]; }
            set { Fields.MoveType[this] = value; }
        }

        [DisplayName("Loc From"), Column("LOC_FROM"), Size(4), NotNull]
        public String LocFrom
        {
            get { return Fields.LocFrom[this]; }
            set { Fields.LocFrom[this] = value; }
        }

        [DisplayName("Loc To"), Column("LOC_TO"), Size(4), NotNull]
        public String LocTo
        {
            get { return Fields.LocTo[this]; }
            set { Fields.LocTo[this] = value; }
        }

        [DisplayName("Reference"), Column("REFERENCE"), Size(30)]
        public String Reference
        {
            get { return Fields.Reference[this]; }
            set { Fields.Reference[this] = value; }
        }

        [DisplayName("Received From"), Column("RECEIVED_FROM"), Size(60)]
        public String ReceivedFrom
        {
            get { return Fields.ReceivedFrom[this]; }
            set { Fields.ReceivedFrom[this] = value; }
        }

        [DisplayName("Issued To"), Column("ISSUED_TO"), Size(60)]
        public String IssuedTo
        {
            get { return Fields.IssuedTo[this]; }
            set { Fields.IssuedTo[this] = value; }
        }

        [DisplayName("Dept"), Column("DEPT"), Size(4), NotNull]
        public String Dept
        {
            get { return Fields.Dept[this]; }
            set { Fields.Dept[this] = value; }
        }

        [DisplayName("Total Cost"), Column("TOTAL_COST"), Size(16), Scale(2)]
        public Decimal? TotalCost
        {
            get { return Fields.TotalCost[this]; }
            set { Fields.TotalCost[this] = value; }
        }

        [DisplayName("Last Line No"), Column("LAST_LINE_NO"), Size(8)]
        public Decimal? LastLineNo
        {
            get { return Fields.LastLineNo[this]; }
            set { Fields.LastLineNo[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10), NotNull]
        public String CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE"), NotNull]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
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

        [DisplayName("Posted Date"), Column("POSTED_DATE")]
        public DateTime? PostedDate
        {
            get { return Fields.PostedDate[this]; }
            set { Fields.PostedDate[this] = value; }
        }

        [DisplayName("Posted By"), Column("POSTED_BY"), Size(10)]
        public String PostedBy
        {
            get { return Fields.PostedBy[this]; }
            set { Fields.PostedBy[this] = value; }
        }

        [DisplayName("Log No"), Column("LOG_NO"), Size(8), NotNull]
        public Decimal? LogNo
        {
            get { return Fields.LogNo[this]; }
            set { Fields.LogNo[this] = value; }
        }

        [DisplayName("Source Type"), Column("SOURCE_TYPE"), Size(12)]
        public String SourceType
        {
            get { return Fields.SourceType[this]; }
            set { Fields.SourceType[this] = value; }
        }

        [DisplayName("Source Ref"), Column("SOURCE_REF"), Size(16)]
        public String SourceRef
        {
            get { return Fields.SourceRef[this]; }
            set { Fields.SourceRef[this] = value; }
        }

        [DisplayName("Anlys1"), Column("ANLYS1"), Size(30)]
        public String Anlys1
        {
            get { return Fields.Anlys1[this]; }
            set { Fields.Anlys1[this] = value; }
        }

        [DisplayName("Anlys2"), Column("ANLYS2"), Size(30)]
        public String Anlys2
        {
            get { return Fields.Anlys2[this]; }
            set { Fields.Anlys2[this] = value; }
        }

        [DisplayName("Period"), Column("PERIOD"), Size(7)]
        public String Period
        {
            get { return Fields.Period[this]; }
            set { Fields.Period[this] = value; }
        }

        [DisplayName("Fiscal Year"), Column("FISCAL_YEAR"), Size(4)]
        public Decimal? FiscalYear
        {
            get { return Fields.FiscalYear[this]; }
            set { Fields.FiscalYear[this] = value; }
        }

        [DisplayName("Period No"), Column("PERIOD_NO"), Size(2)]
        public Decimal? PeriodNo
        {
            get { return Fields.PeriodNo[this]; }
            set { Fields.PeriodNo[this] = value; }
        }

        [DisplayName("Job No"), Column("JOB_NO"), Size(16), NotNull]
        public String JobNo
        {
            get { return Fields.JobNo[this]; }
            set { Fields.JobNo[this] = value; }
        }

        [DisplayName("Batch No"), Column("BATCH_NO"), Size(10)]
        public String BatchNo
        {
            get { return Fields.BatchNo[this]; }
            set { Fields.BatchNo[this] = value; }
        }

        [DisplayName("Start Date"), Column("START_DATE")]
        public DateTime? StartDate
        {
            get { return Fields.StartDate[this]; }
            set { Fields.StartDate[this] = value; }
        }

        [DisplayName("Branch No"), Column("BRANCH_NO"), Size(4)]
        public String BranchNo
        {
            get { return Fields.BranchNo[this]; }
            set { Fields.BranchNo[this] = value; }
        }

        [DisplayName("Final"), Column("FINAL"), Size(1)]
        public String Final
        {
            get { return Fields.Final[this]; }
            set { Fields.Final[this] = value; }
        }

        [DisplayName("Lots Pending"), Column("LOTS_PENDING"), Size(8)]
        public Decimal? LotsPending
        {
            get { return Fields.LotsPending[this]; }
            set { Fields.LotsPending[this] = value; }
        }

        [DisplayName("Lots Issued"), Column("LOTS_ISSUED"), Size(8)]
        public Decimal? LotsIssued
        {
            get { return Fields.LotsIssued[this]; }
            set { Fields.LotsIssued[this] = value; }
        }

        [DisplayName("Qty Issued"), Column("QTY_ISSUED"), Size(12), Scale(4)]
        public Decimal? QtyIssued
        {
            get { return Fields.QtyIssued[this]; }
            set { Fields.QtyIssued[this] = value; }
        }

        [DisplayName("Std Output"), Column("STD_OUTPUT"), Size(12), Scale(4)]
        public Decimal? StdOutput
        {
            get { return Fields.StdOutput[this]; }
            set { Fields.StdOutput[this] = value; }
        }

        [DisplayName("Batch Select"), Column("BATCH_SELECT"), Size(1)]
        public String BatchSelect
        {
            get { return Fields.BatchSelect[this]; }
            set { Fields.BatchSelect[this] = value; }
        }

        [DisplayName("Gl Link"), Column("GL_LINK"), Size(1)]
        public String GlLink
        {
            get { return Fields.GlLink[this]; }
            set { Fields.GlLink[this] = value; }
        }

        [DisplayName("Gl Link Type"), Column("GL_LINK_TYPE"), Size(6)]
        public String GlLinkType
        {
            get { return Fields.GlLinkType[this]; }
            set { Fields.GlLinkType[this] = value; }
        }

        [DisplayName("Gl Link No"), Column("GL_LINK_NO"), Size(16)]
        public String GlLinkNo
        {
            get { return Fields.GlLinkNo[this]; }
            set { Fields.GlLinkNo[this] = value; }
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

        [DisplayName("Particulars"), Column("PARTICULARS"), Size(1073741823)]
        public String Particulars
        {
            get { return Fields.Particulars[this]; }
            set { Fields.Particulars[this] = value; }
        }

        [DisplayName("Revised Cost"), Column("REVISED_COST"), Size(16), Scale(2)]
        public Decimal? RevisedCost
        {
            get { return Fields.RevisedCost[this]; }
            set { Fields.RevisedCost[this] = value; }
        }

        [DisplayName("Cost Diff"), Column("COST_DIFF"), Size(16), Scale(2)]
        public Decimal? CostDiff
        {
            get { return Fields.CostDiff[this]; }
            set { Fields.CostDiff[this] = value; }
        }

        [DisplayName("Diff Acct"), Column("DIFF_ACCT"), Size(30)]
        public String DiffAcct
        {
            get { return Fields.DiffAcct[this]; }
            set { Fields.DiffAcct[this] = value; }
        }

        [DisplayName("Item No"), Column("ITEM_NO"), Size(30)]
        public String ItemNo
        {
            get { return Fields.ItemNo[this]; }
            set { Fields.ItemNo[this] = value; }
        }

        [DisplayName("Bom No"), Column("BOM_NO"), Size(30)]
        public String BomNo
        {
            get { return Fields.BomNo[this]; }
            set { Fields.BomNo[this] = value; }
        }

        [DisplayName("Uom"), Column("UOM"), Size(4)]
        public String Uom
        {
            get { return Fields.Uom[this]; }
            set { Fields.Uom[this] = value; }
        }

        [DisplayName("Qty"), Column("QTY"), Size(12), Scale(4)]
        public Decimal? Qty
        {
            get { return Fields.Qty[this]; }
            set { Fields.Qty[this] = value; }
        }

        [DisplayName("Follow List"), Column("FOLLOW_LIST"), Size(1)]
        public String FollowList
        {
            get { return Fields.FollowList[this]; }
            set { Fields.FollowList[this] = value; }
        }

        [DisplayName("Anlys7"), Column("ANLYS7"), Size(30)]
        public String Anlys7
        {
            get { return Fields.Anlys7[this]; }
            set { Fields.Anlys7[this] = value; }
        }

        [DisplayName("Anlys8"), Column("ANLYS8"), Size(30)]
        public String Anlys8
        {
            get { return Fields.Anlys8[this]; }
            set { Fields.Anlys8[this] = value; }
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

        [DisplayName("Frozen"), Column("FROZEN"), Size(1)]
        public String Frozen
        {
            get { return Fields.Frozen[this]; }
            set { Fields.Frozen[this] = value; }
        }

        [DisplayName("Exclude Scrap"), Column("EXCLUDE_SCRAP"), Size(1)]
        public String ExcludeScrap
        {
            get { return Fields.ExcludeScrap[this]; }
            set { Fields.ExcludeScrap[this] = value; }
        }

        [DisplayName("Anlys9"), Column("ANLYS9"), Size(30)]
        public String Anlys9
        {
            get { return Fields.Anlys9[this]; }
            set { Fields.Anlys9[this] = value; }
        }

        [DisplayName("Anlys10"), Column("ANLYS10"), Size(30)]
        public String Anlys10
        {
            get { return Fields.Anlys10[this]; }
            set { Fields.Anlys10[this] = value; }
        }

        [DisplayName("Anlys11"), Column("ANLYS11"), Size(30)]
        public String Anlys11
        {
            get { return Fields.Anlys11[this]; }
            set { Fields.Anlys11[this] = value; }
        }

        [DisplayName("Anlys12"), Column("ANLYS12"), Size(30)]
        public String Anlys12
        {
            get { return Fields.Anlys12[this]; }
            set { Fields.Anlys12[this] = value; }
        }

        [DisplayName("Anlys13"), Column("ANLYS13"), Size(30)]
        public String Anlys13
        {
            get { return Fields.Anlys13[this]; }
            set { Fields.Anlys13[this] = value; }
        }

        [DisplayName("Anlys14"), Column("ANLYS14"), Size(30)]
        public String Anlys14
        {
            get { return Fields.Anlys14[this]; }
            set { Fields.Anlys14[this] = value; }
        }

        [DisplayName("Lots Returned"), Column("LOTS_RETURNED"), Size(8)]
        public Decimal? LotsReturned
        {
            get { return Fields.LotsReturned[this]; }
            set { Fields.LotsReturned[this] = value; }
        }

        [DisplayName("Step No"), Column("STEP_NO"), Size(6)]
        public Decimal? StepNo
        {
            get { return Fields.StepNo[this]; }
            set { Fields.StepNo[this] = value; }
        }

        [DisplayName("Cons Issue"), Column("CONS_ISSUE")]
        public Boolean? ConsIssue
        {
            get { return Fields.ConsIssue[this]; }
            set { Fields.ConsIssue[this] = value; }
        }

        [DisplayName("Cons Issue Ref No"), Column("CONS_ISSUE_REF_NO"), Size(16)]
        public String ConsIssueRefNo
        {
            get { return Fields.ConsIssueRefNo[this]; }
            set { Fields.ConsIssueRefNo[this] = value; }
        }

        [DisplayName("Cons Issue Line No"), Column("CONS_ISSUE_LINE_NO")]
        public Int32? ConsIssueLineNo
        {
            get { return Fields.ConsIssueLineNo[this]; }
            set { Fields.ConsIssueLineNo[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.RefNo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.RefNo; }
        }

        [MasterDetailRelation(foreignKey: "RefNo")]
        [DisplayName("Detail List"), NotMapped]
        public List<InventoryMovementDetailRow> DetailList  
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }

        //[MasterDetailRelation(foreignKey: "MovieId", IncludeColumns = "PersonFullname")]
        //[DisplayName("Cast List"), NotMapped]
        //public List<MovieCastRow> CastList
        //{
        //    get { return Fields.CastList[this]; }
        //    set { Fields.CastList[this] = value; }
        //}

        public static readonly RowFields Fields = new RowFields().Init();

        public InventoryMovementRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField RefNo;
            public StringField TranType;
            public DateTimeField MoveDate;
            public DateTimeField ValueDate;
            public StringField Posted;
            public StringField PostedStep1;
            public StringField FlowType;
            public StringField MoveType;
            public StringField LocFrom;
            public StringField LocTo;
            public StringField Reference;
            public StringField ReceivedFrom;
            public StringField IssuedTo;
            public StringField Dept;
            public DecimalField TotalCost;
            public DecimalField LastLineNo;
            public StringField CreatedBy;
            public DateTimeField CreatedDate;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField PostedDate;
            public StringField PostedBy;
            public DecimalField LogNo;
            public StringField SourceType;
            public StringField SourceRef;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Period;
            public DecimalField FiscalYear;
            public DecimalField PeriodNo;
            public StringField JobNo;
            public StringField BatchNo;
            public DateTimeField StartDate;
            public StringField BranchNo;
            public StringField Final;
            public DecimalField LotsPending;
            public DecimalField LotsIssued;
            public DecimalField QtyIssued;
            public DecimalField StdOutput;
            public StringField BatchSelect;
            public StringField GlLink;
            public StringField GlLinkType;
            public StringField GlLinkNo;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Particulars;
            public DecimalField RevisedCost;
            public DecimalField CostDiff;
            public StringField DiffAcct;
            public StringField ItemNo;
            public StringField BomNo;
            public StringField Uom;
            public DecimalField Qty;
            public StringField FollowList;
            public StringField Anlys7;
            public StringField Anlys8;
            public StringField Flag;
            public StringField HoldBy;
            public StringField Frozen;
            public StringField ExcludeScrap;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;
            public DecimalField LotsReturned;
            public DecimalField StepNo;
            public BooleanField ConsIssue;
            public StringField ConsIssueRefNo;
            public Int32Field ConsIssueLineNo;

            public RowListField<InventoryMovementDetailRow> DetailList;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Inventory.InventoryMovement";
            }
        }
    }
}
