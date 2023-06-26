#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseReturnRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Purchasing.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Purchasing"), TableName("[dbo].[PURETH]")]
    [DisplayName("Purchase Return"), InstanceName("Purchase Return"), TwoLevelCached]   
    public sealed class PurchaseReturnRow : Row, IIdRow, INameRow
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

        [DisplayName("Tran Date"), Column("TRAN_DATE"), NotNull]
        public DateTime? TranDate
        {
            get { return Fields.TranDate[this]; }
            set { Fields.TranDate[this] = value; }
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

        [DisplayName("Do No"), Column("DO_NO"), Size(16)]
        public String DoNo
        {
            get { return Fields.DoNo[this]; }
            set { Fields.DoNo[this] = value; }
        }

        [DisplayName("Invoice No"), Column("INVOICE_NO"), Size(16)]
        public String InvoiceNo
        {
            get { return Fields.InvoiceNo[this]; }
            set { Fields.InvoiceNo[this] = value; }
        }

        [DisplayName("Hold Items"), Column("HOLD_ITEMS"), Size(1)]
        public String HoldItems
        {
            get { return Fields.HoldItems[this]; }
            set { Fields.HoldItems[this] = value; }
        }

        [DisplayName("Loc"), Column("LOC"), Size(4)]
        public String Loc
        {
            get { return Fields.Loc[this]; }
            set { Fields.Loc[this] = value; }
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

        [DisplayName("Tot Refund Amt"), Column("TOT_REFUND_AMT"), Size(16), Scale(2)]
        public Decimal? TotRefundAmt
        {
            get { return Fields.TotRefundAmt[this]; }
            set { Fields.TotRefundAmt[this] = value; }
        }

        [DisplayName("Tot Varia Amt"), Column("TOT_VARIA_AMT"), Size(16), Scale(2)]
        public Decimal? TotVariaAmt
        {
            get { return Fields.TotVariaAmt[this]; }
            set { Fields.TotVariaAmt[this] = value; }
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

        [DisplayName("Tot Chgs Amt"), Column("TOT_CHGS_AMT"), Size(16), Scale(2)]
        public Decimal? TotChgsAmt
        {
            get { return Fields.TotChgsAmt[this]; }
            set { Fields.TotChgsAmt[this] = value; }
        }

        [DisplayName("Net Ordr Amt"), Column("NET_ORDR_AMT"), Size(16), Scale(2)]
        public Decimal? NetOrdrAmt
        {
            get { return Fields.NetOrdrAmt[this]; }
            set { Fields.NetOrdrAmt[this] = value; }
        }

        [DisplayName("Tot Gtax Amt"), Column("TOT_GTAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotGtaxAmt
        {
            get { return Fields.TotGtaxAmt[this]; }
            set { Fields.TotGtaxAmt[this] = value; }
        }

        [DisplayName("Net Pay Amt"), Column("NET_PAY_AMT"), Size(16), Scale(2)]
        public Decimal? NetPayAmt
        {
            get { return Fields.NetPayAmt[this]; }
            set { Fields.NetPayAmt[this] = value; }
        }

        [DisplayName("Tot Tdisc Cpd"), Column("TOT_TDISC_CPD"), Size(16), Scale(2)]
        public Decimal? TotTdiscCpd
        {
            get { return Fields.TotTdiscCpd[this]; }
            set { Fields.TotTdiscCpd[this] = value; }
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

        [DisplayName("Loc Refund Amt"), Column("LOC_REFUND_AMT"), Size(16), Scale(2)]
        public Decimal? LocRefundAmt
        {
            get { return Fields.LocRefundAmt[this]; }
            set { Fields.LocRefundAmt[this] = value; }
        }

        [DisplayName("Loc Varia Amt"), Column("LOC_VARIA_AMT"), Size(16), Scale(2)]
        public Decimal? LocVariaAmt
        {
            get { return Fields.LocVariaAmt[this]; }
            set { Fields.LocVariaAmt[this] = value; }
        }

        [DisplayName("Loc Tdisc Amt"), Column("LOC_TDISC_AMT"), Size(16), Scale(2)]
        public Decimal? LocTdiscAmt
        {
            get { return Fields.LocTdiscAmt[this]; }
            set { Fields.LocTdiscAmt[this] = value; }
        }

        [DisplayName("Loc Chgs Amt"), Column("LOC_CHGS_AMT"), Size(16), Scale(2)]
        public Decimal? LocChgsAmt
        {
            get { return Fields.LocChgsAmt[this]; }
            set { Fields.LocChgsAmt[this] = value; }
        }

        [DisplayName("Loc Gtax Amt"), Column("LOC_GTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocGtaxAmt
        {
            get { return Fields.LocGtaxAmt[this]; }
            set { Fields.LocGtaxAmt[this] = value; }
        }

        [DisplayName("Loc Pay Amt"), Column("LOC_PAY_AMT"), Size(16), Scale(2)]
        public Decimal? LocPayAmt
        {
            get { return Fields.LocPayAmt[this]; }
            set { Fields.LocPayAmt[this] = value; }
        }

        [DisplayName("Acct Vendor"), Column("ACCT_VENDOR"), Size(30)]
        public String AcctVendor
        {
            get { return Fields.AcctVendor[this]; }
            set { Fields.AcctVendor[this] = value; }
        }

        [DisplayName("Acct Tdisc"), Column("ACCT_TDISC"), Size(30)]
        public String AcctTdisc
        {
            get { return Fields.AcctTdisc[this]; }
            set { Fields.AcctTdisc[this] = value; }
        }

        [DisplayName("Acct Gtax"), Column("ACCT_GTAX"), Size(30)]
        public String AcctGtax
        {
            get { return Fields.AcctGtax[this]; }
            set { Fields.AcctGtax[this] = value; }
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

        [DisplayName("Log No"), Column("LOG_NO"), Size(8), NotNull]
        public Decimal? LogNo
        {
            get { return Fields.LogNo[this]; }
            set { Fields.LogNo[this] = value; }
        }

        [DisplayName("Last Log No"), Column("LAST_LOG_NO"), Size(8)]
        public Decimal? LastLogNo
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

        [DisplayName("Reason"), Column("REASON"), Size(1073741823)]
        public String Reason
        {
            get { return Fields.Reason[this]; }
            set { Fields.Reason[this] = value; }
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

        [DisplayName("Anlys15"), Column("ANLYS15"), Size(30)]
        public String Anlys15
        {
            get { return Fields.Anlys15[this]; }
            set { Fields.Anlys15[this] = value; }
        }

        [DisplayName("Anlys16"), Column("ANLYS16"), Size(30)]
        public String Anlys16
        {
            get { return Fields.Anlys16[this]; }
            set { Fields.Anlys16[this] = value; }
        }

        [DisplayName("Anlys17"), Column("ANLYS17"), Size(30)]
        public String Anlys17
        {
            get { return Fields.Anlys17[this]; }
            set { Fields.Anlys17[this] = value; }
        }

        [DisplayName("Anlys18"), Column("ANLYS18"), Size(30)]
        public String Anlys18
        {
            get { return Fields.Anlys18[this]; }
            set { Fields.Anlys18[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.RefNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PurchaseReturnRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField RefNo;
            public StringField EntryMethod;
            public StringField Posted;
            public DateTimeField TranDate;
            public StringField GrnNo;
            public StringField VendorNo;
            public StringField VendorName;
            public StringField DoNo;
            public StringField InvoiceNo;
            public StringField HoldItems;
            public StringField Loc;
            public StringField Ccy;
            public DecimalField ExchRate;
            public DecimalField TotPriceAmt;
            public DecimalField TotPtaxAmt;
            public DecimalField TotExtPrice;
            public DecimalField TotLdiscAmt;
            public DecimalField TotAtaxAmt;
            public DecimalField TotItemAmt;
            public DecimalField TotRefundAmt;
            public DecimalField TotVariaAmt;
            public DecimalField TdiscPcent;
            public DecimalField TotTdiscAmt;
            public DecimalField NetTradeAmt;
            public DecimalField TotChgsAmt;
            public DecimalField NetOrdrAmt;
            public DecimalField TotGtaxAmt;
            public DecimalField NetPayAmt;
            public DecimalField TotTdiscCpd;
            public DecimalField LocPriceAmt;
            public DecimalField LocPtaxAmt;
            public DecimalField LocExtPrice;
            public DecimalField LocLdiscAmt;
            public DecimalField LocAtaxAmt;
            public DecimalField LocItemAmt;
            public DecimalField LocRefundAmt;
            public DecimalField LocVariaAmt;
            public DecimalField LocTdiscAmt;
            public DecimalField LocChgsAmt;
            public DecimalField LocGtaxAmt;
            public DecimalField LocPayAmt;
            public StringField AcctVendor;
            public StringField AcctTdisc;
            public StringField AcctGtax;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField PostedDate;
            public StringField PostedBy;
            public DecimalField LogNo;
            public DecimalField LastLogNo;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField SettleAt;
            public StringField Reason;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Purchasing.PurchaseReturn";
            }
        }
    }
}
