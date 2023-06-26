#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseReturnChargeRow.cs
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

    [ConnectionKey("Purchasing"), TableName("[dbo].[PURETC]")]
    [DisplayName("Purchase Return Charge"), InstanceName("Purchase Return Charge"), TwoLevelCached]   
    public sealed class PurchaseReturnChargeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Ref No"), Column("REF_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[PURETH]", "REF_NO"), LeftJoin("jRefNo"), QuickSearch, TextualField("RefNoEntryMethod")]
        public String RefNo
        {
            get { return Fields.RefNo[this]; }
            set { Fields.RefNo[this] = value; }
        }

        [DisplayName("Entry No"), Column("ENTRY_NO"), Size(6), PrimaryKey]
        public Decimal? EntryNo
        {
            get { return Fields.EntryNo[this]; }
            set { Fields.EntryNo[this] = value; }
        }

        [DisplayName("Order No"), Column("ORDER_NO"), Size(16)]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Seq No"), Column("SEQ_NO"), Size(4)]
        public Decimal? SeqNo
        {
            get { return Fields.SeqNo[this]; }
            set { Fields.SeqNo[this] = value; }
        }

        [DisplayName("Charge Type"), Column("CHARGE_TYPE"), Size(6)]
        public String ChargeType
        {
            get { return Fields.ChargeType[this]; }
            set { Fields.ChargeType[this] = value; }
        }

        [DisplayName("Particulars"), Column("PARTICULARS"), Size(40)]
        public String Particulars
        {
            get { return Fields.Particulars[this]; }
            set { Fields.Particulars[this] = value; }
        }

        [DisplayName("Bal Amt"), Column("BAL_AMT"), Size(14), Scale(2)]
        public Decimal? BalAmt
        {
            get { return Fields.BalAmt[this]; }
            set { Fields.BalAmt[this] = value; }
        }

        [DisplayName("Return Amt"), Column("RETURN_AMT"), Size(14), Scale(2)]
        public Decimal? ReturnAmt
        {
            get { return Fields.ReturnAmt[this]; }
            set { Fields.ReturnAmt[this] = value; }
        }

        [DisplayName("Loc Return Amt"), Column("LOC_RETURN_AMT"), Size(14), Scale(2)]
        public Decimal? LocReturnAmt
        {
            get { return Fields.LocReturnAmt[this]; }
            set { Fields.LocReturnAmt[this] = value; }
        }

        [DisplayName("Acct Purchase"), Column("ACCT_PURCHASE"), Size(30)]
        public String AcctPurchase
        {
            get { return Fields.AcctPurchase[this]; }
            set { Fields.AcctPurchase[this] = value; }
        }

        [DisplayName("Deduction"), Column("DEDUCTION"), Size(1)]
        public String Deduction
        {
            get { return Fields.Deduction[this]; }
            set { Fields.Deduction[this] = value; }
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

        [DisplayName("Ref No Recnum"), Expression("jRefNo.[RECNUM]")]
        public Decimal? RefNoRecnum
        {
            get { return Fields.RefNoRecnum[this]; }
            set { Fields.RefNoRecnum[this] = value; }
        }

        [DisplayName("Ref No Entry Method"), Expression("jRefNo.[ENTRY_METHOD]")]
        public String RefNoEntryMethod
        {
            get { return Fields.RefNoEntryMethod[this]; }
            set { Fields.RefNoEntryMethod[this] = value; }
        }

        [DisplayName("Ref No Posted"), Expression("jRefNo.[POSTED]")]
        public String RefNoPosted
        {
            get { return Fields.RefNoPosted[this]; }
            set { Fields.RefNoPosted[this] = value; }
        }

        [DisplayName("Ref No Tran Date"), Expression("jRefNo.[TRAN_DATE]")]
        public DateTime? RefNoTranDate
        {
            get { return Fields.RefNoTranDate[this]; }
            set { Fields.RefNoTranDate[this] = value; }
        }

        [DisplayName("Ref No Grn No"), Expression("jRefNo.[GRN_NO]")]
        public String RefNoGrnNo
        {
            get { return Fields.RefNoGrnNo[this]; }
            set { Fields.RefNoGrnNo[this] = value; }
        }

        [DisplayName("Ref No Vendor No"), Expression("jRefNo.[VENDOR_NO]")]
        public String RefNoVendorNo
        {
            get { return Fields.RefNoVendorNo[this]; }
            set { Fields.RefNoVendorNo[this] = value; }
        }

        [DisplayName("Ref No Vendor Name"), Expression("jRefNo.[VENDOR_NAME]")]
        public String RefNoVendorName
        {
            get { return Fields.RefNoVendorName[this]; }
            set { Fields.RefNoVendorName[this] = value; }
        }

        [DisplayName("Ref No Do No"), Expression("jRefNo.[DO_NO]")]
        public String RefNoDoNo
        {
            get { return Fields.RefNoDoNo[this]; }
            set { Fields.RefNoDoNo[this] = value; }
        }

        [DisplayName("Ref No Invoice No"), Expression("jRefNo.[INVOICE_NO]")]
        public String RefNoInvoiceNo
        {
            get { return Fields.RefNoInvoiceNo[this]; }
            set { Fields.RefNoInvoiceNo[this] = value; }
        }

        [DisplayName("Ref No Hold Items"), Expression("jRefNo.[HOLD_ITEMS]")]
        public String RefNoHoldItems
        {
            get { return Fields.RefNoHoldItems[this]; }
            set { Fields.RefNoHoldItems[this] = value; }
        }

        [DisplayName("Ref No Loc"), Expression("jRefNo.[LOC]")]
        public String RefNoLoc
        {
            get { return Fields.RefNoLoc[this]; }
            set { Fields.RefNoLoc[this] = value; }
        }

        [DisplayName("Ref No Ccy"), Expression("jRefNo.[CCY]")]
        public String RefNoCcy
        {
            get { return Fields.RefNoCcy[this]; }
            set { Fields.RefNoCcy[this] = value; }
        }

        [DisplayName("Ref No Exch Rate"), Expression("jRefNo.[EXCH_RATE]")]
        public Decimal? RefNoExchRate
        {
            get { return Fields.RefNoExchRate[this]; }
            set { Fields.RefNoExchRate[this] = value; }
        }

        [DisplayName("Ref No Tot Price Amt"), Expression("jRefNo.[TOT_PRICE_AMT]")]
        public Decimal? RefNoTotPriceAmt
        {
            get { return Fields.RefNoTotPriceAmt[this]; }
            set { Fields.RefNoTotPriceAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Ptax Amt"), Expression("jRefNo.[TOT_PTAX_AMT]")]
        public Decimal? RefNoTotPtaxAmt
        {
            get { return Fields.RefNoTotPtaxAmt[this]; }
            set { Fields.RefNoTotPtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Ext Price"), Expression("jRefNo.[TOT_EXT_PRICE]")]
        public Decimal? RefNoTotExtPrice
        {
            get { return Fields.RefNoTotExtPrice[this]; }
            set { Fields.RefNoTotExtPrice[this] = value; }
        }

        [DisplayName("Ref No Tot Ldisc Amt"), Expression("jRefNo.[TOT_LDISC_AMT]")]
        public Decimal? RefNoTotLdiscAmt
        {
            get { return Fields.RefNoTotLdiscAmt[this]; }
            set { Fields.RefNoTotLdiscAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Atax Amt"), Expression("jRefNo.[TOT_ATAX_AMT]")]
        public Decimal? RefNoTotAtaxAmt
        {
            get { return Fields.RefNoTotAtaxAmt[this]; }
            set { Fields.RefNoTotAtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Item Amt"), Expression("jRefNo.[TOT_ITEM_AMT]")]
        public Decimal? RefNoTotItemAmt
        {
            get { return Fields.RefNoTotItemAmt[this]; }
            set { Fields.RefNoTotItemAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Refund Amt"), Expression("jRefNo.[TOT_REFUND_AMT]")]
        public Decimal? RefNoTotRefundAmt
        {
            get { return Fields.RefNoTotRefundAmt[this]; }
            set { Fields.RefNoTotRefundAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Varia Amt"), Expression("jRefNo.[TOT_VARIA_AMT]")]
        public Decimal? RefNoTotVariaAmt
        {
            get { return Fields.RefNoTotVariaAmt[this]; }
            set { Fields.RefNoTotVariaAmt[this] = value; }
        }

        [DisplayName("Ref No Tdisc Pcent"), Expression("jRefNo.[TDISC_PCENT]")]
        public Decimal? RefNoTdiscPcent
        {
            get { return Fields.RefNoTdiscPcent[this]; }
            set { Fields.RefNoTdiscPcent[this] = value; }
        }

        [DisplayName("Ref No Tot Tdisc Amt"), Expression("jRefNo.[TOT_TDISC_AMT]")]
        public Decimal? RefNoTotTdiscAmt
        {
            get { return Fields.RefNoTotTdiscAmt[this]; }
            set { Fields.RefNoTotTdiscAmt[this] = value; }
        }

        [DisplayName("Ref No Net Trade Amt"), Expression("jRefNo.[NET_TRADE_AMT]")]
        public Decimal? RefNoNetTradeAmt
        {
            get { return Fields.RefNoNetTradeAmt[this]; }
            set { Fields.RefNoNetTradeAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Chgs Amt"), Expression("jRefNo.[TOT_CHGS_AMT]")]
        public Decimal? RefNoTotChgsAmt
        {
            get { return Fields.RefNoTotChgsAmt[this]; }
            set { Fields.RefNoTotChgsAmt[this] = value; }
        }

        [DisplayName("Ref No Net Ordr Amt"), Expression("jRefNo.[NET_ORDR_AMT]")]
        public Decimal? RefNoNetOrdrAmt
        {
            get { return Fields.RefNoNetOrdrAmt[this]; }
            set { Fields.RefNoNetOrdrAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Gtax Amt"), Expression("jRefNo.[TOT_GTAX_AMT]")]
        public Decimal? RefNoTotGtaxAmt
        {
            get { return Fields.RefNoTotGtaxAmt[this]; }
            set { Fields.RefNoTotGtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Net Pay Amt"), Expression("jRefNo.[NET_PAY_AMT]")]
        public Decimal? RefNoNetPayAmt
        {
            get { return Fields.RefNoNetPayAmt[this]; }
            set { Fields.RefNoNetPayAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Tdisc Cpd"), Expression("jRefNo.[TOT_TDISC_CPD]")]
        public Decimal? RefNoTotTdiscCpd
        {
            get { return Fields.RefNoTotTdiscCpd[this]; }
            set { Fields.RefNoTotTdiscCpd[this] = value; }
        }

        [DisplayName("Ref No Loc Price Amt"), Expression("jRefNo.[LOC_PRICE_AMT]")]
        public Decimal? RefNoLocPriceAmt
        {
            get { return Fields.RefNoLocPriceAmt[this]; }
            set { Fields.RefNoLocPriceAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Ptax Amt"), Expression("jRefNo.[LOC_PTAX_AMT]")]
        public Decimal? RefNoLocPtaxAmt
        {
            get { return Fields.RefNoLocPtaxAmt[this]; }
            set { Fields.RefNoLocPtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Ext Price"), Expression("jRefNo.[LOC_EXT_PRICE]")]
        public Decimal? RefNoLocExtPrice
        {
            get { return Fields.RefNoLocExtPrice[this]; }
            set { Fields.RefNoLocExtPrice[this] = value; }
        }

        [DisplayName("Ref No Loc Ldisc Amt"), Expression("jRefNo.[LOC_LDISC_AMT]")]
        public Decimal? RefNoLocLdiscAmt
        {
            get { return Fields.RefNoLocLdiscAmt[this]; }
            set { Fields.RefNoLocLdiscAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Atax Amt"), Expression("jRefNo.[LOC_ATAX_AMT]")]
        public Decimal? RefNoLocAtaxAmt
        {
            get { return Fields.RefNoLocAtaxAmt[this]; }
            set { Fields.RefNoLocAtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Item Amt"), Expression("jRefNo.[LOC_ITEM_AMT]")]
        public Decimal? RefNoLocItemAmt
        {
            get { return Fields.RefNoLocItemAmt[this]; }
            set { Fields.RefNoLocItemAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Refund Amt"), Expression("jRefNo.[LOC_REFUND_AMT]")]
        public Decimal? RefNoLocRefundAmt
        {
            get { return Fields.RefNoLocRefundAmt[this]; }
            set { Fields.RefNoLocRefundAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Varia Amt"), Expression("jRefNo.[LOC_VARIA_AMT]")]
        public Decimal? RefNoLocVariaAmt
        {
            get { return Fields.RefNoLocVariaAmt[this]; }
            set { Fields.RefNoLocVariaAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Tdisc Amt"), Expression("jRefNo.[LOC_TDISC_AMT]")]
        public Decimal? RefNoLocTdiscAmt
        {
            get { return Fields.RefNoLocTdiscAmt[this]; }
            set { Fields.RefNoLocTdiscAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Chgs Amt"), Expression("jRefNo.[LOC_CHGS_AMT]")]
        public Decimal? RefNoLocChgsAmt
        {
            get { return Fields.RefNoLocChgsAmt[this]; }
            set { Fields.RefNoLocChgsAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Gtax Amt"), Expression("jRefNo.[LOC_GTAX_AMT]")]
        public Decimal? RefNoLocGtaxAmt
        {
            get { return Fields.RefNoLocGtaxAmt[this]; }
            set { Fields.RefNoLocGtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Pay Amt"), Expression("jRefNo.[LOC_PAY_AMT]")]
        public Decimal? RefNoLocPayAmt
        {
            get { return Fields.RefNoLocPayAmt[this]; }
            set { Fields.RefNoLocPayAmt[this] = value; }
        }

        [DisplayName("Ref No Acct Vendor"), Expression("jRefNo.[ACCT_VENDOR]")]
        public String RefNoAcctVendor
        {
            get { return Fields.RefNoAcctVendor[this]; }
            set { Fields.RefNoAcctVendor[this] = value; }
        }

        [DisplayName("Ref No Acct Tdisc"), Expression("jRefNo.[ACCT_TDISC]")]
        public String RefNoAcctTdisc
        {
            get { return Fields.RefNoAcctTdisc[this]; }
            set { Fields.RefNoAcctTdisc[this] = value; }
        }

        [DisplayName("Ref No Acct Gtax"), Expression("jRefNo.[ACCT_GTAX]")]
        public String RefNoAcctGtax
        {
            get { return Fields.RefNoAcctGtax[this]; }
            set { Fields.RefNoAcctGtax[this] = value; }
        }

        [DisplayName("Ref No Created Date"), Expression("jRefNo.[CREATED_DATE]")]
        public DateTime? RefNoCreatedDate
        {
            get { return Fields.RefNoCreatedDate[this]; }
            set { Fields.RefNoCreatedDate[this] = value; }
        }

        [DisplayName("Ref No Created By"), Expression("jRefNo.[CREATED_BY]")]
        public String RefNoCreatedBy
        {
            get { return Fields.RefNoCreatedBy[this]; }
            set { Fields.RefNoCreatedBy[this] = value; }
        }

        [DisplayName("Ref No Revised Date"), Expression("jRefNo.[REVISED_DATE]")]
        public DateTime? RefNoRevisedDate
        {
            get { return Fields.RefNoRevisedDate[this]; }
            set { Fields.RefNoRevisedDate[this] = value; }
        }

        [DisplayName("Ref No Revised By"), Expression("jRefNo.[REVISED_BY]")]
        public String RefNoRevisedBy
        {
            get { return Fields.RefNoRevisedBy[this]; }
            set { Fields.RefNoRevisedBy[this] = value; }
        }

        [DisplayName("Ref No Posted Date"), Expression("jRefNo.[POSTED_DATE]")]
        public DateTime? RefNoPostedDate
        {
            get { return Fields.RefNoPostedDate[this]; }
            set { Fields.RefNoPostedDate[this] = value; }
        }

        [DisplayName("Ref No Posted By"), Expression("jRefNo.[POSTED_BY]")]
        public String RefNoPostedBy
        {
            get { return Fields.RefNoPostedBy[this]; }
            set { Fields.RefNoPostedBy[this] = value; }
        }

        [DisplayName("Ref No Log No"), Expression("jRefNo.[LOG_NO]")]
        public Decimal? RefNoLogNo
        {
            get { return Fields.RefNoLogNo[this]; }
            set { Fields.RefNoLogNo[this] = value; }
        }

        [DisplayName("Ref No Last Log No"), Expression("jRefNo.[LAST_LOG_NO]")]
        public Decimal? RefNoLastLogNo
        {
            get { return Fields.RefNoLastLogNo[this]; }
            set { Fields.RefNoLastLogNo[this] = value; }
        }

        [DisplayName("Ref No Owner Branch"), Expression("jRefNo.[OWNER_BRANCH]")]
        public String RefNoOwnerBranch
        {
            get { return Fields.RefNoOwnerBranch[this]; }
            set { Fields.RefNoOwnerBranch[this] = value; }
        }

        [DisplayName("Ref No Source Branch"), Expression("jRefNo.[SOURCE_BRANCH]")]
        public String RefNoSourceBranch
        {
            get { return Fields.RefNoSourceBranch[this]; }
            set { Fields.RefNoSourceBranch[this] = value; }
        }

        [DisplayName("Ref No Settle At"), Expression("jRefNo.[SETTLE_AT]")]
        public String RefNoSettleAt
        {
            get { return Fields.RefNoSettleAt[this]; }
            set { Fields.RefNoSettleAt[this] = value; }
        }

        [DisplayName("Ref No Reason"), Expression("jRefNo.[REASON]")]
        public String RefNoReason
        {
            get { return Fields.RefNoReason[this]; }
            set { Fields.RefNoReason[this] = value; }
        }

        [DisplayName("Ref No Anlys9"), Expression("jRefNo.[ANLYS9]")]
        public String RefNoAnlys9
        {
            get { return Fields.RefNoAnlys9[this]; }
            set { Fields.RefNoAnlys9[this] = value; }
        }

        [DisplayName("Ref No Anlys10"), Expression("jRefNo.[ANLYS10]")]
        public String RefNoAnlys10
        {
            get { return Fields.RefNoAnlys10[this]; }
            set { Fields.RefNoAnlys10[this] = value; }
        }

        [DisplayName("Ref No Anlys11"), Expression("jRefNo.[ANLYS11]")]
        public String RefNoAnlys11
        {
            get { return Fields.RefNoAnlys11[this]; }
            set { Fields.RefNoAnlys11[this] = value; }
        }

        [DisplayName("Ref No Anlys12"), Expression("jRefNo.[ANLYS12]")]
        public String RefNoAnlys12
        {
            get { return Fields.RefNoAnlys12[this]; }
            set { Fields.RefNoAnlys12[this] = value; }
        }

        [DisplayName("Ref No Anlys13"), Expression("jRefNo.[ANLYS13]")]
        public String RefNoAnlys13
        {
            get { return Fields.RefNoAnlys13[this]; }
            set { Fields.RefNoAnlys13[this] = value; }
        }

        [DisplayName("Ref No Anlys14"), Expression("jRefNo.[ANLYS14]")]
        public String RefNoAnlys14
        {
            get { return Fields.RefNoAnlys14[this]; }
            set { Fields.RefNoAnlys14[this] = value; }
        }

        [DisplayName("Ref No Anlys15"), Expression("jRefNo.[ANLYS15]")]
        public String RefNoAnlys15
        {
            get { return Fields.RefNoAnlys15[this]; }
            set { Fields.RefNoAnlys15[this] = value; }
        }

        [DisplayName("Ref No Anlys16"), Expression("jRefNo.[ANLYS16]")]
        public String RefNoAnlys16
        {
            get { return Fields.RefNoAnlys16[this]; }
            set { Fields.RefNoAnlys16[this] = value; }
        }

        [DisplayName("Ref No Anlys17"), Expression("jRefNo.[ANLYS17]")]
        public String RefNoAnlys17
        {
            get { return Fields.RefNoAnlys17[this]; }
            set { Fields.RefNoAnlys17[this] = value; }
        }

        [DisplayName("Ref No Anlys18"), Expression("jRefNo.[ANLYS18]")]
        public String RefNoAnlys18
        {
            get { return Fields.RefNoAnlys18[this]; }
            set { Fields.RefNoAnlys18[this] = value; }
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

        public PurchaseReturnChargeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField RefNo;
            public DecimalField EntryNo;
            public StringField OrderNo;
            public DecimalField SeqNo;
            public StringField ChargeType;
            public StringField Particulars;
            public DecimalField BalAmt;
            public DecimalField ReturnAmt;
            public DecimalField LocReturnAmt;
            public StringField AcctPurchase;
            public StringField Deduction;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys7;
            public StringField Anlys8;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;

            public DecimalField RefNoRecnum;
            public StringField RefNoEntryMethod;
            public StringField RefNoPosted;
            public DateTimeField RefNoTranDate;
            public StringField RefNoGrnNo;
            public StringField RefNoVendorNo;
            public StringField RefNoVendorName;
            public StringField RefNoDoNo;
            public StringField RefNoInvoiceNo;
            public StringField RefNoHoldItems;
            public StringField RefNoLoc;
            public StringField RefNoCcy;
            public DecimalField RefNoExchRate;
            public DecimalField RefNoTotPriceAmt;
            public DecimalField RefNoTotPtaxAmt;
            public DecimalField RefNoTotExtPrice;
            public DecimalField RefNoTotLdiscAmt;
            public DecimalField RefNoTotAtaxAmt;
            public DecimalField RefNoTotItemAmt;
            public DecimalField RefNoTotRefundAmt;
            public DecimalField RefNoTotVariaAmt;
            public DecimalField RefNoTdiscPcent;
            public DecimalField RefNoTotTdiscAmt;
            public DecimalField RefNoNetTradeAmt;
            public DecimalField RefNoTotChgsAmt;
            public DecimalField RefNoNetOrdrAmt;
            public DecimalField RefNoTotGtaxAmt;
            public DecimalField RefNoNetPayAmt;
            public DecimalField RefNoTotTdiscCpd;
            public DecimalField RefNoLocPriceAmt;
            public DecimalField RefNoLocPtaxAmt;
            public DecimalField RefNoLocExtPrice;
            public DecimalField RefNoLocLdiscAmt;
            public DecimalField RefNoLocAtaxAmt;
            public DecimalField RefNoLocItemAmt;
            public DecimalField RefNoLocRefundAmt;
            public DecimalField RefNoLocVariaAmt;
            public DecimalField RefNoLocTdiscAmt;
            public DecimalField RefNoLocChgsAmt;
            public DecimalField RefNoLocGtaxAmt;
            public DecimalField RefNoLocPayAmt;
            public StringField RefNoAcctVendor;
            public StringField RefNoAcctTdisc;
            public StringField RefNoAcctGtax;
            public DateTimeField RefNoCreatedDate;
            public StringField RefNoCreatedBy;
            public DateTimeField RefNoRevisedDate;
            public StringField RefNoRevisedBy;
            public DateTimeField RefNoPostedDate;
            public StringField RefNoPostedBy;
            public DecimalField RefNoLogNo;
            public DecimalField RefNoLastLogNo;
            public StringField RefNoOwnerBranch;
            public StringField RefNoSourceBranch;
            public StringField RefNoSettleAt;
            public StringField RefNoReason;
            public StringField RefNoAnlys9;
            public StringField RefNoAnlys10;
            public StringField RefNoAnlys11;
            public StringField RefNoAnlys12;
            public StringField RefNoAnlys13;
            public StringField RefNoAnlys14;
            public StringField RefNoAnlys15;
            public StringField RefNoAnlys16;
            public StringField RefNoAnlys17;
            public StringField RefNoAnlys18;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Purchasing.PurchaseReturnCharge";
            }
        }
    }
}
