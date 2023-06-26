#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  SalesOrderRow.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;

namespace Matrix.Sales.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Sales"), TableName("[dbo].[SLORDH]")]
    [DisplayName("Sales Order"), InstanceName("Sales Order"), TwoLevelCached]   
    public sealed class SalesOrderRow : Row, IIdRow, INameRow
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
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Closed"), Column("CLOSED"), Size(1), NotNull]
        public String Closed
        {
            get { return Fields.Closed[this]; }
            set { Fields.Closed[this] = value; }
        }

        [DisplayName("Customer No"), Column("CUSTOMER_NO"), Size(8), NotNull]
        public String CustomerNo
        {
            get { return Fields.CustomerNo[this]; }
            set { Fields.CustomerNo[this] = value; }
        }

        [DisplayName("Customer Name"), Column("CUSTOMER_NAME"), Size(50)]
        public String CustomerName
        {
            get { return Fields.CustomerName[this]; }
            set { Fields.CustomerName[this] = value; }
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

        [DisplayName("Customer Po"), Column("CUSTOMER_PO"), Size(20)]
        public String CustomerPo
        {
            get { return Fields.CustomerPo[this]; }
            set { Fields.CustomerPo[this] = value; }
        }

        [DisplayName("Ship To"), Column("SHIP_TO"), Size(6)]
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

        [DisplayName("Multi Ship"), Column("MULTI_SHIP"), Size(1)]
        public String MultiShip
        {
            get { return Fields.MultiShip[this]; }
            set { Fields.MultiShip[this] = value; }
        }

        [DisplayName("Auto Po"), Column("AUTO_PO"), Size(1), NotNull]
        public String AutoPo
        {
            get { return Fields.AutoPo[this]; }
            set { Fields.AutoPo[this] = value; }
        }

        [DisplayName("Auto Job"), Column("AUTO_JOB"), Size(1)]
        public String AutoJob
        {
            get { return Fields.AutoJob[this]; }
            set { Fields.AutoJob[this] = value; }
        }

        [DisplayName("Compute Tax"), Column("COMPUTE_TAX"), Size(1)]
        public String ComputeTax
        {
            get { return Fields.ComputeTax[this]; }
            set { Fields.ComputeTax[this] = value; }
        }

        [DisplayName("Auto Resv"), Column("AUTO_RESV"), Size(1)]
        public String AutoResv
        {
            get { return Fields.AutoResv[this]; }
            set { Fields.AutoResv[this] = value; }
        }

        [DisplayName("Auto Wait"), Column("AUTO_WAIT"), Size(1)]
        public String AutoWait
        {
            get { return Fields.AutoWait[this]; }
            set { Fields.AutoWait[this] = value; }
        }

        [DisplayName("Vendor No"), Column("VENDOR_NO"), Size(8)]
        public String VendorNo
        {
            get { return Fields.VendorNo[this]; }
            set { Fields.VendorNo[this] = value; }
        }

        [DisplayName("Po No"), Column("PO_NO"), Size(15), NotNull]
        public String PoNo
        {
            get { return Fields.PoNo[this]; }
            set { Fields.PoNo[this] = value; }
        }

        [DisplayName("Po Pay Terms"), Column("PO_PAY_TERMS"), Size(6)]
        public String PoPayTerms
        {
            get { return Fields.PoPayTerms[this]; }
            set { Fields.PoPayTerms[this] = value; }
        }

        [DisplayName("Po Ship To"), Column("PO_SHIP_TO"), Size(4)]
        public String PoShipTo
        {
            get { return Fields.PoShipTo[this]; }
            set { Fields.PoShipTo[this] = value; }
        }

        [DisplayName("Po Buyer"), Column("PO_BUYER"), Size(6)]
        public String PoBuyer
        {
            get { return Fields.PoBuyer[this]; }
            set { Fields.PoBuyer[this] = value; }
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

        [DisplayName("Salesman"), Column("SALESMAN"), Size(6), NotNull]
        public String Salesman
        {
            get { return Fields.Salesman[this]; }
            set { Fields.Salesman[this] = value; }
        }

        [DisplayName("Pay Terms"), Column("PAY_TERMS"), Size(6)]
        public String PayTerms
        {
            get { return Fields.PayTerms[this]; }
            set { Fields.PayTerms[this] = value; }
        }

        [DisplayName("Price Code"), Column("PRICE_CODE"), Size(6)]
        public String PriceCode
        {
            get { return Fields.PriceCode[this]; }
            set { Fields.PriceCode[this] = value; }
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

        [DisplayName("Ship From"), Column("SHIP_FROM"), Size(4), NotNull]
        public String ShipFrom
        {
            get { return Fields.ShipFrom[this]; }
            set { Fields.ShipFrom[this] = value; }
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

        [DisplayName("Last Ctn No"), Column("LAST_CTN_NO"), Size(6)]
        public Decimal? LastCtnNo
        {
            get { return Fields.LastCtnNo[this]; }
            set { Fields.LastCtnNo[this] = value; }
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

        [DisplayName("Dps Receipt No"), Column("DPS_RECEIPT_NO"), Size(15)]
        public String DpsReceiptNo
        {
            get { return Fields.DpsReceiptNo[this]; }
            set { Fields.DpsReceiptNo[this] = value; }
        }

        [DisplayName("Dps Fund Code"), Column("DPS_FUND_CODE"), Size(6)]
        public String DpsFundCode
        {
            get { return Fields.DpsFundCode[this]; }
            set { Fields.DpsFundCode[this] = value; }
        }

        [DisplayName("Dps Reference"), Column("DPS_REFERENCE"), Size(12)]
        public String DpsReference
        {
            get { return Fields.DpsReference[this]; }
            set { Fields.DpsReference[this] = value; }
        }

        [DisplayName("Dps Rcpt Date"), Column("DPS_RCPT_DATE")]
        public DateTime? DpsRcptDate
        {
            get { return Fields.DpsRcptDate[this]; }
            set { Fields.DpsRcptDate[this] = value; }
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

        [DisplayName("Prevised Date"), Column("PREVISED_DATE")]
        public DateTime? PrevisedDate
        {
            get { return Fields.PrevisedDate[this]; }
            set { Fields.PrevisedDate[this] = value; }
        }

        [DisplayName("Prevised By"), Column("PREVISED_BY"), Size(10)]
        public String PrevisedBy
        {
            get { return Fields.PrevisedBy[this]; }
            set { Fields.PrevisedBy[this] = value; }
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

        [DisplayName("Vend Tax Code"), Column("VEND_TAX_CODE"), Size(6)]
        public String VendTaxCode
        {
            get { return Fields.VendTaxCode[this]; }
            set { Fields.VendTaxCode[this] = value; }
        }

        [DisplayName("Cust Tax Code"), Column("CUST_TAX_CODE"), Size(6)]
        public String CustTaxCode
        {
            get { return Fields.CustTaxCode[this]; }
            set { Fields.CustTaxCode[this] = value; }
        }

        [DisplayName("Packing Ok"), Column("PACKING_OK"), Size(1)]
        public String PackingOk
        {
            get { return Fields.PackingOk[this]; }
            set { Fields.PackingOk[this] = value; }
        }

        [DisplayName("Weight Uom"), Column("WEIGHT_UOM"), Size(4)]
        public String WeightUom
        {
            get { return Fields.WeightUom[this]; }
            set { Fields.WeightUom[this] = value; }
        }

        [DisplayName("Gr Wt"), Column("GR_WT"), Size(12), Scale(4)]
        public Decimal? GrWt
        {
            get { return Fields.GrWt[this]; }
            set { Fields.GrWt[this] = value; }
        }

        [DisplayName("Nt Wt"), Column("NT_WT"), Size(12), Scale(4)]
        public Decimal? NtWt
        {
            get { return Fields.NtWt[this]; }
            set { Fields.NtWt[this] = value; }
        }

        [DisplayName("Dimension Uom"), Column("DIMENSION_UOM"), Size(4)]
        public String DimensionUom
        {
            get { return Fields.DimensionUom[this]; }
            set { Fields.DimensionUom[this] = value; }
        }

        [DisplayName("Volume"), Column("VOLUME"), Size(14), Scale(6)]
        public Decimal? Volume
        {
            get { return Fields.Volume[this]; }
            set { Fields.Volume[this] = value; }
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

        [DisplayName("Web Published"), Column("WEB_PUBLISHED"), Size(1)]
        public String WebPublished
        {
            get { return Fields.WebPublished[this]; }
            set { Fields.WebPublished[this] = value; }
        }

        [DisplayName("Send Web Msg"), Column("SEND_WEB_MSG"), Size(1)]
        public String SendWebMsg
        {
            get { return Fields.SendWebMsg[this]; }
            set { Fields.SendWebMsg[this] = value; }
        }

        [DisplayName("Web User Name"), Column("WEB_USER_NAME"), Size(10)]
        public String WebUserName
        {
            get { return Fields.WebUserName[this]; }
            set { Fields.WebUserName[this] = value; }
        }

        [DisplayName("Attention"), Column("ATTENTION"), Size(30)]
        public String Attention
        {
            get { return Fields.Attention[this]; }
            set { Fields.Attention[this] = value; }
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

        [DisplayName("Port Loading"), Column("PORT_LOADING"), Size(50)]
        public String PortLoading
        {
            get { return Fields.PortLoading[this]; }
            set { Fields.PortLoading[this] = value; }
        }

        [DisplayName("Port Discharge"), Column("PORT_DISCHARGE"), Size(50)]
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

        [DisplayName("Lc No"), Column("LC_NO"), Size(25)]
        public String LcNo
        {
            get { return Fields.LcNo[this]; }
            set { Fields.LcNo[this] = value; }
        }

        [DisplayName("Origin Country"), Column("ORIGIN_COUNTRY"), Size(25)]
        public String OriginCountry
        {
            get { return Fields.OriginCountry[this]; }
            set { Fields.OriginCountry[this] = value; }
        }

        [DisplayName("Mrp Exclude"), Column("MRP_EXCLUDE"), Size(1)]
        public String MrpExclude
        {
            get { return Fields.MrpExclude[this]; }
            set { Fields.MrpExclude[this] = value; }
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

        [DisplayName("Tot Gsltax Amt"), Column("TOT_GSLTAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotGsltaxAmt
        {
            get { return Fields.TotGsltaxAmt[this]; }
            set { Fields.TotGsltaxAmt[this] = value; }
        }

        [DisplayName("Tot Lsltax Amt"), Column("TOT_LSLTAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotLsltaxAmt
        {
            get { return Fields.TotLsltaxAmt[this]; }
            set { Fields.TotLsltaxAmt[this] = value; }
        }

        [DisplayName("Last Text No1"), Column("LAST_TEXT_NO1"), Size(6)]
        public Decimal? LastTextNo1
        {
            get { return Fields.LastTextNo1[this]; }
            set { Fields.LastTextNo1[this] = value; }
        }

        [DisplayName("Comments5"), Column("COMMENTS5"), Size(1073741823)]
        public String Comments5
        {
            get { return Fields.Comments5[this]; }
            set { Fields.Comments5[this] = value; }
        }

        [DisplayName("Comments6"), Column("COMMENTS6"), Size(1073741823)]
        public String Comments6
        {
            get { return Fields.Comments6[this]; }
            set { Fields.Comments6[this] = value; }
        }

        [DisplayName("Comments7"), Column("COMMENTS7"), Size(1073741823)]
        public String Comments7
        {
            get { return Fields.Comments7[this]; }
            set { Fields.Comments7[this] = value; }
        }

        [DisplayName("Comments8"), Column("COMMENTS8"), Size(1073741823)]
        public String Comments8
        {
            get { return Fields.Comments8[this]; }
            set { Fields.Comments8[this] = value; }
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

        [DisplayName("Quo Ref No"), Column("QUO_REF_NO"), Size(16)]
        public String QuoRefNo
        {
            get { return Fields.QuoRefNo[this]; }
            set { Fields.QuoRefNo[this] = value; }
        }

        [DisplayName("Brand Code"), Column("BRAND_CODE"), Size(20), NotNull]
        public String BrandCode
        {
            get { return Fields.BrandCode[this]; }
            set { Fields.BrandCode[this] = value; }
        }

        [DisplayName("Item Code"), Column("ITEM_CODE"), Size(3)]
        public String ItemCode
        {
            get { return Fields.ItemCode[this]; }
            set { Fields.ItemCode[this] = value; }
        }

        [DisplayName("Pkg Unit"), Column("PKG_UNIT"), Size(8)]
        public String PkgUnit
        {
            get { return Fields.PkgUnit[this]; }
            set { Fields.PkgUnit[this] = value; }
        }

        [DisplayName("Weight Unit"), Column("WEIGHT_UNIT"), Size(8)]
        public String WeightUnit
        {
            get { return Fields.WeightUnit[this]; }
            set { Fields.WeightUnit[this] = value; }
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

        [DisplayName("Order Type"), Column("ORDER_TYPE"), Size(1), NotNull]
        public String OrderType
        {
            get { return Fields.OrderType[this]; }
            set { Fields.OrderType[this] = value; }
        }

        [DisplayName("Ref Company Code"), Column("REF_COMPANY_CODE"), Size(20)]
        public String RefCompanyCode
        {
            get { return Fields.RefCompanyCode[this]; }
            set { Fields.RefCompanyCode[this] = value; }
        }

        [DisplayName("Ref Purchase Order No"), Column("REF_PURCHASE_ORDER_NO"), Size(32)]
        public String RefPurchaseOrderNo
        {
            get { return Fields.RefPurchaseOrderNo[this]; }
            set { Fields.RefPurchaseOrderNo[this] = value; }
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
        [DisplayName("Detail List"), NotMapped]
        public List<SalesOrderDetailRow> DetailList
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public SalesOrderRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField OrderNo;
            public StringField Posted;
            public StringField Closed;
            public StringField CustomerNo;
            public StringField CustomerName;
            public DateTimeField OrderDate;
            public DateTimeField DueDate;
            public DateTimeField SchedDate;
            public StringField CustomerPo;
            public StringField ShipTo;
            public StringField Address;
            public StringField Address2;
            public StringField Address3;
            public StringField Address4;
            public StringField MultiShip;
            public StringField AutoPo;
            public StringField AutoJob;
            public StringField ComputeTax;
            public StringField AutoResv;
            public StringField AutoWait;
            public StringField VendorNo;
            public StringField PoNo;
            public StringField PoPayTerms;
            public StringField PoShipTo;
            public StringField PoBuyer;
            public StringField ShipVia;
            public StringField ShipmentTerms;
            public StringField Salesman;
            public StringField PayTerms;
            public StringField PriceCode;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Ccy;
            public DecimalField ExchRate;
            public StringField ShipFrom;
            public DecimalField LastSchedNo;
            public DecimalField LastLineNo;
            public DecimalField LastTextNo;
            public DecimalField LastCtnNo;
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
            public StringField DpsReceiptNo;
            public StringField DpsFundCode;
            public StringField DpsReference;
            public DateTimeField DpsRcptDate;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField PostedDate;
            public StringField PostedBy;
            public DateTimeField PrevisedDate;
            public StringField PrevisedBy;
            public StringField LockType;
            public StringField LockRefNo;
            public DecimalField LastLogNo;
            public StringField VendTaxCode;
            public StringField CustTaxCode;
            public StringField PackingOk;
            public StringField WeightUom;
            public DecimalField GrWt;
            public DecimalField NtWt;
            public StringField DimensionUom;
            public DecimalField Volume;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Comments1;
            public StringField Comments2;
            public StringField Comments3;
            public StringField Comments4;
            public StringField CheckCrlimit;
            public DecimalField CheckCrbal;
            public StringField WebPublished;
            public StringField SendWebMsg;
            public StringField WebUserName;
            public StringField Attention;
            public StringField TelNo;
            public StringField FaxNo;
            public StringField PortLoading;
            public StringField PortDischarge;
            public StringField VesselName;
            public StringField Forwarder;
            public StringField LcNo;
            public StringField OriginCountry;
            public StringField MrpExclude;
            public StringField SltaxType;
            public DecimalField GsltaxPcent;
            public DecimalField TotGsltaxAmt;
            public DecimalField TotLsltaxAmt;
            public DecimalField LastTextNo1;
            public StringField Comments5;
            public StringField Comments6;
            public StringField Comments7;
            public StringField Comments8;
            public StringField Anlys7;
            public StringField Anlys8;
            public StringField Flag;
            public StringField HoldBy;
            public StringField QuoRefNo;
            public StringField BrandCode;
            public StringField ItemCode;
            public StringField PkgUnit;
            public StringField WeightUnit;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;
            public StringField OrderType;
            public StringField RefCompanyCode;
            public StringField RefPurchaseOrderNo;

            public RowListField<SalesOrderDetailRow> DetailList;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Sales.SalesOrder";
            }
        }
    }
}
