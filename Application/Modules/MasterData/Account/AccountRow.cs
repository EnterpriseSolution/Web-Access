#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountRow.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;
using Matrix.Finance.Entities;
using Matrix.Sales.Entities;

namespace Matrix.MasterData.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MasterData"), TableName("[dbo].[GBACCT]")]
    [DisplayName("Account"), InstanceName("Account"), TwoLevelCached]   
    public sealed class AccountRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Account No"), Column("ACCT_NO"), Size(30), PrimaryKey, QuickSearch]
        public String AcctNo
        {
            get { return Fields.AcctNo[this]; }
            set { Fields.AcctNo[this] = value; }
        }

        [DisplayName("Account Name"), Column("ACCT_NAME"), Size(120), NotNull]
        public String AcctName
        {
            get { return Fields.AcctName[this]; }
            set { Fields.AcctName[this] = value; }
        }

        [DisplayName("Alt Acct No"), Column("ALT_ACCT_NO"), Size(30)]
        public String AltAcctNo
        {
            get { return Fields.AltAcctNo[this]; }
            set { Fields.AltAcctNo[this] = value; }
        }

        [DisplayName("Normal Sign"), Column("NORMAL_SIGN"), Size(1)]
        public String NormalSign
        {
            get { return Fields.NormalSign[this]; }
            set { Fields.NormalSign[this] = value; }
        }

        [DisplayName("Balance Sheet"), Column("TYPE_BS"), Size(1)]
        [Serenity.Data.BoolStringConverterAttribute]
        public bool? TypeBs
        {
            get { return Fields.TypeBs[this]; }
            set { Fields.TypeBs[this] = value; }
        }

        [DisplayName("Profit Lost"), Column("TYPE_PL"), Size(1)]
        [Serenity.Data.BoolStringConverterAttribute]
        public bool? TypePl
        {
            get { return Fields.TypePl[this]; }
            set { Fields.TypePl[this] = value; }
        }

        [DisplayName("Type Debtor"), Column("TYPE_DEBTOR"), Size(1)]
        public String TypeDebtor
        {
            get { return Fields.TypeDebtor[this]; }
            set { Fields.TypeDebtor[this] = value; }
        }

        [DisplayName("Type Creditor"), Column("TYPE_CREDITOR"), Size(1)]
        public String TypeCreditor
        {
            get { return Fields.TypeCreditor[this]; }
            set { Fields.TypeCreditor[this] = value; }
        }

        [DisplayName("Type Memo"), Column("TYPE_MEMO"), Size(1)]
        public String TypeMemo
        {
            get { return Fields.TypeMemo[this]; }
            set { Fields.TypeMemo[this] = value; }
        }

        [DisplayName("Default Ccy"), Column("DEFAULT_CCY"), Size(4)]
        public String DefaultCcy
        {
            get { return Fields.DefaultCcy[this]; }
            set { Fields.DefaultCcy[this] = value; }
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

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Fixed Currency"), Column("FIXED_CURRENCY"), Size(1)]
        public String FixedCurrency
        {
            get { return Fields.FixedCurrency[this]; }
            set { Fields.FixedCurrency[this] = value; }
        }

        [DisplayName("Auto Dist"), Column("AUTO_DIST"), Size(1)]
        public String AutoDist
        {
            get { return Fields.AutoDist[this]; }
            set { Fields.AutoDist[this] = value; }
        }

        [DisplayName("Budget Control"), Column("BUDGET_CONTROL"), Size(1)]
        public String BudgetControl
        {
            get { return Fields.BudgetControl[this]; }
            set { Fields.BudgetControl[this] = value; }
        }

        [DisplayName("Suppr Anlys3"), Column("SUPPR_ANLYS3"), Size(1)]
        public String SupprAnlys3
        {
            get { return Fields.SupprAnlys3[this]; }
            set { Fields.SupprAnlys3[this] = value; }
        }

        [DisplayName("Suppr Anlys4"), Column("SUPPR_ANLYS4"), Size(1)]
        public String SupprAnlys4
        {
            get { return Fields.SupprAnlys4[this]; }
            set { Fields.SupprAnlys4[this] = value; }
        }

        [DisplayName("Suppr Anlys5"), Column("SUPPR_ANLYS5"), Size(1)]
        public String SupprAnlys5
        {
            get { return Fields.SupprAnlys5[this]; }
            set { Fields.SupprAnlys5[this] = value; }
        }

        [DisplayName("Suppr Anlys6"), Column("SUPPR_ANLYS6"), Size(1)]
        public String SupprAnlys6
        {
            get { return Fields.SupprAnlys6[this]; }
            set { Fields.SupprAnlys6[this] = value; }
        }

        [DisplayName("Suppr Reval"), Column("SUPPR_REVAL"), Size(1)]
        public String SupprReval
        {
            get { return Fields.SupprReval[this]; }
            set { Fields.SupprReval[this] = value; }
        }

        [DisplayName("No Cost Centre"), Column("NO_COST_CENTRE"), Size(1)]
        public String NoCostCentre
        {
            get { return Fields.NoCostCentre[this]; }
            set { Fields.NoCostCentre[this] = value; }
        }

        [DisplayName("No Dept"), Column("NO_DEPT"), Size(1)]
        public String NoDept
        {
            get { return Fields.NoDept[this]; }
            set { Fields.NoDept[this] = value; }
        }

        [DisplayName("Oper1"), Column("OPER1"), Size(1)]
        public String Oper1
        {
            get { return Fields.Oper1[this]; }
            set { Fields.Oper1[this] = value; }
        }

        [DisplayName("Oper2"), Column("OPER2"), Size(1)]
        public String Oper2
        {
            get { return Fields.Oper2[this]; }
            set { Fields.Oper2[this] = value; }
        }

        [DisplayName("Oper3"), Column("OPER3"), Size(1)]
        public String Oper3
        {
            get { return Fields.Oper3[this]; }
            set { Fields.Oper3[this] = value; }
        }

        [DisplayName("Oper4"), Column("OPER4"), Size(1)]
        public String Oper4
        {
            get { return Fields.Oper4[this]; }
            set { Fields.Oper4[this] = value; }
        }

        [DisplayName("Oper5"), Column("OPER5"), Size(1)]
        public String Oper5
        {
            get { return Fields.Oper5[this]; }
            set { Fields.Oper5[this] = value; }
        }

        [DisplayName("Lines Bef Print"), Column("LINES_BEF_PRINT"), Size(2)]
        public Decimal? LinesBefPrint
        {
            get { return Fields.LinesBefPrint[this]; }
            set { Fields.LinesBefPrint[this] = value; }
        }

        [DisplayName("Tran Acct"), Column("TRAN_ACCT"), Size(1)]
        public String TranAcct
        {
            get { return Fields.TranAcct[this]; }
            set { Fields.TranAcct[this] = value; }
        }

        [DisplayName("Summary Pos"), Column("SUMMARY_POS"), Size(10)]
        public String SummaryPos
        {
            get { return Fields.SummaryPos[this]; }
            set { Fields.SummaryPos[this] = value; }
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

        [DisplayName("Recon Last Date"), Column("RECON_LAST_DATE")]
        public DateTime? ReconLastDate
        {
            get { return Fields.ReconLastDate[this]; }
            set { Fields.ReconLastDate[this] = value; }
        }

        [DisplayName("Recon Last Jrn"), Column("RECON_LAST_JRN"), Size(8)]
        public Decimal? ReconLastJrn
        {
            get { return Fields.ReconLastJrn[this]; }
            set { Fields.ReconLastJrn[this] = value; }
        }

        [DisplayName("Recon Bal"), Column("RECON_BAL"), Size(16), Scale(2)]
        public Decimal? ReconBal
        {
            get { return Fields.ReconBal[this]; }
            set { Fields.ReconBal[this] = value; }
        }

        [DisplayName("Recon Bal Sign"), Column("RECON_BAL_SIGN"), Size(6)]
        public String ReconBalSign
        {
            get { return Fields.ReconBalSign[this]; }
            set { Fields.ReconBalSign[this] = value; }
        }

        [DisplayName("Last Tran Date"), Column("LAST_TRAN_DATE")]
        public DateTime? LastTranDate
        {
            get { return Fields.LastTranDate[this]; }
            set { Fields.LastTranDate[this] = value; }
        }

        [DisplayName("Last Jrn No"), Column("LAST_JRN_NO"), Size(8)]
        public Decimal? LastJrnNo
        {
            get { return Fields.LastJrnNo[this]; }
            set { Fields.LastJrnNo[this] = value; }
        }

        [DisplayName("Dist Total Pct"), Column("DIST_TOTAL_PCT"), Size(8), Scale(2)]
        public Decimal? DistTotalPct
        {
            get { return Fields.DistTotalPct[this]; }
            set { Fields.DistTotalPct[this] = value; }
        }

        [DisplayName("Dist Last Line"), Column("DIST_LAST_LINE"), Size(6)]
        public Decimal? DistLastLine
        {
            get { return Fields.DistLastLine[this]; }
            set { Fields.DistLastLine[this] = value; }
        }

        [DisplayName("Recon Count"), Column("RECON_COUNT"), Size(4)]
        public Decimal? ReconCount
        {
            get { return Fields.ReconCount[this]; }
            set { Fields.ReconCount[this] = value; }
        }

        [DisplayName("Balance End"), Column("BALANCE_END"), Size(16), Scale(2)]
        public Decimal? BalanceEnd
        {
            get { return Fields.BalanceEnd[this]; }
            set { Fields.BalanceEnd[this] = value; }
        }

        [DisplayName("Balance Sign"), Column("BALANCE_SIGN"), Size(6)]
        public String BalanceSign
        {
            get { return Fields.BalanceSign[this]; }
            set { Fields.BalanceSign[this] = value; }
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

        [DisplayName("Allow Edit"), Column("ALLOW_EDIT"), Size(1)]
        public String AllowEdit
        {
            get { return Fields.AllowEdit[this]; }
            set { Fields.AllowEdit[this] = value; }
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

        IIdField IIdRow.IdField
        {
            get { return Fields.AcctNo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.AcctName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        [MasterDetailRelation(foreignKey: "AcctNo")]
        [DisplayName("Detail List"), NotMapped]
        public List<AccountBudgetRow> DetailList
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }


        public AccountRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public RowListField<AccountBudgetRow> DetailList;


            public DecimalField Recnum;
            public StringField AcctNo;
            public StringField AcctName;
            public StringField AltAcctNo;
            public StringField NormalSign;
            public BooleanField TypeBs;
            public BooleanField TypePl;
            public StringField TypeDebtor;
            public StringField TypeCreditor;
            public StringField TypeMemo;
            public StringField DefaultCcy;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys3;
            public StringField Anlys4;
            public BooleanField Suspended;
            public StringField FixedCurrency;
            public StringField AutoDist;
            public StringField BudgetControl;
            public StringField SupprAnlys3;
            public StringField SupprAnlys4;
            public StringField SupprAnlys5;
            public StringField SupprAnlys6;
            public StringField SupprReval;
            public StringField NoCostCentre;
            public StringField NoDept;
            public StringField Oper1;
            public StringField Oper2;
            public StringField Oper3;
            public StringField Oper4;
            public StringField Oper5;
            public DecimalField LinesBefPrint;
            public StringField TranAcct;
            public StringField SummaryPos;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField ReconLastDate;
            public DecimalField ReconLastJrn;
            public DecimalField ReconBal;
            public StringField ReconBalSign;
            public DateTimeField LastTranDate;
            public DecimalField LastJrnNo;
            public DecimalField DistTotalPct;
            public DecimalField DistLastLine;
            public DecimalField ReconCount;
            public DecimalField BalanceEnd;
            public StringField BalanceSign;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField AllowEdit;
            public StringField Anlys5;
            public StringField Anlys6;
            public StringField Anlys7;
            public StringField Anlys8;
            public StringField Anlys9;
            public StringField Anlys10;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Account";
            }
        }
    }
}
