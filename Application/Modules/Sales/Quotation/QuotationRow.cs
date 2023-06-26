#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  QuotationRow.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;

namespace Matrix.Sales.Entities
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Sales"), TableName("[dbo].[SLQUOH]")]
    [DisplayName("Quotation"), InstanceName("Quotation"), TwoLevelCached]   
    public sealed class QuotationRow : Row, IIdRow, INameRow
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

        [DisplayName("Issue Date"), Column("ISSUE_DATE"), NotNull]
        public DateTime? IssueDate
        {
            get { return Fields.IssueDate[this]; }
            set { Fields.IssueDate[this] = value; }
        }

        [DisplayName("Valid Until"), Column("VALID_UNTIL")]
        public DateTime? ValidUntil
        {
            get { return Fields.ValidUntil[this]; }
            set { Fields.ValidUntil[this] = value; }
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

        [DisplayName("Attention"), Column("ATTENTION"), Size(30)]
        public String Attention
        {
            get { return Fields.Attention[this]; }
            set { Fields.Attention[this] = value; }
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

        [DisplayName("Base Loc"), Column("BASE_LOC"), Size(4)]
        public String BaseLoc
        {
            get { return Fields.BaseLoc[this]; }
            set { Fields.BaseLoc[this] = value; }
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

        [DisplayName("Price Code"), Column("PRICE_CODE"), Size(6), NotNull]
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

        [DisplayName("Compute Tax"), Column("COMPUTE_TAX"), Size(1)]
        public String ComputeTax
        {
            get { return Fields.ComputeTax[this]; }
            set { Fields.ComputeTax[this] = value; }
        }

        [DisplayName("Last Line No"), Column("LAST_LINE_NO"), Size(8)]
        public Decimal? LastLineNo
        {
            get { return Fields.LastLineNo[this]; }
            set { Fields.LastLineNo[this] = value; }
        }

        [DisplayName("Last Mail No"), Column("LAST_MAIL_NO"), Size(6)]
        public Decimal? LastMailNo
        {
            get { return Fields.LastMailNo[this]; }
            set { Fields.LastMailNo[this] = value; }
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

        [DisplayName("Closed Date"), Column("CLOSED_DATE")]
        public DateTime? ClosedDate
        {
            get { return Fields.ClosedDate[this]; }
            set { Fields.ClosedDate[this] = value; }
        }

        [DisplayName("Closed By"), Column("CLOSED_BY"), Size(10)]
        public String ClosedBy
        {
            get { return Fields.ClosedBy[this]; }
            set { Fields.ClosedBy[this] = value; }
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

        [DisplayName("Web Published"), Column("WEB_PUBLISHED"), Size(1)]
        public String WebPublished
        {
            get { return Fields.WebPublished[this]; }
            set { Fields.WebPublished[this] = value; }
        }

        [DisplayName("Confirmed"), Column("CONFIRMED"), Size(1)]
        public String Confirmed
        {
            get { return Fields.Confirmed[this]; }
            set { Fields.Confirmed[this] = value; }
        }

        [DisplayName("Rfq No"), Column("RFQ_NO"), Size(16)]
        public String RfqNo
        {
            get { return Fields.RfqNo[this]; }
            set { Fields.RfqNo[this] = value; }
        }

        [DisplayName("Web User Name"), Column("WEB_USER_NAME"), Size(10)]
        public String WebUserName
        {
            get { return Fields.WebUserName[this]; }
            set { Fields.WebUserName[this] = value; }
        }

        [DisplayName("Ship To"), Column("SHIP_TO"), Size(6)]
        public String ShipTo
        {
            get { return Fields.ShipTo[this]; }
            set { Fields.ShipTo[this] = value; }
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

        [DisplayName("Country of Origin"), Column("ORIGIN_COUNTRY"), Size(25)]
        public String OriginCountry
        {
            get { return Fields.OriginCountry[this]; }
            set { Fields.OriginCountry[this] = value; }
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

        [DisplayName("Markup Decimal"), Column("MARKUP_DECIMAL"), Size(1)]
        public Decimal? MarkupDecimal
        {
            get { return Fields.MarkupDecimal[this]; }
            set { Fields.MarkupDecimal[this] = value; }
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

        [DisplayName("Item Code"), Column("ITEM_CODE"), Size(3)]
        public String ItemCode
        {
            get { return Fields.ItemCode[this]; }
            set { Fields.ItemCode[this] = value; }
        }

        [DisplayName("Transport"), Column("TRANSPORT"), Size(1)]
        public String Transport
        {
            get { return Fields.Transport[this]; }
            set { Fields.Transport[this] = value; }
        }

        [MasterDetailRelation(foreignKey: "RefNo")]
        [DisplayName("Detail List"), NotMapped]
        public List<QuotationDetailRow> DetailList 
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }


        IIdField IIdRow.IdField
        {
            get { return Fields.RefNo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.RefNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public QuotationRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField RefNo;
            public DateTimeField IssueDate;
            public DateTimeField ValidUntil;
            public StringField Closed;
            public StringField CustomerNo;
            public StringField CustomerName;
            public StringField Address;
            public StringField Address2;
            public StringField Address3;
            public StringField Address4;
            public StringField Attention;
            public StringField ShipVia;
            public StringField ShipmentTerms;
            public StringField BaseLoc;
            public StringField Salesman;
            public StringField PayTerms;
            public StringField PriceCode;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Ccy;
            public DecimalField ExchRate;
            public StringField ComputeTax;
            public DecimalField LastLineNo;
            public DecimalField LastMailNo;
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
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DecimalField TotTdiscCpd;
            public DecimalField TotGtaxCpd;
            public DecimalField TotDpsCpd;
            public DateTimeField ClosedDate;
            public StringField ClosedBy;
            public StringField Comments1;
            public StringField Comments2;
            public StringField Comments3;
            public StringField Comments4;
            public StringField WebPublished;
            public StringField Confirmed;
            public StringField RfqNo;
            public StringField WebUserName;
            public StringField ShipTo;
            public StringField TelNo;
            public StringField FaxNo;
            public StringField PortLoading;
            public StringField PortDischarge;
            public StringField OriginCountry;
            public StringField SltaxType;
            public DecimalField GsltaxPcent;
            public DecimalField TotGsltaxAmt;
            public DecimalField TotLsltaxAmt;
            public StringField Anlys7;
            public StringField Anlys8;
            public DecimalField MarkupDecimal;
            public StringField PkgUnit;
            public StringField WeightUnit;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;
            public StringField ItemCode;
            public StringField Transport;

            public RowListField<QuotationDetailRow> DetailList;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Sales.Quotation";
            }
        }
    }
}
