#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ShipmentDetailRow.cs
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

    [ConnectionKey("Sales"), TableName("[dbo].[SLSHPD]")]
    [DisplayName("Shipment Detail"), InstanceName("Shipment Detail"), TwoLevelCached]   
    public sealed class ShipmentDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Ref No"), Column("REF_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[SLSHPH]", "REF_NO"), LeftJoin("jRefNo"), QuickSearch, TextualField("RefNoPosted")]
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

        [DisplayName("Selected"), Column("SELECTED"), Size(1), NotNull]
        public String Selected
        {
            get { return Fields.Selected[this]; }
            set { Fields.Selected[this] = value; }
        }

        [DisplayName("Order No"), Column("ORDER_NO"), Size(16), NotNull]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), Size(6), NotNull]
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

        [DisplayName("Configurable"), Column("CONFIGURABLE"), Size(1)]
        public String Configurable
        {
            get { return Fields.Configurable[this]; }
            set { Fields.Configurable[this] = value; }
        }

        [DisplayName("Qty Balance"), Column("QTY_BALANCE"), Size(14), Scale(4)]
        public Decimal? QtyBalance
        {
            get { return Fields.QtyBalance[this]; }
            set { Fields.QtyBalance[this] = value; }
        }

        [DisplayName("Qty Due"), Column("QTY_DUE"), Size(14), Scale(4)]
        public Decimal? QtyDue
        {
            get { return Fields.QtyDue[this]; }
            set { Fields.QtyDue[this] = value; }
        }

        [DisplayName("Qty Shipped"), Column("QTY_SHIPPED"), Size(14), Scale(4)]
        public Decimal? QtyShipped
        {
            get { return Fields.QtyShipped[this]; }
            set { Fields.QtyShipped[this] = value; }
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

        [DisplayName("Ldisc Pcent"), Column("LDISC_PCENT"), Size(10), Scale(2)]
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

        [DisplayName("Ptax Amt"), Column("PTAX_AMT"), Size(14), Scale(2)]
        public Decimal? PtaxAmt
        {
            get { return Fields.PtaxAmt[this]; }
            set { Fields.PtaxAmt[this] = value; }
        }

        [DisplayName("Ldisc Rate"), Column("LDISC_RATE"), Size(10), Scale(4)]
        public Decimal? LdiscRate
        {
            get { return Fields.LdiscRate[this]; }
            set { Fields.LdiscRate[this] = value; }
        }

        [DisplayName("Atax Rate"), Column("ATAX_RATE"), Size(10), Scale(4)]
        public Decimal? AtaxRate
        {
            get { return Fields.AtaxRate[this]; }
            set { Fields.AtaxRate[this] = value; }
        }

        [DisplayName("Ldisc Amt Cpd"), Column("LDISC_AMT_CPD"), Size(14), Scale(2)]
        public Decimal? LdiscAmtCpd
        {
            get { return Fields.LdiscAmtCpd[this]; }
            set { Fields.LdiscAmtCpd[this] = value; }
        }

        [DisplayName("Atax Amt Cpd"), Column("ATAX_AMT_CPD"), Size(14), Scale(2)]
        public Decimal? AtaxAmtCpd
        {
            get { return Fields.AtaxAmtCpd[this]; }
            set { Fields.AtaxAmtCpd[this] = value; }
        }

        [DisplayName("Loc Price Amt"), Column("LOC_PRICE_AMT"), Size(14), Scale(2)]
        public Decimal? LocPriceAmt
        {
            get { return Fields.LocPriceAmt[this]; }
            set { Fields.LocPriceAmt[this] = value; }
        }

        [DisplayName("Loc Ptax Amt"), Column("LOC_PTAX_AMT"), Size(14), Scale(2)]
        public Decimal? LocPtaxAmt
        {
            get { return Fields.LocPtaxAmt[this]; }
            set { Fields.LocPtaxAmt[this] = value; }
        }

        [DisplayName("Loc Ext Price"), Column("LOC_EXT_PRICE"), Size(14), Scale(2)]
        public Decimal? LocExtPrice
        {
            get { return Fields.LocExtPrice[this]; }
            set { Fields.LocExtPrice[this] = value; }
        }

        [DisplayName("Loc Ldisc Amt"), Column("LOC_LDISC_AMT"), Size(14), Scale(2)]
        public Decimal? LocLdiscAmt
        {
            get { return Fields.LocLdiscAmt[this]; }
            set { Fields.LocLdiscAmt[this] = value; }
        }

        [DisplayName("Loc Atax Amt"), Column("LOC_ATAX_AMT"), Size(14), Scale(2)]
        public Decimal? LocAtaxAmt
        {
            get { return Fields.LocAtaxAmt[this]; }
            set { Fields.LocAtaxAmt[this] = value; }
        }

        [DisplayName("Loc Item Amt"), Column("LOC_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? LocItemAmt
        {
            get { return Fields.LocItemAmt[this]; }
            set { Fields.LocItemAmt[this] = value; }
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

        [DisplayName("Posted"), Column("POSTED"), Size(1), NotNull]
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Log No"), Column("LOG_NO"), Size(8), NotNull]
        public Decimal? LogNo
        {
            get { return Fields.LogNo[this]; }
            set { Fields.LogNo[this] = value; }
        }

        [DisplayName("Returned"), Column("RETURNED"), Size(1)]
        public String Returned
        {
            get { return Fields.Returned[this]; }
            set { Fields.Returned[this] = value; }
        }

        [DisplayName("Shipment Date"), Column("SHIPMENT_DATE"), NotNull]
        public DateTime? ShipmentDate
        {
            get { return Fields.ShipmentDate[this]; }
            set { Fields.ShipmentDate[this] = value; }
        }

        [DisplayName("Customer No"), Column("CUSTOMER_NO"), Size(8), NotNull]
        public String CustomerNo
        {
            get { return Fields.CustomerNo[this]; }
            set { Fields.CustomerNo[this] = value; }
        }

        [DisplayName("Ship From"), Column("SHIP_FROM"), Size(4), NotNull]
        public String ShipFrom
        {
            get { return Fields.ShipFrom[this]; }
            set { Fields.ShipFrom[this] = value; }
        }

        [DisplayName("Commis Type"), Column("COMMIS_TYPE"), Size(6)]
        public String CommisType
        {
            get { return Fields.CommisType[this]; }
            set { Fields.CommisType[this] = value; }
        }

        [DisplayName("Commis Ref No"), Column("COMMIS_REF_NO"), Size(16)]
        public String CommisRefNo
        {
            get { return Fields.CommisRefNo[this]; }
            set { Fields.CommisRefNo[this] = value; }
        }

        [DisplayName("Cust Item No"), Column("CUST_ITEM_NO"), Size(30)]
        public String CustItemNo
        {
            get { return Fields.CustItemNo[this]; }
            set { Fields.CustItemNo[this] = value; }
        }

        [DisplayName("Acct Sales"), Column("ACCT_SALES"), Size(30)]
        public String AcctSales
        {
            get { return Fields.AcctSales[this]; }
            set { Fields.AcctSales[this] = value; }
        }

        [DisplayName("Acct Ldisc"), Column("ACCT_LDISC"), Size(30)]
        public String AcctLdisc
        {
            get { return Fields.AcctLdisc[this]; }
            set { Fields.AcctLdisc[this] = value; }
        }

        [DisplayName("Acct Ptax"), Column("ACCT_PTAX"), Size(30)]
        public String AcctPtax
        {
            get { return Fields.AcctPtax[this]; }
            set { Fields.AcctPtax[this] = value; }
        }

        [DisplayName("Acct Atax"), Column("ACCT_ATAX"), Size(30)]
        public String AcctAtax
        {
            get { return Fields.AcctAtax[this]; }
            set { Fields.AcctAtax[this] = value; }
        }

        [DisplayName("Item Tax Code"), Column("ITEM_TAX_CODE"), Size(6)]
        public String ItemTaxCode
        {
            get { return Fields.ItemTaxCode[this]; }
            set { Fields.ItemTaxCode[this] = value; }
        }

        [DisplayName("Qty Returned"), Column("QTY_RETURNED"), Size(14), Scale(4)]
        public Decimal? QtyReturned
        {
            get { return Fields.QtyReturned[this]; }
            set { Fields.QtyReturned[this] = value; }
        }

        [DisplayName("Ret Price Amt"), Column("RET_PRICE_AMT"), Size(14), Scale(2)]
        public Decimal? RetPriceAmt
        {
            get { return Fields.RetPriceAmt[this]; }
            set { Fields.RetPriceAmt[this] = value; }
        }

        [DisplayName("Ret Ptax Amt"), Column("RET_PTAX_AMT"), Size(14), Scale(2)]
        public Decimal? RetPtaxAmt
        {
            get { return Fields.RetPtaxAmt[this]; }
            set { Fields.RetPtaxAmt[this] = value; }
        }

        [DisplayName("Ret Ext Price"), Column("RET_EXT_PRICE"), Size(14), Scale(2)]
        public Decimal? RetExtPrice
        {
            get { return Fields.RetExtPrice[this]; }
            set { Fields.RetExtPrice[this] = value; }
        }

        [DisplayName("Ret Ldisc Amt"), Column("RET_LDISC_AMT"), Size(14), Scale(2)]
        public Decimal? RetLdiscAmt
        {
            get { return Fields.RetLdiscAmt[this]; }
            set { Fields.RetLdiscAmt[this] = value; }
        }

        [DisplayName("Ret Atax Amt"), Column("RET_ATAX_AMT"), Size(14), Scale(2)]
        public Decimal? RetAtaxAmt
        {
            get { return Fields.RetAtaxAmt[this]; }
            set { Fields.RetAtaxAmt[this] = value; }
        }

        [DisplayName("Ret Item Amt"), Column("RET_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? RetItemAmt
        {
            get { return Fields.RetItemAmt[this]; }
            set { Fields.RetItemAmt[this] = value; }
        }

        [DisplayName("Lret Price Amt"), Column("LRET_PRICE_AMT"), Size(14), Scale(2)]
        public Decimal? LretPriceAmt
        {
            get { return Fields.LretPriceAmt[this]; }
            set { Fields.LretPriceAmt[this] = value; }
        }

        [DisplayName("Lret Ptax Amt"), Column("LRET_PTAX_AMT"), Size(14), Scale(2)]
        public Decimal? LretPtaxAmt
        {
            get { return Fields.LretPtaxAmt[this]; }
            set { Fields.LretPtaxAmt[this] = value; }
        }

        [DisplayName("Lret Ext Price"), Column("LRET_EXT_PRICE"), Size(14), Scale(2)]
        public Decimal? LretExtPrice
        {
            get { return Fields.LretExtPrice[this]; }
            set { Fields.LretExtPrice[this] = value; }
        }

        [DisplayName("Lret Ldisc Amt"), Column("LRET_LDISC_AMT"), Size(14), Scale(2)]
        public Decimal? LretLdiscAmt
        {
            get { return Fields.LretLdiscAmt[this]; }
            set { Fields.LretLdiscAmt[this] = value; }
        }

        [DisplayName("Lret Atax Amt"), Column("LRET_ATAX_AMT"), Size(14), Scale(2)]
        public Decimal? LretAtaxAmt
        {
            get { return Fields.LretAtaxAmt[this]; }
            set { Fields.LretAtaxAmt[this] = value; }
        }

        [DisplayName("Lret Item Amt"), Column("LRET_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? LretItemAmt
        {
            get { return Fields.LretItemAmt[this]; }
            set { Fields.LretItemAmt[this] = value; }
        }

        [DisplayName("Qty Packed"), Column("QTY_PACKED"), Size(14), Scale(4)]
        public Decimal? QtyPacked
        {
            get { return Fields.QtyPacked[this]; }
            set { Fields.QtyPacked[this] = value; }
        }

        [DisplayName("Cost Returned"), Column("COST_RETURNED"), Size(12), Scale(2)]
        public Decimal? CostReturned
        {
            get { return Fields.CostReturned[this]; }
            set { Fields.CostReturned[this] = value; }
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

        [DisplayName("Vendor Pack"), Column("VENDOR_PACK"), Size(15)]
        public String VendorPack
        {
            get { return Fields.VendorPack[this]; }
            set { Fields.VendorPack[this] = value; }
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

        [DisplayName("Lot Size Cost"), Column("LOT_SIZE_COST"), Size(18), Scale(6)]
        public Decimal? LotSizeCost
        {
            get { return Fields.LotSizeCost[this]; }
            set { Fields.LotSizeCost[this] = value; }
        }

        [DisplayName("Ref No Recnum"), Expression("jRefNo.[RECNUM]")]
        public Decimal? RefNoRecnum
        {
            get { return Fields.RefNoRecnum[this]; }
            set { Fields.RefNoRecnum[this] = value; }
        }

        [DisplayName("Ref No Shipment Date"), Expression("jRefNo.[SHIPMENT_DATE]")]
        public DateTime? RefNoShipmentDate
        {
            get { return Fields.RefNoShipmentDate[this]; }
            set { Fields.RefNoShipmentDate[this] = value; }
        }

        [DisplayName("Ref No Posted"), Expression("jRefNo.[POSTED]")]
        public String RefNoPosted
        {
            get { return Fields.RefNoPosted[this]; }
            set { Fields.RefNoPosted[this] = value; }
        }

        [DisplayName("Ref No Returned"), Expression("jRefNo.[RETURNED]")]
        public String RefNoReturned
        {
            get { return Fields.RefNoReturned[this]; }
            set { Fields.RefNoReturned[this] = value; }
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

        [DisplayName("Ref No Ship To"), Expression("jRefNo.[SHIP_TO]")]
        public String RefNoShipTo
        {
            get { return Fields.RefNoShipTo[this]; }
            set { Fields.RefNoShipTo[this] = value; }
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

        [DisplayName("Ref No Cutoff Date"), Expression("jRefNo.[CUTOFF_DATE]")]
        public DateTime? RefNoCutoffDate
        {
            get { return Fields.RefNoCutoffDate[this]; }
            set { Fields.RefNoCutoffDate[this] = value; }
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

        [DisplayName("Ref No Vessel Name"), Expression("jRefNo.[VESSEL_NAME]")]
        public String RefNoVesselName
        {
            get { return Fields.RefNoVesselName[this]; }
            set { Fields.RefNoVesselName[this] = value; }
        }

        [DisplayName("Ref No Etd"), Expression("jRefNo.[ETD]")]
        public DateTime? RefNoEtd
        {
            get { return Fields.RefNoEtd[this]; }
            set { Fields.RefNoEtd[this] = value; }
        }

        [DisplayName("Ref No Eta"), Expression("jRefNo.[ETA]")]
        public DateTime? RefNoEta
        {
            get { return Fields.RefNoEta[this]; }
            set { Fields.RefNoEta[this] = value; }
        }

        [DisplayName("Ref No Pay Terms"), Expression("jRefNo.[PAY_TERMS]")]
        public String RefNoPayTerms
        {
            get { return Fields.RefNoPayTerms[this]; }
            set { Fields.RefNoPayTerms[this] = value; }
        }

        [DisplayName("Ref No Disc Days"), Expression("jRefNo.[DISC_DAYS]")]
        public Decimal? RefNoDiscDays
        {
            get { return Fields.RefNoDiscDays[this]; }
            set { Fields.RefNoDiscDays[this] = value; }
        }

        [DisplayName("Ref No Disc Percent"), Expression("jRefNo.[DISC_PERCENT]")]
        public Decimal? RefNoDiscPercent
        {
            get { return Fields.RefNoDiscPercent[this]; }
            set { Fields.RefNoDiscPercent[this] = value; }
        }

        [DisplayName("Ref No Net Days"), Expression("jRefNo.[NET_DAYS]")]
        public Decimal? RefNoNetDays
        {
            get { return Fields.RefNoNetDays[this]; }
            set { Fields.RefNoNetDays[this] = value; }
        }

        [DisplayName("Ref No Discount Date"), Expression("jRefNo.[DISCOUNT_DATE]")]
        public DateTime? RefNoDiscountDate
        {
            get { return Fields.RefNoDiscountDate[this]; }
            set { Fields.RefNoDiscountDate[this] = value; }
        }

        [DisplayName("Ref No Due Date"), Expression("jRefNo.[DUE_DATE]")]
        public DateTime? RefNoDueDate
        {
            get { return Fields.RefNoDueDate[this]; }
            set { Fields.RefNoDueDate[this] = value; }
        }

        [DisplayName("Ref No Expected Date"), Expression("jRefNo.[EXPECTED_DATE]")]
        public DateTime? RefNoExpectedDate
        {
            get { return Fields.RefNoExpectedDate[this]; }
            set { Fields.RefNoExpectedDate[this] = value; }
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

        [DisplayName("Ref No Ship From"), Expression("jRefNo.[SHIP_FROM]")]
        public String RefNoShipFrom
        {
            get { return Fields.RefNoShipFrom[this]; }
            set { Fields.RefNoShipFrom[this] = value; }
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

        [DisplayName("Ref No Compute Tax"), Expression("jRefNo.[COMPUTE_TAX]")]
        public String RefNoComputeTax
        {
            get { return Fields.RefNoComputeTax[this]; }
            set { Fields.RefNoComputeTax[this] = value; }
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

        [DisplayName("Ref No Dps Cover"), Expression("jRefNo.[DPS_COVER]")]
        public Decimal? RefNoDpsCover
        {
            get { return Fields.RefNoDpsCover[this]; }
            set { Fields.RefNoDpsCover[this] = value; }
        }

        [DisplayName("Ref No Dps Applied"), Expression("jRefNo.[DPS_APPLIED]")]
        public Decimal? RefNoDpsApplied
        {
            get { return Fields.RefNoDpsApplied[this]; }
            set { Fields.RefNoDpsApplied[this] = value; }
        }

        [DisplayName("Ref No Net Bal Amt"), Expression("jRefNo.[NET_BAL_AMT]")]
        public Decimal? RefNoNetBalAmt
        {
            get { return Fields.RefNoNetBalAmt[this]; }
            set { Fields.RefNoNetBalAmt[this] = value; }
        }

        [DisplayName("Ref No Cpd Tdisc Amt"), Expression("jRefNo.[CPD_TDISC_AMT]")]
        public Decimal? RefNoCpdTdiscAmt
        {
            get { return Fields.RefNoCpdTdiscAmt[this]; }
            set { Fields.RefNoCpdTdiscAmt[this] = value; }
        }

        [DisplayName("Ref No Cpd Gtax Amt"), Expression("jRefNo.[CPD_GTAX_AMT]")]
        public Decimal? RefNoCpdGtaxAmt
        {
            get { return Fields.RefNoCpdGtaxAmt[this]; }
            set { Fields.RefNoCpdGtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Cpd Dps Amt"), Expression("jRefNo.[CPD_DPS_AMT]")]
        public Decimal? RefNoCpdDpsAmt
        {
            get { return Fields.RefNoCpdDpsAmt[this]; }
            set { Fields.RefNoCpdDpsAmt[this] = value; }
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

        [DisplayName("Ref No Loc Dps Applied"), Expression("jRefNo.[LOC_DPS_APPLIED]")]
        public Decimal? RefNoLocDpsApplied
        {
            get { return Fields.RefNoLocDpsApplied[this]; }
            set { Fields.RefNoLocDpsApplied[this] = value; }
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

        [DisplayName("Ref No Prevised Date"), Expression("jRefNo.[PREVISED_DATE]")]
        public DateTime? RefNoPrevisedDate
        {
            get { return Fields.RefNoPrevisedDate[this]; }
            set { Fields.RefNoPrevisedDate[this] = value; }
        }

        [DisplayName("Ref No Prevised By"), Expression("jRefNo.[PREVISED_BY]")]
        public String RefNoPrevisedBy
        {
            get { return Fields.RefNoPrevisedBy[this]; }
            set { Fields.RefNoPrevisedBy[this] = value; }
        }

        [DisplayName("Ref No Last Entry No"), Expression("jRefNo.[LAST_ENTRY_NO]")]
        public Decimal? RefNoLastEntryNo
        {
            get { return Fields.RefNoLastEntryNo[this]; }
            set { Fields.RefNoLastEntryNo[this] = value; }
        }

        [DisplayName("Ref No Last Chgs No"), Expression("jRefNo.[LAST_CHGS_NO]")]
        public Decimal? RefNoLastChgsNo
        {
            get { return Fields.RefNoLastChgsNo[this]; }
            set { Fields.RefNoLastChgsNo[this] = value; }
        }

        [DisplayName("Ref No Last Text No"), Expression("jRefNo.[LAST_TEXT_NO]")]
        public Decimal? RefNoLastTextNo
        {
            get { return Fields.RefNoLastTextNo[this]; }
            set { Fields.RefNoLastTextNo[this] = value; }
        }

        [DisplayName("Ref No Last Ctn No"), Expression("jRefNo.[LAST_CTN_NO]")]
        public Decimal? RefNoLastCtnNo
        {
            get { return Fields.RefNoLastCtnNo[this]; }
            set { Fields.RefNoLastCtnNo[this] = value; }
        }

        [DisplayName("Ref No Lock Type"), Expression("jRefNo.[LOCK_TYPE]")]
        public String RefNoLockType
        {
            get { return Fields.RefNoLockType[this]; }
            set { Fields.RefNoLockType[this] = value; }
        }

        [DisplayName("Ref No Lock Ref No"), Expression("jRefNo.[LOCK_REF_NO]")]
        public String RefNoLockRefNo
        {
            get { return Fields.RefNoLockRefNo[this]; }
            set { Fields.RefNoLockRefNo[this] = value; }
        }

        [DisplayName("Ref No Last Log No"), Expression("jRefNo.[LAST_LOG_NO]")]
        public Decimal? RefNoLastLogNo
        {
            get { return Fields.RefNoLastLogNo[this]; }
            set { Fields.RefNoLastLogNo[this] = value; }
        }

        [DisplayName("Ref No New Item Count"), Expression("jRefNo.[NEW_ITEM_COUNT]")]
        public Decimal? RefNoNewItemCount
        {
            get { return Fields.RefNoNewItemCount[this]; }
            set { Fields.RefNoNewItemCount[this] = value; }
        }

        [DisplayName("Ref No New Chgs Count"), Expression("jRefNo.[NEW_CHGS_COUNT]")]
        public Decimal? RefNoNewChgsCount
        {
            get { return Fields.RefNoNewChgsCount[this]; }
            set { Fields.RefNoNewChgsCount[this] = value; }
        }

        [DisplayName("Ref No Acct Customer"), Expression("jRefNo.[ACCT_CUSTOMER]")]
        public String RefNoAcctCustomer
        {
            get { return Fields.RefNoAcctCustomer[this]; }
            set { Fields.RefNoAcctCustomer[this] = value; }
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

        [DisplayName("Ref No Dps Apply Ref"), Expression("jRefNo.[DPS_APPLY_REF]")]
        public String RefNoDpsApplyRef
        {
            get { return Fields.RefNoDpsApplyRef[this]; }
            set { Fields.RefNoDpsApplyRef[this] = value; }
        }

        [DisplayName("Ref No Vend Tax Code"), Expression("jRefNo.[VEND_TAX_CODE]")]
        public String RefNoVendTaxCode
        {
            get { return Fields.RefNoVendTaxCode[this]; }
            set { Fields.RefNoVendTaxCode[this] = value; }
        }

        [DisplayName("Ref No Cust Tax Code"), Expression("jRefNo.[CUST_TAX_CODE]")]
        public String RefNoCustTaxCode
        {
            get { return Fields.RefNoCustTaxCode[this]; }
            set { Fields.RefNoCustTaxCode[this] = value; }
        }

        [DisplayName("Ref No Ret Price Amt"), Expression("jRefNo.[RET_PRICE_AMT]")]
        public Decimal? RefNoRetPriceAmt
        {
            get { return Fields.RefNoRetPriceAmt[this]; }
            set { Fields.RefNoRetPriceAmt[this] = value; }
        }

        [DisplayName("Ref No Ret Ptax Amt"), Expression("jRefNo.[RET_PTAX_AMT]")]
        public Decimal? RefNoRetPtaxAmt
        {
            get { return Fields.RefNoRetPtaxAmt[this]; }
            set { Fields.RefNoRetPtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Ret Ext Price"), Expression("jRefNo.[RET_EXT_PRICE]")]
        public Decimal? RefNoRetExtPrice
        {
            get { return Fields.RefNoRetExtPrice[this]; }
            set { Fields.RefNoRetExtPrice[this] = value; }
        }

        [DisplayName("Ref No Ret Ldisc Amt"), Expression("jRefNo.[RET_LDISC_AMT]")]
        public Decimal? RefNoRetLdiscAmt
        {
            get { return Fields.RefNoRetLdiscAmt[this]; }
            set { Fields.RefNoRetLdiscAmt[this] = value; }
        }

        [DisplayName("Ref No Ret Atax Amt"), Expression("jRefNo.[RET_ATAX_AMT]")]
        public Decimal? RefNoRetAtaxAmt
        {
            get { return Fields.RefNoRetAtaxAmt[this]; }
            set { Fields.RefNoRetAtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Ret Item Amt"), Expression("jRefNo.[RET_ITEM_AMT]")]
        public Decimal? RefNoRetItemAmt
        {
            get { return Fields.RefNoRetItemAmt[this]; }
            set { Fields.RefNoRetItemAmt[this] = value; }
        }

        [DisplayName("Ref No Ret Tdisc Amt"), Expression("jRefNo.[RET_TDISC_AMT]")]
        public Decimal? RefNoRetTdiscAmt
        {
            get { return Fields.RefNoRetTdiscAmt[this]; }
            set { Fields.RefNoRetTdiscAmt[this] = value; }
        }

        [DisplayName("Ref No Ret Gtax Amt"), Expression("jRefNo.[RET_GTAX_AMT]")]
        public Decimal? RefNoRetGtaxAmt
        {
            get { return Fields.RefNoRetGtaxAmt[this]; }
            set { Fields.RefNoRetGtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Ret Chgs Amt"), Expression("jRefNo.[RET_CHGS_AMT]")]
        public Decimal? RefNoRetChgsAmt
        {
            get { return Fields.RefNoRetChgsAmt[this]; }
            set { Fields.RefNoRetChgsAmt[this] = value; }
        }

        [DisplayName("Ref No Ret Pay Amt"), Expression("jRefNo.[RET_PAY_AMT]")]
        public Decimal? RefNoRetPayAmt
        {
            get { return Fields.RefNoRetPayAmt[this]; }
            set { Fields.RefNoRetPayAmt[this] = value; }
        }

        [DisplayName("Ref No Lret Price Amt"), Expression("jRefNo.[LRET_PRICE_AMT]")]
        public Decimal? RefNoLretPriceAmt
        {
            get { return Fields.RefNoLretPriceAmt[this]; }
            set { Fields.RefNoLretPriceAmt[this] = value; }
        }

        [DisplayName("Ref No Lret Ptax Amt"), Expression("jRefNo.[LRET_PTAX_AMT]")]
        public Decimal? RefNoLretPtaxAmt
        {
            get { return Fields.RefNoLretPtaxAmt[this]; }
            set { Fields.RefNoLretPtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Lret Ext Price"), Expression("jRefNo.[LRET_EXT_PRICE]")]
        public Decimal? RefNoLretExtPrice
        {
            get { return Fields.RefNoLretExtPrice[this]; }
            set { Fields.RefNoLretExtPrice[this] = value; }
        }

        [DisplayName("Ref No Lret Ldisc Amt"), Expression("jRefNo.[LRET_LDISC_AMT]")]
        public Decimal? RefNoLretLdiscAmt
        {
            get { return Fields.RefNoLretLdiscAmt[this]; }
            set { Fields.RefNoLretLdiscAmt[this] = value; }
        }

        [DisplayName("Ref No Lret Atax Amt"), Expression("jRefNo.[LRET_ATAX_AMT]")]
        public Decimal? RefNoLretAtaxAmt
        {
            get { return Fields.RefNoLretAtaxAmt[this]; }
            set { Fields.RefNoLretAtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Lret Item Amt"), Expression("jRefNo.[LRET_ITEM_AMT]")]
        public Decimal? RefNoLretItemAmt
        {
            get { return Fields.RefNoLretItemAmt[this]; }
            set { Fields.RefNoLretItemAmt[this] = value; }
        }

        [DisplayName("Ref No Lret Tdisc Amt"), Expression("jRefNo.[LRET_TDISC_AMT]")]
        public Decimal? RefNoLretTdiscAmt
        {
            get { return Fields.RefNoLretTdiscAmt[this]; }
            set { Fields.RefNoLretTdiscAmt[this] = value; }
        }

        [DisplayName("Ref No Lret Gtax Amt"), Expression("jRefNo.[LRET_GTAX_AMT]")]
        public Decimal? RefNoLretGtaxAmt
        {
            get { return Fields.RefNoLretGtaxAmt[this]; }
            set { Fields.RefNoLretGtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Lret Chgs Amt"), Expression("jRefNo.[LRET_CHGS_AMT]")]
        public Decimal? RefNoLretChgsAmt
        {
            get { return Fields.RefNoLretChgsAmt[this]; }
            set { Fields.RefNoLretChgsAmt[this] = value; }
        }

        [DisplayName("Ref No Lret Pay Amt"), Expression("jRefNo.[LRET_PAY_AMT]")]
        public Decimal? RefNoLretPayAmt
        {
            get { return Fields.RefNoLretPayAmt[this]; }
            set { Fields.RefNoLretPayAmt[this] = value; }
        }

        [DisplayName("Ref No Weight Uom"), Expression("jRefNo.[WEIGHT_UOM]")]
        public String RefNoWeightUom
        {
            get { return Fields.RefNoWeightUom[this]; }
            set { Fields.RefNoWeightUom[this] = value; }
        }

        [DisplayName("Ref No Gr Wt"), Expression("jRefNo.[GR_WT]")]
        public Decimal? RefNoGrWt
        {
            get { return Fields.RefNoGrWt[this]; }
            set { Fields.RefNoGrWt[this] = value; }
        }

        [DisplayName("Ref No Nt Wt"), Expression("jRefNo.[NT_WT]")]
        public Decimal? RefNoNtWt
        {
            get { return Fields.RefNoNtWt[this]; }
            set { Fields.RefNoNtWt[this] = value; }
        }

        [DisplayName("Ref No Dimension Uom"), Expression("jRefNo.[DIMENSION_UOM]")]
        public String RefNoDimensionUom
        {
            get { return Fields.RefNoDimensionUom[this]; }
            set { Fields.RefNoDimensionUom[this] = value; }
        }

        [DisplayName("Ref No Volume"), Expression("jRefNo.[VOLUME]")]
        public Decimal? RefNoVolume
        {
            get { return Fields.RefNoVolume[this]; }
            set { Fields.RefNoVolume[this] = value; }
        }

        [DisplayName("Ref No Gl Link"), Expression("jRefNo.[GL_LINK]")]
        public String RefNoGlLink
        {
            get { return Fields.RefNoGlLink[this]; }
            set { Fields.RefNoGlLink[this] = value; }
        }

        [DisplayName("Ref No Gl Link Type"), Expression("jRefNo.[GL_LINK_TYPE]")]
        public String RefNoGlLinkType
        {
            get { return Fields.RefNoGlLinkType[this]; }
            set { Fields.RefNoGlLinkType[this] = value; }
        }

        [DisplayName("Ref No Gl Link No"), Expression("jRefNo.[GL_LINK_NO]")]
        public String RefNoGlLinkNo
        {
            get { return Fields.RefNoGlLinkNo[this]; }
            set { Fields.RefNoGlLinkNo[this] = value; }
        }

        [DisplayName("Ref No Packing Ok"), Expression("jRefNo.[PACKING_OK]")]
        public String RefNoPackingOk
        {
            get { return Fields.RefNoPackingOk[this]; }
            set { Fields.RefNoPackingOk[this] = value; }
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

        [DisplayName("Ref No Settle At"), Expression("jRefNo.[SETTLE_AT]")]
        public String RefNoSettleAt
        {
            get { return Fields.RefNoSettleAt[this]; }
            set { Fields.RefNoSettleAt[this] = value; }
        }

        [DisplayName("Ref No Check Crlimit"), Expression("jRefNo.[CHECK_CRLIMIT]")]
        public String RefNoCheckCrlimit
        {
            get { return Fields.RefNoCheckCrlimit[this]; }
            set { Fields.RefNoCheckCrlimit[this] = value; }
        }

        [DisplayName("Ref No Check Crbal"), Expression("jRefNo.[CHECK_CRBAL]")]
        public Decimal? RefNoCheckCrbal
        {
            get { return Fields.RefNoCheckCrbal[this]; }
            set { Fields.RefNoCheckCrbal[this] = value; }
        }

        [DisplayName("Ref No Attention"), Expression("jRefNo.[ATTENTION]")]
        public String RefNoAttention
        {
            get { return Fields.RefNoAttention[this]; }
            set { Fields.RefNoAttention[this] = value; }
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

        [DisplayName("Ref No Forwarder"), Expression("jRefNo.[FORWARDER]")]
        public String RefNoForwarder
        {
            get { return Fields.RefNoForwarder[this]; }
            set { Fields.RefNoForwarder[this] = value; }
        }

        [DisplayName("Ref No Lc No"), Expression("jRefNo.[LC_NO]")]
        public String RefNoLcNo
        {
            get { return Fields.RefNoLcNo[this]; }
            set { Fields.RefNoLcNo[this] = value; }
        }

        [DisplayName("Ref No Origin Country"), Expression("jRefNo.[ORIGIN_COUNTRY]")]
        public String RefNoOriginCountry
        {
            get { return Fields.RefNoOriginCountry[this]; }
            set { Fields.RefNoOriginCountry[this] = value; }
        }

        [DisplayName("Ref No Comments5"), Expression("jRefNo.[COMMENTS5]")]
        public String RefNoComments5
        {
            get { return Fields.RefNoComments5[this]; }
            set { Fields.RefNoComments5[this] = value; }
        }

        [DisplayName("Ref No Comments6"), Expression("jRefNo.[COMMENTS6]")]
        public String RefNoComments6
        {
            get { return Fields.RefNoComments6[this]; }
            set { Fields.RefNoComments6[this] = value; }
        }

        [DisplayName("Ref No Comments7"), Expression("jRefNo.[COMMENTS7]")]
        public String RefNoComments7
        {
            get { return Fields.RefNoComments7[this]; }
            set { Fields.RefNoComments7[this] = value; }
        }

        [DisplayName("Ref No Comments8"), Expression("jRefNo.[COMMENTS8]")]
        public String RefNoComments8
        {
            get { return Fields.RefNoComments8[this]; }
            set { Fields.RefNoComments8[this] = value; }
        }

        [DisplayName("Ref No Issue Bank"), Expression("jRefNo.[ISSUE_BANK]")]
        public String RefNoIssueBank
        {
            get { return Fields.RefNoIssueBank[this]; }
            set { Fields.RefNoIssueBank[this] = value; }
        }

        [DisplayName("Ref No Issue Date"), Expression("jRefNo.[ISSUE_DATE]")]
        public DateTime? RefNoIssueDate
        {
            get { return Fields.RefNoIssueDate[this]; }
            set { Fields.RefNoIssueDate[this] = value; }
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

        [DisplayName("Ref No Loc Gsltax Amt"), Expression("jRefNo.[LOC_GSLTAX_AMT]")]
        public Decimal? RefNoLocGsltaxAmt
        {
            get { return Fields.RefNoLocGsltaxAmt[this]; }
            set { Fields.RefNoLocGsltaxAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Lsltax Amt"), Expression("jRefNo.[LOC_LSLTAX_AMT]")]
        public Decimal? RefNoLocLsltaxAmt
        {
            get { return Fields.RefNoLocLsltaxAmt[this]; }
            set { Fields.RefNoLocLsltaxAmt[this] = value; }
        }

        [DisplayName("Ref No So Sltax Type"), Expression("jRefNo.[SO_SLTAX_TYPE]")]
        public String RefNoSoSltaxType
        {
            get { return Fields.RefNoSoSltaxType[this]; }
            set { Fields.RefNoSoSltaxType[this] = value; }
        }

        [DisplayName("Ref No So Gsltax Pcent"), Expression("jRefNo.[SO_GSLTAX_PCENT]")]
        public Decimal? RefNoSoGsltaxPcent
        {
            get { return Fields.RefNoSoGsltaxPcent[this]; }
            set { Fields.RefNoSoGsltaxPcent[this] = value; }
        }

        [DisplayName("Ref No Order Count"), Expression("jRefNo.[ORDER_COUNT]")]
        public Decimal? RefNoOrderCount
        {
            get { return Fields.RefNoOrderCount[this]; }
            set { Fields.RefNoOrderCount[this] = value; }
        }

        [DisplayName("Ref No Acct Sltax"), Expression("jRefNo.[ACCT_SLTAX]")]
        public String RefNoAcctSltax
        {
            get { return Fields.RefNoAcctSltax[this]; }
            set { Fields.RefNoAcctSltax[this] = value; }
        }

        [DisplayName("Ref No Last Text No1"), Expression("jRefNo.[LAST_TEXT_NO1]")]
        public Decimal? RefNoLastTextNo1
        {
            get { return Fields.RefNoLastTextNo1[this]; }
            set { Fields.RefNoLastTextNo1[this] = value; }
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

        [DisplayName("Ref No Dn Only"), Expression("jRefNo.[DN_ONLY]")]
        public String RefNoDnOnly
        {
            get { return Fields.RefNoDnOnly[this]; }
            set { Fields.RefNoDnOnly[this] = value; }
        }

        [DisplayName("Ref No Invoiced"), Expression("jRefNo.[INVOICED]")]
        public String RefNoInvoiced
        {
            get { return Fields.RefNoInvoiced[this]; }
            set { Fields.RefNoInvoiced[this] = value; }
        }

        [DisplayName("Ref No Invoice No"), Expression("jRefNo.[INVOICE_NO]")]
        public String RefNoInvoiceNo
        {
            get { return Fields.RefNoInvoiceNo[this]; }
            set { Fields.RefNoInvoiceNo[this] = value; }
        }

        [DisplayName("Ref No Flag"), Expression("jRefNo.[FLAG]")]
        public String RefNoFlag
        {
            get { return Fields.RefNoFlag[this]; }
            set { Fields.RefNoFlag[this] = value; }
        }

        [DisplayName("Ref No Hold By"), Expression("jRefNo.[HOLD_BY]")]
        public String RefNoHoldBy
        {
            get { return Fields.RefNoHoldBy[this]; }
            set { Fields.RefNoHoldBy[this] = value; }
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

        [DisplayName("Ref No Manual Shipment Detail"), Expression("jRefNo.[MANUAL_SHIPMENT_DETAIL]")]
        public Boolean? RefNoManualShipmentDetail
        {
            get { return Fields.RefNoManualShipmentDetail[this]; }
            set { Fields.RefNoManualShipmentDetail[this] = value; }
        }

        [DisplayName("Ref No Ref Company Code"), Expression("jRefNo.[REF_COMPANY_CODE]")]
        public String RefNoRefCompanyCode
        {
            get { return Fields.RefNoRefCompanyCode[this]; }
            set { Fields.RefNoRefCompanyCode[this] = value; }
        }

        [DisplayName("Ref No Ref Grn No"), Expression("jRefNo.[REF_GRN_NO]")]
        public String RefNoRefGrnNo
        {
            get { return Fields.RefNoRefGrnNo[this]; }
            set { Fields.RefNoRefGrnNo[this] = value; }
        }

        [DisplayName("Ref No Lc Name"), Expression("jRefNo.[LC_NAME]")]
        public String RefNoLcName
        {
            get { return Fields.RefNoLcName[this]; }
            set { Fields.RefNoLcName[this] = value; }
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

        public ShipmentDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField RefNo;
            public DecimalField EntryNo;
            public StringField Selected;
            public StringField OrderNo;
            public DecimalField LineNo;
            public StringField ItemNo;
            public StringField Description;
            public StringField Uom;
            public DecimalField LotSize;
            public StringField Configurable;
            public DecimalField QtyBalance;
            public DecimalField QtyDue;
            public DecimalField QtyShipped;
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
            public DecimalField LdiscRate;
            public DecimalField AtaxRate;
            public DecimalField LdiscAmtCpd;
            public DecimalField AtaxAmtCpd;
            public DecimalField LocPriceAmt;
            public DecimalField LocPtaxAmt;
            public DecimalField LocExtPrice;
            public DecimalField LocLdiscAmt;
            public DecimalField LocAtaxAmt;
            public DecimalField LocItemAmt;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField Anlys5;
            public StringField Anlys6;
            public StringField Posted;
            public DecimalField LogNo;
            public StringField Returned;
            public DateTimeField ShipmentDate;
            public StringField CustomerNo;
            public StringField ShipFrom;
            public StringField CommisType;
            public StringField CommisRefNo;
            public StringField CustItemNo;
            public StringField AcctSales;
            public StringField AcctLdisc;
            public StringField AcctPtax;
            public StringField AcctAtax;
            public StringField ItemTaxCode;
            public DecimalField QtyReturned;
            public DecimalField RetPriceAmt;
            public DecimalField RetPtaxAmt;
            public DecimalField RetExtPrice;
            public DecimalField RetLdiscAmt;
            public DecimalField RetAtaxAmt;
            public DecimalField RetItemAmt;
            public DecimalField LretPriceAmt;
            public DecimalField LretPtaxAmt;
            public DecimalField LretExtPrice;
            public DecimalField LretLdiscAmt;
            public DecimalField LretAtaxAmt;
            public DecimalField LretItemAmt;
            public DecimalField QtyPacked;
            public DecimalField CostReturned;
            public StringField StdAssort;
            public StringField ExtDescription;
            public StringField VendorPack;
            public DecimalField SltaxPcent;
            public DecimalField SltaxAmt;
            public DecimalField LocSltaxAmt;
            public StringField AcctSltax;
            public DecimalField MarkupPcent;
            public DecimalField Markup;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;
            public StringField Anlys19;
            public StringField Anlys20;
            public DecimalField LotSizeCost;

            public DecimalField RefNoRecnum;
            public DateTimeField RefNoShipmentDate;
            public StringField RefNoPosted;
            public StringField RefNoReturned;
            public StringField RefNoCustomerNo;
            public StringField RefNoCustomerName;
            public StringField RefNoShipTo;
            public StringField RefNoAddress;
            public StringField RefNoAddress2;
            public StringField RefNoAddress3;
            public StringField RefNoAddress4;
            public DateTimeField RefNoCutoffDate;
            public StringField RefNoShipVia;
            public StringField RefNoShipmentTerms;
            public StringField RefNoVesselName;
            public DateTimeField RefNoEtd;
            public DateTimeField RefNoEta;
            public StringField RefNoPayTerms;
            public DecimalField RefNoDiscDays;
            public DecimalField RefNoDiscPercent;
            public DecimalField RefNoNetDays;
            public DateTimeField RefNoDiscountDate;
            public DateTimeField RefNoDueDate;
            public DateTimeField RefNoExpectedDate;
            public StringField RefNoCcy;
            public DecimalField RefNoExchRate;
            public StringField RefNoShipFrom;
            public StringField RefNoOwnerBranch;
            public StringField RefNoSourceBranch;
            public StringField RefNoComputeTax;
            public DecimalField RefNoTotPriceAmt;
            public DecimalField RefNoTotPtaxAmt;
            public DecimalField RefNoTotExtPrice;
            public DecimalField RefNoTotLdiscAmt;
            public DecimalField RefNoTotAtaxAmt;
            public DecimalField RefNoTotItemAmt;
            public DecimalField RefNoTotTdiscAmt;
            public DecimalField RefNoNetTradeAmt;
            public DecimalField RefNoTotChgsAmt;
            public DecimalField RefNoNetOrdrAmt;
            public DecimalField RefNoTotGtaxAmt;
            public DecimalField RefNoNetPayAmt;
            public DecimalField RefNoDpsCover;
            public DecimalField RefNoDpsApplied;
            public DecimalField RefNoNetBalAmt;
            public DecimalField RefNoCpdTdiscAmt;
            public DecimalField RefNoCpdGtaxAmt;
            public DecimalField RefNoCpdDpsAmt;
            public DecimalField RefNoLocPriceAmt;
            public DecimalField RefNoLocPtaxAmt;
            public DecimalField RefNoLocExtPrice;
            public DecimalField RefNoLocLdiscAmt;
            public DecimalField RefNoLocAtaxAmt;
            public DecimalField RefNoLocItemAmt;
            public DecimalField RefNoLocTdiscAmt;
            public DecimalField RefNoLocChgsAmt;
            public DecimalField RefNoLocGtaxAmt;
            public DecimalField RefNoLocPayAmt;
            public DecimalField RefNoLocDpsApplied;
            public DateTimeField RefNoCreatedDate;
            public StringField RefNoCreatedBy;
            public DateTimeField RefNoRevisedDate;
            public StringField RefNoRevisedBy;
            public DateTimeField RefNoPostedDate;
            public StringField RefNoPostedBy;
            public DateTimeField RefNoPrevisedDate;
            public StringField RefNoPrevisedBy;
            public DecimalField RefNoLastEntryNo;
            public DecimalField RefNoLastChgsNo;
            public DecimalField RefNoLastTextNo;
            public DecimalField RefNoLastCtnNo;
            public StringField RefNoLockType;
            public StringField RefNoLockRefNo;
            public DecimalField RefNoLastLogNo;
            public DecimalField RefNoNewItemCount;
            public DecimalField RefNoNewChgsCount;
            public StringField RefNoAcctCustomer;
            public StringField RefNoAcctTdisc;
            public StringField RefNoAcctGtax;
            public StringField RefNoDpsApplyRef;
            public StringField RefNoVendTaxCode;
            public StringField RefNoCustTaxCode;
            public DecimalField RefNoRetPriceAmt;
            public DecimalField RefNoRetPtaxAmt;
            public DecimalField RefNoRetExtPrice;
            public DecimalField RefNoRetLdiscAmt;
            public DecimalField RefNoRetAtaxAmt;
            public DecimalField RefNoRetItemAmt;
            public DecimalField RefNoRetTdiscAmt;
            public DecimalField RefNoRetGtaxAmt;
            public DecimalField RefNoRetChgsAmt;
            public DecimalField RefNoRetPayAmt;
            public DecimalField RefNoLretPriceAmt;
            public DecimalField RefNoLretPtaxAmt;
            public DecimalField RefNoLretExtPrice;
            public DecimalField RefNoLretLdiscAmt;
            public DecimalField RefNoLretAtaxAmt;
            public DecimalField RefNoLretItemAmt;
            public DecimalField RefNoLretTdiscAmt;
            public DecimalField RefNoLretGtaxAmt;
            public DecimalField RefNoLretChgsAmt;
            public DecimalField RefNoLretPayAmt;
            public StringField RefNoWeightUom;
            public DecimalField RefNoGrWt;
            public DecimalField RefNoNtWt;
            public StringField RefNoDimensionUom;
            public DecimalField RefNoVolume;
            public StringField RefNoGlLink;
            public StringField RefNoGlLinkType;
            public StringField RefNoGlLinkNo;
            public StringField RefNoPackingOk;
            public StringField RefNoComments1;
            public StringField RefNoComments2;
            public StringField RefNoComments3;
            public StringField RefNoComments4;
            public StringField RefNoSettleAt;
            public StringField RefNoCheckCrlimit;
            public DecimalField RefNoCheckCrbal;
            public StringField RefNoAttention;
            public StringField RefNoTelNo;
            public StringField RefNoFaxNo;
            public StringField RefNoPortLoading;
            public StringField RefNoPortDischarge;
            public StringField RefNoForwarder;
            public StringField RefNoLcNo;
            public StringField RefNoOriginCountry;
            public StringField RefNoComments5;
            public StringField RefNoComments6;
            public StringField RefNoComments7;
            public StringField RefNoComments8;
            public StringField RefNoIssueBank;
            public DateTimeField RefNoIssueDate;
            public StringField RefNoSltaxType;
            public DecimalField RefNoGsltaxPcent;
            public DecimalField RefNoTotGsltaxAmt;
            public DecimalField RefNoTotLsltaxAmt;
            public DecimalField RefNoLocGsltaxAmt;
            public DecimalField RefNoLocLsltaxAmt;
            public StringField RefNoSoSltaxType;
            public DecimalField RefNoSoGsltaxPcent;
            public DecimalField RefNoOrderCount;
            public StringField RefNoAcctSltax;
            public DecimalField RefNoLastTextNo1;
            public StringField RefNoAnlys1;
            public StringField RefNoAnlys2;
            public StringField RefNoAnlys7;
            public StringField RefNoAnlys8;
            public StringField RefNoDnOnly;
            public StringField RefNoInvoiced;
            public StringField RefNoInvoiceNo;
            public StringField RefNoFlag;
            public StringField RefNoHoldBy;
            public StringField RefNoAnlys9;
            public StringField RefNoAnlys10;
            public StringField RefNoAnlys11;
            public StringField RefNoAnlys12;
            public StringField RefNoAnlys13;
            public StringField RefNoAnlys14;
            public BooleanField RefNoManualShipmentDetail;
            public StringField RefNoRefCompanyCode;
            public StringField RefNoRefGrnNo;
            public StringField RefNoLcName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Sales.ShipmentDetail";
            }
        }
    }
}
