#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorGroupRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Enterprise.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Enterprise"), TableName("[dbo].[GBVGRP]")]
    [DisplayName("Vendor Group"), InstanceName("Vendor Group"), TwoLevelCached]
    public sealed class VendorGroupRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Vendor Group"), Column("VENDOR_GROUP"), Size(6), PrimaryKey, QuickSearch]
        public String VendorGroup
        {
            get { return Fields.VendorGroup[this]; }
            set { Fields.VendorGroup[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(30), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [Serenity.Data.BoolStringConverterAttribute]
        public Boolean? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Acct Ap Vend"), Column("ACCT_AP_VEND"), Size(30)]
        public String AcctApVend
        {
            get { return Fields.AcctApVend[this]; }
            set { Fields.AcctApVend[this] = value; }
        }

        [DisplayName("Acct Ap Disc"), Column("ACCT_AP_DISC"), Size(30)]
        public String AcctApDisc
        {
            get { return Fields.AcctApDisc[this]; }
            set { Fields.AcctApDisc[this] = value; }
        }

        [DisplayName("Acct Ap Adj"), Column("ACCT_AP_ADJ"), Size(30)]
        public String AcctApAdj
        {
            get { return Fields.AcctApAdj[this]; }
            set { Fields.AcctApAdj[this] = value; }
        }

        [DisplayName("Acct Pur Trdisc"), Column("ACCT_PUR_TRDISC"), Size(30)]
        public String AcctPurTrdisc
        {
            get { return Fields.AcctPurTrdisc[this]; }
            set { Fields.AcctPurTrdisc[this] = value; }
        }

        [DisplayName("Gtax Code"), Column("GTAX_CODE"), Size(6)]
        public String GtaxCode
        {
            get { return Fields.GtaxCode[this]; }
            set { Fields.GtaxCode[this] = value; }
        }

        [DisplayName("Ltax Code"), Column("LTAX_CODE"), Size(6)]
        public String LtaxCode
        {
            get { return Fields.LtaxCode[this]; }
            set { Fields.LtaxCode[this] = value; }
        }

        [DisplayName("Order Ccy"), Column("ORDER_CCY"), Size(4)]
        public String OrderCcy
        {
            get { return Fields.OrderCcy[this]; }
            set { Fields.OrderCcy[this] = value; }
        }

        [DisplayName("Pay Terms"), Column("PAY_TERMS"), Size(6)]
        public String PayTerms
        {
            get { return Fields.PayTerms[this]; }
            set { Fields.PayTerms[this] = value; }
        }

        [DisplayName("Use Alt Names"), Column("USE_ALT_NAMES"), Size(1)]
        [BoolStringConverter]
        public bool? UseAltNames
        {
            get { return Fields.UseAltNames[this]; }
            set { Fields.UseAltNames[this] = value; }
        }

        [DisplayName("With Cr Limit"), Column("WITH_CR_LIMIT"), Size(1)]
        public String WithCrLimit
        {
            get { return Fields.WithCrLimit[this]; }
            set { Fields.WithCrLimit[this] = value; }
        }

        [DisplayName("Credit Limit"), Column("CREDIT_LIMIT"), Size(16), Scale(2)]
        public Decimal? CreditLimit
        {
            get { return Fields.CreditLimit[this]; }
            set { Fields.CreditLimit[this] = value; }
        }

        [DisplayName("Trade Discount"), Column("TRADE_DISCOUNT"), Size(6), Scale(2)]
        public Decimal? TradeDiscount
        {
            get { return Fields.TradeDiscount[this]; }
            set { Fields.TradeDiscount[this] = value; }
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

        [DisplayName("Vendor Count"), Column("VENDOR_COUNT"), Size(8)]
        public Decimal? VendorCount
        {
            get { return Fields.VendorCount[this]; }
            set { Fields.VendorCount[this] = value; }
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

        [DisplayName("Arevised Date"), Column("AREVISED_DATE")]
        public DateTime? ArevisedDate
        {
            get { return Fields.ArevisedDate[this]; }
            set { Fields.ArevisedDate[this] = value; }
        }

        [DisplayName("Arevised By"), Column("AREVISED_BY"), Size(10)]
        public String ArevisedBy
        {
            get { return Fields.ArevisedBy[this]; }
            set { Fields.ArevisedBy[this] = value; }
        }

        [DisplayName("Trevised Date"), Column("TREVISED_DATE")]
        public DateTime? TrevisedDate
        {
            get { return Fields.TrevisedDate[this]; }
            set { Fields.TrevisedDate[this] = value; }
        }

        [DisplayName("Trevised By"), Column("TREVISED_BY"), Size(10)]
        public String TrevisedBy
        {
            get { return Fields.TrevisedBy[this]; }
            set { Fields.TrevisedBy[this] = value; }
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

        [DisplayName("Putax Pcent"), Column("PUTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? PutaxPcent
        {
            get { return Fields.PutaxPcent[this]; }
            set { Fields.PutaxPcent[this] = value; }
        }

        [DisplayName("Acct Vend Putax"), Column("ACCT_VEND_PUTAX"), Size(30)]
        public String AcctVendPutax
        {
            get { return Fields.AcctVendPutax[this]; }
            set { Fields.AcctVendPutax[this] = value; }
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

        [DisplayName("Acct Temp"), Column("ACCT_TEMP"), Size(30)]
        public String AcctTemp
        {
            get { return Fields.AcctTemp[this]; }
            set { Fields.AcctTemp[this] = value; }
        }

        [DisplayName("Acct Ap Deposit"), Column("ACCT_AP_DEPOSIT"), Size(30)]
        public String AcctApDeposit
        {
            get { return Fields.AcctApDeposit[this]; }
            set { Fields.AcctApDeposit[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.VendorGroup; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Description; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VendorGroupRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField VendorGroup;
            public StringField Description;
            public BooleanField Suspended;
            public StringField AcctApVend;
            public StringField AcctApDisc;
            public StringField AcctApAdj;
            public StringField AcctPurTrdisc;
            public StringField GtaxCode;
            public StringField LtaxCode;
            public StringField OrderCcy;
            public StringField PayTerms;
            public BooleanField UseAltNames;
            public StringField WithCrLimit;
            public DecimalField CreditLimit;
            public DecimalField TradeDiscount;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys3;
            public StringField Anlys4;
            public DecimalField VendorCount;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField ArevisedDate;
            public StringField ArevisedBy;
            public DateTimeField TrevisedDate;
            public StringField TrevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public DecimalField PutaxPcent;
            public StringField AcctVendPutax;
            public StringField Anlys5;
            public StringField Anlys6;
            public StringField Anlys7;
            public StringField Anlys8;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField AcctTemp;
            public StringField AcctApDeposit;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Enterprise.VendorGroup";
            }
        }
    }
}
