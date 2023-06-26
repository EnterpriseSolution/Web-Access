#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ChargeTypeRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBCHGS]")]
    [DisplayName("Speical Charge"), InstanceName("Speical Charge"), TwoLevelCached]   
    public sealed class ChargeTypeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Charge Type"), Column("CHARGE_TYPE"), Size(6), PrimaryKey, QuickSearch]
        public String ChargeType
        {
            get { return Fields.ChargeType[this]; }
            set { Fields.ChargeType[this] = value; }
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

        [DisplayName("Deduction"), Column("DEDUCTION"), Size(1)]
        [BoolStringConverter]
        public bool? Deduction
        {
            get { return Fields.Deduction[this]; }
            set { Fields.Deduction[this] = value; }
        }

        [DisplayName("Use In Sales"), Column("USE_IN_SALES"), Size(1), NotNull]
        [BoolStringConverter]
        public bool? UseInSales
        {
            get { return Fields.UseInSales[this]; }
            set { Fields.UseInSales[this] = value; }
        }

        [DisplayName("Use In Purchase"), Column("USE_IN_PURCHASE"), Size(1), NotNull]
        [BoolStringConverter]
        public bool? UseInPurchase
        {
            get { return Fields.UseInPurchase[this]; }
            set { Fields.UseInPurchase[this] = value; }
        }

        [DisplayName("Sls Acct No"), Column("SLS_ACCT_NO"), Size(30)]
        public String SlsAcctNo
        {
            get { return Fields.SlsAcctNo[this]; }
            set { Fields.SlsAcctNo[this] = value; }
        }

        [DisplayName("Pur Acct No"), Column("PUR_ACCT_NO"), Size(30)]
        public String PurAcctNo
        {
            get { return Fields.PurAcctNo[this]; }
            set { Fields.PurAcctNo[this] = value; }
        }

        [DisplayName("Fixed Rate"), Column("FIXED_RATE"), Size(1)]
        public String FixedRate
        {
            get { return Fields.FixedRate[this]; }
            set { Fields.FixedRate[this] = value; }
        }

        [DisplayName("Fixed Basis"), Column("FIXED_BASIS"), Size(1)]
        public String FixedBasis
        {
            get { return Fields.FixedBasis[this]; }
            set { Fields.FixedBasis[this] = value; }
        }

        [DisplayName("Fixed Percent"), Column("FIXED_PERCENT"), Size(6), Scale(2)]
        public Decimal? FixedPercent
        {
            get { return Fields.FixedPercent[this]; }
            set { Fields.FixedPercent[this] = value; }
        }

        [DisplayName("Fixed Amt"), Column("FIXED_AMT"), Size(16), Scale(2)]
        public Decimal? FixedAmt
        {
            get { return Fields.FixedAmt[this]; }
            set { Fields.FixedAmt[this] = value; }
        }

        [DisplayName("Step01"), Column("STEP01"), Size(1)]
        public String Step01
        {
            get { return Fields.Step01[this]; }
            set { Fields.Step01[this] = value; }
        }

        [DisplayName("Oper01"), Column("OPER01"), Size(1)]
        public String Oper01
        {
            get { return Fields.Oper01[this]; }
            set { Fields.Oper01[this] = value; }
        }

        [DisplayName("Step02"), Column("STEP02"), Size(1)]
        public String Step02
        {
            get { return Fields.Step02[this]; }
            set { Fields.Step02[this] = value; }
        }

        [DisplayName("Oper02"), Column("OPER02"), Size(1)]
        public String Oper02
        {
            get { return Fields.Oper02[this]; }
            set { Fields.Oper02[this] = value; }
        }

        [DisplayName("Step03"), Column("STEP03"), Size(1)]
        public String Step03
        {
            get { return Fields.Step03[this]; }
            set { Fields.Step03[this] = value; }
        }

        [DisplayName("Oper03"), Column("OPER03"), Size(1)]
        public String Oper03
        {
            get { return Fields.Oper03[this]; }
            set { Fields.Oper03[this] = value; }
        }

        [DisplayName("Step04"), Column("STEP04"), Size(1)]
        public String Step04
        {
            get { return Fields.Step04[this]; }
            set { Fields.Step04[this] = value; }
        }

        [DisplayName("Oper04"), Column("OPER04"), Size(1)]
        public String Oper04
        {
            get { return Fields.Oper04[this]; }
            set { Fields.Oper04[this] = value; }
        }

        [DisplayName("Step05"), Column("STEP05"), Size(1)]
        public String Step05
        {
            get { return Fields.Step05[this]; }
            set { Fields.Step05[this] = value; }
        }

        [DisplayName("Oper05"), Column("OPER05"), Size(1)]
        public String Oper05
        {
            get { return Fields.Oper05[this]; }
            set { Fields.Oper05[this] = value; }
        }

        [DisplayName("Step06"), Column("STEP06"), Size(1)]
        public String Step06
        {
            get { return Fields.Step06[this]; }
            set { Fields.Step06[this] = value; }
        }

        [DisplayName("Oper06"), Column("OPER06"), Size(1)]
        public String Oper06
        {
            get { return Fields.Oper06[this]; }
            set { Fields.Oper06[this] = value; }
        }

        [DisplayName("Step07"), Column("STEP07"), Size(1)]
        public String Step07
        {
            get { return Fields.Step07[this]; }
            set { Fields.Step07[this] = value; }
        }

        [DisplayName("Oper07"), Column("OPER07"), Size(1)]
        public String Oper07
        {
            get { return Fields.Oper07[this]; }
            set { Fields.Oper07[this] = value; }
        }

        [DisplayName("Step08"), Column("STEP08"), Size(1)]
        public String Step08
        {
            get { return Fields.Step08[this]; }
            set { Fields.Step08[this] = value; }
        }

        [DisplayName("Oper08"), Column("OPER08"), Size(1)]
        public String Oper08
        {
            get { return Fields.Oper08[this]; }
            set { Fields.Oper08[this] = value; }
        }

        [DisplayName("Step09"), Column("STEP09"), Size(1)]
        public String Step09
        {
            get { return Fields.Step09[this]; }
            set { Fields.Step09[this] = value; }
        }

        [DisplayName("Oper09"), Column("OPER09"), Size(1)]
        public String Oper09
        {
            get { return Fields.Oper09[this]; }
            set { Fields.Oper09[this] = value; }
        }

        [DisplayName("Step10"), Column("STEP10"), Size(1)]
        public String Step10
        {
            get { return Fields.Step10[this]; }
            set { Fields.Step10[this] = value; }
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

        [DisplayName("Use In Production"), Column("USE_IN_PRODUCTION"), Size(1)]
        public String UseInProduction
        {
            get { return Fields.UseInProduction[this]; }
            set { Fields.UseInProduction[this] = value; }
        }

        [DisplayName("Prod Acct No"), Column("PROD_ACCT_NO"), Size(30)]
        public String ProdAcctNo
        {
            get { return Fields.ProdAcctNo[this]; }
            set { Fields.ProdAcctNo[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ChargeType; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Description; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ChargeTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField ChargeType;
            public StringField Description;
            public BooleanField Suspended;
            public BooleanField Deduction;
            public BooleanField UseInSales;
            public BooleanField UseInPurchase;
            public StringField SlsAcctNo;
            public StringField PurAcctNo;
            public StringField FixedRate;
            public StringField FixedBasis;
            public DecimalField FixedPercent;
            public DecimalField FixedAmt;
            public StringField Step01;
            public StringField Oper01;
            public StringField Step02;
            public StringField Oper02;
            public StringField Step03;
            public StringField Oper03;
            public StringField Step04;
            public StringField Oper04;
            public StringField Step05;
            public StringField Oper05;
            public StringField Step06;
            public StringField Oper06;
            public StringField Step07;
            public StringField Oper07;
            public StringField Step08;
            public StringField Oper08;
            public StringField Step09;
            public StringField Oper09;
            public StringField Step10;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField UseInProduction;
            public StringField ProdAcctNo;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.ChargeType";
            }
        }
    }
}
