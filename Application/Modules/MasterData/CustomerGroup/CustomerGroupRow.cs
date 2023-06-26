#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CustomerGroupRow.cs
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

    [ConnectionKey("Enterprise"), TableName("[dbo].[GBCGRP]")]
    [DisplayName("Customer Group"), InstanceName("Customer Group"), TwoLevelCached]
    public sealed class CustomerGroupRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Customer Group"), Column("CUSTOMER_GROUP"), Size(8), PrimaryKey, QuickSearch]
        public String CustomerGroup
        {
            get { return Fields.CustomerGroup[this]; }
            set { Fields.CustomerGroup[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(30), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Acct Ar Cust"), Column("ACCT_AR_CUST"), Size(30)]
        public String AcctArCust
        {
            get { return Fields.AcctArCust[this]; }
            set { Fields.AcctArCust[this] = value; }
        }

        [DisplayName("Acct Ar Disc"), Column("ACCT_AR_DISC"), Size(30)]
        public String AcctArDisc
        {
            get { return Fields.AcctArDisc[this]; }
            set { Fields.AcctArDisc[this] = value; }
        }

        [DisplayName("Acct Ar Adj"), Column("ACCT_AR_ADJ"), Size(30)]
        public String AcctArAdj
        {
            get { return Fields.AcctArAdj[this]; }
            set { Fields.AcctArAdj[this] = value; }
        }

        [DisplayName("Acct Sls Trdisc"), Column("ACCT_SLS_TRDISC"), Size(30)]
        public String AcctSlsTrdisc
        {
            get { return Fields.AcctSlsTrdisc[this]; }
            set { Fields.AcctSlsTrdisc[this] = value; }
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

        [DisplayName("Payment Ccy"), Column("PAYMENT_CCY"), Size(4)]
        public String PaymentCcy
        {
            get { return Fields.PaymentCcy[this]; }
            set { Fields.PaymentCcy[this] = value; }
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

        [DisplayName("Use Alt Names"), Column("USE_ALT_NAMES"), Size(1)]
        [BoolStringConverter]
        public bool? UseAltNames
        {
            get { return Fields.UseAltNames[this]; }
            set { Fields.UseAltNames[this] = value; }
        }

        [DisplayName("With Cr Limit"), Column("WITH_CR_LIMIT"), Size(1)]
        [BoolStringConverter]
        public bool? WithCrLimit
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

        [DisplayName("Customer Count"), Column("CUSTOMER_COUNT"), Size(8)]
        public Decimal? CustomerCount
        {
            get { return Fields.CustomerCount[this]; }
            set { Fields.CustomerCount[this] = value; }
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

        [DisplayName("Acct Cust Sltax"), Column("ACCT_CUST_SLTAX"), Size(30)]
        public String AcctCustSltax
        {
            get { return Fields.AcctCustSltax[this]; }
            set { Fields.AcctCustSltax[this] = value; }
        }

        [DisplayName("Sltax Pcent"), Column("SLTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? SltaxPcent
        {
            get { return Fields.SltaxPcent[this]; }
            set { Fields.SltaxPcent[this] = value; }
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

        [DisplayName("Client Company Name"), Column("CLIENT_COMPANY_NAME"), Size(100)]
        public String ClientCompanyName
        {
            get { return Fields.ClientCompanyName[this]; }
            set { Fields.ClientCompanyName[this] = value; }
        }

        [DisplayName("Client Address 1"), Column("CLIENT_ADDRESS_1"), Size(100)]
        public String ClientAddress1
        {
            get { return Fields.ClientAddress1[this]; }
            set { Fields.ClientAddress1[this] = value; }
        }

        [DisplayName("Client Address 2"), Column("CLIENT_ADDRESS_2"), Size(100)]
        public String ClientAddress2
        {
            get { return Fields.ClientAddress2[this]; }
            set { Fields.ClientAddress2[this] = value; }
        }

        [DisplayName("Client Address 3"), Column("CLIENT_ADDRESS_3"), Size(100)]
        public String ClientAddress3
        {
            get { return Fields.ClientAddress3[this]; }
            set { Fields.ClientAddress3[this] = value; }
        }

        [DisplayName("Client Address 4"), Column("CLIENT_ADDRESS_4"), Size(100)]
        public String ClientAddress4
        {
            get { return Fields.ClientAddress4[this]; }
            set { Fields.ClientAddress4[this] = value; }
        }

        [DisplayName("Client Address 5"), Column("CLIENT_ADDRESS_5"), Size(100)]
        public String ClientAddress5
        {
            get { return Fields.ClientAddress5[this]; }
            set { Fields.ClientAddress5[this] = value; }
        }

        [DisplayName("Client Tel No"), Column("CLIENT_TEL_NO"), Size(20)]
        public String ClientTelNo
        {
            get { return Fields.ClientTelNo[this]; }
            set { Fields.ClientTelNo[this] = value; }
        }

        [DisplayName("Client Fax No"), Column("CLIENT_FAX_NO"), Size(20)]
        public String ClientFaxNo
        {
            get { return Fields.ClientFaxNo[this]; }
            set { Fields.ClientFaxNo[this] = value; }
        }

        [DisplayName("Client Email Address"), Column("CLIENT_EMAIL_ADDRESS"), Size(100)]
        public String ClientEmailAddress
        {
            get { return Fields.ClientEmailAddress[this]; }
            set { Fields.ClientEmailAddress[this] = value; }
        }

        [DisplayName("Client Contact Person"), Column("CLIENT_CONTACT_PERSON"), Size(100)]
        public String ClientContactPerson
        {
            get { return Fields.ClientContactPerson[this]; }
            set { Fields.ClientContactPerson[this] = value; }
        }

        [DisplayName("Client Contact Title"), Column("CLIENT_CONTACT_TITLE"), Size(100)]
        public String ClientContactTitle
        {
            get { return Fields.ClientContactTitle[this]; }
            set { Fields.ClientContactTitle[this] = value; }
        }

        [DisplayName("Client Remarks"), Column("CLIENT_REMARKS"), Size(400)]
        public String ClientRemarks
        {
            get { return Fields.ClientRemarks[this]; }
            set { Fields.ClientRemarks[this] = value; }
        }

        [DisplayName("Acct Ar Deposit"), Column("ACCT_AR_DEPOSIT"), Size(30)]
        public String AcctArDeposit
        {
            get { return Fields.AcctArDeposit[this]; }
            set { Fields.AcctArDeposit[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CustomerGroup; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CustomerGroup; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CustomerGroupRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField CustomerGroup;
            public StringField Description;
            public BooleanField Suspended;
            public StringField AcctArCust;
            public StringField AcctArDisc;
            public StringField AcctArAdj;
            public StringField AcctSlsTrdisc;
            public StringField GtaxCode;
            public StringField LtaxCode;
            public StringField PaymentCcy;
            public StringField PayTerms;
            public StringField PriceCode;
            public BooleanField UseAltNames;
            public BooleanField WithCrLimit;
            public DecimalField CreditLimit;
            public DecimalField TradeDiscount;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys3;
            public StringField Anlys4;
            public DecimalField CustomerCount;
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
            public StringField AcctCustSltax;
            public DecimalField SltaxPcent;
            public StringField Anlys5;
            public StringField Anlys6;
            public StringField Anlys7;
            public StringField Anlys8;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField AcctTemp;
            public StringField ClientCompanyName;
            public StringField ClientAddress1;
            public StringField ClientAddress2;
            public StringField ClientAddress3;
            public StringField ClientAddress4;
            public StringField ClientAddress5;
            public StringField ClientTelNo;
            public StringField ClientFaxNo;
            public StringField ClientEmailAddress;
            public StringField ClientContactPerson;
            public StringField ClientContactTitle;
            public StringField ClientRemarks;
            public StringField AcctArDeposit;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Enterprise.CustomerGroup";
            }
        }
    }
}
