#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivableInvoiceOrderRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Finance.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Finance"), TableName("[dbo].[ARINVO]")]
    [DisplayName("Accounts Receivable Invoice Order"), InstanceName("Accounts Receivable Invoice Order"), TwoLevelCached]   
    public sealed class AccountsReceivableInvoiceOrderRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Invoice No"), Column("INVOICE_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[ARINVH]", "INVOICE_NO"), LeftJoin("jInvoiceNo"), QuickSearch, TextualField("InvoiceNoDirectEntry")]
        public String InvoiceNo
        {
            get { return Fields.InvoiceNo[this]; }
            set { Fields.InvoiceNo[this] = value; }
        }

        [DisplayName("Shipment Ref"), Column("SHIPMENT_REF"), Size(16), PrimaryKey]
        public String ShipmentRef
        {
            get { return Fields.ShipmentRef[this]; }
            set { Fields.ShipmentRef[this] = value; }
        }

        [DisplayName("Order No"), Column("ORDER_NO"), Size(16), PrimaryKey]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Tot Price Amt"), Column("TOT_PRICE_AMT"), Size(14), Scale(2)]
        public Decimal? TotPriceAmt
        {
            get { return Fields.TotPriceAmt[this]; }
            set { Fields.TotPriceAmt[this] = value; }
        }

        [DisplayName("Tot Ext Price"), Column("TOT_EXT_PRICE"), Size(14), Scale(2)]
        public Decimal? TotExtPrice
        {
            get { return Fields.TotExtPrice[this]; }
            set { Fields.TotExtPrice[this] = value; }
        }

        [DisplayName("Tot Ldisc Amt"), Column("TOT_LDISC_AMT"), Size(14), Scale(2)]
        public Decimal? TotLdiscAmt
        {
            get { return Fields.TotLdiscAmt[this]; }
            set { Fields.TotLdiscAmt[this] = value; }
        }

        [DisplayName("Tot Item Amt"), Column("TOT_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? TotItemAmt
        {
            get { return Fields.TotItemAmt[this]; }
            set { Fields.TotItemAmt[this] = value; }
        }

        [DisplayName("Tdisc Pcent"), Column("TDISC_PCENT"), Size(12), Scale(2)]
        public Decimal? TdiscPcent
        {
            get { return Fields.TdiscPcent[this]; }
            set { Fields.TdiscPcent[this] = value; }
        }

        [DisplayName("Tot Tdisc Amt"), Column("TOT_TDISC_AMT"), Size(14), Scale(2)]
        public Decimal? TotTdiscAmt
        {
            get { return Fields.TotTdiscAmt[this]; }
            set { Fields.TotTdiscAmt[this] = value; }
        }

        [DisplayName("Net Trade Amt"), Column("NET_TRADE_AMT"), Size(14), Scale(2)]
        public Decimal? NetTradeAmt
        {
            get { return Fields.NetTradeAmt[this]; }
            set { Fields.NetTradeAmt[this] = value; }
        }

        [DisplayName("Tot Chgs Amt"), Column("TOT_CHGS_AMT"), Size(14), Scale(2)]
        public Decimal? TotChgsAmt
        {
            get { return Fields.TotChgsAmt[this]; }
            set { Fields.TotChgsAmt[this] = value; }
        }

        [DisplayName("Net Ordr Amt"), Column("NET_ORDR_AMT"), Size(14), Scale(2)]
        public Decimal? NetOrdrAmt
        {
            get { return Fields.NetOrdrAmt[this]; }
            set { Fields.NetOrdrAmt[this] = value; }
        }

        [DisplayName("Net Pay Amt"), Column("NET_PAY_AMT"), Size(14), Scale(2)]
        public Decimal? NetPayAmt
        {
            get { return Fields.NetPayAmt[this]; }
            set { Fields.NetPayAmt[this] = value; }
        }

        [DisplayName("Dps Cover"), Column("DPS_COVER"), Size(12), Scale(2)]
        public Decimal? DpsCover
        {
            get { return Fields.DpsCover[this]; }
            set { Fields.DpsCover[this] = value; }
        }

        [DisplayName("Dps Pcent"), Column("DPS_PCENT"), Size(12), Scale(2)]
        public Decimal? DpsPcent
        {
            get { return Fields.DpsPcent[this]; }
            set { Fields.DpsPcent[this] = value; }
        }

        [DisplayName("Dps Applied"), Column("DPS_APPLIED"), Size(12), Scale(2)]
        public Decimal? DpsApplied
        {
            get { return Fields.DpsApplied[this]; }
            set { Fields.DpsApplied[this] = value; }
        }

        [DisplayName("Loc Dps Applied"), Column("LOC_DPS_APPLIED"), Size(12), Scale(2)]
        public Decimal? LocDpsApplied
        {
            get { return Fields.LocDpsApplied[this]; }
            set { Fields.LocDpsApplied[this] = value; }
        }

        [DisplayName("Net Bal Amt"), Column("NET_BAL_AMT"), Size(14), Scale(2)]
        public Decimal? NetBalAmt
        {
            get { return Fields.NetBalAmt[this]; }
            set { Fields.NetBalAmt[this] = value; }
        }

        [DisplayName("Sltax Type"), Column("SLTAX_TYPE"), Size(1)]
        public String SltaxType
        {
            get { return Fields.SltaxType[this]; }
            set { Fields.SltaxType[this] = value; }
        }

        [DisplayName("Gsltax Pcent"), Column("GSLTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? GsltaxPcent
        {
            get { return Fields.GsltaxPcent[this]; }
            set { Fields.GsltaxPcent[this] = value; }
        }

        [DisplayName("Tot Gsltax Amt"), Column("TOT_GSLTAX_AMT"), Size(14), Scale(2)]
        public Decimal? TotGsltaxAmt
        {
            get { return Fields.TotGsltaxAmt[this]; }
            set { Fields.TotGsltaxAmt[this] = value; }
        }

        [DisplayName("Tot Lsltax Amt"), Column("TOT_LSLTAX_AMT"), Size(14), Scale(2)]
        public Decimal? TotLsltaxAmt
        {
            get { return Fields.TotLsltaxAmt[this]; }
            set { Fields.TotLsltaxAmt[this] = value; }
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

        [DisplayName("Customer Po"), Column("CUSTOMER_PO"), Size(20)]
        public String CustomerPo
        {
            get { return Fields.CustomerPo[this]; }
            set { Fields.CustomerPo[this] = value; }
        }

        [DisplayName("Anlys21"), Column("ANLYS21"), Size(30)]
        public String Anlys21
        {
            get { return Fields.Anlys21[this]; }
            set { Fields.Anlys21[this] = value; }
        }

        [DisplayName("Anlys22"), Column("ANLYS22"), Size(30)]
        public String Anlys22
        {
            get { return Fields.Anlys22[this]; }
            set { Fields.Anlys22[this] = value; }
        }

        [DisplayName("Anlys23"), Column("ANLYS23"), Size(30)]
        public String Anlys23
        {
            get { return Fields.Anlys23[this]; }
            set { Fields.Anlys23[this] = value; }
        }

        [DisplayName("Anlys24"), Column("ANLYS24"), Size(30)]
        public String Anlys24
        {
            get { return Fields.Anlys24[this]; }
            set { Fields.Anlys24[this] = value; }
        }

        [DisplayName("Anlys25"), Column("ANLYS25"), Size(30)]
        public String Anlys25
        {
            get { return Fields.Anlys25[this]; }
            set { Fields.Anlys25[this] = value; }
        }

        [DisplayName("Anlys26"), Column("ANLYS26"), Size(30)]
        public String Anlys26
        {
            get { return Fields.Anlys26[this]; }
            set { Fields.Anlys26[this] = value; }
        }

        [DisplayName("Invoice No Recnum"), Expression("jInvoiceNo.[RECNUM]")]
        public Decimal? InvoiceNoRecnum
        {
            get { return Fields.InvoiceNoRecnum[this]; }
            set { Fields.InvoiceNoRecnum[this] = value; }
        }

        [DisplayName("Invoice No Direct Entry"), Expression("jInvoiceNo.[DIRECT_ENTRY]")]
        public String InvoiceNoDirectEntry
        {
            get { return Fields.InvoiceNoDirectEntry[this]; }
            set { Fields.InvoiceNoDirectEntry[this] = value; }
        }

        [DisplayName("Invoice No Posted"), Expression("jInvoiceNo.[POSTED]")]
        public String InvoiceNoPosted
        {
            get { return Fields.InvoiceNoPosted[this]; }
            set { Fields.InvoiceNoPosted[this] = value; }
        }

        [DisplayName("Invoice No Closed"), Expression("jInvoiceNo.[CLOSED]")]
        public String InvoiceNoClosed
        {
            get { return Fields.InvoiceNoClosed[this]; }
            set { Fields.InvoiceNoClosed[this] = value; }
        }

        [DisplayName("Invoice No Returned"), Expression("jInvoiceNo.[RETURNED]")]
        public String InvoiceNoReturned
        {
            get { return Fields.InvoiceNoReturned[this]; }
            set { Fields.InvoiceNoReturned[this] = value; }
        }

        [DisplayName("Invoice No Debit Note"), Expression("jInvoiceNo.[DEBIT_NOTE]")]
        public String InvoiceNoDebitNote
        {
            get { return Fields.InvoiceNoDebitNote[this]; }
            set { Fields.InvoiceNoDebitNote[this] = value; }
        }

        [DisplayName("Invoice No Customer No"), Expression("jInvoiceNo.[CUSTOMER_NO]")]
        public String InvoiceNoCustomerNo
        {
            get { return Fields.InvoiceNoCustomerNo[this]; }
            set { Fields.InvoiceNoCustomerNo[this] = value; }
        }

        [DisplayName("Invoice No Customer Name"), Expression("jInvoiceNo.[CUSTOMER_NAME]")]
        public String InvoiceNoCustomerName
        {
            get { return Fields.InvoiceNoCustomerName[this]; }
            set { Fields.InvoiceNoCustomerName[this] = value; }
        }

        [DisplayName("Invoice No Address"), Expression("jInvoiceNo.[ADDRESS]")]
        public String InvoiceNoAddress
        {
            get { return Fields.InvoiceNoAddress[this]; }
            set { Fields.InvoiceNoAddress[this] = value; }
        }

        [DisplayName("Invoice No Address2"), Expression("jInvoiceNo.[ADDRESS2]")]
        public String InvoiceNoAddress2
        {
            get { return Fields.InvoiceNoAddress2[this]; }
            set { Fields.InvoiceNoAddress2[this] = value; }
        }

        [DisplayName("Invoice No Address3"), Expression("jInvoiceNo.[ADDRESS3]")]
        public String InvoiceNoAddress3
        {
            get { return Fields.InvoiceNoAddress3[this]; }
            set { Fields.InvoiceNoAddress3[this] = value; }
        }

        [DisplayName("Invoice No Address4"), Expression("jInvoiceNo.[ADDRESS4]")]
        public String InvoiceNoAddress4
        {
            get { return Fields.InvoiceNoAddress4[this]; }
            set { Fields.InvoiceNoAddress4[this] = value; }
        }

        [DisplayName("Invoice No Attention"), Expression("jInvoiceNo.[ATTENTION]")]
        public String InvoiceNoAttention
        {
            get { return Fields.InvoiceNoAttention[this]; }
            set { Fields.InvoiceNoAttention[this] = value; }
        }

        [DisplayName("Invoice No Invoice Date"), Expression("jInvoiceNo.[INVOICE_DATE]")]
        public DateTime? InvoiceNoInvoiceDate
        {
            get { return Fields.InvoiceNoInvoiceDate[this]; }
            set { Fields.InvoiceNoInvoiceDate[this] = value; }
        }

        [DisplayName("Invoice No Period"), Expression("jInvoiceNo.[PERIOD]")]
        public String InvoiceNoPeriod
        {
            get { return Fields.InvoiceNoPeriod[this]; }
            set { Fields.InvoiceNoPeriod[this] = value; }
        }

        [DisplayName("Invoice No Fiscal Year"), Expression("jInvoiceNo.[FISCAL_YEAR]")]
        public Decimal? InvoiceNoFiscalYear
        {
            get { return Fields.InvoiceNoFiscalYear[this]; }
            set { Fields.InvoiceNoFiscalYear[this] = value; }
        }

        [DisplayName("Invoice No Period No"), Expression("jInvoiceNo.[PERIOD_NO]")]
        public Decimal? InvoiceNoPeriodNo
        {
            get { return Fields.InvoiceNoPeriodNo[this]; }
            set { Fields.InvoiceNoPeriodNo[this] = value; }
        }

        [DisplayName("Invoice No Salesman"), Expression("jInvoiceNo.[SALESMAN]")]
        public String InvoiceNoSalesman
        {
            get { return Fields.InvoiceNoSalesman[this]; }
            set { Fields.InvoiceNoSalesman[this] = value; }
        }

        [DisplayName("Invoice No Ccy"), Expression("jInvoiceNo.[CCY]")]
        public String InvoiceNoCcy
        {
            get { return Fields.InvoiceNoCcy[this]; }
            set { Fields.InvoiceNoCcy[this] = value; }
        }

        [DisplayName("Invoice No Exch Rate"), Expression("jInvoiceNo.[EXCH_RATE]")]
        public Decimal? InvoiceNoExchRate
        {
            get { return Fields.InvoiceNoExchRate[this]; }
            set { Fields.InvoiceNoExchRate[this] = value; }
        }

        [DisplayName("Invoice No Pay Terms"), Expression("jInvoiceNo.[PAY_TERMS]")]
        public String InvoiceNoPayTerms
        {
            get { return Fields.InvoiceNoPayTerms[this]; }
            set { Fields.InvoiceNoPayTerms[this] = value; }
        }

        [DisplayName("Invoice No Disc Days"), Expression("jInvoiceNo.[DISC_DAYS]")]
        public Decimal? InvoiceNoDiscDays
        {
            get { return Fields.InvoiceNoDiscDays[this]; }
            set { Fields.InvoiceNoDiscDays[this] = value; }
        }

        [DisplayName("Invoice No Disc Pcent"), Expression("jInvoiceNo.[DISC_PCENT]")]
        public Decimal? InvoiceNoDiscPcent
        {
            get { return Fields.InvoiceNoDiscPcent[this]; }
            set { Fields.InvoiceNoDiscPcent[this] = value; }
        }

        [DisplayName("Invoice No Due Days"), Expression("jInvoiceNo.[DUE_DAYS]")]
        public Decimal? InvoiceNoDueDays
        {
            get { return Fields.InvoiceNoDueDays[this]; }
            set { Fields.InvoiceNoDueDays[this] = value; }
        }

        [DisplayName("Invoice No Discount Date"), Expression("jInvoiceNo.[DISCOUNT_DATE]")]
        public DateTime? InvoiceNoDiscountDate
        {
            get { return Fields.InvoiceNoDiscountDate[this]; }
            set { Fields.InvoiceNoDiscountDate[this] = value; }
        }

        [DisplayName("Invoice No Due Date"), Expression("jInvoiceNo.[DUE_DATE]")]
        public DateTime? InvoiceNoDueDate
        {
            get { return Fields.InvoiceNoDueDate[this]; }
            set { Fields.InvoiceNoDueDate[this] = value; }
        }

        [DisplayName("Invoice No Expected Date"), Expression("jInvoiceNo.[EXPECTED_DATE]")]
        public DateTime? InvoiceNoExpectedDate
        {
            get { return Fields.InvoiceNoExpectedDate[this]; }
            set { Fields.InvoiceNoExpectedDate[this] = value; }
        }

        [DisplayName("Invoice No Anlys1"), Expression("jInvoiceNo.[ANLYS1]")]
        public String InvoiceNoAnlys1
        {
            get { return Fields.InvoiceNoAnlys1[this]; }
            set { Fields.InvoiceNoAnlys1[this] = value; }
        }

        [DisplayName("Invoice No Anlys2"), Expression("jInvoiceNo.[ANLYS2]")]
        public String InvoiceNoAnlys2
        {
            get { return Fields.InvoiceNoAnlys2[this]; }
            set { Fields.InvoiceNoAnlys2[this] = value; }
        }

        [DisplayName("Invoice No Tot Price Amt"), Expression("jInvoiceNo.[TOT_PRICE_AMT]")]
        public Decimal? InvoiceNoTotPriceAmt
        {
            get { return Fields.InvoiceNoTotPriceAmt[this]; }
            set { Fields.InvoiceNoTotPriceAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Price Amt"), Expression("jInvoiceNo.[LOC_PRICE_AMT]")]
        public Decimal? InvoiceNoLocPriceAmt
        {
            get { return Fields.InvoiceNoLocPriceAmt[this]; }
            set { Fields.InvoiceNoLocPriceAmt[this] = value; }
        }

        [DisplayName("Invoice No Tot Ptax Amt"), Expression("jInvoiceNo.[TOT_PTAX_AMT]")]
        public Decimal? InvoiceNoTotPtaxAmt
        {
            get { return Fields.InvoiceNoTotPtaxAmt[this]; }
            set { Fields.InvoiceNoTotPtaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Ptax Amt"), Expression("jInvoiceNo.[LOC_PTAX_AMT]")]
        public Decimal? InvoiceNoLocPtaxAmt
        {
            get { return Fields.InvoiceNoLocPtaxAmt[this]; }
            set { Fields.InvoiceNoLocPtaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Tot Ext Price"), Expression("jInvoiceNo.[TOT_EXT_PRICE]")]
        public Decimal? InvoiceNoTotExtPrice
        {
            get { return Fields.InvoiceNoTotExtPrice[this]; }
            set { Fields.InvoiceNoTotExtPrice[this] = value; }
        }

        [DisplayName("Invoice No Loc Ext Price"), Expression("jInvoiceNo.[LOC_EXT_PRICE]")]
        public Decimal? InvoiceNoLocExtPrice
        {
            get { return Fields.InvoiceNoLocExtPrice[this]; }
            set { Fields.InvoiceNoLocExtPrice[this] = value; }
        }

        [DisplayName("Invoice No Tot Ldisc Amt"), Expression("jInvoiceNo.[TOT_LDISC_AMT]")]
        public Decimal? InvoiceNoTotLdiscAmt
        {
            get { return Fields.InvoiceNoTotLdiscAmt[this]; }
            set { Fields.InvoiceNoTotLdiscAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Ldisc Amt"), Expression("jInvoiceNo.[LOC_LDISC_AMT]")]
        public Decimal? InvoiceNoLocLdiscAmt
        {
            get { return Fields.InvoiceNoLocLdiscAmt[this]; }
            set { Fields.InvoiceNoLocLdiscAmt[this] = value; }
        }

        [DisplayName("Invoice No Tot Atax Amt"), Expression("jInvoiceNo.[TOT_ATAX_AMT]")]
        public Decimal? InvoiceNoTotAtaxAmt
        {
            get { return Fields.InvoiceNoTotAtaxAmt[this]; }
            set { Fields.InvoiceNoTotAtaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Atax Amt"), Expression("jInvoiceNo.[LOC_ATAX_AMT]")]
        public Decimal? InvoiceNoLocAtaxAmt
        {
            get { return Fields.InvoiceNoLocAtaxAmt[this]; }
            set { Fields.InvoiceNoLocAtaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Tot Item Amt"), Expression("jInvoiceNo.[TOT_ITEM_AMT]")]
        public Decimal? InvoiceNoTotItemAmt
        {
            get { return Fields.InvoiceNoTotItemAmt[this]; }
            set { Fields.InvoiceNoTotItemAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Item Amt"), Expression("jInvoiceNo.[LOC_ITEM_AMT]")]
        public Decimal? InvoiceNoLocItemAmt
        {
            get { return Fields.InvoiceNoLocItemAmt[this]; }
            set { Fields.InvoiceNoLocItemAmt[this] = value; }
        }

        [DisplayName("Invoice No Tdisc Pcent"), Expression("jInvoiceNo.[TDISC_PCENT]")]
        public Decimal? InvoiceNoTdiscPcent
        {
            get { return Fields.InvoiceNoTdiscPcent[this]; }
            set { Fields.InvoiceNoTdiscPcent[this] = value; }
        }

        [DisplayName("Invoice No Tdisc Amt"), Expression("jInvoiceNo.[TDISC_AMT]")]
        public Decimal? InvoiceNoTdiscAmt
        {
            get { return Fields.InvoiceNoTdiscAmt[this]; }
            set { Fields.InvoiceNoTdiscAmt[this] = value; }
        }

        [DisplayName("Invoice No Local Tdisc Amt"), Expression("jInvoiceNo.[LOCAL_TDISC_AMT]")]
        public Decimal? InvoiceNoLocalTdiscAmt
        {
            get { return Fields.InvoiceNoLocalTdiscAmt[this]; }
            set { Fields.InvoiceNoLocalTdiscAmt[this] = value; }
        }

        [DisplayName("Invoice No Chgs Amt"), Expression("jInvoiceNo.[CHGS_AMT]")]
        public Decimal? InvoiceNoChgsAmt
        {
            get { return Fields.InvoiceNoChgsAmt[this]; }
            set { Fields.InvoiceNoChgsAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Chgs Amt"), Expression("jInvoiceNo.[LOC_CHGS_AMT]")]
        public Decimal? InvoiceNoLocChgsAmt
        {
            get { return Fields.InvoiceNoLocChgsAmt[this]; }
            set { Fields.InvoiceNoLocChgsAmt[this] = value; }
        }

        [DisplayName("Invoice No Gtax Amt"), Expression("jInvoiceNo.[GTAX_AMT]")]
        public Decimal? InvoiceNoGtaxAmt
        {
            get { return Fields.InvoiceNoGtaxAmt[this]; }
            set { Fields.InvoiceNoGtaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Local Gtax Amt"), Expression("jInvoiceNo.[LOCAL_GTAX_AMT]")]
        public Decimal? InvoiceNoLocalGtaxAmt
        {
            get { return Fields.InvoiceNoLocalGtaxAmt[this]; }
            set { Fields.InvoiceNoLocalGtaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Net Amt"), Expression("jInvoiceNo.[NET_AMT]")]
        public Decimal? InvoiceNoNetAmt
        {
            get { return Fields.InvoiceNoNetAmt[this]; }
            set { Fields.InvoiceNoNetAmt[this] = value; }
        }

        [DisplayName("Invoice No Local Net Amt"), Expression("jInvoiceNo.[LOCAL_NET_AMT]")]
        public Decimal? InvoiceNoLocalNetAmt
        {
            get { return Fields.InvoiceNoLocalNetAmt[this]; }
            set { Fields.InvoiceNoLocalNetAmt[this] = value; }
        }

        [DisplayName("Invoice No Tdisc Amt Cpd"), Expression("jInvoiceNo.[TDISC_AMT_CPD]")]
        public Decimal? InvoiceNoTdiscAmtCpd
        {
            get { return Fields.InvoiceNoTdiscAmtCpd[this]; }
            set { Fields.InvoiceNoTdiscAmtCpd[this] = value; }
        }

        [DisplayName("Invoice No Last Line No"), Expression("jInvoiceNo.[LAST_LINE_NO]")]
        public Decimal? InvoiceNoLastLineNo
        {
            get { return Fields.InvoiceNoLastLineNo[this]; }
            set { Fields.InvoiceNoLastLineNo[this] = value; }
        }

        [DisplayName("Invoice No Created Date"), Expression("jInvoiceNo.[CREATED_DATE]")]
        public DateTime? InvoiceNoCreatedDate
        {
            get { return Fields.InvoiceNoCreatedDate[this]; }
            set { Fields.InvoiceNoCreatedDate[this] = value; }
        }

        [DisplayName("Invoice No Created By"), Expression("jInvoiceNo.[CREATED_BY]")]
        public String InvoiceNoCreatedBy
        {
            get { return Fields.InvoiceNoCreatedBy[this]; }
            set { Fields.InvoiceNoCreatedBy[this] = value; }
        }

        [DisplayName("Invoice No Revised Date"), Expression("jInvoiceNo.[REVISED_DATE]")]
        public DateTime? InvoiceNoRevisedDate
        {
            get { return Fields.InvoiceNoRevisedDate[this]; }
            set { Fields.InvoiceNoRevisedDate[this] = value; }
        }

        [DisplayName("Invoice No Revised By"), Expression("jInvoiceNo.[REVISED_BY]")]
        public String InvoiceNoRevisedBy
        {
            get { return Fields.InvoiceNoRevisedBy[this]; }
            set { Fields.InvoiceNoRevisedBy[this] = value; }
        }

        [DisplayName("Invoice No Posted Date"), Expression("jInvoiceNo.[POSTED_DATE]")]
        public DateTime? InvoiceNoPostedDate
        {
            get { return Fields.InvoiceNoPostedDate[this]; }
            set { Fields.InvoiceNoPostedDate[this] = value; }
        }

        [DisplayName("Invoice No Posted By"), Expression("jInvoiceNo.[POSTED_BY]")]
        public String InvoiceNoPostedBy
        {
            get { return Fields.InvoiceNoPostedBy[this]; }
            set { Fields.InvoiceNoPostedBy[this] = value; }
        }

        [DisplayName("Invoice No Last Log No"), Expression("jInvoiceNo.[LAST_LOG_NO]")]
        public Decimal? InvoiceNoLastLogNo
        {
            get { return Fields.InvoiceNoLastLogNo[this]; }
            set { Fields.InvoiceNoLastLogNo[this] = value; }
        }

        [DisplayName("Invoice No Settled Amt"), Expression("jInvoiceNo.[SETTLED_AMT]")]
        public Decimal? InvoiceNoSettledAmt
        {
            get { return Fields.InvoiceNoSettledAmt[this]; }
            set { Fields.InvoiceNoSettledAmt[this] = value; }
        }

        [DisplayName("Invoice No Lsettled Amt"), Expression("jInvoiceNo.[LSETTLED_AMT]")]
        public Decimal? InvoiceNoLsettledAmt
        {
            get { return Fields.InvoiceNoLsettledAmt[this]; }
            set { Fields.InvoiceNoLsettledAmt[this] = value; }
        }

        [DisplayName("Invoice No Term Disc Amt"), Expression("jInvoiceNo.[TERM_DISC_AMT]")]
        public Decimal? InvoiceNoTermDiscAmt
        {
            get { return Fields.InvoiceNoTermDiscAmt[this]; }
            set { Fields.InvoiceNoTermDiscAmt[this] = value; }
        }

        [DisplayName("Invoice No Lterm Disc Amt"), Expression("jInvoiceNo.[LTERM_DISC_AMT]")]
        public Decimal? InvoiceNoLtermDiscAmt
        {
            get { return Fields.InvoiceNoLtermDiscAmt[this]; }
            set { Fields.InvoiceNoLtermDiscAmt[this] = value; }
        }

        [DisplayName("Invoice No Return Amt"), Expression("jInvoiceNo.[RETURN_AMT]")]
        public Decimal? InvoiceNoReturnAmt
        {
            get { return Fields.InvoiceNoReturnAmt[this]; }
            set { Fields.InvoiceNoReturnAmt[this] = value; }
        }

        [DisplayName("Invoice No Lreturn Amt"), Expression("jInvoiceNo.[LRETURN_AMT]")]
        public Decimal? InvoiceNoLreturnAmt
        {
            get { return Fields.InvoiceNoLreturnAmt[this]; }
            set { Fields.InvoiceNoLreturnAmt[this] = value; }
        }

        [DisplayName("Invoice No Bal Amt"), Expression("jInvoiceNo.[BAL_AMT]")]
        public Decimal? InvoiceNoBalAmt
        {
            get { return Fields.InvoiceNoBalAmt[this]; }
            set { Fields.InvoiceNoBalAmt[this] = value; }
        }

        [DisplayName("Invoice No Bal Amt Local"), Expression("jInvoiceNo.[BAL_AMT_LOCAL]")]
        public Decimal? InvoiceNoBalAmtLocal
        {
            get { return Fields.InvoiceNoBalAmtLocal[this]; }
            set { Fields.InvoiceNoBalAmtLocal[this] = value; }
        }

        [DisplayName("Invoice No Over Alloc Amt"), Expression("jInvoiceNo.[OVER_ALLOC_AMT]")]
        public Decimal? InvoiceNoOverAllocAmt
        {
            get { return Fields.InvoiceNoOverAllocAmt[this]; }
            set { Fields.InvoiceNoOverAllocAmt[this] = value; }
        }

        [DisplayName("Invoice No Lover Alloc Amt"), Expression("jInvoiceNo.[LOVER_ALLOC_AMT]")]
        public Decimal? InvoiceNoLoverAllocAmt
        {
            get { return Fields.InvoiceNoLoverAllocAmt[this]; }
            set { Fields.InvoiceNoLoverAllocAmt[this] = value; }
        }

        [DisplayName("Invoice No Acct Customer"), Expression("jInvoiceNo.[ACCT_CUSTOMER]")]
        public String InvoiceNoAcctCustomer
        {
            get { return Fields.InvoiceNoAcctCustomer[this]; }
            set { Fields.InvoiceNoAcctCustomer[this] = value; }
        }

        [DisplayName("Invoice No Acct Tdisc"), Expression("jInvoiceNo.[ACCT_TDISC]")]
        public String InvoiceNoAcctTdisc
        {
            get { return Fields.InvoiceNoAcctTdisc[this]; }
            set { Fields.InvoiceNoAcctTdisc[this] = value; }
        }

        [DisplayName("Invoice No Acct Gtax"), Expression("jInvoiceNo.[ACCT_GTAX]")]
        public String InvoiceNoAcctGtax
        {
            get { return Fields.InvoiceNoAcctGtax[this]; }
            set { Fields.InvoiceNoAcctGtax[this] = value; }
        }

        [DisplayName("Invoice No Lock Type"), Expression("jInvoiceNo.[LOCK_TYPE]")]
        public String InvoiceNoLockType
        {
            get { return Fields.InvoiceNoLockType[this]; }
            set { Fields.InvoiceNoLockType[this] = value; }
        }

        [DisplayName("Invoice No Lock Ref No"), Expression("jInvoiceNo.[LOCK_REF_NO]")]
        public String InvoiceNoLockRefNo
        {
            get { return Fields.InvoiceNoLockRefNo[this]; }
            set { Fields.InvoiceNoLockRefNo[this] = value; }
        }

        [DisplayName("Invoice No Batch Select"), Expression("jInvoiceNo.[BATCH_SELECT]")]
        public String InvoiceNoBatchSelect
        {
            get { return Fields.InvoiceNoBatchSelect[this]; }
            set { Fields.InvoiceNoBatchSelect[this] = value; }
        }

        [DisplayName("Invoice No Gl Link"), Expression("jInvoiceNo.[GL_LINK]")]
        public String InvoiceNoGlLink
        {
            get { return Fields.InvoiceNoGlLink[this]; }
            set { Fields.InvoiceNoGlLink[this] = value; }
        }

        [DisplayName("Invoice No Gl Link Type"), Expression("jInvoiceNo.[GL_LINK_TYPE]")]
        public String InvoiceNoGlLinkType
        {
            get { return Fields.InvoiceNoGlLinkType[this]; }
            set { Fields.InvoiceNoGlLinkType[this] = value; }
        }

        [DisplayName("Invoice No Gl Link No"), Expression("jInvoiceNo.[GL_LINK_NO]")]
        public String InvoiceNoGlLinkNo
        {
            get { return Fields.InvoiceNoGlLinkNo[this]; }
            set { Fields.InvoiceNoGlLinkNo[this] = value; }
        }

        [DisplayName("Invoice No Owner Branch"), Expression("jInvoiceNo.[OWNER_BRANCH]")]
        public String InvoiceNoOwnerBranch
        {
            get { return Fields.InvoiceNoOwnerBranch[this]; }
            set { Fields.InvoiceNoOwnerBranch[this] = value; }
        }

        [DisplayName("Invoice No Source Branch"), Expression("jInvoiceNo.[SOURCE_BRANCH]")]
        public String InvoiceNoSourceBranch
        {
            get { return Fields.InvoiceNoSourceBranch[this]; }
            set { Fields.InvoiceNoSourceBranch[this] = value; }
        }

        [DisplayName("Invoice No Check Crlimit"), Expression("jInvoiceNo.[CHECK_CRLIMIT]")]
        public String InvoiceNoCheckCrlimit
        {
            get { return Fields.InvoiceNoCheckCrlimit[this]; }
            set { Fields.InvoiceNoCheckCrlimit[this] = value; }
        }

        [DisplayName("Invoice No Check Crbal"), Expression("jInvoiceNo.[CHECK_CRBAL]")]
        public Decimal? InvoiceNoCheckCrbal
        {
            get { return Fields.InvoiceNoCheckCrbal[this]; }
            set { Fields.InvoiceNoCheckCrbal[this] = value; }
        }

        [DisplayName("Invoice No Comments1"), Expression("jInvoiceNo.[COMMENTS1]")]
        public String InvoiceNoComments1
        {
            get { return Fields.InvoiceNoComments1[this]; }
            set { Fields.InvoiceNoComments1[this] = value; }
        }

        [DisplayName("Invoice No Comments2"), Expression("jInvoiceNo.[COMMENTS2]")]
        public String InvoiceNoComments2
        {
            get { return Fields.InvoiceNoComments2[this]; }
            set { Fields.InvoiceNoComments2[this] = value; }
        }

        [DisplayName("Invoice No Comments3"), Expression("jInvoiceNo.[COMMENTS3]")]
        public String InvoiceNoComments3
        {
            get { return Fields.InvoiceNoComments3[this]; }
            set { Fields.InvoiceNoComments3[this] = value; }
        }

        [DisplayName("Invoice No Comments4"), Expression("jInvoiceNo.[COMMENTS4]")]
        public String InvoiceNoComments4
        {
            get { return Fields.InvoiceNoComments4[this]; }
            set { Fields.InvoiceNoComments4[this] = value; }
        }

        [DisplayName("Invoice No Last Text No"), Expression("jInvoiceNo.[LAST_TEXT_NO]")]
        public Decimal? InvoiceNoLastTextNo
        {
            get { return Fields.InvoiceNoLastTextNo[this]; }
            set { Fields.InvoiceNoLastTextNo[this] = value; }
        }

        [DisplayName("Invoice No Ship To"), Expression("jInvoiceNo.[SHIP_TO]")]
        public String InvoiceNoShipTo
        {
            get { return Fields.InvoiceNoShipTo[this]; }
            set { Fields.InvoiceNoShipTo[this] = value; }
        }

        [DisplayName("Invoice No Tel No"), Expression("jInvoiceNo.[TEL_NO]")]
        public String InvoiceNoTelNo
        {
            get { return Fields.InvoiceNoTelNo[this]; }
            set { Fields.InvoiceNoTelNo[this] = value; }
        }

        [DisplayName("Invoice No Fax No"), Expression("jInvoiceNo.[FAX_NO]")]
        public String InvoiceNoFaxNo
        {
            get { return Fields.InvoiceNoFaxNo[this]; }
            set { Fields.InvoiceNoFaxNo[this] = value; }
        }

        [DisplayName("Invoice No Sltax Type"), Expression("jInvoiceNo.[SLTAX_TYPE]")]
        public String InvoiceNoSltaxType
        {
            get { return Fields.InvoiceNoSltaxType[this]; }
            set { Fields.InvoiceNoSltaxType[this] = value; }
        }

        [DisplayName("Invoice No Gsltax Pcent"), Expression("jInvoiceNo.[GSLTAX_PCENT]")]
        public Decimal? InvoiceNoGsltaxPcent
        {
            get { return Fields.InvoiceNoGsltaxPcent[this]; }
            set { Fields.InvoiceNoGsltaxPcent[this] = value; }
        }

        [DisplayName("Invoice No Tot Gsltax Amt"), Expression("jInvoiceNo.[TOT_GSLTAX_AMT]")]
        public Decimal? InvoiceNoTotGsltaxAmt
        {
            get { return Fields.InvoiceNoTotGsltaxAmt[this]; }
            set { Fields.InvoiceNoTotGsltaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Tot Lsltax Amt"), Expression("jInvoiceNo.[TOT_LSLTAX_AMT]")]
        public Decimal? InvoiceNoTotLsltaxAmt
        {
            get { return Fields.InvoiceNoTotLsltaxAmt[this]; }
            set { Fields.InvoiceNoTotLsltaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Gsltax Amt"), Expression("jInvoiceNo.[LOC_GSLTAX_AMT]")]
        public Decimal? InvoiceNoLocGsltaxAmt
        {
            get { return Fields.InvoiceNoLocGsltaxAmt[this]; }
            set { Fields.InvoiceNoLocGsltaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Lsltax Amt"), Expression("jInvoiceNo.[LOC_LSLTAX_AMT]")]
        public Decimal? InvoiceNoLocLsltaxAmt
        {
            get { return Fields.InvoiceNoLocLsltaxAmt[this]; }
            set { Fields.InvoiceNoLocLsltaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Acct Sltax"), Expression("jInvoiceNo.[ACCT_SLTAX]")]
        public String InvoiceNoAcctSltax
        {
            get { return Fields.InvoiceNoAcctSltax[this]; }
            set { Fields.InvoiceNoAcctSltax[this] = value; }
        }

        [DisplayName("Invoice No Customer Po"), Expression("jInvoiceNo.[CUSTOMER_PO]")]
        public String InvoiceNoCustomerPo
        {
            get { return Fields.InvoiceNoCustomerPo[this]; }
            set { Fields.InvoiceNoCustomerPo[this] = value; }
        }

        [DisplayName("Invoice No Ai Link"), Expression("jInvoiceNo.[AI_LINK]")]
        public String InvoiceNoAiLink
        {
            get { return Fields.InvoiceNoAiLink[this]; }
            set { Fields.InvoiceNoAiLink[this] = value; }
        }

        [DisplayName("Invoice No Ai Link Type"), Expression("jInvoiceNo.[AI_LINK_TYPE]")]
        public String InvoiceNoAiLinkType
        {
            get { return Fields.InvoiceNoAiLinkType[this]; }
            set { Fields.InvoiceNoAiLinkType[this] = value; }
        }

        [DisplayName("Invoice No Ai Link No"), Expression("jInvoiceNo.[AI_LINK_NO]")]
        public String InvoiceNoAiLinkNo
        {
            get { return Fields.InvoiceNoAiLinkNo[this]; }
            set { Fields.InvoiceNoAiLinkNo[this] = value; }
        }

        [DisplayName("Invoice No Anlys7"), Expression("jInvoiceNo.[ANLYS7]")]
        public String InvoiceNoAnlys7
        {
            get { return Fields.InvoiceNoAnlys7[this]; }
            set { Fields.InvoiceNoAnlys7[this] = value; }
        }

        [DisplayName("Invoice No Anlys8"), Expression("jInvoiceNo.[ANLYS8]")]
        public String InvoiceNoAnlys8
        {
            get { return Fields.InvoiceNoAnlys8[this]; }
            set { Fields.InvoiceNoAnlys8[this] = value; }
        }

        [DisplayName("Invoice No Net Trade Amt"), Expression("jInvoiceNo.[NET_TRADE_AMT]")]
        public Decimal? InvoiceNoNetTradeAmt
        {
            get { return Fields.InvoiceNoNetTradeAmt[this]; }
            set { Fields.InvoiceNoNetTradeAmt[this] = value; }
        }

        [DisplayName("Invoice No Net Ordr Amt"), Expression("jInvoiceNo.[NET_ORDR_AMT]")]
        public Decimal? InvoiceNoNetOrdrAmt
        {
            get { return Fields.InvoiceNoNetOrdrAmt[this]; }
            set { Fields.InvoiceNoNetOrdrAmt[this] = value; }
        }

        [DisplayName("Invoice No Ship Amt"), Expression("jInvoiceNo.[SHIP_AMT]")]
        public Decimal? InvoiceNoShipAmt
        {
            get { return Fields.InvoiceNoShipAmt[this]; }
            set { Fields.InvoiceNoShipAmt[this] = value; }
        }

        [DisplayName("Invoice No Lship Amt"), Expression("jInvoiceNo.[LSHIP_AMT]")]
        public Decimal? InvoiceNoLshipAmt
        {
            get { return Fields.InvoiceNoLshipAmt[this]; }
            set { Fields.InvoiceNoLshipAmt[this] = value; }
        }

        [DisplayName("Invoice No Varia Amt"), Expression("jInvoiceNo.[VARIA_AMT]")]
        public Decimal? InvoiceNoVariaAmt
        {
            get { return Fields.InvoiceNoVariaAmt[this]; }
            set { Fields.InvoiceNoVariaAmt[this] = value; }
        }

        [DisplayName("Invoice No Lvaria Amt"), Expression("jInvoiceNo.[LVARIA_AMT]")]
        public Decimal? InvoiceNoLvariaAmt
        {
            get { return Fields.InvoiceNoLvariaAmt[this]; }
            set { Fields.InvoiceNoLvariaAmt[this] = value; }
        }

        [DisplayName("Invoice No Item Varia Amt"), Expression("jInvoiceNo.[ITEM_VARIA_AMT]")]
        public Decimal? InvoiceNoItemVariaAmt
        {
            get { return Fields.InvoiceNoItemVariaAmt[this]; }
            set { Fields.InvoiceNoItemVariaAmt[this] = value; }
        }

        [DisplayName("Invoice No Litem Varia Amt"), Expression("jInvoiceNo.[LITEM_VARIA_AMT]")]
        public Decimal? InvoiceNoLitemVariaAmt
        {
            get { return Fields.InvoiceNoLitemVariaAmt[this]; }
            set { Fields.InvoiceNoLitemVariaAmt[this] = value; }
        }

        [DisplayName("Invoice No Chgs Varia Amt"), Expression("jInvoiceNo.[CHGS_VARIA_AMT]")]
        public Decimal? InvoiceNoChgsVariaAmt
        {
            get { return Fields.InvoiceNoChgsVariaAmt[this]; }
            set { Fields.InvoiceNoChgsVariaAmt[this] = value; }
        }

        [DisplayName("Invoice No Lchgs Varia Amt"), Expression("jInvoiceNo.[LCHGS_VARIA_AMT]")]
        public Decimal? InvoiceNoLchgsVariaAmt
        {
            get { return Fields.InvoiceNoLchgsVariaAmt[this]; }
            set { Fields.InvoiceNoLchgsVariaAmt[this] = value; }
        }

        [DisplayName("Invoice No Dps Applied"), Expression("jInvoiceNo.[DPS_APPLIED]")]
        public Decimal? InvoiceNoDpsApplied
        {
            get { return Fields.InvoiceNoDpsApplied[this]; }
            set { Fields.InvoiceNoDpsApplied[this] = value; }
        }

        [DisplayName("Invoice No Loc Dps Applied"), Expression("jInvoiceNo.[LOC_DPS_APPLIED]")]
        public Decimal? InvoiceNoLocDpsApplied
        {
            get { return Fields.InvoiceNoLocDpsApplied[this]; }
            set { Fields.InvoiceNoLocDpsApplied[this] = value; }
        }

        [DisplayName("Invoice No Ship Sltax Type"), Expression("jInvoiceNo.[SHIP_SLTAX_TYPE]")]
        public String InvoiceNoShipSltaxType
        {
            get { return Fields.InvoiceNoShipSltaxType[this]; }
            set { Fields.InvoiceNoShipSltaxType[this] = value; }
        }

        [DisplayName("Invoice No Ship Gsltax Pcent"), Expression("jInvoiceNo.[SHIP_GSLTAX_PCENT]")]
        public Decimal? InvoiceNoShipGsltaxPcent
        {
            get { return Fields.InvoiceNoShipGsltaxPcent[this]; }
            set { Fields.InvoiceNoShipGsltaxPcent[this] = value; }
        }

        [DisplayName("Invoice No Ship Count"), Expression("jInvoiceNo.[SHIP_COUNT]")]
        public Decimal? InvoiceNoShipCount
        {
            get { return Fields.InvoiceNoShipCount[this]; }
            set { Fields.InvoiceNoShipCount[this] = value; }
        }

        [DisplayName("Invoice No Source Type"), Expression("jInvoiceNo.[SOURCE_TYPE]")]
        public String InvoiceNoSourceType
        {
            get { return Fields.InvoiceNoSourceType[this]; }
            set { Fields.InvoiceNoSourceType[this] = value; }
        }

        [DisplayName("Invoice No Last Chgs No"), Expression("jInvoiceNo.[LAST_CHGS_NO]")]
        public Decimal? InvoiceNoLastChgsNo
        {
            get { return Fields.InvoiceNoLastChgsNo[this]; }
            set { Fields.InvoiceNoLastChgsNo[this] = value; }
        }

        [DisplayName("Invoice No Doc Type"), Expression("jInvoiceNo.[DOC_TYPE]")]
        public String InvoiceNoDocType
        {
            get { return Fields.InvoiceNoDocType[this]; }
            set { Fields.InvoiceNoDocType[this] = value; }
        }

        [DisplayName("Invoice No Doc Id"), Expression("jInvoiceNo.[DOC_ID]")]
        public String InvoiceNoDocId
        {
            get { return Fields.InvoiceNoDocId[this]; }
            set { Fields.InvoiceNoDocId[this] = value; }
        }

        [DisplayName("Invoice No Anlys9"), Expression("jInvoiceNo.[ANLYS9]")]
        public String InvoiceNoAnlys9
        {
            get { return Fields.InvoiceNoAnlys9[this]; }
            set { Fields.InvoiceNoAnlys9[this] = value; }
        }

        [DisplayName("Invoice No Anlys10"), Expression("jInvoiceNo.[ANLYS10]")]
        public String InvoiceNoAnlys10
        {
            get { return Fields.InvoiceNoAnlys10[this]; }
            set { Fields.InvoiceNoAnlys10[this] = value; }
        }

        [DisplayName("Invoice No Anlys11"), Expression("jInvoiceNo.[ANLYS11]")]
        public String InvoiceNoAnlys11
        {
            get { return Fields.InvoiceNoAnlys11[this]; }
            set { Fields.InvoiceNoAnlys11[this] = value; }
        }

        [DisplayName("Invoice No Anlys12"), Expression("jInvoiceNo.[ANLYS12]")]
        public String InvoiceNoAnlys12
        {
            get { return Fields.InvoiceNoAnlys12[this]; }
            set { Fields.InvoiceNoAnlys12[this] = value; }
        }

        [DisplayName("Invoice No Anlys13"), Expression("jInvoiceNo.[ANLYS13]")]
        public String InvoiceNoAnlys13
        {
            get { return Fields.InvoiceNoAnlys13[this]; }
            set { Fields.InvoiceNoAnlys13[this] = value; }
        }

        [DisplayName("Invoice No Anlys14"), Expression("jInvoiceNo.[ANLYS14]")]
        public String InvoiceNoAnlys14
        {
            get { return Fields.InvoiceNoAnlys14[this]; }
            set { Fields.InvoiceNoAnlys14[this] = value; }
        }

        [DisplayName("Invoice No Break Debit Note"), Expression("jInvoiceNo.[BREAK_DEBIT_NOTE]")]
        public Boolean? InvoiceNoBreakDebitNote
        {
            get { return Fields.InvoiceNoBreakDebitNote[this]; }
            set { Fields.InvoiceNoBreakDebitNote[this] = value; }
        }

        [DisplayName("Invoice No Freezed"), Expression("jInvoiceNo.[FREEZED]")]
        public Boolean? InvoiceNoFreezed
        {
            get { return Fields.InvoiceNoFreezed[this]; }
            set { Fields.InvoiceNoFreezed[this] = value; }
        }

        [DisplayName("Invoice No Related Debit Note"), Expression("jInvoiceNo.[RELATED_DEBIT_NOTE]")]
        public String InvoiceNoRelatedDebitNote
        {
            get { return Fields.InvoiceNoRelatedDebitNote[this]; }
            set { Fields.InvoiceNoRelatedDebitNote[this] = value; }
        }

        [DisplayName("Invoice No Cloned"), Expression("jInvoiceNo.[CLONED]")]
        public Boolean? InvoiceNoCloned
        {
            get { return Fields.InvoiceNoCloned[this]; }
            set { Fields.InvoiceNoCloned[this] = value; }
        }

        [DisplayName("Invoice No Cloned Company Code"), Expression("jInvoiceNo.[CLONED_COMPANY_CODE]")]
        public String InvoiceNoClonedCompanyCode
        {
            get { return Fields.InvoiceNoClonedCompanyCode[this]; }
            set { Fields.InvoiceNoClonedCompanyCode[this] = value; }
        }

        [DisplayName("Invoice No Use Sample Acct"), Expression("jInvoiceNo.[USE_SAMPLE_ACCT]")]
        public Boolean? InvoiceNoUseSampleAcct
        {
            get { return Fields.InvoiceNoUseSampleAcct[this]; }
            set { Fields.InvoiceNoUseSampleAcct[this] = value; }
        }

        [DisplayName("Invoice No Reference Date"), Expression("jInvoiceNo.[REFERENCE_DATE]")]
        public DateTime? InvoiceNoReferenceDate
        {
            get { return Fields.InvoiceNoReferenceDate[this]; }
            set { Fields.InvoiceNoReferenceDate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.InvoiceNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AccountsReceivableInvoiceOrderRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField InvoiceNo;
            public StringField ShipmentRef;
            public StringField OrderNo;
            public DecimalField TotPriceAmt;
            public DecimalField TotExtPrice;
            public DecimalField TotLdiscAmt;
            public DecimalField TotItemAmt;
            public DecimalField TdiscPcent;
            public DecimalField TotTdiscAmt;
            public DecimalField NetTradeAmt;
            public DecimalField TotChgsAmt;
            public DecimalField NetOrdrAmt;
            public DecimalField NetPayAmt;
            public DecimalField DpsCover;
            public DecimalField DpsPcent;
            public DecimalField DpsApplied;
            public DecimalField LocDpsApplied;
            public DecimalField NetBalAmt;
            public StringField SltaxType;
            public DecimalField GsltaxPcent;
            public DecimalField TotGsltaxAmt;
            public DecimalField TotLsltaxAmt;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField CustomerPo;
            public StringField Anlys21;
            public StringField Anlys22;
            public StringField Anlys23;
            public StringField Anlys24;
            public StringField Anlys25;
            public StringField Anlys26;

            public DecimalField InvoiceNoRecnum;
            public StringField InvoiceNoDirectEntry;
            public StringField InvoiceNoPosted;
            public StringField InvoiceNoClosed;
            public StringField InvoiceNoReturned;
            public StringField InvoiceNoDebitNote;
            public StringField InvoiceNoCustomerNo;
            public StringField InvoiceNoCustomerName;
            public StringField InvoiceNoAddress;
            public StringField InvoiceNoAddress2;
            public StringField InvoiceNoAddress3;
            public StringField InvoiceNoAddress4;
            public StringField InvoiceNoAttention;
            public DateTimeField InvoiceNoInvoiceDate;
            public StringField InvoiceNoPeriod;
            public DecimalField InvoiceNoFiscalYear;
            public DecimalField InvoiceNoPeriodNo;
            public StringField InvoiceNoSalesman;
            public StringField InvoiceNoCcy;
            public DecimalField InvoiceNoExchRate;
            public StringField InvoiceNoPayTerms;
            public DecimalField InvoiceNoDiscDays;
            public DecimalField InvoiceNoDiscPcent;
            public DecimalField InvoiceNoDueDays;
            public DateTimeField InvoiceNoDiscountDate;
            public DateTimeField InvoiceNoDueDate;
            public DateTimeField InvoiceNoExpectedDate;
            public StringField InvoiceNoAnlys1;
            public StringField InvoiceNoAnlys2;
            public DecimalField InvoiceNoTotPriceAmt;
            public DecimalField InvoiceNoLocPriceAmt;
            public DecimalField InvoiceNoTotPtaxAmt;
            public DecimalField InvoiceNoLocPtaxAmt;
            public DecimalField InvoiceNoTotExtPrice;
            public DecimalField InvoiceNoLocExtPrice;
            public DecimalField InvoiceNoTotLdiscAmt;
            public DecimalField InvoiceNoLocLdiscAmt;
            public DecimalField InvoiceNoTotAtaxAmt;
            public DecimalField InvoiceNoLocAtaxAmt;
            public DecimalField InvoiceNoTotItemAmt;
            public DecimalField InvoiceNoLocItemAmt;
            public DecimalField InvoiceNoTdiscPcent;
            public DecimalField InvoiceNoTdiscAmt;
            public DecimalField InvoiceNoLocalTdiscAmt;
            public DecimalField InvoiceNoChgsAmt;
            public DecimalField InvoiceNoLocChgsAmt;
            public DecimalField InvoiceNoGtaxAmt;
            public DecimalField InvoiceNoLocalGtaxAmt;
            public DecimalField InvoiceNoNetAmt;
            public DecimalField InvoiceNoLocalNetAmt;
            public DecimalField InvoiceNoTdiscAmtCpd;
            public DecimalField InvoiceNoLastLineNo;
            public DateTimeField InvoiceNoCreatedDate;
            public StringField InvoiceNoCreatedBy;
            public DateTimeField InvoiceNoRevisedDate;
            public StringField InvoiceNoRevisedBy;
            public DateTimeField InvoiceNoPostedDate;
            public StringField InvoiceNoPostedBy;
            public DecimalField InvoiceNoLastLogNo;
            public DecimalField InvoiceNoSettledAmt;
            public DecimalField InvoiceNoLsettledAmt;
            public DecimalField InvoiceNoTermDiscAmt;
            public DecimalField InvoiceNoLtermDiscAmt;
            public DecimalField InvoiceNoReturnAmt;
            public DecimalField InvoiceNoLreturnAmt;
            public DecimalField InvoiceNoBalAmt;
            public DecimalField InvoiceNoBalAmtLocal;
            public DecimalField InvoiceNoOverAllocAmt;
            public DecimalField InvoiceNoLoverAllocAmt;
            public StringField InvoiceNoAcctCustomer;
            public StringField InvoiceNoAcctTdisc;
            public StringField InvoiceNoAcctGtax;
            public StringField InvoiceNoLockType;
            public StringField InvoiceNoLockRefNo;
            public StringField InvoiceNoBatchSelect;
            public StringField InvoiceNoGlLink;
            public StringField InvoiceNoGlLinkType;
            public StringField InvoiceNoGlLinkNo;
            public StringField InvoiceNoOwnerBranch;
            public StringField InvoiceNoSourceBranch;
            public StringField InvoiceNoCheckCrlimit;
            public DecimalField InvoiceNoCheckCrbal;
            public StringField InvoiceNoComments1;
            public StringField InvoiceNoComments2;
            public StringField InvoiceNoComments3;
            public StringField InvoiceNoComments4;
            public DecimalField InvoiceNoLastTextNo;
            public StringField InvoiceNoShipTo;
            public StringField InvoiceNoTelNo;
            public StringField InvoiceNoFaxNo;
            public StringField InvoiceNoSltaxType;
            public DecimalField InvoiceNoGsltaxPcent;
            public DecimalField InvoiceNoTotGsltaxAmt;
            public DecimalField InvoiceNoTotLsltaxAmt;
            public DecimalField InvoiceNoLocGsltaxAmt;
            public DecimalField InvoiceNoLocLsltaxAmt;
            public StringField InvoiceNoAcctSltax;
            public StringField InvoiceNoCustomerPo;
            public StringField InvoiceNoAiLink;
            public StringField InvoiceNoAiLinkType;
            public StringField InvoiceNoAiLinkNo;
            public StringField InvoiceNoAnlys7;
            public StringField InvoiceNoAnlys8;
            public DecimalField InvoiceNoNetTradeAmt;
            public DecimalField InvoiceNoNetOrdrAmt;
            public DecimalField InvoiceNoShipAmt;
            public DecimalField InvoiceNoLshipAmt;
            public DecimalField InvoiceNoVariaAmt;
            public DecimalField InvoiceNoLvariaAmt;
            public DecimalField InvoiceNoItemVariaAmt;
            public DecimalField InvoiceNoLitemVariaAmt;
            public DecimalField InvoiceNoChgsVariaAmt;
            public DecimalField InvoiceNoLchgsVariaAmt;
            public DecimalField InvoiceNoDpsApplied;
            public DecimalField InvoiceNoLocDpsApplied;
            public StringField InvoiceNoShipSltaxType;
            public DecimalField InvoiceNoShipGsltaxPcent;
            public DecimalField InvoiceNoShipCount;
            public StringField InvoiceNoSourceType;
            public DecimalField InvoiceNoLastChgsNo;
            public StringField InvoiceNoDocType;
            public StringField InvoiceNoDocId;
            public StringField InvoiceNoAnlys9;
            public StringField InvoiceNoAnlys10;
            public StringField InvoiceNoAnlys11;
            public StringField InvoiceNoAnlys12;
            public StringField InvoiceNoAnlys13;
            public StringField InvoiceNoAnlys14;
            public BooleanField InvoiceNoBreakDebitNote;
            public BooleanField InvoiceNoFreezed;
            public StringField InvoiceNoRelatedDebitNote;
            public BooleanField InvoiceNoCloned;
            public StringField InvoiceNoClonedCompanyCode;
            public BooleanField InvoiceNoUseSampleAcct;
            public DateTimeField InvoiceNoReferenceDate;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.AccountsReceivableInvoiceOrder";
            }
        }
    }
}
