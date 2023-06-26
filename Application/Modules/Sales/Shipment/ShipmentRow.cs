#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ShipmentRow.cs
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

    [ConnectionKey("Sales"), TableName("[dbo].[SLSHPH]")]
    [DisplayName("Shipment"), InstanceName("Shipment"), TwoLevelCached]   
    public sealed class ShipmentRow : Row, IIdRow, INameRow
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

        [DisplayName("Shipment Date"), Column("SHIPMENT_DATE"), NotNull]
        public DateTime? ShipmentDate
        {
            get { return Fields.ShipmentDate[this]; }
            set { Fields.ShipmentDate[this] = value; }
        }

        [DisplayName("Posted"), Column("POSTED"), Size(1), NotNull]
        [BoolStringConverter]
        public bool? Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Returned"), Column("RETURNED"), Size(1)]
        [BoolStringConverter]
        public bool? Returned
        {
            get { return Fields.Returned[this]; }
            set { Fields.Returned[this] = value; }
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

        [DisplayName("Cutoff Date"), Column("CUTOFF_DATE")]
        public DateTime? CutoffDate
        {
            get { return Fields.CutoffDate[this]; }
            set { Fields.CutoffDate[this] = value; }
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

        [DisplayName("Vessel Name"), Column("VESSEL_NAME"), Size(35)]
        public String VesselName
        {
            get { return Fields.VesselName[this]; }
            set { Fields.VesselName[this] = value; }
        }

        [DisplayName("ETD"), Column("ETD")]
        public DateTime? Etd
        {
            get { return Fields.Etd[this]; }
            set { Fields.Etd[this] = value; }
        }

        [DisplayName("ETA"), Column("ETA")]
        public DateTime? Eta
        {
            get { return Fields.Eta[this]; }
            set { Fields.Eta[this] = value; }
        }

        [DisplayName("Pay Terms"), Column("PAY_TERMS"), Size(6)]
        public String PayTerms
        {
            get { return Fields.PayTerms[this]; }
            set { Fields.PayTerms[this] = value; }
        }

        [DisplayName("Disc Days"), Column("DISC_DAYS"), Size(4)]
        public Decimal? DiscDays
        {
            get { return Fields.DiscDays[this]; }
            set { Fields.DiscDays[this] = value; }
        }

        [DisplayName("Discount %"), Column("DISC_PERCENT"), Size(6), Scale(2)]
        public Decimal? DiscPercent
        {
            get { return Fields.DiscPercent[this]; }
            set { Fields.DiscPercent[this] = value; }
        }

        [DisplayName("Net Days"), Column("NET_DAYS"), Size(4)]
        public Decimal? NetDays
        {
            get { return Fields.NetDays[this]; }
            set { Fields.NetDays[this] = value; }
        }

        [DisplayName("Discount Date"), Column("DISCOUNT_DATE")]
        public DateTime? DiscountDate
        {
            get { return Fields.DiscountDate[this]; }
            set { Fields.DiscountDate[this] = value; }
        }

        [DisplayName("Due Date"), Column("DUE_DATE")]
        public DateTime? DueDate
        {
            get { return Fields.DueDate[this]; }
            set { Fields.DueDate[this] = value; }
        }

        [DisplayName("Expected Date"), Column("EXPECTED_DATE")]
        public DateTime? ExpectedDate
        {
            get { return Fields.ExpectedDate[this]; }
            set { Fields.ExpectedDate[this] = value; }
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

        [DisplayName("Compute Tax"), Column("COMPUTE_TAX"), Size(1)]
        public String ComputeTax
        {
            get { return Fields.ComputeTax[this]; }
            set { Fields.ComputeTax[this] = value; }
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

        [DisplayName("Dps Cover"), Column("DPS_COVER"), Size(12), Scale(2)]
        public Decimal? DpsCover
        {
            get { return Fields.DpsCover[this]; }
            set { Fields.DpsCover[this] = value; }
        }

        [DisplayName("Dps Applied"), Column("DPS_APPLIED"), Size(12), Scale(2)]
        public Decimal? DpsApplied
        {
            get { return Fields.DpsApplied[this]; }
            set { Fields.DpsApplied[this] = value; }
        }

        [DisplayName("Net Bal Amt"), Column("NET_BAL_AMT"), Size(16), Scale(2)]
        public Decimal? NetBalAmt
        {
            get { return Fields.NetBalAmt[this]; }
            set { Fields.NetBalAmt[this] = value; }
        }

        [DisplayName("Cpd Tdisc Amt"), Column("CPD_TDISC_AMT"), Size(16), Scale(2)]
        public Decimal? CpdTdiscAmt
        {
            get { return Fields.CpdTdiscAmt[this]; }
            set { Fields.CpdTdiscAmt[this] = value; }
        }

        [DisplayName("Cpd Gtax Amt"), Column("CPD_GTAX_AMT"), Size(16), Scale(2)]
        public Decimal? CpdGtaxAmt
        {
            get { return Fields.CpdGtaxAmt[this]; }
            set { Fields.CpdGtaxAmt[this] = value; }
        }

        [DisplayName("Cpd Dps Amt"), Column("CPD_DPS_AMT"), Size(16), Scale(2)]
        public Decimal? CpdDpsAmt
        {
            get { return Fields.CpdDpsAmt[this]; }
            set { Fields.CpdDpsAmt[this] = value; }
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

        [DisplayName("Loc Dps Applied"), Column("LOC_DPS_APPLIED"), Size(12), Scale(2)]
        public Decimal? LocDpsApplied
        {
            get { return Fields.LocDpsApplied[this]; }
            set { Fields.LocDpsApplied[this] = value; }
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

        [DisplayName("Last Entry No"), Column("LAST_ENTRY_NO"), Size(8)]
        public Decimal? LastEntryNo
        {
            get { return Fields.LastEntryNo[this]; }
            set { Fields.LastEntryNo[this] = value; }
        }

        [DisplayName("Last Chgs No"), Column("LAST_CHGS_NO"), Size(6)]
        public Decimal? LastChgsNo
        {
            get { return Fields.LastChgsNo[this]; }
            set { Fields.LastChgsNo[this] = value; }
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

        [DisplayName("New Item Count"), Column("NEW_ITEM_COUNT"), Size(4)]
        public Decimal? NewItemCount
        {
            get { return Fields.NewItemCount[this]; }
            set { Fields.NewItemCount[this] = value; }
        }

        [DisplayName("New Chgs Count"), Column("NEW_CHGS_COUNT"), Size(4)]
        public Decimal? NewChgsCount
        {
            get { return Fields.NewChgsCount[this]; }
            set { Fields.NewChgsCount[this] = value; }
        }

        [DisplayName("Acct Customer"), Column("ACCT_CUSTOMER"), Size(30)]
        public String AcctCustomer
        {
            get { return Fields.AcctCustomer[this]; }
            set { Fields.AcctCustomer[this] = value; }
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

        [DisplayName("Dps Apply Ref"), Column("DPS_APPLY_REF"), Size(16)]
        public String DpsApplyRef
        {
            get { return Fields.DpsApplyRef[this]; }
            set { Fields.DpsApplyRef[this] = value; }
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

        [DisplayName("Ret Price Amt"), Column("RET_PRICE_AMT"), Size(16), Scale(2)]
        public Decimal? RetPriceAmt
        {
            get { return Fields.RetPriceAmt[this]; }
            set { Fields.RetPriceAmt[this] = value; }
        }

        [DisplayName("Ret Ptax Amt"), Column("RET_PTAX_AMT"), Size(16), Scale(2)]
        public Decimal? RetPtaxAmt
        {
            get { return Fields.RetPtaxAmt[this]; }
            set { Fields.RetPtaxAmt[this] = value; }
        }

        [DisplayName("Ret Ext Price"), Column("RET_EXT_PRICE"), Size(16), Scale(2)]
        public Decimal? RetExtPrice
        {
            get { return Fields.RetExtPrice[this]; }
            set { Fields.RetExtPrice[this] = value; }
        }

        [DisplayName("Ret Ldisc Amt"), Column("RET_LDISC_AMT"), Size(16), Scale(2)]
        public Decimal? RetLdiscAmt
        {
            get { return Fields.RetLdiscAmt[this]; }
            set { Fields.RetLdiscAmt[this] = value; }
        }

        [DisplayName("Ret Atax Amt"), Column("RET_ATAX_AMT"), Size(16), Scale(2)]
        public Decimal? RetAtaxAmt
        {
            get { return Fields.RetAtaxAmt[this]; }
            set { Fields.RetAtaxAmt[this] = value; }
        }

        [DisplayName("Ret Item Amt"), Column("RET_ITEM_AMT"), Size(16), Scale(2)]
        public Decimal? RetItemAmt
        {
            get { return Fields.RetItemAmt[this]; }
            set { Fields.RetItemAmt[this] = value; }
        }

        [DisplayName("Ret Tdisc Amt"), Column("RET_TDISC_AMT"), Size(16), Scale(2)]
        public Decimal? RetTdiscAmt
        {
            get { return Fields.RetTdiscAmt[this]; }
            set { Fields.RetTdiscAmt[this] = value; }
        }

        [DisplayName("Ret Gtax Amt"), Column("RET_GTAX_AMT"), Size(16), Scale(2)]
        public Decimal? RetGtaxAmt
        {
            get { return Fields.RetGtaxAmt[this]; }
            set { Fields.RetGtaxAmt[this] = value; }
        }

        [DisplayName("Ret Chgs Amt"), Column("RET_CHGS_AMT"), Size(16), Scale(2)]
        public Decimal? RetChgsAmt
        {
            get { return Fields.RetChgsAmt[this]; }
            set { Fields.RetChgsAmt[this] = value; }
        }

        [DisplayName("Ret Pay Amt"), Column("RET_PAY_AMT"), Size(16), Scale(2)]
        public Decimal? RetPayAmt
        {
            get { return Fields.RetPayAmt[this]; }
            set { Fields.RetPayAmt[this] = value; }
        }

        [DisplayName("Lret Price Amt"), Column("LRET_PRICE_AMT"), Size(16), Scale(2)]
        public Decimal? LretPriceAmt
        {
            get { return Fields.LretPriceAmt[this]; }
            set { Fields.LretPriceAmt[this] = value; }
        }

        [DisplayName("Lret Ptax Amt"), Column("LRET_PTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LretPtaxAmt
        {
            get { return Fields.LretPtaxAmt[this]; }
            set { Fields.LretPtaxAmt[this] = value; }
        }

        [DisplayName("Lret Ext Price"), Column("LRET_EXT_PRICE"), Size(16), Scale(2)]
        public Decimal? LretExtPrice
        {
            get { return Fields.LretExtPrice[this]; }
            set { Fields.LretExtPrice[this] = value; }
        }

        [DisplayName("Lret Ldisc Amt"), Column("LRET_LDISC_AMT"), Size(16), Scale(2)]
        public Decimal? LretLdiscAmt
        {
            get { return Fields.LretLdiscAmt[this]; }
            set { Fields.LretLdiscAmt[this] = value; }
        }

        [DisplayName("Lret Atax Amt"), Column("LRET_ATAX_AMT"), Size(16), Scale(2)]
        public Decimal? LretAtaxAmt
        {
            get { return Fields.LretAtaxAmt[this]; }
            set { Fields.LretAtaxAmt[this] = value; }
        }

        [DisplayName("Lret Item Amt"), Column("LRET_ITEM_AMT"), Size(16), Scale(2)]
        public Decimal? LretItemAmt
        {
            get { return Fields.LretItemAmt[this]; }
            set { Fields.LretItemAmt[this] = value; }
        }

        [DisplayName("Lret Tdisc Amt"), Column("LRET_TDISC_AMT"), Size(16), Scale(2)]
        public Decimal? LretTdiscAmt
        {
            get { return Fields.LretTdiscAmt[this]; }
            set { Fields.LretTdiscAmt[this] = value; }
        }

        [DisplayName("Lret Gtax Amt"), Column("LRET_GTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LretGtaxAmt
        {
            get { return Fields.LretGtaxAmt[this]; }
            set { Fields.LretGtaxAmt[this] = value; }
        }

        [DisplayName("Lret Chgs Amt"), Column("LRET_CHGS_AMT"), Size(16), Scale(2)]
        public Decimal? LretChgsAmt
        {
            get { return Fields.LretChgsAmt[this]; }
            set { Fields.LretChgsAmt[this] = value; }
        }

        [DisplayName("Lret Pay Amt"), Column("LRET_PAY_AMT"), Size(16), Scale(2)]
        public Decimal? LretPayAmt
        {
            get { return Fields.LretPayAmt[this]; }
            set { Fields.LretPayAmt[this] = value; }
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

        [DisplayName("Packing Ok"), Column("PACKING_OK"), Size(1)]
        public String PackingOk
        {
            get { return Fields.PackingOk[this]; }
            set { Fields.PackingOk[this] = value; }
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

        [DisplayName("Settle At"), Column("SETTLE_AT"), Size(4)]
        public String SettleAt
        {
            get { return Fields.SettleAt[this]; }
            set { Fields.SettleAt[this] = value; }
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

        [DisplayName("Issue Bank"), Column("ISSUE_BANK"), Size(30)]
        public String IssueBank
        {
            get { return Fields.IssueBank[this]; }
            set { Fields.IssueBank[this] = value; }
        }

        [DisplayName("Issue Date"), Column("ISSUE_DATE")]
        public DateTime? IssueDate
        {
            get { return Fields.IssueDate[this]; }
            set { Fields.IssueDate[this] = value; }
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

        [DisplayName("Loc Gsltax Amt"), Column("LOC_GSLTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocGsltaxAmt
        {
            get { return Fields.LocGsltaxAmt[this]; }
            set { Fields.LocGsltaxAmt[this] = value; }
        }

        [DisplayName("Loc Lsltax Amt"), Column("LOC_LSLTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocLsltaxAmt
        {
            get { return Fields.LocLsltaxAmt[this]; }
            set { Fields.LocLsltaxAmt[this] = value; }
        }

        [DisplayName("So Sltax Type"), Column("SO_SLTAX_TYPE"), Size(1)]
        public String SoSltaxType
        {
            get { return Fields.SoSltaxType[this]; }
            set { Fields.SoSltaxType[this] = value; }
        }

        [DisplayName("So Gsltax Pcent"), Column("SO_GSLTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? SoGsltaxPcent
        {
            get { return Fields.SoGsltaxPcent[this]; }
            set { Fields.SoGsltaxPcent[this] = value; }
        }

        [DisplayName("Order Count"), Column("ORDER_COUNT"), Size(4)]
        public Decimal? OrderCount
        {
            get { return Fields.OrderCount[this]; }
            set { Fields.OrderCount[this] = value; }
        }

        [DisplayName("Acct Sltax"), Column("ACCT_SLTAX"), Size(30)]
        public String AcctSltax
        {
            get { return Fields.AcctSltax[this]; }
            set { Fields.AcctSltax[this] = value; }
        }

        [DisplayName("Last Text No1"), Column("LAST_TEXT_NO1"), Size(6)]
        public Decimal? LastTextNo1
        {
            get { return Fields.LastTextNo1[this]; }
            set { Fields.LastTextNo1[this] = value; }
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

        [DisplayName("Dn Only"), Column("DN_ONLY"), Size(1), NotNull]
        public String DnOnly
        {
            get { return Fields.DnOnly[this]; }
            set { Fields.DnOnly[this] = value; }
        }

        [DisplayName("Invoiced"), Column("INVOICED"), Size(1), NotNull]
        [BoolStringConverter]
        public bool? Invoiced
        {
            get { return Fields.Invoiced[this]; }
            set { Fields.Invoiced[this] = value; }
        }

        [DisplayName("Invoice No"), Column("INVOICE_NO"), Size(16)]
        public String InvoiceNo
        {
            get { return Fields.InvoiceNo[this]; }
            set { Fields.InvoiceNo[this] = value; }
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

        [DisplayName("Manual Shipment Detail"), Column("MANUAL_SHIPMENT_DETAIL")]
        public Boolean? ManualShipmentDetail
        {
            get { return Fields.ManualShipmentDetail[this]; }
            set { Fields.ManualShipmentDetail[this] = value; }
        }

        [DisplayName("Ref Company Code"), Column("REF_COMPANY_CODE"), Size(20)]
        public String RefCompanyCode
        {
            get { return Fields.RefCompanyCode[this]; }
            set { Fields.RefCompanyCode[this] = value; }
        }

        [DisplayName("Ref Grn No"), Column("REF_GRN_NO"), Size(32)]
        public String RefGrnNo
        {
            get { return Fields.RefGrnNo[this]; }
            set { Fields.RefGrnNo[this] = value; }
        }

        [DisplayName("Lc Name"), Column("LC_NAME"), Size(60)]
        public String LcName
        {
            get { return Fields.LcName[this]; }
            set { Fields.LcName[this] = value; }
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
        public List<ShipmentDetailRow> DetailList
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ShipmentRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField RefNo;
            public DateTimeField ShipmentDate;
            public BooleanField Posted;
            public BooleanField Returned;
            public StringField CustomerNo;
            public StringField CustomerName;
            public StringField ShipTo;
            public StringField Address;
            public StringField Address2;
            public StringField Address3;
            public StringField Address4;
            public DateTimeField CutoffDate;
            public StringField ShipVia;
            public StringField ShipmentTerms;
            public StringField VesselName;
            public DateTimeField Etd;
            public DateTimeField Eta;
            public StringField PayTerms;
            public DecimalField DiscDays;
            public DecimalField DiscPercent;
            public DecimalField NetDays;
            public DateTimeField DiscountDate;
            public DateTimeField DueDate;
            public DateTimeField ExpectedDate;
            public StringField Ccy;
            public DecimalField ExchRate;
            public StringField ShipFrom;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField ComputeTax;
            public DecimalField TotPriceAmt;
            public DecimalField TotPtaxAmt;
            public DecimalField TotExtPrice;
            public DecimalField TotLdiscAmt;
            public DecimalField TotAtaxAmt;
            public DecimalField TotItemAmt;
            public DecimalField TotTdiscAmt;
            public DecimalField NetTradeAmt;
            public DecimalField TotChgsAmt;
            public DecimalField NetOrdrAmt;
            public DecimalField TotGtaxAmt;
            public DecimalField NetPayAmt;
            public DecimalField DpsCover;
            public DecimalField DpsApplied;
            public DecimalField NetBalAmt;
            public DecimalField CpdTdiscAmt;
            public DecimalField CpdGtaxAmt;
            public DecimalField CpdDpsAmt;
            public DecimalField LocPriceAmt;
            public DecimalField LocPtaxAmt;
            public DecimalField LocExtPrice;
            public DecimalField LocLdiscAmt;
            public DecimalField LocAtaxAmt;
            public DecimalField LocItemAmt;
            public DecimalField LocTdiscAmt;
            public DecimalField LocChgsAmt;
            public DecimalField LocGtaxAmt;
            public DecimalField LocPayAmt;
            public DecimalField LocDpsApplied;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField PostedDate;
            public StringField PostedBy;
            public DateTimeField PrevisedDate;
            public StringField PrevisedBy;
            public DecimalField LastEntryNo;
            public DecimalField LastChgsNo;
            public DecimalField LastTextNo;
            public DecimalField LastCtnNo;
            public StringField LockType;
            public StringField LockRefNo;
            public DecimalField LastLogNo;
            public DecimalField NewItemCount;
            public DecimalField NewChgsCount;
            public StringField AcctCustomer;
            public StringField AcctTdisc;
            public StringField AcctGtax;
            public StringField DpsApplyRef;
            public StringField VendTaxCode;
            public StringField CustTaxCode;
            public DecimalField RetPriceAmt;
            public DecimalField RetPtaxAmt;
            public DecimalField RetExtPrice;
            public DecimalField RetLdiscAmt;
            public DecimalField RetAtaxAmt;
            public DecimalField RetItemAmt;
            public DecimalField RetTdiscAmt;
            public DecimalField RetGtaxAmt;
            public DecimalField RetChgsAmt;
            public DecimalField RetPayAmt;
            public DecimalField LretPriceAmt;
            public DecimalField LretPtaxAmt;
            public DecimalField LretExtPrice;
            public DecimalField LretLdiscAmt;
            public DecimalField LretAtaxAmt;
            public DecimalField LretItemAmt;
            public DecimalField LretTdiscAmt;
            public DecimalField LretGtaxAmt;
            public DecimalField LretChgsAmt;
            public DecimalField LretPayAmt;
            public StringField WeightUom;
            public DecimalField GrWt;
            public DecimalField NtWt;
            public StringField DimensionUom;
            public DecimalField Volume;
            public StringField GlLink;
            public StringField GlLinkType;
            public StringField GlLinkNo;
            public StringField PackingOk;
            public StringField Comments1;
            public StringField Comments2;
            public StringField Comments3;
            public StringField Comments4;
            public StringField SettleAt;
            public StringField CheckCrlimit;
            public DecimalField CheckCrbal;
            public StringField Attention;
            public StringField TelNo;
            public StringField FaxNo;
            public StringField PortLoading;
            public StringField PortDischarge;
            public StringField Forwarder;
            public StringField LcNo;
            public StringField OriginCountry;
            public StringField Comments5;
            public StringField Comments6;
            public StringField Comments7;
            public StringField Comments8;
            public StringField IssueBank;
            public DateTimeField IssueDate;
            public StringField SltaxType;
            public DecimalField GsltaxPcent;
            public DecimalField TotGsltaxAmt;
            public DecimalField TotLsltaxAmt;
            public DecimalField LocGsltaxAmt;
            public DecimalField LocLsltaxAmt;
            public StringField SoSltaxType;
            public DecimalField SoGsltaxPcent;
            public DecimalField OrderCount;
            public StringField AcctSltax;
            public DecimalField LastTextNo1;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys7;
            public StringField Anlys8;
            public StringField DnOnly;
            public BooleanField Invoiced;
            public StringField InvoiceNo;
            public StringField Flag;
            public StringField HoldBy;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;
            public BooleanField ManualShipmentDetail;
            public StringField RefCompanyCode;
            public StringField RefGrnNo;
            public StringField LcName;

            public RowListField<ShipmentDetailRow> DetailList;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Sales.Shipment";
            }
        }
    }
}
