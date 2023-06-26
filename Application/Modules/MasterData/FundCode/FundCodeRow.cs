#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  FundCodeRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MasterData"), TableName("[dbo].[GBFUND]")]
    [DisplayName("Fund Code"), InstanceName("Fund Code"), TwoLevelCached]   
    public sealed class FundCodeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Fund Code"), Column("FUND_CODE"), Size(6), PrimaryKey, QuickSearch]
        public String FundCode
        {
            get { return Fields.FundCode[this]; }
            set { Fields.FundCode[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(30), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Rcpt Suspended"), Column("RCPT_SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? RcptSuspended
        {
            get { return Fields.RcptSuspended[this]; }
            set { Fields.RcptSuspended[this] = value; }
        }

        [DisplayName("Pmnt Suspended"), Column("PMNT_SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? PmntSuspended
        {
            get { return Fields.PmntSuspended[this]; }
            set { Fields.PmntSuspended[this] = value; }
        }

        [DisplayName("Default Ccy"), Column("DEFAULT_CCY"), Size(4)]
        public String DefaultCcy
        {
            get { return Fields.DefaultCcy[this]; }
            set { Fields.DefaultCcy[this] = value; }
        }

        [DisplayName("Fixed Currency"), Column("FIXED_CURRENCY"), Size(1)]
        [BoolStringConverter]
        public bool? FixedCurrency
        {
            get { return Fields.FixedCurrency[this]; }
            set { Fields.FixedCurrency[this] = value; }
        }

        [DisplayName("Is Bank Acct"), Column("IS_BANK_ACCT"), Size(1)]
        [BoolStringConverter]
        public bool? IsBankAcct
        {
            get { return Fields.IsBankAcct[this]; }
            set { Fields.IsBankAcct[this] = value; }
        }

        [DisplayName("Is Curr Acct"), Column("IS_CURR_ACCT"), Size(1)]
        [BoolStringConverter]
        public bool? IsCurrAcct
        {
            get { return Fields.IsCurrAcct[this]; }
            set { Fields.IsCurrAcct[this] = value; }
        }

        [DisplayName("Bank Acct No"), Column("BANK_ACCT_NO"), Size(20)]
        public String BankAcctNo
        {
            get { return Fields.BankAcctNo[this]; }
            set { Fields.BankAcctNo[this] = value; }
        }

        [DisplayName("Next Cheque No"), Column("NEXT_CHEQUE_NO"), Size(8)]
        public Decimal? NextChequeNo
        {
            get { return Fields.NextChequeNo[this]; }
            set { Fields.NextChequeNo[this] = value; }
        }

        [DisplayName("Acct Cash"), Column("ACCT_CASH"), Size(30)]
        public String AcctCash
        {
            get { return Fields.AcctCash[this]; }
            set { Fields.AcctCash[this] = value; }
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

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.FundCode; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public FundCodeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField FundCode;
            public StringField Description;
            public BooleanField RcptSuspended;
            public BooleanField PmntSuspended;
            public StringField DefaultCcy;
            public BooleanField FixedCurrency;
            public BooleanField IsBankAcct;
            public BooleanField IsCurrAcct;
            public StringField BankAcctNo;
            public DecimalField NextChequeNo;
            public StringField AcctCash;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.FundCode";
            }
        }
    }
}
