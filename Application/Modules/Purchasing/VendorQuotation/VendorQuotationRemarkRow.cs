#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorQuotationRemarkRow.cs
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

    [ConnectionKey("Purchasing"), TableName("[dbo].[PUQUOP]")]
    [DisplayName("Vendor Quotation Remark"), InstanceName("Vendor Quotation Remark"), TwoLevelCached]   
    public sealed class VendorQuotationRemarkRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(28), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Order No"), Column("ORDER_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[PUQUOH]", "ORDER_NO"), LeftJoin("jOrderNo"), QuickSearch, TextualField("OrderNoClosed")]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Text No"), Column("TEXT_NO"), PrimaryKey]
        public Int16? TextNo
        {
            get { return Fields.TextNo[this]; }
            set { Fields.TextNo[this] = value; }
        }

        [DisplayName("Text Type"), Column("TEXT_TYPE"), Size(6), NotNull]
        public String TextType
        {
            get { return Fields.TextType[this]; }
            set { Fields.TextType[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(30)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Remarks"), Column("REMARKS"), Size(1073741823)]
        public String Remarks
        {
            get { return Fields.Remarks[this]; }
            set { Fields.Remarks[this] = value; }
        }

        [DisplayName("Order No Recnum"), Expression("jOrderNo.[RECNUM]")]
        public Decimal? OrderNoRecnum
        {
            get { return Fields.OrderNoRecnum[this]; }
            set { Fields.OrderNoRecnum[this] = value; }
        }

        [DisplayName("Order No Closed"), Expression("jOrderNo.[CLOSED]")]
        public String OrderNoClosed
        {
            get { return Fields.OrderNoClosed[this]; }
            set { Fields.OrderNoClosed[this] = value; }
        }

        [DisplayName("Order No Vendor No"), Expression("jOrderNo.[VENDOR_NO]")]
        public String OrderNoVendorNo
        {
            get { return Fields.OrderNoVendorNo[this]; }
            set { Fields.OrderNoVendorNo[this] = value; }
        }

        [DisplayName("Order No Vendor Name"), Expression("jOrderNo.[VENDOR_NAME]")]
        public String OrderNoVendorName
        {
            get { return Fields.OrderNoVendorName[this]; }
            set { Fields.OrderNoVendorName[this] = value; }
        }

        [DisplayName("Order No Vendor Address"), Expression("jOrderNo.[VENDOR_ADDRESS]")]
        public String OrderNoVendorAddress
        {
            get { return Fields.OrderNoVendorAddress[this]; }
            set { Fields.OrderNoVendorAddress[this] = value; }
        }

        [DisplayName("Order No Vendor Address2"), Expression("jOrderNo.[VENDOR_ADDRESS2]")]
        public String OrderNoVendorAddress2
        {
            get { return Fields.OrderNoVendorAddress2[this]; }
            set { Fields.OrderNoVendorAddress2[this] = value; }
        }

        [DisplayName("Order No Vendor Address3"), Expression("jOrderNo.[VENDOR_ADDRESS3]")]
        public String OrderNoVendorAddress3
        {
            get { return Fields.OrderNoVendorAddress3[this]; }
            set { Fields.OrderNoVendorAddress3[this] = value; }
        }

        [DisplayName("Order No Vendor Address4"), Expression("jOrderNo.[VENDOR_ADDRESS4]")]
        public String OrderNoVendorAddress4
        {
            get { return Fields.OrderNoVendorAddress4[this]; }
            set { Fields.OrderNoVendorAddress4[this] = value; }
        }

        [DisplayName("Order No Order Date"), Expression("jOrderNo.[ORDER_DATE]")]
        public DateTime? OrderNoOrderDate
        {
            get { return Fields.OrderNoOrderDate[this]; }
            set { Fields.OrderNoOrderDate[this] = value; }
        }

        [DisplayName("Order No Due Date"), Expression("jOrderNo.[DUE_DATE]")]
        public DateTime? OrderNoDueDate
        {
            get { return Fields.OrderNoDueDate[this]; }
            set { Fields.OrderNoDueDate[this] = value; }
        }

        [DisplayName("Order No Sched Date"), Expression("jOrderNo.[SCHED_DATE]")]
        public DateTime? OrderNoSchedDate
        {
            get { return Fields.OrderNoSchedDate[this]; }
            set { Fields.OrderNoSchedDate[this] = value; }
        }

        [DisplayName("Order No Ship To"), Expression("jOrderNo.[SHIP_TO]")]
        public String OrderNoShipTo
        {
            get { return Fields.OrderNoShipTo[this]; }
            set { Fields.OrderNoShipTo[this] = value; }
        }

        [DisplayName("Order No Address"), Expression("jOrderNo.[ADDRESS]")]
        public String OrderNoAddress
        {
            get { return Fields.OrderNoAddress[this]; }
            set { Fields.OrderNoAddress[this] = value; }
        }

        [DisplayName("Order No Address2"), Expression("jOrderNo.[ADDRESS2]")]
        public String OrderNoAddress2
        {
            get { return Fields.OrderNoAddress2[this]; }
            set { Fields.OrderNoAddress2[this] = value; }
        }

        [DisplayName("Order No Address3"), Expression("jOrderNo.[ADDRESS3]")]
        public String OrderNoAddress3
        {
            get { return Fields.OrderNoAddress3[this]; }
            set { Fields.OrderNoAddress3[this] = value; }
        }

        [DisplayName("Order No Address4"), Expression("jOrderNo.[ADDRESS4]")]
        public String OrderNoAddress4
        {
            get { return Fields.OrderNoAddress4[this]; }
            set { Fields.OrderNoAddress4[this] = value; }
        }

        [DisplayName("Order No Multi Ship"), Expression("jOrderNo.[MULTI_SHIP]")]
        public String OrderNoMultiShip
        {
            get { return Fields.OrderNoMultiShip[this]; }
            set { Fields.OrderNoMultiShip[this] = value; }
        }

        [DisplayName("Order No Compute Tax"), Expression("jOrderNo.[COMPUTE_TAX]")]
        public String OrderNoComputeTax
        {
            get { return Fields.OrderNoComputeTax[this]; }
            set { Fields.OrderNoComputeTax[this] = value; }
        }

        [DisplayName("Order No Ship Via"), Expression("jOrderNo.[SHIP_VIA]")]
        public String OrderNoShipVia
        {
            get { return Fields.OrderNoShipVia[this]; }
            set { Fields.OrderNoShipVia[this] = value; }
        }

        [DisplayName("Order No Shipment Terms"), Expression("jOrderNo.[SHIPMENT_TERMS]")]
        public String OrderNoShipmentTerms
        {
            get { return Fields.OrderNoShipmentTerms[this]; }
            set { Fields.OrderNoShipmentTerms[this] = value; }
        }

        [DisplayName("Order No Buyer"), Expression("jOrderNo.[BUYER]")]
        public String OrderNoBuyer
        {
            get { return Fields.OrderNoBuyer[this]; }
            set { Fields.OrderNoBuyer[this] = value; }
        }

        [DisplayName("Order No Pay Terms"), Expression("jOrderNo.[PAY_TERMS]")]
        public String OrderNoPayTerms
        {
            get { return Fields.OrderNoPayTerms[this]; }
            set { Fields.OrderNoPayTerms[this] = value; }
        }

        [DisplayName("Order No Anlys1"), Expression("jOrderNo.[ANLYS1]")]
        public String OrderNoAnlys1
        {
            get { return Fields.OrderNoAnlys1[this]; }
            set { Fields.OrderNoAnlys1[this] = value; }
        }

        [DisplayName("Order No Anlys2"), Expression("jOrderNo.[ANLYS2]")]
        public String OrderNoAnlys2
        {
            get { return Fields.OrderNoAnlys2[this]; }
            set { Fields.OrderNoAnlys2[this] = value; }
        }

        [DisplayName("Order No Ccy"), Expression("jOrderNo.[CCY]")]
        public String OrderNoCcy
        {
            get { return Fields.OrderNoCcy[this]; }
            set { Fields.OrderNoCcy[this] = value; }
        }

        [DisplayName("Order No Exch Rate"), Expression("jOrderNo.[EXCH_RATE]")]
        public Decimal? OrderNoExchRate
        {
            get { return Fields.OrderNoExchRate[this]; }
            set { Fields.OrderNoExchRate[this] = value; }
        }

        [DisplayName("Order No Source Type"), Expression("jOrderNo.[SOURCE_TYPE]")]
        public String OrderNoSourceType
        {
            get { return Fields.OrderNoSourceType[this]; }
            set { Fields.OrderNoSourceType[this] = value; }
        }

        [DisplayName("Order No Source Ref No"), Expression("jOrderNo.[SOURCE_REF_NO]")]
        public String OrderNoSourceRefNo
        {
            get { return Fields.OrderNoSourceRefNo[this]; }
            set { Fields.OrderNoSourceRefNo[this] = value; }
        }

        [DisplayName("Order No Last Sched No"), Expression("jOrderNo.[LAST_SCHED_NO]")]
        public Int16? OrderNoLastSchedNo
        {
            get { return Fields.OrderNoLastSchedNo[this]; }
            set { Fields.OrderNoLastSchedNo[this] = value; }
        }

        [DisplayName("Order No Last Line No"), Expression("jOrderNo.[LAST_LINE_NO]")]
        public Int32? OrderNoLastLineNo
        {
            get { return Fields.OrderNoLastLineNo[this]; }
            set { Fields.OrderNoLastLineNo[this] = value; }
        }

        [DisplayName("Order No Last Text No"), Expression("jOrderNo.[LAST_TEXT_NO]")]
        public Int32? OrderNoLastTextNo
        {
            get { return Fields.OrderNoLastTextNo[this]; }
            set { Fields.OrderNoLastTextNo[this] = value; }
        }

        [DisplayName("Order No Tot Price Amt"), Expression("jOrderNo.[TOT_PRICE_AMT]")]
        public Decimal? OrderNoTotPriceAmt
        {
            get { return Fields.OrderNoTotPriceAmt[this]; }
            set { Fields.OrderNoTotPriceAmt[this] = value; }
        }

        [DisplayName("Order No Tot Ptax Amt"), Expression("jOrderNo.[TOT_PTAX_AMT]")]
        public Decimal? OrderNoTotPtaxAmt
        {
            get { return Fields.OrderNoTotPtaxAmt[this]; }
            set { Fields.OrderNoTotPtaxAmt[this] = value; }
        }

        [DisplayName("Order No Tot Ext Price"), Expression("jOrderNo.[TOT_EXT_PRICE]")]
        public Decimal? OrderNoTotExtPrice
        {
            get { return Fields.OrderNoTotExtPrice[this]; }
            set { Fields.OrderNoTotExtPrice[this] = value; }
        }

        [DisplayName("Order No Tot Ldisc Amt"), Expression("jOrderNo.[TOT_LDISC_AMT]")]
        public Decimal? OrderNoTotLdiscAmt
        {
            get { return Fields.OrderNoTotLdiscAmt[this]; }
            set { Fields.OrderNoTotLdiscAmt[this] = value; }
        }

        [DisplayName("Order No Tot Atax Amt"), Expression("jOrderNo.[TOT_ATAX_AMT]")]
        public Decimal? OrderNoTotAtaxAmt
        {
            get { return Fields.OrderNoTotAtaxAmt[this]; }
            set { Fields.OrderNoTotAtaxAmt[this] = value; }
        }

        [DisplayName("Order No Tot Item Amt"), Expression("jOrderNo.[TOT_ITEM_AMT]")]
        public Decimal? OrderNoTotItemAmt
        {
            get { return Fields.OrderNoTotItemAmt[this]; }
            set { Fields.OrderNoTotItemAmt[this] = value; }
        }

        [DisplayName("Order No Tdisc Pcent"), Expression("jOrderNo.[TDISC_PCENT]")]
        public Decimal? OrderNoTdiscPcent
        {
            get { return Fields.OrderNoTdiscPcent[this]; }
            set { Fields.OrderNoTdiscPcent[this] = value; }
        }

        [DisplayName("Order No Tot Tdisc Amt"), Expression("jOrderNo.[TOT_TDISC_AMT]")]
        public Decimal? OrderNoTotTdiscAmt
        {
            get { return Fields.OrderNoTotTdiscAmt[this]; }
            set { Fields.OrderNoTotTdiscAmt[this] = value; }
        }

        [DisplayName("Order No Net Trade Amt"), Expression("jOrderNo.[NET_TRADE_AMT]")]
        public Decimal? OrderNoNetTradeAmt
        {
            get { return Fields.OrderNoNetTradeAmt[this]; }
            set { Fields.OrderNoNetTradeAmt[this] = value; }
        }

        [DisplayName("Order No Tot Chgs Amt"), Expression("jOrderNo.[TOT_CHGS_AMT]")]
        public Decimal? OrderNoTotChgsAmt
        {
            get { return Fields.OrderNoTotChgsAmt[this]; }
            set { Fields.OrderNoTotChgsAmt[this] = value; }
        }

        [DisplayName("Order No Net Ordr Amt"), Expression("jOrderNo.[NET_ORDR_AMT]")]
        public Decimal? OrderNoNetOrdrAmt
        {
            get { return Fields.OrderNoNetOrdrAmt[this]; }
            set { Fields.OrderNoNetOrdrAmt[this] = value; }
        }

        [DisplayName("Order No Tot Gtax Amt"), Expression("jOrderNo.[TOT_GTAX_AMT]")]
        public Decimal? OrderNoTotGtaxAmt
        {
            get { return Fields.OrderNoTotGtaxAmt[this]; }
            set { Fields.OrderNoTotGtaxAmt[this] = value; }
        }

        [DisplayName("Order No Net Pay Amt"), Expression("jOrderNo.[NET_PAY_AMT]")]
        public Decimal? OrderNoNetPayAmt
        {
            get { return Fields.OrderNoNetPayAmt[this]; }
            set { Fields.OrderNoNetPayAmt[this] = value; }
        }

        [DisplayName("Order No Dps Pcent"), Expression("jOrderNo.[DPS_PCENT]")]
        public Decimal? OrderNoDpsPcent
        {
            get { return Fields.OrderNoDpsPcent[this]; }
            set { Fields.OrderNoDpsPcent[this] = value; }
        }

        [DisplayName("Order No Tot Dps Amt"), Expression("jOrderNo.[TOT_DPS_AMT]")]
        public Decimal? OrderNoTotDpsAmt
        {
            get { return Fields.OrderNoTotDpsAmt[this]; }
            set { Fields.OrderNoTotDpsAmt[this] = value; }
        }

        [DisplayName("Order No Net Bal Amt"), Expression("jOrderNo.[NET_BAL_AMT]")]
        public Decimal? OrderNoNetBalAmt
        {
            get { return Fields.OrderNoNetBalAmt[this]; }
            set { Fields.OrderNoNetBalAmt[this] = value; }
        }

        [DisplayName("Order No Tot Tdisc Cpd"), Expression("jOrderNo.[TOT_TDISC_CPD]")]
        public Decimal? OrderNoTotTdiscCpd
        {
            get { return Fields.OrderNoTotTdiscCpd[this]; }
            set { Fields.OrderNoTotTdiscCpd[this] = value; }
        }

        [DisplayName("Order No Tot Gtax Cpd"), Expression("jOrderNo.[TOT_GTAX_CPD]")]
        public Decimal? OrderNoTotGtaxCpd
        {
            get { return Fields.OrderNoTotGtaxCpd[this]; }
            set { Fields.OrderNoTotGtaxCpd[this] = value; }
        }

        [DisplayName("Order No Tot Dps Cpd"), Expression("jOrderNo.[TOT_DPS_CPD]")]
        public Decimal? OrderNoTotDpsCpd
        {
            get { return Fields.OrderNoTotDpsCpd[this]; }
            set { Fields.OrderNoTotDpsCpd[this] = value; }
        }

        [DisplayName("Order No Created Date"), Expression("jOrderNo.[CREATED_DATE]")]
        public DateTime? OrderNoCreatedDate
        {
            get { return Fields.OrderNoCreatedDate[this]; }
            set { Fields.OrderNoCreatedDate[this] = value; }
        }

        [DisplayName("Order No Created By"), Expression("jOrderNo.[CREATED_BY]")]
        public String OrderNoCreatedBy
        {
            get { return Fields.OrderNoCreatedBy[this]; }
            set { Fields.OrderNoCreatedBy[this] = value; }
        }

        [DisplayName("Order No Revised Date"), Expression("jOrderNo.[REVISED_DATE]")]
        public DateTime? OrderNoRevisedDate
        {
            get { return Fields.OrderNoRevisedDate[this]; }
            set { Fields.OrderNoRevisedDate[this] = value; }
        }

        [DisplayName("Order No Revised By"), Expression("jOrderNo.[REVISED_BY]")]
        public String OrderNoRevisedBy
        {
            get { return Fields.OrderNoRevisedBy[this]; }
            set { Fields.OrderNoRevisedBy[this] = value; }
        }

        [DisplayName("Order No Posted Date"), Expression("jOrderNo.[POSTED_DATE]")]
        public DateTime? OrderNoPostedDate
        {
            get { return Fields.OrderNoPostedDate[this]; }
            set { Fields.OrderNoPostedDate[this] = value; }
        }

        [DisplayName("Order No Posted By"), Expression("jOrderNo.[POSTED_BY]")]
        public String OrderNoPostedBy
        {
            get { return Fields.OrderNoPostedBy[this]; }
            set { Fields.OrderNoPostedBy[this] = value; }
        }

        [DisplayName("Order No Lock Ref No"), Expression("jOrderNo.[LOCK_REF_NO]")]
        public String OrderNoLockRefNo
        {
            get { return Fields.OrderNoLockRefNo[this]; }
            set { Fields.OrderNoLockRefNo[this] = value; }
        }

        [DisplayName("Order No Last Log No"), Expression("jOrderNo.[LAST_LOG_NO]")]
        public Int32? OrderNoLastLogNo
        {
            get { return Fields.OrderNoLastLogNo[this]; }
            set { Fields.OrderNoLastLogNo[this] = value; }
        }

        [DisplayName("Order No Owner Branch"), Expression("jOrderNo.[OWNER_BRANCH]")]
        public String OrderNoOwnerBranch
        {
            get { return Fields.OrderNoOwnerBranch[this]; }
            set { Fields.OrderNoOwnerBranch[this] = value; }
        }

        [DisplayName("Order No Source Branch"), Expression("jOrderNo.[SOURCE_BRANCH]")]
        public String OrderNoSourceBranch
        {
            get { return Fields.OrderNoSourceBranch[this]; }
            set { Fields.OrderNoSourceBranch[this] = value; }
        }

        [DisplayName("Order No Comments1"), Expression("jOrderNo.[COMMENTS1]")]
        public String OrderNoComments1
        {
            get { return Fields.OrderNoComments1[this]; }
            set { Fields.OrderNoComments1[this] = value; }
        }

        [DisplayName("Order No Comments2"), Expression("jOrderNo.[COMMENTS2]")]
        public String OrderNoComments2
        {
            get { return Fields.OrderNoComments2[this]; }
            set { Fields.OrderNoComments2[this] = value; }
        }

        [DisplayName("Order No Comments3"), Expression("jOrderNo.[COMMENTS3]")]
        public String OrderNoComments3
        {
            get { return Fields.OrderNoComments3[this]; }
            set { Fields.OrderNoComments3[this] = value; }
        }

        [DisplayName("Order No Comments4"), Expression("jOrderNo.[COMMENTS4]")]
        public String OrderNoComments4
        {
            get { return Fields.OrderNoComments4[this]; }
            set { Fields.OrderNoComments4[this] = value; }
        }

        [DisplayName("Order No Port Loading"), Expression("jOrderNo.[PORT_LOADING]")]
        public String OrderNoPortLoading
        {
            get { return Fields.OrderNoPortLoading[this]; }
            set { Fields.OrderNoPortLoading[this] = value; }
        }

        [DisplayName("Order No Port Discharge"), Expression("jOrderNo.[PORT_DISCHARGE]")]
        public String OrderNoPortDischarge
        {
            get { return Fields.OrderNoPortDischarge[this]; }
            set { Fields.OrderNoPortDischarge[this] = value; }
        }

        [DisplayName("Order No Vessel Name"), Expression("jOrderNo.[VESSEL_NAME]")]
        public String OrderNoVesselName
        {
            get { return Fields.OrderNoVesselName[this]; }
            set { Fields.OrderNoVesselName[this] = value; }
        }

        [DisplayName("Order No Forwarder"), Expression("jOrderNo.[FORWARDER]")]
        public String OrderNoForwarder
        {
            get { return Fields.OrderNoForwarder[this]; }
            set { Fields.OrderNoForwarder[this] = value; }
        }

        [DisplayName("Order No Lc No"), Expression("jOrderNo.[LC_NO]")]
        public String OrderNoLcNo
        {
            get { return Fields.OrderNoLcNo[this]; }
            set { Fields.OrderNoLcNo[this] = value; }
        }

        [DisplayName("Order No Origin Country"), Expression("jOrderNo.[ORIGIN_COUNTRY]")]
        public String OrderNoOriginCountry
        {
            get { return Fields.OrderNoOriginCountry[this]; }
            set { Fields.OrderNoOriginCountry[this] = value; }
        }

        [DisplayName("Order No Putax Type"), Expression("jOrderNo.[PUTAX_TYPE]")]
        public String OrderNoPutaxType
        {
            get { return Fields.OrderNoPutaxType[this]; }
            set { Fields.OrderNoPutaxType[this] = value; }
        }

        [DisplayName("Order No Gputax Pcent"), Expression("jOrderNo.[GPUTAX_PCENT]")]
        public Decimal? OrderNoGputaxPcent
        {
            get { return Fields.OrderNoGputaxPcent[this]; }
            set { Fields.OrderNoGputaxPcent[this] = value; }
        }

        [DisplayName("Order No Tot Gputax Amt"), Expression("jOrderNo.[TOT_GPUTAX_AMT]")]
        public Decimal? OrderNoTotGputaxAmt
        {
            get { return Fields.OrderNoTotGputaxAmt[this]; }
            set { Fields.OrderNoTotGputaxAmt[this] = value; }
        }

        [DisplayName("Order No Tot Lputax Amt"), Expression("jOrderNo.[TOT_LPUTAX_AMT]")]
        public Decimal? OrderNoTotLputaxAmt
        {
            get { return Fields.OrderNoTotLputaxAmt[this]; }
            set { Fields.OrderNoTotLputaxAmt[this] = value; }
        }

        [DisplayName("Order No Anlys7"), Expression("jOrderNo.[ANLYS7]")]
        public String OrderNoAnlys7
        {
            get { return Fields.OrderNoAnlys7[this]; }
            set { Fields.OrderNoAnlys7[this] = value; }
        }

        [DisplayName("Order No Anlys8"), Expression("jOrderNo.[ANLYS8]")]
        public String OrderNoAnlys8
        {
            get { return Fields.OrderNoAnlys8[this]; }
            set { Fields.OrderNoAnlys8[this] = value; }
        }

        [DisplayName("Order No Vendor Ref No"), Expression("jOrderNo.[VENDOR_REF_NO]")]
        public String OrderNoVendorRefNo
        {
            get { return Fields.OrderNoVendorRefNo[this]; }
            set { Fields.OrderNoVendorRefNo[this] = value; }
        }

        [DisplayName("Order No Valid Until"), Expression("jOrderNo.[VALID_UNTIL]")]
        public DateTime? OrderNoValidUntil
        {
            get { return Fields.OrderNoValidUntil[this]; }
            set { Fields.OrderNoValidUntil[this] = value; }
        }

        [DisplayName("Order No Closed By"), Expression("jOrderNo.[CLOSED_BY]")]
        public String OrderNoClosedBy
        {
            get { return Fields.OrderNoClosedBy[this]; }
            set { Fields.OrderNoClosedBy[this] = value; }
        }

        [DisplayName("Order No Closed Date"), Expression("jOrderNo.[CLOSED_DATE]")]
        public DateTime? OrderNoClosedDate
        {
            get { return Fields.OrderNoClosedDate[this]; }
            set { Fields.OrderNoClosedDate[this] = value; }
        }

        [DisplayName("Order No Anlys9"), Expression("jOrderNo.[ANLYS9]")]
        public String OrderNoAnlys9
        {
            get { return Fields.OrderNoAnlys9[this]; }
            set { Fields.OrderNoAnlys9[this] = value; }
        }

        [DisplayName("Order No Anlys10"), Expression("jOrderNo.[ANLYS10]")]
        public String OrderNoAnlys10
        {
            get { return Fields.OrderNoAnlys10[this]; }
            set { Fields.OrderNoAnlys10[this] = value; }
        }

        [DisplayName("Order No Anlys11"), Expression("jOrderNo.[ANLYS11]")]
        public String OrderNoAnlys11
        {
            get { return Fields.OrderNoAnlys11[this]; }
            set { Fields.OrderNoAnlys11[this] = value; }
        }

        [DisplayName("Order No Anlys12"), Expression("jOrderNo.[ANLYS12]")]
        public String OrderNoAnlys12
        {
            get { return Fields.OrderNoAnlys12[this]; }
            set { Fields.OrderNoAnlys12[this] = value; }
        }

        [DisplayName("Order No Anlys13"), Expression("jOrderNo.[ANLYS13]")]
        public String OrderNoAnlys13
        {
            get { return Fields.OrderNoAnlys13[this]; }
            set { Fields.OrderNoAnlys13[this] = value; }
        }

        [DisplayName("Order No Anlys14"), Expression("jOrderNo.[ANLYS14]")]
        public String OrderNoAnlys14
        {
            get { return Fields.OrderNoAnlys14[this]; }
            set { Fields.OrderNoAnlys14[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.OrderNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VendorQuotationRemarkRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField OrderNo;
            public Int16Field TextNo;
            public StringField TextType;
            public StringField Description;
            public StringField Remarks;

            public DecimalField OrderNoRecnum;
            public StringField OrderNoClosed;
            public StringField OrderNoVendorNo;
            public StringField OrderNoVendorName;
            public StringField OrderNoVendorAddress;
            public StringField OrderNoVendorAddress2;
            public StringField OrderNoVendorAddress3;
            public StringField OrderNoVendorAddress4;
            public DateTimeField OrderNoOrderDate;
            public DateTimeField OrderNoDueDate;
            public DateTimeField OrderNoSchedDate;
            public StringField OrderNoShipTo;
            public StringField OrderNoAddress;
            public StringField OrderNoAddress2;
            public StringField OrderNoAddress3;
            public StringField OrderNoAddress4;
            public StringField OrderNoMultiShip;
            public StringField OrderNoComputeTax;
            public StringField OrderNoShipVia;
            public StringField OrderNoShipmentTerms;
            public StringField OrderNoBuyer;
            public StringField OrderNoPayTerms;
            public StringField OrderNoAnlys1;
            public StringField OrderNoAnlys2;
            public StringField OrderNoCcy;
            public DecimalField OrderNoExchRate;
            public StringField OrderNoSourceType;
            public StringField OrderNoSourceRefNo;
            public Int16Field OrderNoLastSchedNo;
            public Int32Field OrderNoLastLineNo;
            public Int32Field OrderNoLastTextNo;
            public DecimalField OrderNoTotPriceAmt;
            public DecimalField OrderNoTotPtaxAmt;
            public DecimalField OrderNoTotExtPrice;
            public DecimalField OrderNoTotLdiscAmt;
            public DecimalField OrderNoTotAtaxAmt;
            public DecimalField OrderNoTotItemAmt;
            public DecimalField OrderNoTdiscPcent;
            public DecimalField OrderNoTotTdiscAmt;
            public DecimalField OrderNoNetTradeAmt;
            public DecimalField OrderNoTotChgsAmt;
            public DecimalField OrderNoNetOrdrAmt;
            public DecimalField OrderNoTotGtaxAmt;
            public DecimalField OrderNoNetPayAmt;
            public DecimalField OrderNoDpsPcent;
            public DecimalField OrderNoTotDpsAmt;
            public DecimalField OrderNoNetBalAmt;
            public DecimalField OrderNoTotTdiscCpd;
            public DecimalField OrderNoTotGtaxCpd;
            public DecimalField OrderNoTotDpsCpd;
            public DateTimeField OrderNoCreatedDate;
            public StringField OrderNoCreatedBy;
            public DateTimeField OrderNoRevisedDate;
            public StringField OrderNoRevisedBy;
            public DateTimeField OrderNoPostedDate;
            public StringField OrderNoPostedBy;
            public StringField OrderNoLockRefNo;
            public Int32Field OrderNoLastLogNo;
            public StringField OrderNoOwnerBranch;
            public StringField OrderNoSourceBranch;
            public StringField OrderNoComments1;
            public StringField OrderNoComments2;
            public StringField OrderNoComments3;
            public StringField OrderNoComments4;
            public StringField OrderNoPortLoading;
            public StringField OrderNoPortDischarge;
            public StringField OrderNoVesselName;
            public StringField OrderNoForwarder;
            public StringField OrderNoLcNo;
            public StringField OrderNoOriginCountry;
            public StringField OrderNoPutaxType;
            public DecimalField OrderNoGputaxPcent;
            public DecimalField OrderNoTotGputaxAmt;
            public DecimalField OrderNoTotLputaxAmt;
            public StringField OrderNoAnlys7;
            public StringField OrderNoAnlys8;
            public StringField OrderNoVendorRefNo;
            public DateTimeField OrderNoValidUntil;
            public StringField OrderNoClosedBy;
            public DateTimeField OrderNoClosedDate;
            public StringField OrderNoAnlys9;
            public StringField OrderNoAnlys10;
            public StringField OrderNoAnlys11;
            public StringField OrderNoAnlys12;
            public StringField OrderNoAnlys13;
            public StringField OrderNoAnlys14;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Purchasing.VendorQuotationRemark";
            }
        }
    }
}
