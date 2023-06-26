#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PeriodicVoucherDetailRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Finance.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Finance"), TableName("[dbo].[GLPERD]")]
    [DisplayName("Periodic Voucher Detail"), InstanceName("Periodic Voucher Detail"), TwoLevelCached]   
    public sealed class PeriodicVoucherDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Entry Key"), Column("ENTRY_KEY"), Size(6), PrimaryKey, ForeignKey("[dbo].[GLPERH]", "ENTRY_KEY"), LeftJoin("jEntryKey"), QuickSearch, TextualField("EntryKeyDescription")]
        public String EntryKey
        {
            get { return Fields.EntryKey[this]; }
            set { Fields.EntryKey[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), Size(6), PrimaryKey]
        public Decimal? LineNo
        {
            get { return Fields.LineNo[this]; }
            set { Fields.LineNo[this] = value; }
        }

        [DisplayName("Acct No"), Column("ACCT_NO"), Size(30)]
        public String AcctNo
        {
            get { return Fields.AcctNo[this]; }
            set { Fields.AcctNo[this] = value; }
        }

        [DisplayName("Acct Name"), Column("ACCT_NAME"), Size(50)]
        public String AcctName
        {
            get { return Fields.AcctName[this]; }
            set { Fields.AcctName[this] = value; }
        }

        [DisplayName("Branch No"), Column("BRANCH_NO"), Size(4)]
        public String BranchNo
        {
            get { return Fields.BranchNo[this]; }
            set { Fields.BranchNo[this] = value; }
        }

        [DisplayName("Cost Centre"), Column("COST_CENTRE"), Size(4)]
        public String CostCentre
        {
            get { return Fields.CostCentre[this]; }
            set { Fields.CostCentre[this] = value; }
        }

        [DisplayName("Dept"), Column("DEPT"), Size(4)]
        public String Dept
        {
            get { return Fields.Dept[this]; }
            set { Fields.Dept[this] = value; }
        }

        [DisplayName("Line Ref"), Column("LINE_REF"), Size(12)]
        public String LineRef
        {
            get { return Fields.LineRef[this]; }
            set { Fields.LineRef[this] = value; }
        }

        [DisplayName("Debit Amt"), Column("DEBIT_AMT"), Size(16), Scale(2)]
        public Decimal? DebitAmt
        {
            get { return Fields.DebitAmt[this]; }
            set { Fields.DebitAmt[this] = value; }
        }

        [DisplayName("Credit Amt"), Column("CREDIT_AMT"), Size(16), Scale(2)]
        public Decimal? CreditAmt
        {
            get { return Fields.CreditAmt[this]; }
            set { Fields.CreditAmt[this] = value; }
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

        [DisplayName("Particulars"), Column("PARTICULARS"), Size(1073741823)]
        public String Particulars
        {
            get { return Fields.Particulars[this]; }
            set { Fields.Particulars[this] = value; }
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

        [DisplayName("Entry Key Recnum"), Expression("jEntryKey.[RECNUM]")]
        public Decimal? EntryKeyRecnum
        {
            get { return Fields.EntryKeyRecnum[this]; }
            set { Fields.EntryKeyRecnum[this] = value; }
        }

        [DisplayName("Entry Key Description"), Expression("jEntryKey.[DESCRIPTION]")]
        public String EntryKeyDescription
        {
            get { return Fields.EntryKeyDescription[this]; }
            set { Fields.EntryKeyDescription[this] = value; }
        }

        [DisplayName("Entry Key Voucher Type"), Expression("jEntryKey.[VOUCHER_TYPE]")]
        public String EntryKeyVoucherType
        {
            get { return Fields.EntryKeyVoucherType[this]; }
            set { Fields.EntryKeyVoucherType[this] = value; }
        }

        [DisplayName("Entry Key Series Code"), Expression("jEntryKey.[SERIES_CODE]")]
        public String EntryKeySeriesCode
        {
            get { return Fields.EntryKeySeriesCode[this]; }
            set { Fields.EntryKeySeriesCode[this] = value; }
        }

        [DisplayName("Entry Key Ccy"), Expression("jEntryKey.[CCY]")]
        public String EntryKeyCcy
        {
            get { return Fields.EntryKeyCcy[this]; }
            set { Fields.EntryKeyCcy[this] = value; }
        }

        [DisplayName("Entry Key Suspended"), Expression("jEntryKey.[SUSPENDED]")]
        public String EntryKeySuspended
        {
            get { return Fields.EntryKeySuspended[this]; }
            set { Fields.EntryKeySuspended[this] = value; }
        }

        [DisplayName("Entry Key Effective From"), Expression("jEntryKey.[EFFECTIVE_FROM]")]
        public DateTime? EntryKeyEffectiveFrom
        {
            get { return Fields.EntryKeyEffectiveFrom[this]; }
            set { Fields.EntryKeyEffectiveFrom[this] = value; }
        }

        [DisplayName("Entry Key Effective To"), Expression("jEntryKey.[EFFECTIVE_TO]")]
        public DateTime? EntryKeyEffectiveTo
        {
            get { return Fields.EntryKeyEffectiveTo[this]; }
            set { Fields.EntryKeyEffectiveTo[this] = value; }
        }

        [DisplayName("Entry Key Last Line No"), Expression("jEntryKey.[LAST_LINE_NO]")]
        public Decimal? EntryKeyLastLineNo
        {
            get { return Fields.EntryKeyLastLineNo[this]; }
            set { Fields.EntryKeyLastLineNo[this] = value; }
        }

        [DisplayName("Entry Key Created Date"), Expression("jEntryKey.[CREATED_DATE]")]
        public DateTime? EntryKeyCreatedDate
        {
            get { return Fields.EntryKeyCreatedDate[this]; }
            set { Fields.EntryKeyCreatedDate[this] = value; }
        }

        [DisplayName("Entry Key Created By"), Expression("jEntryKey.[CREATED_BY]")]
        public String EntryKeyCreatedBy
        {
            get { return Fields.EntryKeyCreatedBy[this]; }
            set { Fields.EntryKeyCreatedBy[this] = value; }
        }

        [DisplayName("Entry Key Revised Date"), Expression("jEntryKey.[REVISED_DATE]")]
        public DateTime? EntryKeyRevisedDate
        {
            get { return Fields.EntryKeyRevisedDate[this]; }
            set { Fields.EntryKeyRevisedDate[this] = value; }
        }

        [DisplayName("Entry Key Revised By"), Expression("jEntryKey.[REVISED_BY]")]
        public String EntryKeyRevisedBy
        {
            get { return Fields.EntryKeyRevisedBy[this]; }
            set { Fields.EntryKeyRevisedBy[this] = value; }
        }

        [DisplayName("Entry Key Owner Branch"), Expression("jEntryKey.[OWNER_BRANCH]")]
        public String EntryKeyOwnerBranch
        {
            get { return Fields.EntryKeyOwnerBranch[this]; }
            set { Fields.EntryKeyOwnerBranch[this] = value; }
        }

        [DisplayName("Entry Key Source Branch"), Expression("jEntryKey.[SOURCE_BRANCH]")]
        public String EntryKeySourceBranch
        {
            get { return Fields.EntryKeySourceBranch[this]; }
            set { Fields.EntryKeySourceBranch[this] = value; }
        }

        [DisplayName("Entry Key Anlys1"), Expression("jEntryKey.[ANLYS1]")]
        public String EntryKeyAnlys1
        {
            get { return Fields.EntryKeyAnlys1[this]; }
            set { Fields.EntryKeyAnlys1[this] = value; }
        }

        [DisplayName("Entry Key Anlys2"), Expression("jEntryKey.[ANLYS2]")]
        public String EntryKeyAnlys2
        {
            get { return Fields.EntryKeyAnlys2[this]; }
            set { Fields.EntryKeyAnlys2[this] = value; }
        }

        [DisplayName("Entry Key Reference"), Expression("jEntryKey.[REFERENCE]")]
        public String EntryKeyReference
        {
            get { return Fields.EntryKeyReference[this]; }
            set { Fields.EntryKeyReference[this] = value; }
        }

        [DisplayName("Entry Key Total Debit"), Expression("jEntryKey.[TOTAL_DEBIT]")]
        public Decimal? EntryKeyTotalDebit
        {
            get { return Fields.EntryKeyTotalDebit[this]; }
            set { Fields.EntryKeyTotalDebit[this] = value; }
        }

        [DisplayName("Entry Key Total Credit"), Expression("jEntryKey.[TOTAL_CREDIT]")]
        public Decimal? EntryKeyTotalCredit
        {
            get { return Fields.EntryKeyTotalCredit[this]; }
            set { Fields.EntryKeyTotalCredit[this] = value; }
        }

        [DisplayName("Entry Key Particulars"), Expression("jEntryKey.[PARTICULARS]")]
        public String EntryKeyParticulars
        {
            get { return Fields.EntryKeyParticulars[this]; }
            set { Fields.EntryKeyParticulars[this] = value; }
        }

        [DisplayName("Entry Key Anlys7"), Expression("jEntryKey.[ANLYS7]")]
        public String EntryKeyAnlys7
        {
            get { return Fields.EntryKeyAnlys7[this]; }
            set { Fields.EntryKeyAnlys7[this] = value; }
        }

        [DisplayName("Entry Key Anlys8"), Expression("jEntryKey.[ANLYS8]")]
        public String EntryKeyAnlys8
        {
            get { return Fields.EntryKeyAnlys8[this]; }
            set { Fields.EntryKeyAnlys8[this] = value; }
        }

        [DisplayName("Entry Key Anlys9"), Expression("jEntryKey.[ANLYS9]")]
        public String EntryKeyAnlys9
        {
            get { return Fields.EntryKeyAnlys9[this]; }
            set { Fields.EntryKeyAnlys9[this] = value; }
        }

        [DisplayName("Entry Key Anlys10"), Expression("jEntryKey.[ANLYS10]")]
        public String EntryKeyAnlys10
        {
            get { return Fields.EntryKeyAnlys10[this]; }
            set { Fields.EntryKeyAnlys10[this] = value; }
        }

        [DisplayName("Entry Key Anlys11"), Expression("jEntryKey.[ANLYS11]")]
        public String EntryKeyAnlys11
        {
            get { return Fields.EntryKeyAnlys11[this]; }
            set { Fields.EntryKeyAnlys11[this] = value; }
        }

        [DisplayName("Entry Key Anlys12"), Expression("jEntryKey.[ANLYS12]")]
        public String EntryKeyAnlys12
        {
            get { return Fields.EntryKeyAnlys12[this]; }
            set { Fields.EntryKeyAnlys12[this] = value; }
        }

        [DisplayName("Entry Key Anlys13"), Expression("jEntryKey.[ANLYS13]")]
        public String EntryKeyAnlys13
        {
            get { return Fields.EntryKeyAnlys13[this]; }
            set { Fields.EntryKeyAnlys13[this] = value; }
        }

        [DisplayName("Entry Key Anlys14"), Expression("jEntryKey.[ANLYS14]")]
        public String EntryKeyAnlys14
        {
            get { return Fields.EntryKeyAnlys14[this]; }
            set { Fields.EntryKeyAnlys14[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.EntryKey; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PeriodicVoucherDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField EntryKey;
            public DecimalField LineNo;
            public StringField AcctNo;
            public StringField AcctName;
            public StringField BranchNo;
            public StringField CostCentre;
            public StringField Dept;
            public StringField LineRef;
            public DecimalField DebitAmt;
            public DecimalField CreditAmt;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField Anlys5;
            public StringField Anlys6;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField Particulars;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;
            public StringField Anlys19;
            public StringField Anlys20;

            public DecimalField EntryKeyRecnum;
            public StringField EntryKeyDescription;
            public StringField EntryKeyVoucherType;
            public StringField EntryKeySeriesCode;
            public StringField EntryKeyCcy;
            public StringField EntryKeySuspended;
            public DateTimeField EntryKeyEffectiveFrom;
            public DateTimeField EntryKeyEffectiveTo;
            public DecimalField EntryKeyLastLineNo;
            public DateTimeField EntryKeyCreatedDate;
            public StringField EntryKeyCreatedBy;
            public DateTimeField EntryKeyRevisedDate;
            public StringField EntryKeyRevisedBy;
            public StringField EntryKeyOwnerBranch;
            public StringField EntryKeySourceBranch;
            public StringField EntryKeyAnlys1;
            public StringField EntryKeyAnlys2;
            public StringField EntryKeyReference;
            public DecimalField EntryKeyTotalDebit;
            public DecimalField EntryKeyTotalCredit;
            public StringField EntryKeyParticulars;
            public StringField EntryKeyAnlys7;
            public StringField EntryKeyAnlys8;
            public StringField EntryKeyAnlys9;
            public StringField EntryKeyAnlys10;
            public StringField EntryKeyAnlys11;
            public StringField EntryKeyAnlys12;
            public StringField EntryKeyAnlys13;
            public StringField EntryKeyAnlys14;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.PeriodicVoucherDetail";
            }
        }
    }
}
