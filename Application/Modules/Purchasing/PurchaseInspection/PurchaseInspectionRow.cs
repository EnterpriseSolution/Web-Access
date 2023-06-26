#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseInspectionRow.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;

namespace Matrix.Purchasing.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Purchasing"), TableName("[dbo].[PUINSH]")]
    [DisplayName("Purchase Inspection"), InstanceName("Purchase Inspection"), TwoLevelCached]   
    public sealed class PurchaseInspectionRow : Row, IIdRow, INameRow
    {
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

        [DisplayName("Inspection Date"), Column("INSPECTION_DATE"), NotNull]
        public DateTime? InspectionDate
        {
            get { return Fields.InspectionDate[this]; }
            set { Fields.InspectionDate[this] = value; }
        }

        [DisplayName("Entry Method"), Column("ENTRY_METHOD"), Size(1), NotNull]
        public String EntryMethod
        {
            get { return Fields.EntryMethod[this]; }
            set { Fields.EntryMethod[this] = value; }
        }

        [DisplayName("Posted"), Column("POSTED"), Size(1), NotNull]
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Inspected By"), Column("INSPECTED_BY"), Size(20)]
        public String InspectedBy
        {
            get { return Fields.InspectedBy[this]; }
            set { Fields.InspectedBy[this] = value; }
        }

        [DisplayName("Loc"), Column("LOC"), Size(4), NotNull]
        public String Loc
        {
            get { return Fields.Loc[this]; }
            set { Fields.Loc[this] = value; }
        }

        [DisplayName("Grn No"), Column("GRN_NO"), Size(16), NotNull]
        public String GrnNo
        {
            get { return Fields.GrnNo[this]; }
            set { Fields.GrnNo[this] = value; }
        }

        [DisplayName("Vendor No"), Column("VENDOR_NO"), Size(8), NotNull]
        public String VendorNo
        {
            get { return Fields.VendorNo[this]; }
            set { Fields.VendorNo[this] = value; }
        }

        [DisplayName("Vendor Name"), Column("VENDOR_NAME"), Size(50)]
        public String VendorName
        {
            get { return Fields.VendorName[this]; }
            set { Fields.VendorName[this] = value; }
        }

        [DisplayName("Received Date"), Column("RECEIVED_DATE")]
        public DateTime? ReceivedDate
        {
            get { return Fields.ReceivedDate[this]; }
            set { Fields.ReceivedDate[this] = value; }
        }

        [DisplayName("Ccy"), Column("CCY"), Size(4)]
        public String Ccy
        {
            get { return Fields.Ccy[this]; }
            set { Fields.Ccy[this] = value; }
        }

        [DisplayName("Exch Rate"), Column("EXCH_RATE"), Size(12), Scale(6)]
        public Decimal? ExchRate
        {
            get { return Fields.ExchRate[this]; }
            set { Fields.ExchRate[this] = value; }
        }

        [DisplayName("Full Inspection"), Column("FULL_INSPECTION"), Size(1)]
        public String FullInspection
        {
            get { return Fields.FullInspection[this]; }
            set { Fields.FullInspection[this] = value; }
        }

        [DisplayName("Pending Count"), Column("PENDING_COUNT"), Size(6)]
        public Decimal? PendingCount
        {
            get { return Fields.PendingCount[this]; }
            set { Fields.PendingCount[this] = value; }
        }

        [DisplayName("With Rejects"), Column("WITH_REJECTS"), Size(1)]
        public String WithRejects
        {
            get { return Fields.WithRejects[this]; }
            set { Fields.WithRejects[this] = value; }
        }

        [DisplayName("Hold Items"), Column("HOLD_ITEMS"), Size(1)]
        public String HoldItems
        {
            get { return Fields.HoldItems[this]; }
            set { Fields.HoldItems[this] = value; }
        }

        [DisplayName("Re Order No"), Column("RE_ORDER_NO"), Size(16), NotNull]
        public String ReOrderNo
        {
            get { return Fields.ReOrderNo[this]; }
            set { Fields.ReOrderNo[this] = value; }
        }

        [DisplayName("Re Order Date"), Column("RE_ORDER_DATE")]
        public DateTime? ReOrderDate
        {
            get { return Fields.ReOrderDate[this]; }
            set { Fields.ReOrderDate[this] = value; }
        }

        [DisplayName("Re Due Date"), Column("RE_DUE_DATE")]
        public DateTime? ReDueDate
        {
            get { return Fields.ReDueDate[this]; }
            set { Fields.ReDueDate[this] = value; }
        }

        [DisplayName("Re Sched Date"), Column("RE_SCHED_DATE")]
        public DateTime? ReSchedDate
        {
            get { return Fields.ReSchedDate[this]; }
            set { Fields.ReSchedDate[this] = value; }
        }

        [DisplayName("Re Ship To"), Column("RE_SHIP_TO"), Size(4)]
        public String ReShipTo
        {
            get { return Fields.ReShipTo[this]; }
            set { Fields.ReShipTo[this] = value; }
        }

        [DisplayName("Re Ship Via"), Column("RE_SHIP_VIA"), Size(30)]
        public String ReShipVia
        {
            get { return Fields.ReShipVia[this]; }
            set { Fields.ReShipVia[this] = value; }
        }

        [DisplayName("Re Ship Terms"), Column("RE_SHIP_TERMS"), Size(15)]
        public String ReShipTerms
        {
            get { return Fields.ReShipTerms[this]; }
            set { Fields.ReShipTerms[this] = value; }
        }

        [DisplayName("Re Count"), Column("RE_COUNT"), Size(6)]
        public Decimal? ReCount
        {
            get { return Fields.ReCount[this]; }
            set { Fields.ReCount[this] = value; }
        }

        [DisplayName("Tot Price Amt"), Column("TOT_PRICE_AMT"), Size(16), Scale(2)]
        public Decimal? TotPriceAmt
        {
            get { return Fields.TotPriceAmt[this]; }
            set { Fields.TotPriceAmt[this] = value; }
        }

        [DisplayName("Tot Ptax Amt"), Column("TOT_PTAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotPtaxAmt
        {
            get { return Fields.TotPtaxAmt[this]; }
            set { Fields.TotPtaxAmt[this] = value; }
        }

        [DisplayName("Tot Ext Price"), Column("TOT_EXT_PRICE"), Size(16), Scale(2)]
        public Decimal? TotExtPrice
        {
            get { return Fields.TotExtPrice[this]; }
            set { Fields.TotExtPrice[this] = value; }
        }

        [DisplayName("Tot Ldisc Amt"), Column("TOT_LDISC_AMT"), Size(16), Scale(2)]
        public Decimal? TotLdiscAmt
        {
            get { return Fields.TotLdiscAmt[this]; }
            set { Fields.TotLdiscAmt[this] = value; }
        }

        [DisplayName("Tot Atax Amt"), Column("TOT_ATAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotAtaxAmt
        {
            get { return Fields.TotAtaxAmt[this]; }
            set { Fields.TotAtaxAmt[this] = value; }
        }

        [DisplayName("Tot Item Amt"), Column("TOT_ITEM_AMT"), Size(16), Scale(2)]
        public Decimal? TotItemAmt
        {
            get { return Fields.TotItemAmt[this]; }
            set { Fields.TotItemAmt[this] = value; }
        }

        [DisplayName("Tdisc Pcent"), Column("TDISC_PCENT"), Size(6), Scale(2)]
        public Decimal? TdiscPcent
        {
            get { return Fields.TdiscPcent[this]; }
            set { Fields.TdiscPcent[this] = value; }
        }

        [DisplayName("Tot Tdisc Amt"), Column("TOT_TDISC_AMT"), Size(16), Scale(2)]
        public Decimal? TotTdiscAmt
        {
            get { return Fields.TotTdiscAmt[this]; }
            set { Fields.TotTdiscAmt[this] = value; }
        }

        [DisplayName("Net Trade Amt"), Column("NET_TRADE_AMT"), Size(16), Scale(2)]
        public Decimal? NetTradeAmt
        {
            get { return Fields.NetTradeAmt[this]; }
            set { Fields.NetTradeAmt[this] = value; }
        }

        [DisplayName("Loc Price Amt"), Column("LOC_PRICE_AMT"), Size(16), Scale(2)]
        public Decimal? LocPriceAmt
        {
            get { return Fields.LocPriceAmt[this]; }
            set { Fields.LocPriceAmt[this] = value; }
        }

        [DisplayName("Loc Ptax Amt"), Column("LOC_PTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocPtaxAmt
        {
            get { return Fields.LocPtaxAmt[this]; }
            set { Fields.LocPtaxAmt[this] = value; }
        }

        [DisplayName("Loc Ext Price"), Column("LOC_EXT_PRICE"), Size(16), Scale(2)]
        public Decimal? LocExtPrice
        {
            get { return Fields.LocExtPrice[this]; }
            set { Fields.LocExtPrice[this] = value; }
        }

        [DisplayName("Loc Ldisc Amt"), Column("LOC_LDISC_AMT"), Size(16), Scale(2)]
        public Decimal? LocLdiscAmt
        {
            get { return Fields.LocLdiscAmt[this]; }
            set { Fields.LocLdiscAmt[this] = value; }
        }

        [DisplayName("Loc Atax Amt"), Column("LOC_ATAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocAtaxAmt
        {
            get { return Fields.LocAtaxAmt[this]; }
            set { Fields.LocAtaxAmt[this] = value; }
        }

        [DisplayName("Loc Item Amt"), Column("LOC_ITEM_AMT"), Size(16), Scale(2)]
        public Decimal? LocItemAmt
        {
            get { return Fields.LocItemAmt[this]; }
            set { Fields.LocItemAmt[this] = value; }
        }

        [DisplayName("Loc Tdisc Amt"), Column("LOC_TDISC_AMT"), Size(16), Scale(2)]
        public Decimal? LocTdiscAmt
        {
            get { return Fields.LocTdiscAmt[this]; }
            set { Fields.LocTdiscAmt[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE"), NotNull]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10), NotNull]
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

        [DisplayName("Log No"), Column("LOG_NO"), Size(6), NotNull]
        public Decimal? LogNo
        {
            get { return Fields.LogNo[this]; }
            set { Fields.LogNo[this] = value; }
        }

        [DisplayName("Last Log No"), Column("LAST_LOG_NO"), Size(6)]
        public String LastLogNo
        {
            get { return Fields.LastLogNo[this]; }
            set { Fields.LastLogNo[this] = value; }
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

        [DisplayName("Settle At"), Column("SETTLE_AT"), Size(4)]
        public String SettleAt
        {
            get { return Fields.SettleAt[this]; }
            set { Fields.SettleAt[this] = value; }
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

        [DisplayName("Do No"), Column("DO_NO"), Size(16)]
        public String DoNo
        {
            get { return Fields.DoNo[this]; }
            set { Fields.DoNo[this] = value; }
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
        public List<PurchaseInspectionDetailRow> DetailList
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }


        public static readonly RowFields Fields = new RowFields().Init();

        public PurchaseInspectionRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField RefNo;
            public DateTimeField InspectionDate;
            public StringField EntryMethod;
            public StringField Posted;
            public StringField InspectedBy;
            public StringField Loc;
            public StringField GrnNo;
            public StringField VendorNo;
            public StringField VendorName;
            public DateTimeField ReceivedDate;
            public StringField Ccy;
            public DecimalField ExchRate;
            public StringField FullInspection;
            public DecimalField PendingCount;
            public StringField WithRejects;
            public StringField HoldItems;
            public StringField ReOrderNo;
            public DateTimeField ReOrderDate;
            public DateTimeField ReDueDate;
            public DateTimeField ReSchedDate;
            public StringField ReShipTo;
            public StringField ReShipVia;
            public StringField ReShipTerms;
            public DecimalField ReCount;
            public DecimalField TotPriceAmt;
            public DecimalField TotPtaxAmt;
            public DecimalField TotExtPrice;
            public DecimalField TotLdiscAmt;
            public DecimalField TotAtaxAmt;
            public DecimalField TotItemAmt;
            public DecimalField TdiscPcent;
            public DecimalField TotTdiscAmt;
            public DecimalField NetTradeAmt;
            public DecimalField LocPriceAmt;
            public DecimalField LocPtaxAmt;
            public DecimalField LocExtPrice;
            public DecimalField LocLdiscAmt;
            public DecimalField LocAtaxAmt;
            public DecimalField LocItemAmt;
            public DecimalField LocTdiscAmt;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField PostedDate;
            public StringField PostedBy;
            public DecimalField LogNo;
            public StringField LastLogNo;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField SettleAt;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys7;
            public StringField Anlys8;
            public StringField DoNo;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;

            public RowListField<PurchaseInspectionDetailRow> DetailList;


            public RowFields()
                : base()
            {
                LocalTextPrefix = "Purchasing.PurchaseInspection";
            }
        }
    }
}
