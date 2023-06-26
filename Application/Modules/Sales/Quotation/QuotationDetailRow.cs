#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  QuotationDetailRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Sales.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Sales"), TableName("[dbo].[SLQUOD]")]
    [DisplayName("Quotation Detail"), InstanceName("Quotation Detail"), TwoLevelCached]   
    public sealed class QuotationDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Ref No"), Column("REF_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[SLQUOH]", "REF_NO"), LeftJoin("jRefNo"), QuickSearch, TextualField("RefNoClosed")]
        public String RefNo
        {
            get { return Fields.RefNo[this]; }
            set { Fields.RefNo[this] = value; }
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

        [DisplayName("Lot Size"), Column("LOT_SIZE"), Size(10), Scale(4)]
        public Decimal? LotSize
        {
            get { return Fields.LotSize[this]; }
            set { Fields.LotSize[this] = value; }
        }

        [DisplayName("Qty"), Column("QTY"), Size(14), Scale(4)]
        public Decimal? Qty
        {
            get { return Fields.Qty[this]; }
            set { Fields.Qty[this] = value; }
        }

        [DisplayName("Price"), Column("PRICE"), Size(18), Scale(6)]
        public Decimal? Price
        {
            get { return Fields.Price[this]; }
            set { Fields.Price[this] = value; }
        }

        [DisplayName("Ptax"), Column("PTAX"), Size(18), Scale(6)]
        public Decimal? Ptax
        {
            get { return Fields.Ptax[this]; }
            set { Fields.Ptax[this] = value; }
        }

        [DisplayName("Net Price"), Column("NET_PRICE"), Size(18), Scale(6)]
        public Decimal? NetPrice
        {
            get { return Fields.NetPrice[this]; }
            set { Fields.NetPrice[this] = value; }
        }

        [DisplayName("Ext Price"), Column("EXT_PRICE"), Size(14), Scale(2)]
        public Decimal? ExtPrice
        {
            get { return Fields.ExtPrice[this]; }
            set { Fields.ExtPrice[this] = value; }
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

        [DisplayName("Atax Amt"), Column("ATAX_AMT"), Size(14), Scale(2)]
        public Decimal? AtaxAmt
        {
            get { return Fields.AtaxAmt[this]; }
            set { Fields.AtaxAmt[this] = value; }
        }

        [DisplayName("Net Item Amt"), Column("NET_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? NetItemAmt
        {
            get { return Fields.NetItemAmt[this]; }
            set { Fields.NetItemAmt[this] = value; }
        }

        [DisplayName("Price Amt"), Column("PRICE_AMT"), Size(14), Scale(2)]
        public Decimal? PriceAmt
        {
            get { return Fields.PriceAmt[this]; }
            set { Fields.PriceAmt[this] = value; }
        }

        [DisplayName("Ptax Amt"), Column("PTAX_AMT"), Size(18), Scale(6)]
        public Decimal? PtaxAmt
        {
            get { return Fields.PtaxAmt[this]; }
            set { Fields.PtaxAmt[this] = value; }
        }

        [DisplayName("Price Cpd"), Column("PRICE_CPD"), Size(18), Scale(6)]
        public Decimal? PriceCpd
        {
            get { return Fields.PriceCpd[this]; }
            set { Fields.PriceCpd[this] = value; }
        }

        [DisplayName("Ptax Cpd"), Column("PTAX_CPD"), Size(18), Scale(6)]
        public Decimal? PtaxCpd
        {
            get { return Fields.PtaxCpd[this]; }
            set { Fields.PtaxCpd[this] = value; }
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

        [DisplayName("Revised Date"), Column("REVISED_DATE"), NotNull]
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

        [DisplayName("Configurable"), Column("CONFIGURABLE"), Size(1)]
        public String Configurable
        {
            get { return Fields.Configurable[this]; }
            set { Fields.Configurable[this] = value; }
        }

        [DisplayName("Cust Item No"), Column("CUST_ITEM_NO"), Size(30)]
        public String CustItemNo
        {
            get { return Fields.CustItemNo[this]; }
            set { Fields.CustItemNo[this] = value; }
        }

        [DisplayName("Spec No"), Column("SPEC_NO"), Size(12)]
        public String SpecNo
        {
            get { return Fields.SpecNo[this]; }
            set { Fields.SpecNo[this] = value; }
        }

        [DisplayName("Bom No"), Column("BOM_NO"), Size(30)]
        public String BomNo
        {
            get { return Fields.BomNo[this]; }
            set { Fields.BomNo[this] = value; }
        }

        [DisplayName("Std Assort"), Column("STD_ASSORT"), Size(1)]
        public String StdAssort
        {
            get { return Fields.StdAssort[this]; }
            set { Fields.StdAssort[this] = value; }
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

        [DisplayName("Markup Pcent "), Column("MARKUP_PCENT "), Size(6), Scale(2)]
        public Decimal? MarkupPcent
        {
            get { return Fields.MarkupPcent[this]; }
            set { Fields.MarkupPcent[this] = value; }
        }

        [DisplayName("Markup"), Column("MARKUP"), Size(18), Scale(6)]
        public Decimal? Markup
        {
            get { return Fields.Markup[this]; }
            set { Fields.Markup[this] = value; }
        }

        [DisplayName("Mold Bom No"), Column("MOLD_BOM_NO"), Size(30)]
        public String MoldBomNo
        {
            get { return Fields.MoldBomNo[this]; }
            set { Fields.MoldBomNo[this] = value; }
        }

        [DisplayName("Mold Formula Code"), Column("MOLD_FORMULA_CODE"), Size(30)]
        public String MoldFormulaCode
        {
            get { return Fields.MoldFormulaCode[this]; }
            set { Fields.MoldFormulaCode[this] = value; }
        }

        [DisplayName("Mold Expected Qty"), Column("MOLD_EXPECTED_QTY"), Size(14), Scale(4)]
        public Decimal? MoldExpectedQty
        {
            get { return Fields.MoldExpectedQty[this]; }
            set { Fields.MoldExpectedQty[this] = value; }
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

        [DisplayName("Ref No Recnum"), Expression("jRefNo.[RECNUM]")]
        public Decimal? RefNoRecnum
        {
            get { return Fields.RefNoRecnum[this]; }
            set { Fields.RefNoRecnum[this] = value; }
        }

        [DisplayName("Ref No Issue Date"), Expression("jRefNo.[ISSUE_DATE]")]
        public DateTime? RefNoIssueDate
        {
            get { return Fields.RefNoIssueDate[this]; }
            set { Fields.RefNoIssueDate[this] = value; }
        }

        [DisplayName("Ref No Valid Until"), Expression("jRefNo.[VALID_UNTIL]")]
        public DateTime? RefNoValidUntil
        {
            get { return Fields.RefNoValidUntil[this]; }
            set { Fields.RefNoValidUntil[this] = value; }
        }

        [DisplayName("Ref No Closed"), Expression("jRefNo.[CLOSED]")]
        public String RefNoClosed
        {
            get { return Fields.RefNoClosed[this]; }
            set { Fields.RefNoClosed[this] = value; }
        }

        [DisplayName("Ref No Customer No"), Expression("jRefNo.[CUSTOMER_NO]")]
        public String RefNoCustomerNo
        {
            get { return Fields.RefNoCustomerNo[this]; }
            set { Fields.RefNoCustomerNo[this] = value; }
        }

        [DisplayName("Ref No Customer Name"), Expression("jRefNo.[CUSTOMER_NAME]")]
        public String RefNoCustomerName
        {
            get { return Fields.RefNoCustomerName[this]; }
            set { Fields.RefNoCustomerName[this] = value; }
        }

        [DisplayName("Ref No Address"), Expression("jRefNo.[ADDRESS]")]
        public String RefNoAddress
        {
            get { return Fields.RefNoAddress[this]; }
            set { Fields.RefNoAddress[this] = value; }
        }

        [DisplayName("Ref No Address2"), Expression("jRefNo.[ADDRESS2]")]
        public String RefNoAddress2
        {
            get { return Fields.RefNoAddress2[this]; }
            set { Fields.RefNoAddress2[this] = value; }
        }

        [DisplayName("Ref No Address3"), Expression("jRefNo.[ADDRESS3]")]
        public String RefNoAddress3
        {
            get { return Fields.RefNoAddress3[this]; }
            set { Fields.RefNoAddress3[this] = value; }
        }

        [DisplayName("Ref No Address4"), Expression("jRefNo.[ADDRESS4]")]
        public String RefNoAddress4
        {
            get { return Fields.RefNoAddress4[this]; }
            set { Fields.RefNoAddress4[this] = value; }
        }

        [DisplayName("Ref No Attention"), Expression("jRefNo.[ATTENTION]")]
        public String RefNoAttention
        {
            get { return Fields.RefNoAttention[this]; }
            set { Fields.RefNoAttention[this] = value; }
        }

        [DisplayName("Ref No Ship Via"), Expression("jRefNo.[SHIP_VIA]")]
        public String RefNoShipVia
        {
            get { return Fields.RefNoShipVia[this]; }
            set { Fields.RefNoShipVia[this] = value; }
        }

        [DisplayName("Ref No Shipment Terms"), Expression("jRefNo.[SHIPMENT_TERMS]")]
        public String RefNoShipmentTerms
        {
            get { return Fields.RefNoShipmentTerms[this]; }
            set { Fields.RefNoShipmentTerms[this] = value; }
        }

        [DisplayName("Ref No Base Loc"), Expression("jRefNo.[BASE_LOC]")]
        public String RefNoBaseLoc
        {
            get { return Fields.RefNoBaseLoc[this]; }
            set { Fields.RefNoBaseLoc[this] = value; }
        }

        [DisplayName("Ref No Salesman"), Expression("jRefNo.[SALESMAN]")]
        public String RefNoSalesman
        {
            get { return Fields.RefNoSalesman[this]; }
            set { Fields.RefNoSalesman[this] = value; }
        }

        [DisplayName("Ref No Pay Terms"), Expression("jRefNo.[PAY_TERMS]")]
        public String RefNoPayTerms
        {
            get { return Fields.RefNoPayTerms[this]; }
            set { Fields.RefNoPayTerms[this] = value; }
        }

        [DisplayName("Ref No Price Code"), Expression("jRefNo.[PRICE_CODE]")]
        public String RefNoPriceCode
        {
            get { return Fields.RefNoPriceCode[this]; }
            set { Fields.RefNoPriceCode[this] = value; }
        }

        [DisplayName("Ref No Anlys1"), Expression("jRefNo.[ANLYS1]")]
        public String RefNoAnlys1
        {
            get { return Fields.RefNoAnlys1[this]; }
            set { Fields.RefNoAnlys1[this] = value; }
        }

        [DisplayName("Ref No Anlys2"), Expression("jRefNo.[ANLYS2]")]
        public String RefNoAnlys2
        {
            get { return Fields.RefNoAnlys2[this]; }
            set { Fields.RefNoAnlys2[this] = value; }
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

        [DisplayName("Ref No Compute Tax"), Expression("jRefNo.[COMPUTE_TAX]")]
        public String RefNoComputeTax
        {
            get { return Fields.RefNoComputeTax[this]; }
            set { Fields.RefNoComputeTax[this] = value; }
        }

        [DisplayName("Ref No Last Line No"), Expression("jRefNo.[LAST_LINE_NO]")]
        public Decimal? RefNoLastLineNo
        {
            get { return Fields.RefNoLastLineNo[this]; }
            set { Fields.RefNoLastLineNo[this] = value; }
        }

        [DisplayName("Ref No Last Mail No"), Expression("jRefNo.[LAST_MAIL_NO]")]
        public Decimal? RefNoLastMailNo
        {
            get { return Fields.RefNoLastMailNo[this]; }
            set { Fields.RefNoLastMailNo[this] = value; }
        }

        [DisplayName("Ref No Last Text No"), Expression("jRefNo.[LAST_TEXT_NO]")]
        public Decimal? RefNoLastTextNo
        {
            get { return Fields.RefNoLastTextNo[this]; }
            set { Fields.RefNoLastTextNo[this] = value; }
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

        [DisplayName("Ref No Dps Pcent"), Expression("jRefNo.[DPS_PCENT]")]
        public Decimal? RefNoDpsPcent
        {
            get { return Fields.RefNoDpsPcent[this]; }
            set { Fields.RefNoDpsPcent[this] = value; }
        }

        [DisplayName("Ref No Tot Dps Amt"), Expression("jRefNo.[TOT_DPS_AMT]")]
        public Decimal? RefNoTotDpsAmt
        {
            get { return Fields.RefNoTotDpsAmt[this]; }
            set { Fields.RefNoTotDpsAmt[this] = value; }
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

        [DisplayName("Ref No Tot Tdisc Cpd"), Expression("jRefNo.[TOT_TDISC_CPD]")]
        public Decimal? RefNoTotTdiscCpd
        {
            get { return Fields.RefNoTotTdiscCpd[this]; }
            set { Fields.RefNoTotTdiscCpd[this] = value; }
        }

        [DisplayName("Ref No Tot Gtax Cpd"), Expression("jRefNo.[TOT_GTAX_CPD]")]
        public Decimal? RefNoTotGtaxCpd
        {
            get { return Fields.RefNoTotGtaxCpd[this]; }
            set { Fields.RefNoTotGtaxCpd[this] = value; }
        }

        [DisplayName("Ref No Tot Dps Cpd"), Expression("jRefNo.[TOT_DPS_CPD]")]
        public Decimal? RefNoTotDpsCpd
        {
            get { return Fields.RefNoTotDpsCpd[this]; }
            set { Fields.RefNoTotDpsCpd[this] = value; }
        }

        [DisplayName("Ref No Closed Date"), Expression("jRefNo.[CLOSED_DATE]")]
        public DateTime? RefNoClosedDate
        {
            get { return Fields.RefNoClosedDate[this]; }
            set { Fields.RefNoClosedDate[this] = value; }
        }

        [DisplayName("Ref No Closed By"), Expression("jRefNo.[CLOSED_BY]")]
        public String RefNoClosedBy
        {
            get { return Fields.RefNoClosedBy[this]; }
            set { Fields.RefNoClosedBy[this] = value; }
        }

        [DisplayName("Ref No Comments1"), Expression("jRefNo.[COMMENTS1]")]
        public String RefNoComments1
        {
            get { return Fields.RefNoComments1[this]; }
            set { Fields.RefNoComments1[this] = value; }
        }

        [DisplayName("Ref No Comments2"), Expression("jRefNo.[COMMENTS2]")]
        public String RefNoComments2
        {
            get { return Fields.RefNoComments2[this]; }
            set { Fields.RefNoComments2[this] = value; }
        }

        [DisplayName("Ref No Comments3"), Expression("jRefNo.[COMMENTS3]")]
        public String RefNoComments3
        {
            get { return Fields.RefNoComments3[this]; }
            set { Fields.RefNoComments3[this] = value; }
        }

        [DisplayName("Ref No Comments4"), Expression("jRefNo.[COMMENTS4]")]
        public String RefNoComments4
        {
            get { return Fields.RefNoComments4[this]; }
            set { Fields.RefNoComments4[this] = value; }
        }

        [DisplayName("Ref No Web Published"), Expression("jRefNo.[WEB_PUBLISHED]")]
        public String RefNoWebPublished
        {
            get { return Fields.RefNoWebPublished[this]; }
            set { Fields.RefNoWebPublished[this] = value; }
        }

        [DisplayName("Ref No Confirmed"), Expression("jRefNo.[CONFIRMED]")]
        public String RefNoConfirmed
        {
            get { return Fields.RefNoConfirmed[this]; }
            set { Fields.RefNoConfirmed[this] = value; }
        }

        [DisplayName("Ref No Rfq No"), Expression("jRefNo.[RFQ_NO]")]
        public String RefNoRfqNo
        {
            get { return Fields.RefNoRfqNo[this]; }
            set { Fields.RefNoRfqNo[this] = value; }
        }

        [DisplayName("Ref No Web User Name"), Expression("jRefNo.[WEB_USER_NAME]")]
        public String RefNoWebUserName
        {
            get { return Fields.RefNoWebUserName[this]; }
            set { Fields.RefNoWebUserName[this] = value; }
        }

        [DisplayName("Ref No Ship To"), Expression("jRefNo.[SHIP_TO]")]
        public String RefNoShipTo
        {
            get { return Fields.RefNoShipTo[this]; }
            set { Fields.RefNoShipTo[this] = value; }
        }

        [DisplayName("Ref No Tel No"), Expression("jRefNo.[TEL_NO]")]
        public String RefNoTelNo
        {
            get { return Fields.RefNoTelNo[this]; }
            set { Fields.RefNoTelNo[this] = value; }
        }

        [DisplayName("Ref No Fax No"), Expression("jRefNo.[FAX_NO]")]
        public String RefNoFaxNo
        {
            get { return Fields.RefNoFaxNo[this]; }
            set { Fields.RefNoFaxNo[this] = value; }
        }

        [DisplayName("Ref No Port Loading"), Expression("jRefNo.[PORT_LOADING]")]
        public String RefNoPortLoading
        {
            get { return Fields.RefNoPortLoading[this]; }
            set { Fields.RefNoPortLoading[this] = value; }
        }

        [DisplayName("Ref No Port Discharge"), Expression("jRefNo.[PORT_DISCHARGE]")]
        public String RefNoPortDischarge
        {
            get { return Fields.RefNoPortDischarge[this]; }
            set { Fields.RefNoPortDischarge[this] = value; }
        }

        [DisplayName("Ref No Origin Country"), Expression("jRefNo.[ORIGIN_COUNTRY]")]
        public String RefNoOriginCountry
        {
            get { return Fields.RefNoOriginCountry[this]; }
            set { Fields.RefNoOriginCountry[this] = value; }
        }

        [DisplayName("Ref No Sltax Type"), Expression("jRefNo.[SLTAX_TYPE]")]
        public String RefNoSltaxType
        {
            get { return Fields.RefNoSltaxType[this]; }
            set { Fields.RefNoSltaxType[this] = value; }
        }

        [DisplayName("Ref No Gsltax Pcent"), Expression("jRefNo.[GSLTAX_PCENT]")]
        public Decimal? RefNoGsltaxPcent
        {
            get { return Fields.RefNoGsltaxPcent[this]; }
            set { Fields.RefNoGsltaxPcent[this] = value; }
        }

        [DisplayName("Ref No Tot Gsltax Amt"), Expression("jRefNo.[TOT_GSLTAX_AMT]")]
        public Decimal? RefNoTotGsltaxAmt
        {
            get { return Fields.RefNoTotGsltaxAmt[this]; }
            set { Fields.RefNoTotGsltaxAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Lsltax Amt"), Expression("jRefNo.[TOT_LSLTAX_AMT]")]
        public Decimal? RefNoTotLsltaxAmt
        {
            get { return Fields.RefNoTotLsltaxAmt[this]; }
            set { Fields.RefNoTotLsltaxAmt[this] = value; }
        }

        [DisplayName("Ref No Anlys7"), Expression("jRefNo.[ANLYS7]")]
        public String RefNoAnlys7
        {
            get { return Fields.RefNoAnlys7[this]; }
            set { Fields.RefNoAnlys7[this] = value; }
        }

        [DisplayName("Ref No Anlys8"), Expression("jRefNo.[ANLYS8]")]
        public String RefNoAnlys8
        {
            get { return Fields.RefNoAnlys8[this]; }
            set { Fields.RefNoAnlys8[this] = value; }
        }

        [DisplayName("Ref No Markup Decimal"), Expression("jRefNo.[MARKUP_DECIMAL]")]
        public Decimal? RefNoMarkupDecimal
        {
            get { return Fields.RefNoMarkupDecimal[this]; }
            set { Fields.RefNoMarkupDecimal[this] = value; }
        }

        [DisplayName("Ref No Pkg Unit"), Expression("jRefNo.[PKG_UNIT]")]
        public String RefNoPkgUnit
        {
            get { return Fields.RefNoPkgUnit[this]; }
            set { Fields.RefNoPkgUnit[this] = value; }
        }

        [DisplayName("Ref No Weight Unit"), Expression("jRefNo.[WEIGHT_UNIT]")]
        public String RefNoWeightUnit
        {
            get { return Fields.RefNoWeightUnit[this]; }
            set { Fields.RefNoWeightUnit[this] = value; }
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

        [DisplayName("Ref No Item Code"), Expression("jRefNo.[ITEM_CODE]")]
        public String RefNoItemCode
        {
            get { return Fields.RefNoItemCode[this]; }
            set { Fields.RefNoItemCode[this] = value; }
        }

        [DisplayName("Ref No Transport"), Expression("jRefNo.[TRANSPORT]")]
        public String RefNoTransport
        {
            get { return Fields.RefNoTransport[this]; }
            set { Fields.RefNoTransport[this] = value; }
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

        public QuotationDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField RefNo;
            public DecimalField LineNo;
            public StringField ItemNo;
            public StringField Description;
            public StringField Uom;
            public DecimalField LotSize;
            public DecimalField Qty;
            public DecimalField Price;
            public DecimalField Ptax;
            public DecimalField NetPrice;
            public DecimalField ExtPrice;
            public DecimalField LdiscPcent;
            public DecimalField LdiscAmt;
            public DecimalField AtaxAmt;
            public DecimalField NetItemAmt;
            public DecimalField PriceAmt;
            public DecimalField PtaxAmt;
            public DecimalField PriceCpd;
            public DecimalField PtaxCpd;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField Configurable;
            public StringField CustItemNo;
            public StringField SpecNo;
            public StringField BomNo;
            public StringField StdAssort;
            public StringField ExtDescription;
            public DecimalField SltaxPcent;
            public DecimalField SltaxAmt;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField Anlys5;
            public StringField Anlys6;
            public DecimalField MarkupPcent;
            public DecimalField Markup;
            public StringField MoldBomNo;
            public StringField MoldFormulaCode;
            public DecimalField MoldExpectedQty;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;
            public StringField Anlys19;
            public StringField Anlys20;

            public DecimalField RefNoRecnum;
            public DateTimeField RefNoIssueDate;
            public DateTimeField RefNoValidUntil;
            public StringField RefNoClosed;
            public StringField RefNoCustomerNo;
            public StringField RefNoCustomerName;
            public StringField RefNoAddress;
            public StringField RefNoAddress2;
            public StringField RefNoAddress3;
            public StringField RefNoAddress4;
            public StringField RefNoAttention;
            public StringField RefNoShipVia;
            public StringField RefNoShipmentTerms;
            public StringField RefNoBaseLoc;
            public StringField RefNoSalesman;
            public StringField RefNoPayTerms;
            public StringField RefNoPriceCode;
            public StringField RefNoAnlys1;
            public StringField RefNoAnlys2;
            public StringField RefNoCcy;
            public DecimalField RefNoExchRate;
            public StringField RefNoComputeTax;
            public DecimalField RefNoLastLineNo;
            public DecimalField RefNoLastMailNo;
            public DecimalField RefNoLastTextNo;
            public DecimalField RefNoTotPriceAmt;
            public DecimalField RefNoTotPtaxAmt;
            public DecimalField RefNoTotExtPrice;
            public DecimalField RefNoTotLdiscAmt;
            public DecimalField RefNoTotAtaxAmt;
            public DecimalField RefNoTotItemAmt;
            public DecimalField RefNoTdiscPcent;
            public DecimalField RefNoTotTdiscAmt;
            public DecimalField RefNoNetTradeAmt;
            public DecimalField RefNoTotChgsAmt;
            public DecimalField RefNoNetOrdrAmt;
            public DecimalField RefNoTotGtaxAmt;
            public DecimalField RefNoNetPayAmt;
            public DecimalField RefNoDpsPcent;
            public DecimalField RefNoTotDpsAmt;
            public DateTimeField RefNoCreatedDate;
            public StringField RefNoCreatedBy;
            public DateTimeField RefNoRevisedDate;
            public StringField RefNoRevisedBy;
            public DecimalField RefNoTotTdiscCpd;
            public DecimalField RefNoTotGtaxCpd;
            public DecimalField RefNoTotDpsCpd;
            public DateTimeField RefNoClosedDate;
            public StringField RefNoClosedBy;
            public StringField RefNoComments1;
            public StringField RefNoComments2;
            public StringField RefNoComments3;
            public StringField RefNoComments4;
            public StringField RefNoWebPublished;
            public StringField RefNoConfirmed;
            public StringField RefNoRfqNo;
            public StringField RefNoWebUserName;
            public StringField RefNoShipTo;
            public StringField RefNoTelNo;
            public StringField RefNoFaxNo;
            public StringField RefNoPortLoading;
            public StringField RefNoPortDischarge;
            public StringField RefNoOriginCountry;
            public StringField RefNoSltaxType;
            public DecimalField RefNoGsltaxPcent;
            public DecimalField RefNoTotGsltaxAmt;
            public DecimalField RefNoTotLsltaxAmt;
            public StringField RefNoAnlys7;
            public StringField RefNoAnlys8;
            public DecimalField RefNoMarkupDecimal;
            public StringField RefNoPkgUnit;
            public StringField RefNoWeightUnit;
            public StringField RefNoAnlys9;
            public StringField RefNoAnlys10;
            public StringField RefNoAnlys11;
            public StringField RefNoAnlys12;
            public StringField RefNoAnlys13;
            public StringField RefNoAnlys14;
            public StringField RefNoItemCode;
            public StringField RefNoTransport;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Sales.QuotationDetail";
            }
        }
    }
}
