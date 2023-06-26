#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VoucherTypeRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GLVOCH]")]
    [DisplayName("Voucher Type"), InstanceName("Voucher Type"), TwoLevelCached]   
    public sealed class VoucherTypeRow : Row, IIdRow, INameRow
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

        [DisplayName("Direct Entry"), Column("DIRECT_ENTRY"), Size(1)]
        [BoolStringConverter]
        public bool? DirectEntry
        {
            get { return Fields.DirectEntry[this]; }
            set { Fields.DirectEntry[this] = value; }
        }

        [DisplayName("Allow Edit"), Column("ALLOW_EDIT"), Size(1)]
        [BoolStringConverter]
        public bool? AllowEdit
        {
            get { return Fields.AllowEdit[this]; }
            set { Fields.AllowEdit[this] = value; }
        }

        [DisplayName("Multi Currency"), Column("MULTI_CURRENCY"), Size(1)]
        [BoolStringConverter]
        public bool? MultiCurrency
        {
            get { return Fields.MultiCurrency[this]; }
            set { Fields.MultiCurrency[this] = value; }
        }

        [DisplayName("Batched Posting"), Column("BATCHED_POSTING"), Size(1)]
        [BoolStringConverter]
        public bool? BatchedPosting
        {
            get { return Fields.BatchedPosting[this]; }
            set { Fields.BatchedPosting[this] = value; }
        }

        [DisplayName("Cost Ctr Opt"), Column("COST_CTR_OPT"), Size(1)]
        public String CostCtrOpt
        {
            get { return Fields.CostCtrOpt[this]; }
            set { Fields.CostCtrOpt[this] = value; }
        }

        [DisplayName("Dept Opt"), Column("DEPT_OPT"), Size(1)]
        public String DeptOpt
        {
            get { return Fields.DeptOpt[this]; }
            set { Fields.DeptOpt[this] = value; }
        }

        [DisplayName("Anlys1 Opt"), Column("ANLYS1_OPT"), Size(1)]
        public String Anlys1Opt
        {
            get { return Fields.Anlys1Opt[this]; }
            set { Fields.Anlys1Opt[this] = value; }
        }

        [DisplayName("Anlys2 Opt"), Column("ANLYS2_OPT"), Size(1)]
        public String Anlys2Opt
        {
            get { return Fields.Anlys2Opt[this]; }
            set { Fields.Anlys2Opt[this] = value; }
        }

        [DisplayName("Anlys3 Dr Opt"), Column("ANLYS3_DR_OPT"), Size(1)]
        public String Anlys3DrOpt
        {
            get { return Fields.Anlys3DrOpt[this]; }
            set { Fields.Anlys3DrOpt[this] = value; }
        }

        [DisplayName("Anlys4 Dr Opt"), Column("ANLYS4_DR_OPT"), Size(1)]
        public String Anlys4DrOpt
        {
            get { return Fields.Anlys4DrOpt[this]; }
            set { Fields.Anlys4DrOpt[this] = value; }
        }

        [DisplayName("Anlys5 Dr Opt"), Column("ANLYS5_DR_OPT"), Size(1)]
        public String Anlys5DrOpt
        {
            get { return Fields.Anlys5DrOpt[this]; }
            set { Fields.Anlys5DrOpt[this] = value; }
        }

        [DisplayName("Anlys6 Dr Opt"), Column("ANLYS6_DR_OPT"), Size(1)]
        public String Anlys6DrOpt
        {
            get { return Fields.Anlys6DrOpt[this]; }
            set { Fields.Anlys6DrOpt[this] = value; }
        }

        [DisplayName("Anlys3 Cr Opt"), Column("ANLYS3_CR_OPT"), Size(1)]
        public String Anlys3CrOpt
        {
            get { return Fields.Anlys3CrOpt[this]; }
            set { Fields.Anlys3CrOpt[this] = value; }
        }

        [DisplayName("Anlys4 Cr Opt"), Column("ANLYS4_CR_OPT"), Size(1)]
        public String Anlys4CrOpt
        {
            get { return Fields.Anlys4CrOpt[this]; }
            set { Fields.Anlys4CrOpt[this] = value; }
        }

        [DisplayName("Anlys5 Cr Opt"), Column("ANLYS5_CR_OPT"), Size(1)]
        public String Anlys5CrOpt
        {
            get { return Fields.Anlys5CrOpt[this]; }
            set { Fields.Anlys5CrOpt[this] = value; }
        }

        [DisplayName("Anlys6 Cr Opt"), Column("ANLYS6_CR_OPT"), Size(1)]
        public String Anlys6CrOpt
        {
            get { return Fields.Anlys6CrOpt[this]; }
            set { Fields.Anlys6CrOpt[this] = value; }
        }

        [DisplayName("Series Code"), Column("SERIES_CODE"), Size(8)]
        public String SeriesCode
        {
            get { return Fields.SeriesCode[this]; }
            set { Fields.SeriesCode[this] = value; }
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

        [DisplayName("Batch Count"), Column("BATCH_COUNT"), Size(8)]
        public Decimal? BatchCount
        {
            get { return Fields.BatchCount[this]; }
            set { Fields.BatchCount[this] = value; }
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

        [DisplayName("Remarks"), Column("REMARKS"), Size(212)]
        public String Remarks
        {
            get { return Fields.Remarks[this]; }
            set { Fields.Remarks[this] = value; }
        }

        [DisplayName("Anlys7 Opt"), Column("ANLYS7_OPT"), Size(1)]
        public String Anlys7Opt
        {
            get { return Fields.Anlys7Opt[this]; }
            set { Fields.Anlys7Opt[this] = value; }
        }

        [DisplayName("Anlys8 Opt"), Column("ANLYS8_OPT"), Size(1)]
        public String Anlys8Opt
        {
            get { return Fields.Anlys8Opt[this]; }
            set { Fields.Anlys8Opt[this] = value; }
        }

        [DisplayName("Anlys9 Opt"), Column("ANLYS9_OPT"), Size(1)]
        public String Anlys9Opt
        {
            get { return Fields.Anlys9Opt[this]; }
            set { Fields.Anlys9Opt[this] = value; }
        }

        [DisplayName("Anlys10 Opt"), Column("ANLYS10_OPT"), Size(1)]
        public String Anlys10Opt
        {
            get { return Fields.Anlys10Opt[this]; }
            set { Fields.Anlys10Opt[this] = value; }
        }

        [DisplayName("Anlys11 Opt"), Column("ANLYS11_OPT"), Size(1)]
        public String Anlys11Opt
        {
            get { return Fields.Anlys11Opt[this]; }
            set { Fields.Anlys11Opt[this] = value; }
        }

        [DisplayName("Anlys12 Opt"), Column("ANLYS12_OPT"), Size(1)]
        public String Anlys12Opt
        {
            get { return Fields.Anlys12Opt[this]; }
            set { Fields.Anlys12Opt[this] = value; }
        }

        [DisplayName("Anlys13 Opt"), Column("ANLYS13_OPT"), Size(1)]
        public String Anlys13Opt
        {
            get { return Fields.Anlys13Opt[this]; }
            set { Fields.Anlys13Opt[this] = value; }
        }

        [DisplayName("Anlys14 Opt"), Column("ANLYS14_OPT"), Size(1)]
        public String Anlys14Opt
        {
            get { return Fields.Anlys14Opt[this]; }
            set { Fields.Anlys14Opt[this] = value; }
        }

        [DisplayName("Anlys15 Dr Opt"), Column("ANLYS15_DR_OPT"), Size(1)]
        public String Anlys15DrOpt
        {
            get { return Fields.Anlys15DrOpt[this]; }
            set { Fields.Anlys15DrOpt[this] = value; }
        }

        [DisplayName("Anlys16 Dr Opt"), Column("ANLYS16_DR_OPT"), Size(1)]
        public String Anlys16DrOpt
        {
            get { return Fields.Anlys16DrOpt[this]; }
            set { Fields.Anlys16DrOpt[this] = value; }
        }

        [DisplayName("Anlys17 Dr Opt"), Column("ANLYS17_DR_OPT"), Size(1)]
        public String Anlys17DrOpt
        {
            get { return Fields.Anlys17DrOpt[this]; }
            set { Fields.Anlys17DrOpt[this] = value; }
        }

        [DisplayName("Anlys18 Dr Opt"), Column("ANLYS18_DR_OPT"), Size(1)]
        public String Anlys18DrOpt
        {
            get { return Fields.Anlys18DrOpt[this]; }
            set { Fields.Anlys18DrOpt[this] = value; }
        }

        [DisplayName("Anlys19 Dr Opt"), Column("ANLYS19_DR_OPT"), Size(1)]
        public String Anlys19DrOpt
        {
            get { return Fields.Anlys19DrOpt[this]; }
            set { Fields.Anlys19DrOpt[this] = value; }
        }

        [DisplayName("Anlys20 Dr Opt"), Column("ANLYS20_DR_OPT"), Size(1)]
        public String Anlys20DrOpt
        {
            get { return Fields.Anlys20DrOpt[this]; }
            set { Fields.Anlys20DrOpt[this] = value; }
        }

        [DisplayName("Anlys15 Cr Opt"), Column("ANLYS15_CR_OPT"), Size(1)]
        public String Anlys15CrOpt
        {
            get { return Fields.Anlys15CrOpt[this]; }
            set { Fields.Anlys15CrOpt[this] = value; }
        }

        [DisplayName("Anlys16 Cr Opt"), Column("ANLYS16_CR_OPT"), Size(1)]
        public String Anlys16CrOpt
        {
            get { return Fields.Anlys16CrOpt[this]; }
            set { Fields.Anlys16CrOpt[this] = value; }
        }

        [DisplayName("Anlys17 Cr Opt"), Column("ANLYS17_CR_OPT"), Size(1)]
        public String Anlys17CrOpt
        {
            get { return Fields.Anlys17CrOpt[this]; }
            set { Fields.Anlys17CrOpt[this] = value; }
        }

        [DisplayName("Anlys18 Cr Opt"), Column("ANLYS18_CR_OPT"), Size(1)]
        public String Anlys18CrOpt
        {
            get { return Fields.Anlys18CrOpt[this]; }
            set { Fields.Anlys18CrOpt[this] = value; }
        }

        [DisplayName("Anlys19 Cr Opt"), Column("ANLYS19_CR_OPT"), Size(1)]
        public String Anlys19CrOpt
        {
            get { return Fields.Anlys19CrOpt[this]; }
            set { Fields.Anlys19CrOpt[this] = value; }
        }

        [DisplayName("Anlys20 Cr Opt"), Column("ANLYS20_CR_OPT"), Size(1)]
        public String Anlys20CrOpt
        {
            get { return Fields.Anlys20CrOpt[this]; }
            set { Fields.Anlys20CrOpt[this] = value; }
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

        public VoucherTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField VoucherType;
            public StringField Description;
            public BooleanField Suspended;
            public BooleanField DirectEntry;
            public BooleanField AllowEdit;
            public BooleanField MultiCurrency;
            public BooleanField BatchedPosting;
            public StringField CostCtrOpt;
            public StringField DeptOpt;
            public StringField Anlys1Opt;
            public StringField Anlys2Opt;
            public StringField Anlys3DrOpt;
            public StringField Anlys4DrOpt;
            public StringField Anlys5DrOpt;
            public StringField Anlys6DrOpt;
            public StringField Anlys3CrOpt;
            public StringField Anlys4CrOpt;
            public StringField Anlys5CrOpt;
            public StringField Anlys6CrOpt;
            public StringField SeriesCode;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DecimalField BatchCount;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Remarks;
            public StringField Anlys7Opt;
            public StringField Anlys8Opt;
            public StringField Anlys9Opt;
            public StringField Anlys10Opt;
            public StringField Anlys11Opt;
            public StringField Anlys12Opt;
            public StringField Anlys13Opt;
            public StringField Anlys14Opt;
            public StringField Anlys15DrOpt;
            public StringField Anlys16DrOpt;
            public StringField Anlys17DrOpt;
            public StringField Anlys18DrOpt;
            public StringField Anlys19DrOpt;
            public StringField Anlys20DrOpt;
            public StringField Anlys15CrOpt;
            public StringField Anlys16CrOpt;
            public StringField Anlys17CrOpt;
            public StringField Anlys18CrOpt;
            public StringField Anlys19CrOpt;
            public StringField Anlys20CrOpt;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.VoucherType";
            }
        }
    }
}
