#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseOrderRow.cs
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

    [ConnectionKey("Purchasing"), TableName("[dbo].[PUORDH]")]
    [DisplayName("Purchase Order"), InstanceName("Purchase Order"), TwoLevelCached]   
    public sealed class PurchaseOrderRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Order No"), Column("ORDER_NO"), Size(16), PrimaryKey, QuickSearch]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Posted"), Column("POSTED"), Size(1), NotNull]
        [BoolStringConverter]
        public bool? Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Closed"), Column("CLOSED"), Size(1), NotNull]
        [BoolStringConverter]
        public bool? Closed
        {
            get { return Fields.Closed[this]; }
            set { Fields.Closed[this] = value; }
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

        [DisplayName("Address"), Column("VENDOR_ADDRESS"), Size(50)]
        public String VendorAddress
        {
            get { return Fields.VendorAddress[this]; }
            set { Fields.VendorAddress[this] = value; }
        }

        [DisplayName(""), Column("VENDOR_ADDRESS2"), Size(50)]
        public String VendorAddress2
        {
            get { return Fields.VendorAddress2[this]; }
            set { Fields.VendorAddress2[this] = value; }
        }

        [DisplayName(""), Column("VENDOR_ADDRESS3"), Size(50)]
        public String VendorAddress3
        {
            get { return Fields.VendorAddress3[this]; }
            set { Fields.VendorAddress3[this] = value; }
        }

        [DisplayName(""), Column("VENDOR_ADDRESS4"), Size(50)]
        public String VendorAddress4
        {
            get { return Fields.VendorAddress4[this]; }
            set { Fields.VendorAddress4[this] = value; }
        }

        [DisplayName("Order Date"), Column("ORDER_DATE"), NotNull]
        public DateTime? OrderDate
        {
            get { return Fields.OrderDate[this]; }
            set { Fields.OrderDate[this] = value; }
        }

        [DisplayName("Due Date"), Column("DUE_DATE"), NotNull]
        public DateTime? DueDate
        {
            get { return Fields.DueDate[this]; }
            set { Fields.DueDate[this] = value; }
        }

        [DisplayName("Sched Date"), Column("SCHED_DATE")]
        public DateTime? SchedDate
        {
            get { return Fields.SchedDate[this]; }
            set { Fields.SchedDate[this] = value; }
        }

        [DisplayName("Ship To"), Column("SHIP_TO"), Size(6), NotNull]
        public String ShipTo
        {
            get { return Fields.ShipTo[this]; }
            set { Fields.ShipTo[this] = value; }
        }

        [DisplayName("Address"), Column("ADDRESS"), Size(50)]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName(""), Column("ADDRESS2"), Size(50)]
        public String Address2
        {
            get { return Fields.Address2[this]; }
            set { Fields.Address2[this] = value; }
        }

        [DisplayName(""), Column("ADDRESS3"), Size(50)]
        public String Address3
        {
            get { return Fields.Address3[this]; }
            set { Fields.Address3[this] = value; }
        }

        [DisplayName(""), Column("ADDRESS4"), Size(50)]
        public String Address4
        {
            get { return Fields.Address4[this]; }
            set { Fields.Address4[this] = value; }
        }

        [DisplayName("Multiple Shipments"), Column("MULTI_SHIP"), Size(1)]
        public String MultiShip
        {
            get { return Fields.MultiShip[this]; }
            set { Fields.MultiShip[this] = value; }
        }

        [DisplayName("Compute Tax"), Column("COMPUTE_TAX"), Size(1)]
        public String ComputeTax
        {
            get { return Fields.ComputeTax[this]; }
            set { Fields.ComputeTax[this] = value; }
        }

        [DisplayName("Ship Via"), Column("SHIP_VIA"), Size(30)]
        public String ShipVia
        {
            get { return Fields.ShipVia[this]; }
            set { Fields.ShipVia[this] = value; }
        }

        [DisplayName("Shipment Terms"), Column("SHIPMENT_TERMS"), Size(15)]
        public String ShipmentTerms
        {
            get { return Fields.ShipmentTerms[this]; }
            set { Fields.ShipmentTerms[this] = value; }
        }

        [DisplayName("Buyer"), Column("BUYER"), Size(6), NotNull]
        public String Buyer
        {
            get { return Fields.Buyer[this]; }
            set { Fields.Buyer[this] = value; }
        }

        [DisplayName("Pay Terms"), Column("PAY_TERMS"), Size(6)]
        public String PayTerms
        {
            get { return Fields.PayTerms[this]; }
            set { Fields.PayTerms[this] = value; }
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

        [DisplayName("Source Type"), Column("SOURCE_TYPE"), Size(12), NotNull]
        public String SourceType
        {
            get { return Fields.SourceType[this]; }
            set { Fields.SourceType[this] = value; }
        }

        [DisplayName("Source Ref No"), Column("SOURCE_REF_NO"), Size(16), NotNull]
        public String SourceRefNo
        {
            get { return Fields.SourceRefNo[this]; }
            set { Fields.SourceRefNo[this] = value; }
        }

        [DisplayName("Last Sched No"), Column("LAST_SCHED_NO"), Size(4)]
        public Decimal? LastSchedNo
        {
            get { return Fields.LastSchedNo[this]; }
            set { Fields.LastSchedNo[this] = value; }
        }

        [DisplayName("Last Line No"), Column("LAST_LINE_NO"), Size(8)]
        public Decimal? LastLineNo
        {
            get { return Fields.LastLineNo[this]; }
            set { Fields.LastLineNo[this] = value; }
        }

        [DisplayName("Last Text No"), Column("LAST_TEXT_NO"), Size(6)]
        public Decimal? LastTextNo
        {
            get { return Fields.LastTextNo[this]; }
            set { Fields.LastTextNo[this] = value; }
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

        [DisplayName("Dps Pcent"), Column("DPS_PCENT"), Size(6), Scale(2)]
        public Decimal? DpsPcent
        {
            get { return Fields.DpsPcent[this]; }
            set { Fields.DpsPcent[this] = value; }
        }

        [DisplayName("Tot Dps Amt"), Column("TOT_DPS_AMT"), Size(16), Scale(2)]
        public Decimal? TotDpsAmt
        {
            get { return Fields.TotDpsAmt[this]; }
            set { Fields.TotDpsAmt[this] = value; }
        }

        [DisplayName("Net Bal Amt"), Column("NET_BAL_AMT"), Size(16), Scale(2)]
        public Decimal? NetBalAmt
        {
            get { return Fields.NetBalAmt[this]; }
            set { Fields.NetBalAmt[this] = value; }
        }

        [DisplayName("Tot Tdisc Cpd"), Column("TOT_TDISC_CPD"), Size(16), Scale(2)]
        public Decimal? TotTdiscCpd
        {
            get { return Fields.TotTdiscCpd[this]; }
            set { Fields.TotTdiscCpd[this] = value; }
        }

        [DisplayName("Tot Gtax Cpd"), Column("TOT_GTAX_CPD"), Size(16), Scale(2)]
        public Decimal? TotGtaxCpd
        {
            get { return Fields.TotGtaxCpd[this]; }
            set { Fields.TotGtaxCpd[this] = value; }
        }

        [DisplayName("Tot Dps Cpd"), Column("TOT_DPS_CPD"), Size(16), Scale(2)]
        public Decimal? TotDpsCpd
        {
            get { return Fields.TotDpsCpd[this]; }
            set { Fields.TotDpsCpd[this] = value; }
        }

        [DisplayName("Dps Ref No"), Column("DPS_REF_NO"), Size(16)]
        public String DpsRefNo
        {
            get { return Fields.DpsRefNo[this]; }
            set { Fields.DpsRefNo[this] = value; }
        }

        [DisplayName("Dps Fund Code"), Column("DPS_FUND_CODE"), Size(6)]
        public String DpsFundCode
        {
            get { return Fields.DpsFundCode[this]; }
            set { Fields.DpsFundCode[this] = value; }
        }

        [DisplayName("Dps Payee"), Column("DPS_PAYEE"), Size(50)]
        public String DpsPayee
        {
            get { return Fields.DpsPayee[this]; }
            set { Fields.DpsPayee[this] = value; }
        }

        [DisplayName("Dps Cheque No"), Column("DPS_CHEQUE_NO"), Size(12)]
        public String DpsChequeNo
        {
            get { return Fields.DpsChequeNo[this]; }
            set { Fields.DpsChequeNo[this] = value; }
        }

        [DisplayName("Dps Date"), Column("DPS_DATE")]
        public DateTime? DpsDate
        {
            get { return Fields.DpsDate[this]; }
            set { Fields.DpsDate[this] = value; }
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

        [DisplayName("Comments1"), Column("COMMENTS1"), Size(1073741823)]
        public String Comments1
        {
            get { return Fields.Comments1[this]; }
            set { Fields.Comments1[this] = value; }
        }

        [DisplayName("Comments2"), Column("COMMENTS2"), Size(1073741823)]
        public String Comments2
        {
            get { return Fields.Comments2[this]; }
            set { Fields.Comments2[this] = value; }
        }

        [DisplayName("Comments3"), Column("COMMENTS3"), Size(1073741823)]
        public String Comments3
        {
            get { return Fields.Comments3[this]; }
            set { Fields.Comments3[this] = value; }
        }

        [DisplayName("Comments4"), Column("COMMENTS4"), Size(1073741823)]
        public String Comments4
        {
            get { return Fields.Comments4[this]; }
            set { Fields.Comments4[this] = value; }
        }

        [DisplayName("Server Revised"), Column("SERVER_REVISED"), Size(1)]
        public String ServerRevised
        {
            get { return Fields.ServerRevised[this]; }
            set { Fields.ServerRevised[this] = value; }
        }

        [DisplayName("Web Amended"), Column("WEB_AMENDED"), Size(1)]
        public String WebAmended
        {
            get { return Fields.WebAmended[this]; }
            set { Fields.WebAmended[this] = value; }
        }

        [DisplayName("Pub Access"), Column("PUB_ACCESS"), Size(1)]
        public String PubAccess
        {
            get { return Fields.PubAccess[this]; }
            set { Fields.PubAccess[this] = value; }
        }

        [DisplayName("Confirmed"), Column("CONFIRMED"), Size(1)]
        public String Confirmed
        {
            get { return Fields.Confirmed[this]; }
            set { Fields.Confirmed[this] = value; }
        }

        [DisplayName("Check Crlimit"), Column("CHECK_CRLIMIT"), Size(1)]
        public String CheckCrlimit
        {
            get { return Fields.CheckCrlimit[this]; }
            set { Fields.CheckCrlimit[this] = value; }
        }

        [DisplayName("Check Crbal"), Column("CHECK_CRBAL"), Size(16), Scale(2)]
        public Decimal? CheckCrbal
        {
            get { return Fields.CheckCrbal[this]; }
            set { Fields.CheckCrbal[this] = value; }
        }

        [DisplayName("Job No"), Column("JOB_NO"), Size(16)]
        public String JobNo
        {
            get { return Fields.JobNo[this]; }
            set { Fields.JobNo[this] = value; }
        }

        [DisplayName("Consign"), Column("CONSIGN"), Size(1)]
        public String Consign
        {
            get { return Fields.Consign[this]; }
            set { Fields.Consign[this] = value; }
        }

        [DisplayName("Port of Loading"), Column("PORT_LOADING"), Size(50)]
        public String PortLoading
        {
            get { return Fields.PortLoading[this]; }
            set { Fields.PortLoading[this] = value; }
        }

        [DisplayName("Port of Discharge"), Column("PORT_DISCHARGE"), Size(50)]
        public String PortDischarge
        {
            get { return Fields.PortDischarge[this]; }
            set { Fields.PortDischarge[this] = value; }
        }

        [DisplayName("Vessel Name"), Column("VESSEL_NAME"), Size(35)]
        public String VesselName
        {
            get { return Fields.VesselName[this]; }
            set { Fields.VesselName[this] = value; }
        }

        [DisplayName("Forwarder"), Column("FORWARDER"), Size(25)]
        public String Forwarder
        {
            get { return Fields.Forwarder[this]; }
            set { Fields.Forwarder[this] = value; }
        }

        [DisplayName("L/C #"), Column("LC_NO"), Size(25)]
        public String LcNo
        {
            get { return Fields.LcNo[this]; }
            set { Fields.LcNo[this] = value; }
        }

        [DisplayName("Country of Origin"), Column("ORIGIN_COUNTRY"), Size(25)]
        public String OriginCountry
        {
            get { return Fields.OriginCountry[this]; }
            set { Fields.OriginCountry[this] = value; }
        }

        [DisplayName("Putax Type"), Column("PUTAX_TYPE"), Size(1)]
        public String PutaxType
        {
            get { return Fields.PutaxType[this]; }
            set { Fields.PutaxType[this] = value; }
        }

        [DisplayName("Gputax Pcent"), Column("GPUTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? GputaxPcent
        {
            get { return Fields.GputaxPcent[this]; }
            set { Fields.GputaxPcent[this] = value; }
        }

        [DisplayName("Tot Gputax Amt"), Column("TOT_GPUTAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotGputaxAmt
        {
            get { return Fields.TotGputaxAmt[this]; }
            set { Fields.TotGputaxAmt[this] = value; }
        }

        [DisplayName("Tot Lputax Amt"), Column("TOT_LPUTAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotLputaxAmt
        {
            get { return Fields.TotLputaxAmt[this]; }
            set { Fields.TotLputaxAmt[this] = value; }
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

        [DisplayName("Last Link No"), Column("LAST_LINK_NO"), Size(6)]
        public Decimal? LastLinkNo
        {
            get { return Fields.LastLinkNo[this]; }
            set { Fields.LastLinkNo[this] = value; }
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

        [DisplayName("Subcon Po"), Column("SUBCON_PO"), Size(1)]
        public String SubconPo
        {
            get { return Fields.SubconPo[this]; }
            set { Fields.SubconPo[this] = value; }
        }

        [DisplayName("MRP Exclude"), Column("MRP_EXCLUDE"), Size(1)]
        public String MrpExclude
        {
            get { return Fields.MrpExclude[this]; }
            set { Fields.MrpExclude[this] = value; }
        }

        [DisplayName("From Pr"), Column("FROM_PR"), Size(1)]
        public String FromPr
        {
            get { return Fields.FromPr[this]; }
            set { Fields.FromPr[this] = value; }
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

        [DisplayName("Ref Company Code"), Column("REF_COMPANY_CODE"), Size(20)]
        public String RefCompanyCode
        {
            get { return Fields.RefCompanyCode[this]; }
            set { Fields.RefCompanyCode[this] = value; }
        }

        [DisplayName("Ref Sales Order No"), Column("REF_SALES_ORDER_NO"), Size(32)]
        public String RefSalesOrderNo
        {
            get { return Fields.RefSalesOrderNo[this]; }
            set { Fields.RefSalesOrderNo[this] = value; }
        }

        [DisplayName("Tax Terms"), Column("TAX_TERMS"), Size(8)]
        public String TaxTerms
        {
            get { return Fields.TaxTerms[this]; }
            set { Fields.TaxTerms[this] = value; }
        }

        [DisplayName("Custom Terms"), Column("CUSTOM_TERMS"), Size(8)]
        public String CustomTerms
        {
            get { return Fields.CustomTerms[this]; }
            set { Fields.CustomTerms[this] = value; }
        }

        [DisplayName("Lme Cost"), Column("LME_COST"), Size(18), Scale(6)]
        public Decimal? LmeCost
        {
            get { return Fields.LmeCost[this]; }
            set { Fields.LmeCost[this] = value; }
        }

        [DisplayName("Lme Ccy"), Column("LME_CCY"), Size(4)]
        public String LmeCcy
        {
            get { return Fields.LmeCcy[this]; }
            set { Fields.LmeCcy[this] = value; }
        }

        [DisplayName("Lme Exch Rate"), Column("LME_EXCH_RATE"), Size(12), Scale(6)]
        public Decimal? LmeExchRate
        {
            get { return Fields.LmeExchRate[this]; }
            set { Fields.LmeExchRate[this] = value; }
        }

        [DisplayName("Address Code"), Column("ADDRESS_CODE"), Size(6)]
        public String AddressCode
        {
            get { return Fields.AddressCode[this]; }
            set { Fields.AddressCode[this] = value; }
        }

        [DisplayName("Contact Person"), Column("CONTACT_PERSON"), Size(30)]
        public String ContactPerson
        {
            get { return Fields.ContactPerson[this]; }
            set { Fields.ContactPerson[this] = value; }
        }

        [DisplayName("Contact Title"), Column("CONTACT_TITLE"), Size(20)]
        public String ContactTitle
        {
            get { return Fields.ContactTitle[this]; }
            set { Fields.ContactTitle[this] = value; }
        }

        [DisplayName("Tel No"), Column("TEL_NO"), Size(30)]
        public String TelNo
        {
            get { return Fields.TelNo[this]; }
            set { Fields.TelNo[this] = value; }
        }

        [DisplayName("Fax No"), Column("FAX_NO"), Size(30)]
        public String FaxNo
        {
            get { return Fields.FaxNo[this]; }
            set { Fields.FaxNo[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.OrderNo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.OrderNo; }
        }

        [MasterDetailRelation(foreignKey: "OrderNo")]
        [DisplayName("Item Detail List"), NotMapped]
        public List<PurchaseOrderDetailRow> ItemDetailList
        {
            get { return Fields.ItemDetailList[this]; }
            set { Fields.ItemDetailList[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PurchaseOrderRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField OrderNo;
            public BooleanField Posted;
            public BooleanField Closed;
            public StringField VendorNo;
            public StringField VendorName;
            public StringField VendorAddress;
            public StringField VendorAddress2;
            public StringField VendorAddress3;
            public StringField VendorAddress4;
            public DateTimeField OrderDate;
            public DateTimeField DueDate;
            public DateTimeField SchedDate;
            public StringField ShipTo;
            public StringField Address;
            public StringField Address2;
            public StringField Address3;
            public StringField Address4;
            public StringField MultiShip;
            public StringField ComputeTax;
            public StringField ShipVia;
            public StringField ShipmentTerms;
            public StringField Buyer;
            public StringField PayTerms;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Ccy;
            public DecimalField ExchRate;
            public StringField SourceType;
            public StringField SourceRefNo;
            public DecimalField LastSchedNo;
            public DecimalField LastLineNo;
            public DecimalField LastTextNo;
            public DecimalField TotPriceAmt;
            public DecimalField TotPtaxAmt;
            public DecimalField TotExtPrice;
            public DecimalField TotLdiscAmt;
            public DecimalField TotAtaxAmt;
            public DecimalField TotItemAmt;
            public DecimalField TdiscPcent;
            public DecimalField TotTdiscAmt;
            public DecimalField NetTradeAmt;
            public DecimalField TotChgsAmt;
            public DecimalField NetOrdrAmt;
            public DecimalField TotGtaxAmt;
            public DecimalField NetPayAmt;
            public DecimalField DpsPcent;
            public DecimalField TotDpsAmt;
            public DecimalField NetBalAmt;
            public DecimalField TotTdiscCpd;
            public DecimalField TotGtaxCpd;
            public DecimalField TotDpsCpd;
            public StringField DpsRefNo;
            public StringField DpsFundCode;
            public StringField DpsPayee;
            public StringField DpsChequeNo;
            public DateTimeField DpsDate;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField PostedDate;
            public StringField PostedBy;
            public StringField LockType;
            public StringField LockRefNo;
            public DecimalField LastLogNo;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Comments1;
            public StringField Comments2;
            public StringField Comments3;
            public StringField Comments4;
            public StringField ServerRevised;
            public StringField WebAmended;
            public StringField PubAccess;
            public StringField Confirmed;
            public StringField CheckCrlimit;
            public DecimalField CheckCrbal;
            public StringField JobNo;
            public StringField Consign;
            public StringField PortLoading;
            public StringField PortDischarge;
            public StringField VesselName;
            public StringField Forwarder;
            public StringField LcNo;
            public StringField OriginCountry;
            public StringField PutaxType;
            public DecimalField GputaxPcent;
            public DecimalField TotGputaxAmt;
            public DecimalField TotLputaxAmt;
            public StringField Anlys7;
            public StringField Anlys8;
            public DecimalField LastLinkNo;
            public StringField Flag;
            public StringField HoldBy;
            public StringField SubconPo;
            public StringField MrpExclude;
            public StringField FromPr;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;
            public StringField RefCompanyCode;
            public StringField RefSalesOrderNo;
            public StringField TaxTerms;
            public StringField CustomTerms;
            public DecimalField LmeCost;
            public StringField LmeCcy;
            public DecimalField LmeExchRate;
            public StringField AddressCode;
            public StringField ContactPerson;
            public StringField ContactTitle;
            public StringField TelNo;
            public StringField FaxNo;

            public RowListField<PurchaseOrderDetailRow> ItemDetailList;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Purchasing.PurchaseOrder";
            }
        }
    }
}
