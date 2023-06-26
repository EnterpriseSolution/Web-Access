#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivablePaymentDepositRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[ARPAYP]")]
    [DisplayName("Accounts Receivable Payment Deposit"), InstanceName("Accounts Receivable Payment Deposit"), TwoLevelCached]   
    public sealed class AccountsReceivablePaymentDepositRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Receipt No"), Column("RECEIPT_NO"), Size(16), PrimaryKey, QuickSearch]
        public String ReceiptNo
        {
            get { return Fields.ReceiptNo[this]; }
            set { Fields.ReceiptNo[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), PrimaryKey]
        public Int32? LineNo
        {
            get { return Fields.LineNo[this]; }
            set { Fields.LineNo[this] = value; }
        }

        [DisplayName("Order No"), Column("ORDER_NO"), Size(16), NotNull]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Deposit Receipt No"), Column("DEPOSIT_RECEIPT_NO"), Size(16), NotNull]
        public String DepositReceiptNo
        {
            get { return Fields.DepositReceiptNo[this]; }
            set { Fields.DepositReceiptNo[this] = value; }
        }

        [DisplayName("Posted"), Column("POSTED")]
        public Boolean? Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Receipt Date"), Column("RECEIPT_DATE")]
        public DateTime? ReceiptDate
        {
            get { return Fields.ReceiptDate[this]; }
            set { Fields.ReceiptDate[this] = value; }
        }

        [DisplayName("Deposit Amt"), Column("DEPOSIT_AMT"), Size(16), Scale(2)]
        public Decimal? DepositAmt
        {
            get { return Fields.DepositAmt[this]; }
            set { Fields.DepositAmt[this] = value; }
        }

        [DisplayName("Deposit Amt Local"), Column("DEPOSIT_AMT_LOCAL"), Size(16), Scale(2)]
        public Decimal? DepositAmtLocal
        {
            get { return Fields.DepositAmtLocal[this]; }
            set { Fields.DepositAmtLocal[this] = value; }
        }

        [DisplayName("Bal Amt"), Column("BAL_AMT"), Size(16), Scale(2)]
        public Decimal? BalAmt
        {
            get { return Fields.BalAmt[this]; }
            set { Fields.BalAmt[this] = value; }
        }

        [DisplayName("Bal Amt Local"), Column("BAL_AMT_LOCAL"), Size(16), Scale(2)]
        public Decimal? BalAmtLocal
        {
            get { return Fields.BalAmtLocal[this]; }
            set { Fields.BalAmtLocal[this] = value; }
        }

        [DisplayName("Paid Amt"), Column("PAID_AMT"), Size(16), Scale(2)]
        public Decimal? PaidAmt
        {
            get { return Fields.PaidAmt[this]; }
            set { Fields.PaidAmt[this] = value; }
        }

        [DisplayName("Paid Amt Local"), Column("PAID_AMT_LOCAL"), Size(16), Scale(2)]
        public Decimal? PaidAmtLocal
        {
            get { return Fields.PaidAmtLocal[this]; }
            set { Fields.PaidAmtLocal[this] = value; }
        }

        [DisplayName("Settle"), Column("SETTLE")]
        public Boolean? Settle
        {
            get { return Fields.Settle[this]; }
            set { Fields.Settle[this] = value; }
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

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ReceiptNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AccountsReceivablePaymentDepositRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField ReceiptNo;
            public Int32Field LineNo;
            public StringField OrderNo;
            public StringField DepositReceiptNo;
            public BooleanField Posted;
            public DateTimeField ReceiptDate;
            public DecimalField DepositAmt;
            public DecimalField DepositAmtLocal;
            public DecimalField BalAmt;
            public DecimalField BalAmtLocal;
            public DecimalField PaidAmt;
            public DecimalField PaidAmtLocal;
            public BooleanField Settle;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys7;
            public StringField Anlys8;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.AccountsReceivablePaymentDeposit";
            }
        }
    }
}
