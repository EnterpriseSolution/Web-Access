#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VoucherPresetRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[GLVOPR]")]
    [DisplayName("Voucher Preset"), InstanceName("Voucher Preset"), TwoLevelCached]   
    public sealed class VoucherPresetRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Voucher Type"), Column("VOUCHER_TYPE"), Size(6), PrimaryKey, ForeignKey("[dbo].[GLVOCH]", "VOUCHER_TYPE"), LeftJoin("jVoucherType"), QuickSearch, TextualField("VoucherTypeDescription")]
        public String VoucherType
        {
            get { return Fields.VoucherType[this]; }
            set { Fields.VoucherType[this] = value; }
        }

        [DisplayName("Seq No"), Column("SEQ_NO"), Size(4), PrimaryKey]
        public Decimal? SeqNo
        {
            get { return Fields.SeqNo[this]; }
            set { Fields.SeqNo[this] = value; }
        }

        [DisplayName("Acct No"), Column("ACCT_NO"), Size(30)]
        public String AcctNo
        {
            get { return Fields.AcctNo[this]; }
            set { Fields.AcctNo[this] = value; }
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

        [DisplayName("Base Line No"), Column("BASE_LINE_NO"), Size(6)]
        public Decimal? BaseLineNo
        {
            get { return Fields.BaseLineNo[this]; }
            set { Fields.BaseLineNo[this] = value; }
        }

        [DisplayName("Base Entry"), Column("BASE_ENTRY"), Size(1)]
        public String BaseEntry
        {
            get { return Fields.BaseEntry[this]; }
            set { Fields.BaseEntry[this] = value; }
        }

        [DisplayName("Result Percent"), Column("RESULT_PERCENT"), Size(6), Scale(2)]
        public Decimal? ResultPercent
        {
            get { return Fields.ResultPercent[this]; }
            set { Fields.ResultPercent[this] = value; }
        }

        [DisplayName("Result Sign"), Column("RESULT_SIGN"), Size(1)]
        public String ResultSign
        {
            get { return Fields.ResultSign[this]; }
            set { Fields.ResultSign[this] = value; }
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

        [DisplayName("Voucher Type Recnum"), Expression("jVoucherType.[RECNUM]")]
        public Decimal? VoucherTypeRecnum
        {
            get { return Fields.VoucherTypeRecnum[this]; }
            set { Fields.VoucherTypeRecnum[this] = value; }
        }

        [DisplayName("Voucher Type Description"), Expression("jVoucherType.[DESCRIPTION]")]
        public String VoucherTypeDescription
        {
            get { return Fields.VoucherTypeDescription[this]; }
            set { Fields.VoucherTypeDescription[this] = value; }
        }

        [DisplayName("Voucher Type Suspended"), Expression("jVoucherType.[SUSPENDED]")]
        public String VoucherTypeSuspended
        {
            get { return Fields.VoucherTypeSuspended[this]; }
            set { Fields.VoucherTypeSuspended[this] = value; }
        }

        [DisplayName("Voucher Type Direct Entry"), Expression("jVoucherType.[DIRECT_ENTRY]")]
        public String VoucherTypeDirectEntry
        {
            get { return Fields.VoucherTypeDirectEntry[this]; }
            set { Fields.VoucherTypeDirectEntry[this] = value; }
        }

        [DisplayName("Voucher Type Allow Edit"), Expression("jVoucherType.[ALLOW_EDIT]")]
        public String VoucherTypeAllowEdit
        {
            get { return Fields.VoucherTypeAllowEdit[this]; }
            set { Fields.VoucherTypeAllowEdit[this] = value; }
        }

        [DisplayName("Voucher Type Multi Currency"), Expression("jVoucherType.[MULTI_CURRENCY]")]
        public String VoucherTypeMultiCurrency
        {
            get { return Fields.VoucherTypeMultiCurrency[this]; }
            set { Fields.VoucherTypeMultiCurrency[this] = value; }
        }

        [DisplayName("Voucher Type Batched Posting"), Expression("jVoucherType.[BATCHED_POSTING]")]
        public String VoucherTypeBatchedPosting
        {
            get { return Fields.VoucherTypeBatchedPosting[this]; }
            set { Fields.VoucherTypeBatchedPosting[this] = value; }
        }

        [DisplayName("Voucher Type Cost Ctr Opt"), Expression("jVoucherType.[COST_CTR_OPT]")]
        public String VoucherTypeCostCtrOpt
        {
            get { return Fields.VoucherTypeCostCtrOpt[this]; }
            set { Fields.VoucherTypeCostCtrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Dept Opt"), Expression("jVoucherType.[DEPT_OPT]")]
        public String VoucherTypeDeptOpt
        {
            get { return Fields.VoucherTypeDeptOpt[this]; }
            set { Fields.VoucherTypeDeptOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys1 Opt"), Expression("jVoucherType.[ANLYS1_OPT]")]
        public String VoucherTypeAnlys1Opt
        {
            get { return Fields.VoucherTypeAnlys1Opt[this]; }
            set { Fields.VoucherTypeAnlys1Opt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys2 Opt"), Expression("jVoucherType.[ANLYS2_OPT]")]
        public String VoucherTypeAnlys2Opt
        {
            get { return Fields.VoucherTypeAnlys2Opt[this]; }
            set { Fields.VoucherTypeAnlys2Opt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys3 Dr Opt"), Expression("jVoucherType.[ANLYS3_DR_OPT]")]
        public String VoucherTypeAnlys3DrOpt
        {
            get { return Fields.VoucherTypeAnlys3DrOpt[this]; }
            set { Fields.VoucherTypeAnlys3DrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys4 Dr Opt"), Expression("jVoucherType.[ANLYS4_DR_OPT]")]
        public String VoucherTypeAnlys4DrOpt
        {
            get { return Fields.VoucherTypeAnlys4DrOpt[this]; }
            set { Fields.VoucherTypeAnlys4DrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys5 Dr Opt"), Expression("jVoucherType.[ANLYS5_DR_OPT]")]
        public String VoucherTypeAnlys5DrOpt
        {
            get { return Fields.VoucherTypeAnlys5DrOpt[this]; }
            set { Fields.VoucherTypeAnlys5DrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys6 Dr Opt"), Expression("jVoucherType.[ANLYS6_DR_OPT]")]
        public String VoucherTypeAnlys6DrOpt
        {
            get { return Fields.VoucherTypeAnlys6DrOpt[this]; }
            set { Fields.VoucherTypeAnlys6DrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys3 Cr Opt"), Expression("jVoucherType.[ANLYS3_CR_OPT]")]
        public String VoucherTypeAnlys3CrOpt
        {
            get { return Fields.VoucherTypeAnlys3CrOpt[this]; }
            set { Fields.VoucherTypeAnlys3CrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys4 Cr Opt"), Expression("jVoucherType.[ANLYS4_CR_OPT]")]
        public String VoucherTypeAnlys4CrOpt
        {
            get { return Fields.VoucherTypeAnlys4CrOpt[this]; }
            set { Fields.VoucherTypeAnlys4CrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys5 Cr Opt"), Expression("jVoucherType.[ANLYS5_CR_OPT]")]
        public String VoucherTypeAnlys5CrOpt
        {
            get { return Fields.VoucherTypeAnlys5CrOpt[this]; }
            set { Fields.VoucherTypeAnlys5CrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys6 Cr Opt"), Expression("jVoucherType.[ANLYS6_CR_OPT]")]
        public String VoucherTypeAnlys6CrOpt
        {
            get { return Fields.VoucherTypeAnlys6CrOpt[this]; }
            set { Fields.VoucherTypeAnlys6CrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Series Code"), Expression("jVoucherType.[SERIES_CODE]")]
        public String VoucherTypeSeriesCode
        {
            get { return Fields.VoucherTypeSeriesCode[this]; }
            set { Fields.VoucherTypeSeriesCode[this] = value; }
        }

        [DisplayName("Voucher Type Created Date"), Expression("jVoucherType.[CREATED_DATE]")]
        public DateTime? VoucherTypeCreatedDate
        {
            get { return Fields.VoucherTypeCreatedDate[this]; }
            set { Fields.VoucherTypeCreatedDate[this] = value; }
        }

        [DisplayName("Voucher Type Created By"), Expression("jVoucherType.[CREATED_BY]")]
        public String VoucherTypeCreatedBy
        {
            get { return Fields.VoucherTypeCreatedBy[this]; }
            set { Fields.VoucherTypeCreatedBy[this] = value; }
        }

        [DisplayName("Voucher Type Revised Date"), Expression("jVoucherType.[REVISED_DATE]")]
        public DateTime? VoucherTypeRevisedDate
        {
            get { return Fields.VoucherTypeRevisedDate[this]; }
            set { Fields.VoucherTypeRevisedDate[this] = value; }
        }

        [DisplayName("Voucher Type Revised By"), Expression("jVoucherType.[REVISED_BY]")]
        public String VoucherTypeRevisedBy
        {
            get { return Fields.VoucherTypeRevisedBy[this]; }
            set { Fields.VoucherTypeRevisedBy[this] = value; }
        }

        [DisplayName("Voucher Type Batch Count"), Expression("jVoucherType.[BATCH_COUNT]")]
        public Decimal? VoucherTypeBatchCount
        {
            get { return Fields.VoucherTypeBatchCount[this]; }
            set { Fields.VoucherTypeBatchCount[this] = value; }
        }

        [DisplayName("Voucher Type Owner Branch"), Expression("jVoucherType.[OWNER_BRANCH]")]
        public String VoucherTypeOwnerBranch
        {
            get { return Fields.VoucherTypeOwnerBranch[this]; }
            set { Fields.VoucherTypeOwnerBranch[this] = value; }
        }

        [DisplayName("Voucher Type Source Branch"), Expression("jVoucherType.[SOURCE_BRANCH]")]
        public String VoucherTypeSourceBranch
        {
            get { return Fields.VoucherTypeSourceBranch[this]; }
            set { Fields.VoucherTypeSourceBranch[this] = value; }
        }

        [DisplayName("Voucher Type Remarks"), Expression("jVoucherType.[REMARKS]")]
        public String VoucherTypeRemarks
        {
            get { return Fields.VoucherTypeRemarks[this]; }
            set { Fields.VoucherTypeRemarks[this] = value; }
        }

        [DisplayName("Voucher Type Anlys7 Opt"), Expression("jVoucherType.[ANLYS7_OPT]")]
        public String VoucherTypeAnlys7Opt
        {
            get { return Fields.VoucherTypeAnlys7Opt[this]; }
            set { Fields.VoucherTypeAnlys7Opt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys8 Opt"), Expression("jVoucherType.[ANLYS8_OPT]")]
        public String VoucherTypeAnlys8Opt
        {
            get { return Fields.VoucherTypeAnlys8Opt[this]; }
            set { Fields.VoucherTypeAnlys8Opt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys9 Opt"), Expression("jVoucherType.[ANLYS9_OPT]")]
        public String VoucherTypeAnlys9Opt
        {
            get { return Fields.VoucherTypeAnlys9Opt[this]; }
            set { Fields.VoucherTypeAnlys9Opt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys10 Opt"), Expression("jVoucherType.[ANLYS10_OPT]")]
        public String VoucherTypeAnlys10Opt
        {
            get { return Fields.VoucherTypeAnlys10Opt[this]; }
            set { Fields.VoucherTypeAnlys10Opt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys11 Opt"), Expression("jVoucherType.[ANLYS11_OPT]")]
        public String VoucherTypeAnlys11Opt
        {
            get { return Fields.VoucherTypeAnlys11Opt[this]; }
            set { Fields.VoucherTypeAnlys11Opt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys12 Opt"), Expression("jVoucherType.[ANLYS12_OPT]")]
        public String VoucherTypeAnlys12Opt
        {
            get { return Fields.VoucherTypeAnlys12Opt[this]; }
            set { Fields.VoucherTypeAnlys12Opt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys13 Opt"), Expression("jVoucherType.[ANLYS13_OPT]")]
        public String VoucherTypeAnlys13Opt
        {
            get { return Fields.VoucherTypeAnlys13Opt[this]; }
            set { Fields.VoucherTypeAnlys13Opt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys14 Opt"), Expression("jVoucherType.[ANLYS14_OPT]")]
        public String VoucherTypeAnlys14Opt
        {
            get { return Fields.VoucherTypeAnlys14Opt[this]; }
            set { Fields.VoucherTypeAnlys14Opt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys15 Dr Opt"), Expression("jVoucherType.[ANLYS15_DR_OPT]")]
        public String VoucherTypeAnlys15DrOpt
        {
            get { return Fields.VoucherTypeAnlys15DrOpt[this]; }
            set { Fields.VoucherTypeAnlys15DrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys16 Dr Opt"), Expression("jVoucherType.[ANLYS16_DR_OPT]")]
        public String VoucherTypeAnlys16DrOpt
        {
            get { return Fields.VoucherTypeAnlys16DrOpt[this]; }
            set { Fields.VoucherTypeAnlys16DrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys17 Dr Opt"), Expression("jVoucherType.[ANLYS17_DR_OPT]")]
        public String VoucherTypeAnlys17DrOpt
        {
            get { return Fields.VoucherTypeAnlys17DrOpt[this]; }
            set { Fields.VoucherTypeAnlys17DrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys18 Dr Opt"), Expression("jVoucherType.[ANLYS18_DR_OPT]")]
        public String VoucherTypeAnlys18DrOpt
        {
            get { return Fields.VoucherTypeAnlys18DrOpt[this]; }
            set { Fields.VoucherTypeAnlys18DrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys19 Dr Opt"), Expression("jVoucherType.[ANLYS19_DR_OPT]")]
        public String VoucherTypeAnlys19DrOpt
        {
            get { return Fields.VoucherTypeAnlys19DrOpt[this]; }
            set { Fields.VoucherTypeAnlys19DrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys20 Dr Opt"), Expression("jVoucherType.[ANLYS20_DR_OPT]")]
        public String VoucherTypeAnlys20DrOpt
        {
            get { return Fields.VoucherTypeAnlys20DrOpt[this]; }
            set { Fields.VoucherTypeAnlys20DrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys15 Cr Opt"), Expression("jVoucherType.[ANLYS15_CR_OPT]")]
        public String VoucherTypeAnlys15CrOpt
        {
            get { return Fields.VoucherTypeAnlys15CrOpt[this]; }
            set { Fields.VoucherTypeAnlys15CrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys16 Cr Opt"), Expression("jVoucherType.[ANLYS16_CR_OPT]")]
        public String VoucherTypeAnlys16CrOpt
        {
            get { return Fields.VoucherTypeAnlys16CrOpt[this]; }
            set { Fields.VoucherTypeAnlys16CrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys17 Cr Opt"), Expression("jVoucherType.[ANLYS17_CR_OPT]")]
        public String VoucherTypeAnlys17CrOpt
        {
            get { return Fields.VoucherTypeAnlys17CrOpt[this]; }
            set { Fields.VoucherTypeAnlys17CrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys18 Cr Opt"), Expression("jVoucherType.[ANLYS18_CR_OPT]")]
        public String VoucherTypeAnlys18CrOpt
        {
            get { return Fields.VoucherTypeAnlys18CrOpt[this]; }
            set { Fields.VoucherTypeAnlys18CrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys19 Cr Opt"), Expression("jVoucherType.[ANLYS19_CR_OPT]")]
        public String VoucherTypeAnlys19CrOpt
        {
            get { return Fields.VoucherTypeAnlys19CrOpt[this]; }
            set { Fields.VoucherTypeAnlys19CrOpt[this] = value; }
        }

        [DisplayName("Voucher Type Anlys20 Cr Opt"), Expression("jVoucherType.[ANLYS20_CR_OPT]")]
        public String VoucherTypeAnlys20CrOpt
        {
            get { return Fields.VoucherTypeAnlys20CrOpt[this]; }
            set { Fields.VoucherTypeAnlys20CrOpt[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.VoucherType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VoucherPresetRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField VoucherType;
            public DecimalField SeqNo;
            public StringField AcctNo;
            public StringField Ccy;
            public DecimalField ExchRate;
            public DecimalField DebitAmt;
            public DecimalField CreditAmt;
            public DecimalField BaseLineNo;
            public StringField BaseEntry;
            public DecimalField ResultPercent;
            public StringField ResultSign;
            public StringField CostCentre;
            public StringField Dept;
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
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Particulars;

            public DecimalField VoucherTypeRecnum;
            public StringField VoucherTypeDescription;
            public StringField VoucherTypeSuspended;
            public StringField VoucherTypeDirectEntry;
            public StringField VoucherTypeAllowEdit;
            public StringField VoucherTypeMultiCurrency;
            public StringField VoucherTypeBatchedPosting;
            public StringField VoucherTypeCostCtrOpt;
            public StringField VoucherTypeDeptOpt;
            public StringField VoucherTypeAnlys1Opt;
            public StringField VoucherTypeAnlys2Opt;
            public StringField VoucherTypeAnlys3DrOpt;
            public StringField VoucherTypeAnlys4DrOpt;
            public StringField VoucherTypeAnlys5DrOpt;
            public StringField VoucherTypeAnlys6DrOpt;
            public StringField VoucherTypeAnlys3CrOpt;
            public StringField VoucherTypeAnlys4CrOpt;
            public StringField VoucherTypeAnlys5CrOpt;
            public StringField VoucherTypeAnlys6CrOpt;
            public StringField VoucherTypeSeriesCode;
            public DateTimeField VoucherTypeCreatedDate;
            public StringField VoucherTypeCreatedBy;
            public DateTimeField VoucherTypeRevisedDate;
            public StringField VoucherTypeRevisedBy;
            public DecimalField VoucherTypeBatchCount;
            public StringField VoucherTypeOwnerBranch;
            public StringField VoucherTypeSourceBranch;
            public StringField VoucherTypeRemarks;
            public StringField VoucherTypeAnlys7Opt;
            public StringField VoucherTypeAnlys8Opt;
            public StringField VoucherTypeAnlys9Opt;
            public StringField VoucherTypeAnlys10Opt;
            public StringField VoucherTypeAnlys11Opt;
            public StringField VoucherTypeAnlys12Opt;
            public StringField VoucherTypeAnlys13Opt;
            public StringField VoucherTypeAnlys14Opt;
            public StringField VoucherTypeAnlys15DrOpt;
            public StringField VoucherTypeAnlys16DrOpt;
            public StringField VoucherTypeAnlys17DrOpt;
            public StringField VoucherTypeAnlys18DrOpt;
            public StringField VoucherTypeAnlys19DrOpt;
            public StringField VoucherTypeAnlys20DrOpt;
            public StringField VoucherTypeAnlys15CrOpt;
            public StringField VoucherTypeAnlys16CrOpt;
            public StringField VoucherTypeAnlys17CrOpt;
            public StringField VoucherTypeAnlys18CrOpt;
            public StringField VoucherTypeAnlys19CrOpt;
            public StringField VoucherTypeAnlys20CrOpt;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.VoucherPreset";
            }
        }
    }
}
