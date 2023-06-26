#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CustomerRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBCUST]")]
    [DisplayName("Customer"), InstanceName("Customer"), TwoLevelCached]   
    public sealed class CustomerRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Customer No"), Column("CUSTOMER_NO"), Size(8), PrimaryKey, QuickSearch]
        public String CustomerNo
        {
            get { return Fields.CustomerNo[this]; }
            set { Fields.CustomerNo[this] = value; }
        }

        [DisplayName("Customer Name"), Column("CUSTOMER_NAME"), Size(50), NotNull]
        public String CustomerName
        {
            get { return Fields.CustomerName[this]; }
            set { Fields.CustomerName[this] = value; }
        }

        [DisplayName("Address"), Column("ADDRESS"), Size(50)]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("Address2"), Column("ADDRESS2"), Size(50)]
        public String Address2
        {
            get { return Fields.Address2[this]; }
            set { Fields.Address2[this] = value; }
        }

        [DisplayName("Address3"), Column("ADDRESS3"), Size(50)]
        public String Address3
        {
            get { return Fields.Address3[this]; }
            set { Fields.Address3[this] = value; }
        }

        [DisplayName("Address4"), Column("ADDRESS4"), Size(50)]
        public String Address4
        {
            get { return Fields.Address4[this]; }
            set { Fields.Address4[this] = value; }
        }

        [DisplayName("Post Code"), Column("POST_CODE"), Size(20)]
        public String PostCode
        {
            get { return Fields.PostCode[this]; }
            set { Fields.PostCode[this] = value; }
        }

        [DisplayName("Telephone"), Column("TEL_NO"), Size(30)]
        public String TelNo
        {
            get { return Fields.TelNo[this]; }
            set { Fields.TelNo[this] = value; }
        }

        [DisplayName("Fax"), Column("FAX_NO"), Size(30)]
        public String FaxNo
        {
            get { return Fields.FaxNo[this]; }
            set { Fields.FaxNo[this] = value; }
        }

        [DisplayName("Email"), Column("EMAIL"), Size(100)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Customer Group"), Column("CUSTOMER_GROUP"), Size(8), NotNull, ForeignKey("[dbo].[GBCGRP]", "CUSTOMER_GROUP"), LeftJoin("jCustomerGroup"), TextualField("CustomerGroupDescription")]
        public String CustomerGroup
        {
            get { return Fields.CustomerGroup[this]; }
            set { Fields.CustomerGroup[this] = value; }
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

        [DisplayName("Price Code"), Column("PRICE_CODE"), Size(6)]
        public String PriceCode
        {
            get { return Fields.PriceCode[this]; }
            set { Fields.PriceCode[this] = value; }
        }

        [DisplayName("Use Alt Names"), Column("USE_ALT_NAMES"), Size(1)]
        public String UseAltNames
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

        [DisplayName("Contact Person"), Column("CONTACT_PERSON"), Size(30)]
        public String ContactPerson
        {
            get { return Fields.ContactPerson[this]; }
            set { Fields.ContactPerson[this] = value; }
        }

        [DisplayName("Contact Title"), Column("CONTACT_TITLE"), Size(20)]
        public String ContactTitle
        {
            get { return Fields.ContactTitle[this]; }
            set { Fields.ContactTitle[this] = value; }
        }

        [DisplayName("Trade Discount"), Column("TRADE_DISCOUNT"), Size(6), Scale(2)]
        public Decimal? TradeDiscount
        {
            get { return Fields.TradeDiscount[this]; }
            set { Fields.TradeDiscount[this] = value; }
        }

        [DisplayName("Alt Cust Name"), Column("ALT_CUST_NAME"), Size(50)]
        public String AltCustName
        {
            get { return Fields.AltCustName[this]; }
            set { Fields.AltCustName[this] = value; }
        }

        [DisplayName("Alt Cust Addr"), Column("ALT_CUST_ADDR"), Size(50)]
        public String AltCustAddr
        {
            get { return Fields.AltCustAddr[this]; }
            set { Fields.AltCustAddr[this] = value; }
        }

        [DisplayName("Alt Cust Addr2"), Column("ALT_CUST_ADDR2"), Size(50)]
        public String AltCustAddr2
        {
            get { return Fields.AltCustAddr2[this]; }
            set { Fields.AltCustAddr2[this] = value; }
        }

        [DisplayName("Alt Cust Addr3"), Column("ALT_CUST_ADDR3"), Size(50)]
        public String AltCustAddr3
        {
            get { return Fields.AltCustAddr3[this]; }
            set { Fields.AltCustAddr3[this] = value; }
        }

        [DisplayName("Alt Cust Addr4"), Column("ALT_CUST_ADDR4"), Size(50)]
        public String AltCustAddr4
        {
            get { return Fields.AltCustAddr4[this]; }
            set { Fields.AltCustAddr4[this] = value; }
        }

        [DisplayName("With Backlog"), Column("WITH_BACKLOG"), Size(1), NotNull]
        public String WithBacklog
        {
            get { return Fields.WithBacklog[this]; }
            set { Fields.WithBacklog[this] = value; }
        }

        [DisplayName("With Balance"), Column("WITH_BALANCE"), Size(1), NotNull]
        public String WithBalance
        {
            get { return Fields.WithBalance[this]; }
            set { Fields.WithBalance[this] = value; }
        }

        [DisplayName("On Order Count"), Column("ON_ORDER_COUNT"), Size(6)]
        public Decimal? OnOrderCount
        {
            get { return Fields.OnOrderCount[this]; }
            set { Fields.OnOrderCount[this] = value; }
        }

        [DisplayName("Invo Amt Bal"), Column("INVO_AMT_BAL"), Size(16), Scale(2)]
        public Decimal? InvoAmtBal
        {
            get { return Fields.InvoAmtBal[this]; }
            set { Fields.InvoAmtBal[this] = value; }
        }

        [DisplayName("Open Amt Bal"), Column("OPEN_AMT_BAL"), Size(16), Scale(2)]
        public Decimal? OpenAmtBal
        {
            get { return Fields.OpenAmtBal[this]; }
            set { Fields.OpenAmtBal[this] = value; }
        }

        [DisplayName("Net Amt Bal"), Column("NET_AMT_BAL"), Size(16), Scale(2)]
        public Decimal? NetAmtBal
        {
            get { return Fields.NetAmtBal[this]; }
            set { Fields.NetAmtBal[this] = value; }
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

        [DisplayName("Last Note No"), Column("LAST_NOTE_NO"), Size(6)]
        public Decimal? LastNoteNo
        {
            get { return Fields.LastNoteNo[this]; }
            set { Fields.LastNoteNo[this] = value; }
        }

        [DisplayName("Salesman"), Column("SALESMAN"), Size(6)]
        public String Salesman
        {
            get { return Fields.Salesman[this]; }
            set { Fields.Salesman[this] = value; }
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

        [DisplayName("Use Alt Desc"), Column("USE_ALT_DESC"), Size(1)]
        public String UseAltDesc
        {
            get { return Fields.UseAltDesc[this]; }
            set { Fields.UseAltDesc[this] = value; }
        }

        [DisplayName("Mask Code"), Column("MASK_CODE"), Size(16)]
        public String MaskCode
        {
            get { return Fields.MaskCode[this]; }
            set { Fields.MaskCode[this] = value; }
        }

        [DisplayName("Short Name"), Column("SHORT_NAME"), Size(16)]
        public String ShortName
        {
            get { return Fields.ShortName[this]; }
            set { Fields.ShortName[this] = value; }
        }

        [DisplayName("Pend Amt Ord"), Column("PEND_AMT_ORD"), Size(16), Scale(2)]
        public Decimal? PendAmtOrd
        {
            get { return Fields.PendAmtOrd[this]; }
            set { Fields.PendAmtOrd[this] = value; }
        }

        [DisplayName("Pend Amt Inv"), Column("PEND_AMT_INV"), Size(16), Scale(2)]
        public Decimal? PendAmtInv
        {
            get { return Fields.PendAmtInv[this]; }
            set { Fields.PendAmtInv[this] = value; }
        }

        [DisplayName("Acct Cust Sltax"), Column("ACCT_CUST_SLTAX"), Size(30)]
        public String AcctCustSltax
        {
            get { return Fields.AcctCustSltax[this]; }
            set { Fields.AcctCustSltax[this] = value; }
        }

        [DisplayName("Taxation Lv"), Column("TAXATION_LV"), Size(1)]
        public String TaxationLv
        {
            get { return Fields.TaxationLv[this]; }
            set { Fields.TaxationLv[this] = value; }
        }

        [DisplayName("Sltax Pcent"), Column("SLTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? SltaxPcent
        {
            get { return Fields.SltaxPcent[this]; }
            set { Fields.SltaxPcent[this] = value; }
        }

        [DisplayName("Shipment Terms"), Column("SHIPMENT_TERMS"), Size(15)]
        public String ShipmentTerms
        {
            get { return Fields.ShipmentTerms[this]; }
            set { Fields.ShipmentTerms[this] = value; }
        }

        [DisplayName("Is Approved"), Column("IS_APPROVED"), Size(1)]
        public String IsApproved
        {
            get { return Fields.IsApproved[this]; }
            set { Fields.IsApproved[this] = value; }
        }

        [DisplayName("Approved By"), Column("APPROVED_BY"), Size(20)]
        public String ApprovedBy
        {
            get { return Fields.ApprovedBy[this]; }
            set { Fields.ApprovedBy[this] = value; }
        }

        [DisplayName("Preapprove"), Column("PREAPPROVE"), Size(1)]
        public String Preapprove
        {
            get { return Fields.Preapprove[this]; }
            set { Fields.Preapprove[this] = value; }
        }

        [DisplayName("Approved Date"), Column("APPROVED_DATE")]
        public DateTime? ApprovedDate
        {
            get { return Fields.ApprovedDate[this]; }
            set { Fields.ApprovedDate[this] = value; }
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

        [DisplayName("User Defined Field 1"), Column("USER_DEFINED_FIELD_1"), Size(100)]
        public String UserDefinedField1
        {
            get { return Fields.UserDefinedField1[this]; }
            set { Fields.UserDefinedField1[this] = value; }
        }

        [DisplayName("User Defined Field 2"), Column("USER_DEFINED_FIELD_2"), Size(100)]
        public String UserDefinedField2
        {
            get { return Fields.UserDefinedField2[this]; }
            set { Fields.UserDefinedField2[this] = value; }
        }

        [DisplayName("User Defined Field 3"), Column("USER_DEFINED_FIELD_3"), Size(100)]
        public String UserDefinedField3
        {
            get { return Fields.UserDefinedField3[this]; }
            set { Fields.UserDefinedField3[this] = value; }
        }

        [DisplayName("User Defined Field 4"), Column("USER_DEFINED_FIELD_4"), Size(100)]
        public String UserDefinedField4
        {
            get { return Fields.UserDefinedField4[this]; }
            set { Fields.UserDefinedField4[this] = value; }
        }

        [DisplayName("User Defined Field 5"), Column("USER_DEFINED_FIELD_5"), Size(100)]
        public String UserDefinedField5
        {
            get { return Fields.UserDefinedField5[this]; }
            set { Fields.UserDefinedField5[this] = value; }
        }

        [DisplayName("User Defined Field 6"), Column("USER_DEFINED_FIELD_6"), Size(100)]
        public String UserDefinedField6
        {
            get { return Fields.UserDefinedField6[this]; }
            set { Fields.UserDefinedField6[this] = value; }
        }

        [DisplayName("User Defined Field 7"), Column("USER_DEFINED_FIELD_7"), Size(100)]
        public String UserDefinedField7
        {
            get { return Fields.UserDefinedField7[this]; }
            set { Fields.UserDefinedField7[this] = value; }
        }

        [DisplayName("User Defined Field 8"), Column("USER_DEFINED_FIELD_8"), Size(100)]
        public String UserDefinedField8
        {
            get { return Fields.UserDefinedField8[this]; }
            set { Fields.UserDefinedField8[this] = value; }
        }

        [DisplayName("User Defined Field 9"), Column("USER_DEFINED_FIELD_9"), Size(100)]
        public String UserDefinedField9
        {
            get { return Fields.UserDefinedField9[this]; }
            set { Fields.UserDefinedField9[this] = value; }
        }

        [DisplayName("User Defined Field 10"), Column("USER_DEFINED_FIELD_10"), Size(100)]
        public String UserDefinedField10
        {
            get { return Fields.UserDefinedField10[this]; }
            set { Fields.UserDefinedField10[this] = value; }
        }

        [DisplayName("User Defined Field 11"), Column("USER_DEFINED_FIELD_11"), Size(100)]
        public String UserDefinedField11
        {
            get { return Fields.UserDefinedField11[this]; }
            set { Fields.UserDefinedField11[this] = value; }
        }

        [DisplayName("User Defined Field 12"), Column("USER_DEFINED_FIELD_12"), Size(100)]
        public String UserDefinedField12
        {
            get { return Fields.UserDefinedField12[this]; }
            set { Fields.UserDefinedField12[this] = value; }
        }

        [DisplayName("User Defined Field 13"), Column("USER_DEFINED_FIELD_13"), Size(100)]
        public String UserDefinedField13
        {
            get { return Fields.UserDefinedField13[this]; }
            set { Fields.UserDefinedField13[this] = value; }
        }

        [DisplayName("User Defined Field 14"), Column("USER_DEFINED_FIELD_14"), Size(100)]
        public String UserDefinedField14
        {
            get { return Fields.UserDefinedField14[this]; }
            set { Fields.UserDefinedField14[this] = value; }
        }

        [DisplayName("User Defined Field 15"), Column("USER_DEFINED_FIELD_15"), Size(100)]
        public String UserDefinedField15
        {
            get { return Fields.UserDefinedField15[this]; }
            set { Fields.UserDefinedField15[this] = value; }
        }

        [DisplayName("User Defined Field 16"), Column("USER_DEFINED_FIELD_16"), Size(100)]
        public String UserDefinedField16
        {
            get { return Fields.UserDefinedField16[this]; }
            set { Fields.UserDefinedField16[this] = value; }
        }

        [DisplayName("User Defined Field 17"), Column("USER_DEFINED_FIELD_17"), Size(100)]
        public String UserDefinedField17
        {
            get { return Fields.UserDefinedField17[this]; }
            set { Fields.UserDefinedField17[this] = value; }
        }

        [DisplayName("User Defined Field 18"), Column("USER_DEFINED_FIELD_18"), Size(100)]
        public String UserDefinedField18
        {
            get { return Fields.UserDefinedField18[this]; }
            set { Fields.UserDefinedField18[this] = value; }
        }

        [DisplayName("User Defined Field 19"), Column("USER_DEFINED_FIELD_19"), Size(100)]
        public String UserDefinedField19
        {
            get { return Fields.UserDefinedField19[this]; }
            set { Fields.UserDefinedField19[this] = value; }
        }

        [DisplayName("User Defined Field 20"), Column("USER_DEFINED_FIELD_20"), Size(100)]
        public String UserDefinedField20
        {
            get { return Fields.UserDefinedField20[this]; }
            set { Fields.UserDefinedField20[this] = value; }
        }

        [DisplayName("Acct Temp"), Column("ACCT_TEMP"), Size(30)]
        public String AcctTemp
        {
            get { return Fields.AcctTemp[this]; }
            set { Fields.AcctTemp[this] = value; }
        }

        [DisplayName("Break Debit Note"), Column("BREAK_DEBIT_NOTE")]
        public Boolean? BreakDebitNote
        {
            get { return Fields.BreakDebitNote[this]; }
            set { Fields.BreakDebitNote[this] = value; }
        }

        [DisplayName("Contractor Code"), Column("CONTRACTOR_CODE"), Size(8)]
        public String ContractorCode
        {
            get { return Fields.ContractorCode[this]; }
            set { Fields.ContractorCode[this] = value; }
        }

        [DisplayName("Pay Terms Ar"), Column("PAY_TERMS_AR"), Size(6)]
        public String PayTermsAr
        {
            get { return Fields.PayTermsAr[this]; }
            set { Fields.PayTermsAr[this] = value; }
        }

        [DisplayName("Acct Ar Deposit"), Column("ACCT_AR_DEPOSIT"), Size(30)]
        public String AcctArDeposit
        {
            get { return Fields.AcctArDeposit[this]; }
            set { Fields.AcctArDeposit[this] = value; }
        }

        [DisplayName("Customer Group Recnum"), Expression("jCustomerGroup.[RECNUM]")]
        public Decimal? CustomerGroupRecnum
        {
            get { return Fields.CustomerGroupRecnum[this]; }
            set { Fields.CustomerGroupRecnum[this] = value; }
        }

        [DisplayName("Customer Group Description"), Expression("jCustomerGroup.[DESCRIPTION]")]
        public String CustomerGroupDescription
        {
            get { return Fields.CustomerGroupDescription[this]; }
            set { Fields.CustomerGroupDescription[this] = value; }
        }

        [DisplayName("Customer Group Suspended"), Expression("jCustomerGroup.[SUSPENDED]")]
        public String CustomerGroupSuspended
        {
            get { return Fields.CustomerGroupSuspended[this]; }
            set { Fields.CustomerGroupSuspended[this] = value; }
        }

        [DisplayName("Customer Group Acct Ar Cust"), Expression("jCustomerGroup.[ACCT_AR_CUST]")]
        public String CustomerGroupAcctArCust
        {
            get { return Fields.CustomerGroupAcctArCust[this]; }
            set { Fields.CustomerGroupAcctArCust[this] = value; }
        }

        [DisplayName("Customer Group Acct Ar Disc"), Expression("jCustomerGroup.[ACCT_AR_DISC]")]
        public String CustomerGroupAcctArDisc
        {
            get { return Fields.CustomerGroupAcctArDisc[this]; }
            set { Fields.CustomerGroupAcctArDisc[this] = value; }
        }

        [DisplayName("Customer Group Acct Ar Adj"), Expression("jCustomerGroup.[ACCT_AR_ADJ]")]
        public String CustomerGroupAcctArAdj
        {
            get { return Fields.CustomerGroupAcctArAdj[this]; }
            set { Fields.CustomerGroupAcctArAdj[this] = value; }
        }

        [DisplayName("Customer Group Acct Sls Trdisc"), Expression("jCustomerGroup.[ACCT_SLS_TRDISC]")]
        public String CustomerGroupAcctSlsTrdisc
        {
            get { return Fields.CustomerGroupAcctSlsTrdisc[this]; }
            set { Fields.CustomerGroupAcctSlsTrdisc[this] = value; }
        }

        [DisplayName("Customer Group Gtax Code"), Expression("jCustomerGroup.[GTAX_CODE]")]
        public String CustomerGroupGtaxCode
        {
            get { return Fields.CustomerGroupGtaxCode[this]; }
            set { Fields.CustomerGroupGtaxCode[this] = value; }
        }

        [DisplayName("Customer Group Ltax Code"), Expression("jCustomerGroup.[LTAX_CODE]")]
        public String CustomerGroupLtaxCode
        {
            get { return Fields.CustomerGroupLtaxCode[this]; }
            set { Fields.CustomerGroupLtaxCode[this] = value; }
        }

        [DisplayName("Customer Group Payment Ccy"), Expression("jCustomerGroup.[PAYMENT_CCY]")]
        public String CustomerGroupPaymentCcy
        {
            get { return Fields.CustomerGroupPaymentCcy[this]; }
            set { Fields.CustomerGroupPaymentCcy[this] = value; }
        }

        [DisplayName("Customer Group Pay Terms"), Expression("jCustomerGroup.[PAY_TERMS]")]
        public String CustomerGroupPayTerms
        {
            get { return Fields.CustomerGroupPayTerms[this]; }
            set { Fields.CustomerGroupPayTerms[this] = value; }
        }

        [DisplayName("Customer Group Price Code"), Expression("jCustomerGroup.[PRICE_CODE]")]
        public String CustomerGroupPriceCode
        {
            get { return Fields.CustomerGroupPriceCode[this]; }
            set { Fields.CustomerGroupPriceCode[this] = value; }
        }

        [DisplayName("Customer Group Use Alt Names"), Expression("jCustomerGroup.[USE_ALT_NAMES]")]
        public String CustomerGroupUseAltNames
        {
            get { return Fields.CustomerGroupUseAltNames[this]; }
            set { Fields.CustomerGroupUseAltNames[this] = value; }
        }

        [DisplayName("Customer Group With Cr Limit"), Expression("jCustomerGroup.[WITH_CR_LIMIT]")]
        public String CustomerGroupWithCrLimit
        {
            get { return Fields.CustomerGroupWithCrLimit[this]; }
            set { Fields.CustomerGroupWithCrLimit[this] = value; }
        }

        [DisplayName("Customer Group Credit Limit"), Expression("jCustomerGroup.[CREDIT_LIMIT]")]
        public Decimal? CustomerGroupCreditLimit
        {
            get { return Fields.CustomerGroupCreditLimit[this]; }
            set { Fields.CustomerGroupCreditLimit[this] = value; }
        }

        [DisplayName("Customer Group Trade Discount"), Expression("jCustomerGroup.[TRADE_DISCOUNT]")]
        public Decimal? CustomerGroupTradeDiscount
        {
            get { return Fields.CustomerGroupTradeDiscount[this]; }
            set { Fields.CustomerGroupTradeDiscount[this] = value; }
        }

        [DisplayName("Customer Group Anlys1"), Expression("jCustomerGroup.[ANLYS1]")]
        public String CustomerGroupAnlys1
        {
            get { return Fields.CustomerGroupAnlys1[this]; }
            set { Fields.CustomerGroupAnlys1[this] = value; }
        }

        [DisplayName("Customer Group Anlys2"), Expression("jCustomerGroup.[ANLYS2]")]
        public String CustomerGroupAnlys2
        {
            get { return Fields.CustomerGroupAnlys2[this]; }
            set { Fields.CustomerGroupAnlys2[this] = value; }
        }

        [DisplayName("Customer Group Anlys3"), Expression("jCustomerGroup.[ANLYS3]")]
        public String CustomerGroupAnlys3
        {
            get { return Fields.CustomerGroupAnlys3[this]; }
            set { Fields.CustomerGroupAnlys3[this] = value; }
        }

        [DisplayName("Customer Group Anlys4"), Expression("jCustomerGroup.[ANLYS4]")]
        public String CustomerGroupAnlys4
        {
            get { return Fields.CustomerGroupAnlys4[this]; }
            set { Fields.CustomerGroupAnlys4[this] = value; }
        }

        [DisplayName("Customer Group Customer Count"), Expression("jCustomerGroup.[CUSTOMER_COUNT]")]
        public Decimal? CustomerGroupCustomerCount
        {
            get { return Fields.CustomerGroupCustomerCount[this]; }
            set { Fields.CustomerGroupCustomerCount[this] = value; }
        }

        [DisplayName("Customer Group Created Date"), Expression("jCustomerGroup.[CREATED_DATE]")]
        public DateTime? CustomerGroupCreatedDate
        {
            get { return Fields.CustomerGroupCreatedDate[this]; }
            set { Fields.CustomerGroupCreatedDate[this] = value; }
        }

        [DisplayName("Customer Group Created By"), Expression("jCustomerGroup.[CREATED_BY]")]
        public String CustomerGroupCreatedBy
        {
            get { return Fields.CustomerGroupCreatedBy[this]; }
            set { Fields.CustomerGroupCreatedBy[this] = value; }
        }

        [DisplayName("Customer Group Revised Date"), Expression("jCustomerGroup.[REVISED_DATE]")]
        public DateTime? CustomerGroupRevisedDate
        {
            get { return Fields.CustomerGroupRevisedDate[this]; }
            set { Fields.CustomerGroupRevisedDate[this] = value; }
        }

        [DisplayName("Customer Group Revised By"), Expression("jCustomerGroup.[REVISED_BY]")]
        public String CustomerGroupRevisedBy
        {
            get { return Fields.CustomerGroupRevisedBy[this]; }
            set { Fields.CustomerGroupRevisedBy[this] = value; }
        }

        [DisplayName("Customer Group Arevised Date"), Expression("jCustomerGroup.[AREVISED_DATE]")]
        public DateTime? CustomerGroupArevisedDate
        {
            get { return Fields.CustomerGroupArevisedDate[this]; }
            set { Fields.CustomerGroupArevisedDate[this] = value; }
        }

        [DisplayName("Customer Group Arevised By"), Expression("jCustomerGroup.[AREVISED_BY]")]
        public String CustomerGroupArevisedBy
        {
            get { return Fields.CustomerGroupArevisedBy[this]; }
            set { Fields.CustomerGroupArevisedBy[this] = value; }
        }

        [DisplayName("Customer Group Trevised Date"), Expression("jCustomerGroup.[TREVISED_DATE]")]
        public DateTime? CustomerGroupTrevisedDate
        {
            get { return Fields.CustomerGroupTrevisedDate[this]; }
            set { Fields.CustomerGroupTrevisedDate[this] = value; }
        }

        [DisplayName("Customer Group Trevised By"), Expression("jCustomerGroup.[TREVISED_BY]")]
        public String CustomerGroupTrevisedBy
        {
            get { return Fields.CustomerGroupTrevisedBy[this]; }
            set { Fields.CustomerGroupTrevisedBy[this] = value; }
        }

        [DisplayName("Customer Group Owner Branch"), Expression("jCustomerGroup.[OWNER_BRANCH]")]
        public String CustomerGroupOwnerBranch
        {
            get { return Fields.CustomerGroupOwnerBranch[this]; }
            set { Fields.CustomerGroupOwnerBranch[this] = value; }
        }

        [DisplayName("Customer Group Source Branch"), Expression("jCustomerGroup.[SOURCE_BRANCH]")]
        public String CustomerGroupSourceBranch
        {
            get { return Fields.CustomerGroupSourceBranch[this]; }
            set { Fields.CustomerGroupSourceBranch[this] = value; }
        }

        [DisplayName("Customer Group Acct Cust Sltax"), Expression("jCustomerGroup.[ACCT_CUST_SLTAX]")]
        public String CustomerGroupAcctCustSltax
        {
            get { return Fields.CustomerGroupAcctCustSltax[this]; }
            set { Fields.CustomerGroupAcctCustSltax[this] = value; }
        }

        [DisplayName("Customer Group Sltax Pcent"), Expression("jCustomerGroup.[SLTAX_PCENT]")]
        public Decimal? CustomerGroupSltaxPcent
        {
            get { return Fields.CustomerGroupSltaxPcent[this]; }
            set { Fields.CustomerGroupSltaxPcent[this] = value; }
        }

        [DisplayName("Customer Group Anlys5"), Expression("jCustomerGroup.[ANLYS5]")]
        public String CustomerGroupAnlys5
        {
            get { return Fields.CustomerGroupAnlys5[this]; }
            set { Fields.CustomerGroupAnlys5[this] = value; }
        }

        [DisplayName("Customer Group Anlys6"), Expression("jCustomerGroup.[ANLYS6]")]
        public String CustomerGroupAnlys6
        {
            get { return Fields.CustomerGroupAnlys6[this]; }
            set { Fields.CustomerGroupAnlys6[this] = value; }
        }

        [DisplayName("Customer Group Anlys7"), Expression("jCustomerGroup.[ANLYS7]")]
        public String CustomerGroupAnlys7
        {
            get { return Fields.CustomerGroupAnlys7[this]; }
            set { Fields.CustomerGroupAnlys7[this] = value; }
        }

        [DisplayName("Customer Group Anlys8"), Expression("jCustomerGroup.[ANLYS8]")]
        public String CustomerGroupAnlys8
        {
            get { return Fields.CustomerGroupAnlys8[this]; }
            set { Fields.CustomerGroupAnlys8[this] = value; }
        }

        [DisplayName("Customer Group Anlys9"), Expression("jCustomerGroup.[ANLYS9]")]
        public String CustomerGroupAnlys9
        {
            get { return Fields.CustomerGroupAnlys9[this]; }
            set { Fields.CustomerGroupAnlys9[this] = value; }
        }

        [DisplayName("Customer Group Anlys10"), Expression("jCustomerGroup.[ANLYS10]")]
        public String CustomerGroupAnlys10
        {
            get { return Fields.CustomerGroupAnlys10[this]; }
            set { Fields.CustomerGroupAnlys10[this] = value; }
        }

        [DisplayName("Customer Group Acct Temp"), Expression("jCustomerGroup.[ACCT_TEMP]")]
        public String CustomerGroupAcctTemp
        {
            get { return Fields.CustomerGroupAcctTemp[this]; }
            set { Fields.CustomerGroupAcctTemp[this] = value; }
        }

        [DisplayName("Customer Group Client Company Name"), Expression("jCustomerGroup.[CLIENT_COMPANY_NAME]")]
        public String CustomerGroupClientCompanyName
        {
            get { return Fields.CustomerGroupClientCompanyName[this]; }
            set { Fields.CustomerGroupClientCompanyName[this] = value; }
        }

        [DisplayName("Customer Group Client Address 1"), Expression("jCustomerGroup.[CLIENT_ADDRESS_1]")]
        public String CustomerGroupClientAddress1
        {
            get { return Fields.CustomerGroupClientAddress1[this]; }
            set { Fields.CustomerGroupClientAddress1[this] = value; }
        }

        [DisplayName("Customer Group Client Address 2"), Expression("jCustomerGroup.[CLIENT_ADDRESS_2]")]
        public String CustomerGroupClientAddress2
        {
            get { return Fields.CustomerGroupClientAddress2[this]; }
            set { Fields.CustomerGroupClientAddress2[this] = value; }
        }

        [DisplayName("Customer Group Client Address 3"), Expression("jCustomerGroup.[CLIENT_ADDRESS_3]")]
        public String CustomerGroupClientAddress3
        {
            get { return Fields.CustomerGroupClientAddress3[this]; }
            set { Fields.CustomerGroupClientAddress3[this] = value; }
        }

        [DisplayName("Customer Group Client Address 4"), Expression("jCustomerGroup.[CLIENT_ADDRESS_4]")]
        public String CustomerGroupClientAddress4
        {
            get { return Fields.CustomerGroupClientAddress4[this]; }
            set { Fields.CustomerGroupClientAddress4[this] = value; }
        }

        [DisplayName("Customer Group Client Address 5"), Expression("jCustomerGroup.[CLIENT_ADDRESS_5]")]
        public String CustomerGroupClientAddress5
        {
            get { return Fields.CustomerGroupClientAddress5[this]; }
            set { Fields.CustomerGroupClientAddress5[this] = value; }
        }

        [DisplayName("Customer Group Client Tel No"), Expression("jCustomerGroup.[CLIENT_TEL_NO]")]
        public String CustomerGroupClientTelNo
        {
            get { return Fields.CustomerGroupClientTelNo[this]; }
            set { Fields.CustomerGroupClientTelNo[this] = value; }
        }

        [DisplayName("Customer Group Client Fax No"), Expression("jCustomerGroup.[CLIENT_FAX_NO]")]
        public String CustomerGroupClientFaxNo
        {
            get { return Fields.CustomerGroupClientFaxNo[this]; }
            set { Fields.CustomerGroupClientFaxNo[this] = value; }
        }

        [DisplayName("Customer Group Client Email Address"), Expression("jCustomerGroup.[CLIENT_EMAIL_ADDRESS]")]
        public String CustomerGroupClientEmailAddress
        {
            get { return Fields.CustomerGroupClientEmailAddress[this]; }
            set { Fields.CustomerGroupClientEmailAddress[this] = value; }
        }

        [DisplayName("Customer Group Client Contact Person"), Expression("jCustomerGroup.[CLIENT_CONTACT_PERSON]")]
        public String CustomerGroupClientContactPerson
        {
            get { return Fields.CustomerGroupClientContactPerson[this]; }
            set { Fields.CustomerGroupClientContactPerson[this] = value; }
        }

        [DisplayName("Customer Group Client Contact Title"), Expression("jCustomerGroup.[CLIENT_CONTACT_TITLE]")]
        public String CustomerGroupClientContactTitle
        {
            get { return Fields.CustomerGroupClientContactTitle[this]; }
            set { Fields.CustomerGroupClientContactTitle[this] = value; }
        }

        [DisplayName("Customer Group Client Remarks"), Expression("jCustomerGroup.[CLIENT_REMARKS]")]
        public String CustomerGroupClientRemarks
        {
            get { return Fields.CustomerGroupClientRemarks[this]; }
            set { Fields.CustomerGroupClientRemarks[this] = value; }
        }

        [DisplayName("Customer Group Acct Ar Deposit"), Expression("jCustomerGroup.[ACCT_AR_DEPOSIT]")]
        public String CustomerGroupAcctArDeposit
        {
            get { return Fields.CustomerGroupAcctArDeposit[this]; }
            set { Fields.CustomerGroupAcctArDeposit[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CustomerNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CustomerRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField CustomerNo;
            public StringField CustomerName;
            public StringField Address;
            public StringField Address2;
            public StringField Address3;
            public StringField Address4;
            public StringField PostCode;
            public StringField TelNo;
            public StringField FaxNo;
            public StringField Email;
            public BooleanField Suspended;
            public StringField CustomerGroup;
            public StringField PaymentCcy;
            public StringField PayTerms;
            public StringField GtaxCode;
            public StringField LtaxCode;
            public StringField AcctArCust;
            public StringField AcctArDisc;
            public StringField AcctArAdj;
            public StringField AcctSlsTrdisc;
            public StringField PriceCode;
            public StringField UseAltNames;
            public StringField WithCrLimit;
            public DecimalField CreditLimit;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField ContactPerson;
            public StringField ContactTitle;
            public DecimalField TradeDiscount;
            public StringField AltCustName;
            public StringField AltCustAddr;
            public StringField AltCustAddr2;
            public StringField AltCustAddr3;
            public StringField AltCustAddr4;
            public StringField WithBacklog;
            public StringField WithBalance;
            public DecimalField OnOrderCount;
            public DecimalField InvoAmtBal;
            public DecimalField OpenAmtBal;
            public DecimalField NetAmtBal;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField ArevisedDate;
            public StringField ArevisedBy;
            public DateTimeField TrevisedDate;
            public StringField TrevisedBy;
            public DecimalField LastNoteNo;
            public StringField Salesman;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField UseAltDesc;
            public StringField MaskCode;
            public StringField ShortName;
            public DecimalField PendAmtOrd;
            public DecimalField PendAmtInv;
            public StringField AcctCustSltax;
            public StringField TaxationLv;
            public DecimalField SltaxPcent;
            public StringField ShipmentTerms;
            public StringField IsApproved;
            public StringField ApprovedBy;
            public StringField Preapprove;
            public DateTimeField ApprovedDate;
            public StringField Anlys5;
            public StringField Anlys6;
            public StringField Anlys7;
            public StringField Anlys8;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField UserDefinedField1;
            public StringField UserDefinedField2;
            public StringField UserDefinedField3;
            public StringField UserDefinedField4;
            public StringField UserDefinedField5;
            public StringField UserDefinedField6;
            public StringField UserDefinedField7;
            public StringField UserDefinedField8;
            public StringField UserDefinedField9;
            public StringField UserDefinedField10;
            public StringField UserDefinedField11;
            public StringField UserDefinedField12;
            public StringField UserDefinedField13;
            public StringField UserDefinedField14;
            public StringField UserDefinedField15;
            public StringField UserDefinedField16;
            public StringField UserDefinedField17;
            public StringField UserDefinedField18;
            public StringField UserDefinedField19;
            public StringField UserDefinedField20;
            public StringField AcctTemp;
            public BooleanField BreakDebitNote;
            public StringField ContractorCode;
            public StringField PayTermsAr;
            public StringField AcctArDeposit;

            public DecimalField CustomerGroupRecnum;
            public StringField CustomerGroupDescription;
            public StringField CustomerGroupSuspended;
            public StringField CustomerGroupAcctArCust;
            public StringField CustomerGroupAcctArDisc;
            public StringField CustomerGroupAcctArAdj;
            public StringField CustomerGroupAcctSlsTrdisc;
            public StringField CustomerGroupGtaxCode;
            public StringField CustomerGroupLtaxCode;
            public StringField CustomerGroupPaymentCcy;
            public StringField CustomerGroupPayTerms;
            public StringField CustomerGroupPriceCode;
            public StringField CustomerGroupUseAltNames;
            public StringField CustomerGroupWithCrLimit;
            public DecimalField CustomerGroupCreditLimit;
            public DecimalField CustomerGroupTradeDiscount;
            public StringField CustomerGroupAnlys1;
            public StringField CustomerGroupAnlys2;
            public StringField CustomerGroupAnlys3;
            public StringField CustomerGroupAnlys4;
            public DecimalField CustomerGroupCustomerCount;
            public DateTimeField CustomerGroupCreatedDate;
            public StringField CustomerGroupCreatedBy;
            public DateTimeField CustomerGroupRevisedDate;
            public StringField CustomerGroupRevisedBy;
            public DateTimeField CustomerGroupArevisedDate;
            public StringField CustomerGroupArevisedBy;
            public DateTimeField CustomerGroupTrevisedDate;
            public StringField CustomerGroupTrevisedBy;
            public StringField CustomerGroupOwnerBranch;
            public StringField CustomerGroupSourceBranch;
            public StringField CustomerGroupAcctCustSltax;
            public DecimalField CustomerGroupSltaxPcent;
            public StringField CustomerGroupAnlys5;
            public StringField CustomerGroupAnlys6;
            public StringField CustomerGroupAnlys7;
            public StringField CustomerGroupAnlys8;
            public StringField CustomerGroupAnlys9;
            public StringField CustomerGroupAnlys10;
            public StringField CustomerGroupAcctTemp;
            public StringField CustomerGroupClientCompanyName;
            public StringField CustomerGroupClientAddress1;
            public StringField CustomerGroupClientAddress2;
            public StringField CustomerGroupClientAddress3;
            public StringField CustomerGroupClientAddress4;
            public StringField CustomerGroupClientAddress5;
            public StringField CustomerGroupClientTelNo;
            public StringField CustomerGroupClientFaxNo;
            public StringField CustomerGroupClientEmailAddress;
            public StringField CustomerGroupClientContactPerson;
            public StringField CustomerGroupClientContactTitle;
            public StringField CustomerGroupClientRemarks;
            public StringField CustomerGroupAcctArDeposit;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Customer";
            }
        }
    }
}
