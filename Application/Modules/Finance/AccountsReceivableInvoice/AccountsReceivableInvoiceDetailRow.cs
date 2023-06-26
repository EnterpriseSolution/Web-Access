#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivableInvoiceDetailRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[ARINVD]")]
    [DisplayName("Accounts Receivable Invoice Detail"), InstanceName("Accounts Receivable Invoice Detail"), TwoLevelCached]   
    public sealed class AccountsReceivableInvoiceDetailRow : Row, IIdRow, INameRow
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

        [DisplayName("Line No"), Column("LINE_NO"), Size(6), PrimaryKey]
        public Decimal? LineNo
        {
            get { return Fields.LineNo[this]; }
            set { Fields.LineNo[this] = value; }
        }

        [DisplayName("Item No"), Column("ITEM_NO"), Size(30), NotNull]
        public String ItemNo
        {
            get { return Fields.ItemNo[this]; }
            set { Fields.ItemNo[this] = value; }
        }

        [DisplayName("Posted"), Column("POSTED"), Size(1)]
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Returned"), Column("RETURNED"), Size(1), NotNull]
        public String Returned
        {
            get { return Fields.Returned[this]; }
            set { Fields.Returned[this] = value; }
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

        [DisplayName("Qty"), Column("QTY"), Size(14), Scale(4)]
        public Decimal? Qty
        {
            get { return Fields.Qty[this]; }
            set { Fields.Qty[this] = value; }
        }

        [DisplayName("Lot Size"), Column("LOT_SIZE"), Size(10), Scale(4)]
        public Decimal? LotSize
        {
            get { return Fields.LotSize[this]; }
            set { Fields.LotSize[this] = value; }
        }

        [DisplayName("Price"), Column("PRICE"), Size(18), Scale(6)]
        public Decimal? Price
        {
            get { return Fields.Price[this]; }
            set { Fields.Price[this] = value; }
        }

        [DisplayName("Ext Price"), Column("EXT_PRICE"), Size(14), Scale(2)]
        public Decimal? ExtPrice
        {
            get { return Fields.ExtPrice[this]; }
            set { Fields.ExtPrice[this] = value; }
        }

        [DisplayName("Loc Ext Price"), Column("LOC_EXT_PRICE"), Size(14), Scale(2)]
        public Decimal? LocExtPrice
        {
            get { return Fields.LocExtPrice[this]; }
            set { Fields.LocExtPrice[this] = value; }
        }

        [DisplayName("Price Cpd"), Column("PRICE_CPD"), Size(12), Scale(4)]
        public Decimal? PriceCpd
        {
            get { return Fields.PriceCpd[this]; }
            set { Fields.PriceCpd[this] = value; }
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

        [DisplayName("Anlys3"), Column("ANLYS3"), Size(30)]
        public String Anlys3
        {
            get { return Fields.Anlys3[this]; }
            set { Fields.Anlys3[this] = value; }
        }

        [DisplayName("Anlys4"), Column("ANLYS4"), Size(30)]
        public String Anlys4
        {
            get { return Fields.Anlys4[this]; }
            set { Fields.Anlys4[this] = value; }
        }

        [DisplayName("Anlys5"), Column("ANLYS5"), Size(30)]
        public String Anlys5
        {
            get { return Fields.Anlys5[this]; }
            set { Fields.Anlys5[this] = value; }
        }

        [DisplayName("Anlys6"), Column("ANLYS6"), Size(30)]
        public String Anlys6
        {
            get { return Fields.Anlys6[this]; }
            set { Fields.Anlys6[this] = value; }
        }

        [DisplayName("Return Qty"), Column("RETURN_QTY"), Size(12), Scale(4)]
        public Decimal? ReturnQty
        {
            get { return Fields.ReturnQty[this]; }
            set { Fields.ReturnQty[this] = value; }
        }

        [DisplayName("Return Amt"), Column("RETURN_AMT"), Size(14), Scale(2)]
        public Decimal? ReturnAmt
        {
            get { return Fields.ReturnAmt[this]; }
            set { Fields.ReturnAmt[this] = value; }
        }

        [DisplayName("Lreturn Amt"), Column("LRETURN_AMT"), Size(14), Scale(2)]
        public Decimal? LreturnAmt
        {
            get { return Fields.LreturnAmt[this]; }
            set { Fields.LreturnAmt[this] = value; }
        }

        [DisplayName("Invoice Date"), Column("INVOICE_DATE")]
        public DateTime? InvoiceDate
        {
            get { return Fields.InvoiceDate[this]; }
            set { Fields.InvoiceDate[this] = value; }
        }

        [DisplayName("Customer No"), Column("CUSTOMER_NO"), Size(8)]
        public String CustomerNo
        {
            get { return Fields.CustomerNo[this]; }
            set { Fields.CustomerNo[this] = value; }
        }

        [DisplayName("Acct Sales"), Column("ACCT_SALES"), Size(30)]
        public String AcctSales
        {
            get { return Fields.AcctSales[this]; }
            set { Fields.AcctSales[this] = value; }
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

        [DisplayName("Ext Description"), Column("EXT_DESCRIPTION"), Size(1073741823)]
        public String ExtDescription
        {
            get { return Fields.ExtDescription[this]; }
            set { Fields.ExtDescription[this] = value; }
        }

        [DisplayName("Sltax Pcent"), Column("SLTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? SltaxPcent
        {
            get { return Fields.SltaxPcent[this]; }
            set { Fields.SltaxPcent[this] = value; }
        }

        [DisplayName("Sltax Amt"), Column("SLTAX_AMT"), Size(14), Scale(2)]
        public Decimal? SltaxAmt
        {
            get { return Fields.SltaxAmt[this]; }
            set { Fields.SltaxAmt[this] = value; }
        }

        [DisplayName("Loc Sltax Amt"), Column("LOC_SLTAX_AMT"), Size(14), Scale(2)]
        public Decimal? LocSltaxAmt
        {
            get { return Fields.LocSltaxAmt[this]; }
            set { Fields.LocSltaxAmt[this] = value; }
        }

        [DisplayName("Acct Sltax"), Column("ACCT_SLTAX"), Size(30)]
        public String AcctSltax
        {
            get { return Fields.AcctSltax[this]; }
            set { Fields.AcctSltax[this] = value; }
        }

        [DisplayName("Shipment Ref"), Column("SHIPMENT_REF"), Size(16)]
        public String ShipmentRef
        {
            get { return Fields.ShipmentRef[this]; }
            set { Fields.ShipmentRef[this] = value; }
        }

        [DisplayName("Shipment Entry No"), Column("SHIPMENT_ENTRY_NO"), Size(6)]
        public Decimal? ShipmentEntryNo
        {
            get { return Fields.ShipmentEntryNo[this]; }
            set { Fields.ShipmentEntryNo[this] = value; }
        }

        [DisplayName("Order No"), Column("ORDER_NO"), Size(16)]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Ldisc Pcent"), Column("LDISC_PCENT"), Size(6), Scale(2)]
        public Decimal? LdiscPcent
        {
            get { return Fields.LdiscPcent[this]; }
            set { Fields.LdiscPcent[this] = value; }
        }

        [DisplayName("Ldisc Amt"), Column("LDISC_AMT"), Size(14), Scale(2)]
        public Decimal? LdiscAmt
        {
            get { return Fields.LdiscAmt[this]; }
            set { Fields.LdiscAmt[this] = value; }
        }

        [DisplayName("Net Item Amt"), Column("NET_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? NetItemAmt
        {
            get { return Fields.NetItemAmt[this]; }
            set { Fields.NetItemAmt[this] = value; }
        }

        [DisplayName("Order Line No"), Column("ORDER_LINE_NO"), Size(6)]
        public Decimal? OrderLineNo
        {
            get { return Fields.OrderLineNo[this]; }
            set { Fields.OrderLineNo[this] = value; }
        }

        [DisplayName("Price Amt"), Column("PRICE_AMT"), Size(14), Scale(2)]
        public Decimal? PriceAmt
        {
            get { return Fields.PriceAmt[this]; }
            set { Fields.PriceAmt[this] = value; }
        }

        [DisplayName("Net Price"), Column("NET_PRICE"), Size(14), Scale(2)]
        public Decimal? NetPrice
        {
            get { return Fields.NetPrice[this]; }
            set { Fields.NetPrice[this] = value; }
        }

        [DisplayName("Acct Ldisc"), Column("ACCT_LDISC"), Size(30)]
        public String AcctLdisc
        {
            get { return Fields.AcctLdisc[this]; }
            set { Fields.AcctLdisc[this] = value; }
        }

        [DisplayName("Ship Item Amt"), Column("SHIP_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? ShipItemAmt
        {
            get { return Fields.ShipItemAmt[this]; }
            set { Fields.ShipItemAmt[this] = value; }
        }

        [DisplayName("Lship Item Amt"), Column("LSHIP_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? LshipItemAmt
        {
            get { return Fields.LshipItemAmt[this]; }
            set { Fields.LshipItemAmt[this] = value; }
        }

        [DisplayName("Loc Item Amt"), Column("LOC_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? LocItemAmt
        {
            get { return Fields.LocItemAmt[this]; }
            set { Fields.LocItemAmt[this] = value; }
        }

        [DisplayName("Loc Price Amt"), Column("LOC_PRICE_AMT"), Size(14), Scale(2)]
        public Decimal? LocPriceAmt
        {
            get { return Fields.LocPriceAmt[this]; }
            set { Fields.LocPriceAmt[this] = value; }
        }

        [DisplayName("Loc Ldisc Amt"), Column("LOC_LDISC_AMT"), Size(14), Scale(2)]
        public Decimal? LocLdiscAmt
        {
            get { return Fields.LocLdiscAmt[this]; }
            set { Fields.LocLdiscAmt[this] = value; }
        }

        [DisplayName("Acct Variance"), Column("ACCT_VARIANCE"), Size(30)]
        public String AcctVariance
        {
            get { return Fields.AcctVariance[this]; }
            set { Fields.AcctVariance[this] = value; }
        }

        [DisplayName("Varia Amt"), Column("VARIA_AMT"), Size(14), Scale(2)]
        public Decimal? VariaAmt
        {
            get { return Fields.VariaAmt[this]; }
            set { Fields.VariaAmt[this] = value; }
        }

        [DisplayName("Local Varia Amt"), Column("LOCAL_VARIA_AMT"), Size(14), Scale(2)]
        public Decimal? LocalVariaAmt
        {
            get { return Fields.LocalVariaAmt[this]; }
            set { Fields.LocalVariaAmt[this] = value; }
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

        [DisplayName("Anlys19"), Column("ANLYS19"), Size(30)]
        public String Anlys19
        {
            get { return Fields.Anlys19[this]; }
            set { Fields.Anlys19[this] = value; }
        }

        [DisplayName("Anlys20"), Column("ANLYS20"), Size(30)]
        public String Anlys20
        {
            get { return Fields.Anlys20[this]; }
            set { Fields.Anlys20[this] = value; }
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

        public AccountsReceivableInvoiceDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField InvoiceNo;
            public DecimalField LineNo;
            public StringField ItemNo;
            public StringField Posted;
            public StringField Returned;
            public StringField Description;
            public StringField Uom;
            public DecimalField Qty;
            public DecimalField LotSize;
            public DecimalField Price;
            public DecimalField ExtPrice;
            public DecimalField LocExtPrice;
            public DecimalField PriceCpd;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField Anlys5;
            public StringField Anlys6;
            public DecimalField ReturnQty;
            public DecimalField ReturnAmt;
            public DecimalField LreturnAmt;
            public DateTimeField InvoiceDate;
            public StringField CustomerNo;
            public StringField AcctSales;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField ExtDescription;
            public DecimalField SltaxPcent;
            public DecimalField SltaxAmt;
            public DecimalField LocSltaxAmt;
            public StringField AcctSltax;
            public StringField ShipmentRef;
            public DecimalField ShipmentEntryNo;
            public StringField OrderNo;
            public DecimalField LdiscPcent;
            public DecimalField LdiscAmt;
            public DecimalField NetItemAmt;
            public DecimalField OrderLineNo;
            public DecimalField PriceAmt;
            public DecimalField NetPrice;
            public StringField AcctLdisc;
            public DecimalField ShipItemAmt;
            public DecimalField LshipItemAmt;
            public DecimalField LocItemAmt;
            public DecimalField LocPriceAmt;
            public DecimalField LocLdiscAmt;
            public StringField AcctVariance;
            public DecimalField VariaAmt;
            public DecimalField LocalVariaAmt;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;
            public StringField Anlys19;
            public StringField Anlys20;

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
                LocalTextPrefix = "Finance.AccountsReceivableInvoiceDetail";
            }
        }
    }
}
