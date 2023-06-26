#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VoucherRow.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;

namespace Matrix.Finance.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Finance"), TableName("[dbo].[GLVOUH]")]
    [DisplayName("Voucher Processing"), InstanceName("Voucher Processing"), TwoLevelCached]   
    public sealed class VoucherRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Voucher Type"), Column("VOUCHER_TYPE"), Size(6), PrimaryKey, QuickSearch]
        public String VoucherType
        {
            get { return Fields.VoucherType[this]; }
            set { Fields.VoucherType[this] = value; }
        }

        [DisplayName("Voucher No"), Column("VOUCHER_NO"), Size(16), PrimaryKey]
        public String VoucherNo
        {
            get { return Fields.VoucherNo[this]; }
            set { Fields.VoucherNo[this] = value; }
        }

        [DisplayName("Posted"), Column("POSTED"), Size(1), NotNull]
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Hold"), Column("HOLD"), Size(1)]
        public String Hold
        {
            get { return Fields.Hold[this]; }
            set { Fields.Hold[this] = value; }
        }

        [DisplayName("Voucher Date"), Column("VOUCHER_DATE")]
        public DateTime? VoucherDate
        {
            get { return Fields.VoucherDate[this]; }
            set { Fields.VoucherDate[this] = value; }
        }

        [DisplayName("Period"), Column("PERIOD"), Size(7)]
        public String Period
        {
            get { return Fields.Period[this]; }
            set { Fields.Period[this] = value; }
        }

        [DisplayName("Fiscal Year"), Column("FISCAL_YEAR"), Size(4)]
        public Decimal? FiscalYear
        {
            get { return Fields.FiscalYear[this]; }
            set { Fields.FiscalYear[this] = value; }
        }

        [DisplayName("Period No"), Column("PERIOD_NO"), Size(2)]
        public Decimal? PeriodNo
        {
            get { return Fields.PeriodNo[this]; }
            set { Fields.PeriodNo[this] = value; }
        }

        [DisplayName("Reference"), Column("REFERENCE"), Size(30)]
        public String Reference
        {
            get { return Fields.Reference[this]; }
            set { Fields.Reference[this] = value; }
        }

        [DisplayName("Last Line No"), Column("LAST_LINE_NO"), Size(8)]
        public Decimal? LastLineNo
        {
            get { return Fields.LastLineNo[this]; }
            set { Fields.LastLineNo[this] = value; }
        }

        [DisplayName("Line Count"), Column("LINE_COUNT"), Size(6)]
        public Decimal? LineCount
        {
            get { return Fields.LineCount[this]; }
            set { Fields.LineCount[this] = value; }
        }

        [DisplayName("Total Debit"), Column("TOTAL_DEBIT"), Size(16), Scale(2)]
        public Decimal? TotalDebit
        {
            get { return Fields.TotalDebit[this]; }
            set { Fields.TotalDebit[this] = value; }
        }

        [DisplayName("Total Credit"), Column("TOTAL_CREDIT"), Size(16), Scale(2)]
        public Decimal? TotalCredit
        {
            get { return Fields.TotalCredit[this]; }
            set { Fields.TotalCredit[this] = value; }
        }

        [DisplayName("Balance"), Column("BALANCE"), Size(16), Scale(2)]
        public Decimal? Balance
        {
            get { return Fields.Balance[this]; }
            set { Fields.Balance[this] = value; }
        }

        [DisplayName("Balance Sign"), Column("BALANCE_SIGN"), Size(6)]
        public String BalanceSign
        {
            get { return Fields.BalanceSign[this]; }
            set { Fields.BalanceSign[this] = value; }
        }

        [DisplayName("Journal No"), Column("JOURNAL_NO"), Size(8), NotNull]
        public Decimal? JournalNo
        {
            get { return Fields.JournalNo[this]; }
            set { Fields.JournalNo[this] = value; }
        }

        [DisplayName("Source Type"), Column("SOURCE_TYPE"), Size(16)]
        public String SourceType
        {
            get { return Fields.SourceType[this]; }
            set { Fields.SourceType[this] = value; }
        }

        [DisplayName("Source Ref"), Column("SOURCE_REF"), Size(16)]
        public String SourceRef
        {
            get { return Fields.SourceRef[this]; }
            set { Fields.SourceRef[this] = value; }
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

        [DisplayName("Batch Select"), Column("BATCH_SELECT"), Size(1)]
        public String BatchSelect
        {
            get { return Fields.BatchSelect[this]; }
            set { Fields.BatchSelect[this] = value; }
        }

        [DisplayName("Local Ccy Only"), Column("LOCAL_CCY_ONLY"), Size(1)]
        public String LocalCcyOnly
        {
            get { return Fields.LocalCcyOnly[this]; }
            set { Fields.LocalCcyOnly[this] = value; }
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

        [DisplayName("Posted By"), Column("POSTED_BY"), Size(10)]
        public String PostedBy
        {
            get { return Fields.PostedBy[this]; }
            set { Fields.PostedBy[this] = value; }
        }

        [DisplayName("Posted Date"), Column("POSTED_DATE")]
        public DateTime? PostedDate
        {
            get { return Fields.PostedDate[this]; }
            set { Fields.PostedDate[this] = value; }
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

        [DisplayName("Particulars"), Column("PARTICULARS"), Size(1073741823)]
        public String Particulars
        {
            get { return Fields.Particulars[this]; }
            set { Fields.Particulars[this] = value; }
        }

        [DisplayName("Ai Link"), Column("AI_LINK"), Size(1), NotNull]
        public String AiLink
        {
            get { return Fields.AiLink[this]; }
            set { Fields.AiLink[this] = value; }
        }

        [DisplayName("Ai Link Type"), Column("AI_LINK_TYPE"), Size(6)]
        public String AiLinkType
        {
            get { return Fields.AiLinkType[this]; }
            set { Fields.AiLinkType[this] = value; }
        }

        [DisplayName("Ai Link No"), Column("AI_LINK_NO"), Size(16)]
        public String AiLinkNo
        {
            get { return Fields.AiLinkNo[this]; }
            set { Fields.AiLinkNo[this] = value; }
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

        [DisplayName("Exported Date"), Column("EXPORTED_DATE")]
        public DateTime? ExportedDate
        {
            get { return Fields.ExportedDate[this]; }
            set { Fields.ExportedDate[this] = value; }
        }

        [DisplayName("Fserialno"), Column("FSERIALNO"), Size(8)]
        public Decimal? Fserialno
        {
            get { return Fields.Fserialno[this]; }
            set { Fields.Fserialno[this] = value; }
        }

        [DisplayName("Fnum"), Column("FNUM"), Size(8)]
        public Decimal? Fnum
        {
            get { return Fields.Fnum[this]; }
            set { Fields.Fnum[this] = value; }
        }

        [DisplayName("Round No"), Column("ROUND_NO"), Size(8), NotNull]
        public Decimal? RoundNo
        {
            get { return Fields.RoundNo[this]; }
            set { Fields.RoundNo[this] = value; }
        }

        [DisplayName("New Voucher No"), Column("NEW_VOUCHER_NO"), Size(20)]
        public String NewVoucherNo
        {
            get { return Fields.NewVoucherNo[this]; }
            set { Fields.NewVoucherNo[this] = value; }
        }

        [DisplayName("Fgroup"), Column("FGROUP"), Size(8)]
        public String Fgroup
        {
            get { return Fields.Fgroup[this]; }
            set { Fields.Fgroup[this] = value; }
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

        [DisplayName("Manual Edited"), Column("MANUAL_EDITED")]
        public Boolean? ManualEdited
        {
            get { return Fields.ManualEdited[this]; }
            set { Fields.ManualEdited[this] = value; }
        }

        [DisplayName("Remark"), Column("REMARK"), Size(100)]
        public String Remark
        {
            get { return Fields.Remark[this]; }
            set { Fields.Remark[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.VoucherNo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.VoucherType; }
        }

        [MasterDetailRelation(foreignKey: "VoucherNo")]
        [DisplayName("Detail List"), NotMapped]
        public List<VoucherDetailRow> DetailList
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VoucherRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public RowListField<VoucherDetailRow> DetailList;

            public DecimalField Recnum;
            public StringField VoucherType;
            public StringField VoucherNo;
            public StringField Posted;
            public StringField Hold;
            public DateTimeField VoucherDate;
            public StringField Period;
            public DecimalField FiscalYear;
            public DecimalField PeriodNo;
            public StringField Reference;
            public DecimalField LastLineNo;
            public DecimalField LineCount;
            public DecimalField TotalDebit;
            public DecimalField TotalCredit;
            public DecimalField Balance;
            public StringField BalanceSign;
            public DecimalField JournalNo;
            public StringField SourceType;
            public StringField SourceRef;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField BatchSelect;
            public StringField LocalCcyOnly;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField PostedBy;
            public DateTimeField PostedDate;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Particulars;
            public StringField AiLink;
            public StringField AiLinkType;
            public StringField AiLinkNo;
            public StringField Anlys7;
            public StringField Anlys8;
            public DateTimeField ExportedDate;
            public DecimalField Fserialno;
            public DecimalField Fnum;
            public DecimalField RoundNo;
            public StringField NewVoucherNo;
            public StringField Fgroup;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;
            public BooleanField ManualEdited;
            public StringField Remark;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.Voucher";
            }
        }
    }
}
