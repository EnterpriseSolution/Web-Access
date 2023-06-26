#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorRow.cs
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

    [ConnectionKey("Enterprise"), TableName("[dbo].[GBVEND]")]
    [DisplayName("Vendor"), InstanceName("Vendor"), TwoLevelCached]
    [LookupScript("Enterprise.VendorLookup")]
    public sealed class VendorRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Vendor No"), Column("VENDOR_NO"), Size(8), PrimaryKey, QuickSearch]
        public String VendorNo
        {
            get { return Fields.VendorNo[this]; }
            set { Fields.VendorNo[this] = value; }
        }

        [DisplayName("Vendor Name"), Column("VENDOR_NAME"), Size(50), NotNull]
        public String VendorName
        {
            get { return Fields.VendorName[this]; }
            set { Fields.VendorName[this] = value; }
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

        [DisplayName("Tel No"), Column("TEL_NO"), Size(30)]
        public String TelNo
        {
            get { return Fields.TelNo[this]; }
            set { Fields.TelNo[this] = value; }
        }

        [DisplayName("Fax No"), Column("FAX_NO"), Size(30)]
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

        [DisplayName("Vendor Group"), Column("VENDOR_GROUP"), Size(6), NotNull, ForeignKey("[dbo].[GBVGRP]", "VENDOR_GROUP"), LeftJoin("jVendorGroup"), TextualField("VendorGroupDescription")]
        public String VendorGroup
        {
            get { return Fields.VendorGroup[this]; }
            set { Fields.VendorGroup[this] = value; }
        }

        [DisplayName("Order Ccy"), Column("ORDER_CCY"), Size(4)]
        public String OrderCcy
        {
            get { return Fields.OrderCcy[this]; }
            set { Fields.OrderCcy[this] = value; }
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

        [DisplayName("Acct Ap Vend"), Column("ACCT_AP_VEND"), Size(30)]
        public String AcctApVend
        {
            get { return Fields.AcctApVend[this]; }
            set { Fields.AcctApVend[this] = value; }
        }

        [DisplayName("Acct Ap Disc"), Column("ACCT_AP_DISC"), Size(30)]
        public String AcctApDisc
        {
            get { return Fields.AcctApDisc[this]; }
            set { Fields.AcctApDisc[this] = value; }
        }

        [DisplayName("Acct Ap Adj"), Column("ACCT_AP_ADJ"), Size(30)]
        public String AcctApAdj
        {
            get { return Fields.AcctApAdj[this]; }
            set { Fields.AcctApAdj[this] = value; }
        }

        [DisplayName("Acct Pur Trdisc"), Column("ACCT_PUR_TRDISC"), Size(30)]
        public String AcctPurTrdisc
        {
            get { return Fields.AcctPurTrdisc[this]; }
            set { Fields.AcctPurTrdisc[this] = value; }
        }

        [DisplayName("Use Alt Names"), Column("USE_ALT_NAMES"), Size(1)]
        public String UseAltNames
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

        [DisplayName("Lead Time"), Column("LEAD_TIME"), Size(4)]
        public Decimal? LeadTime
        {
            get { return Fields.LeadTime[this]; }
            set { Fields.LeadTime[this] = value; }
        }

        [DisplayName("Bank Name"), Column("BANK_NAME"), Size(50)]
        public String BankName
        {
            get { return Fields.BankName[this]; }
            set { Fields.BankName[this] = value; }
        }

        [DisplayName("Bank Acct No"), Column("BANK_ACCT_NO"), Size(20)]
        public String BankAcctNo
        {
            get { return Fields.BankAcctNo[this]; }
            set { Fields.BankAcctNo[this] = value; }
        }

        [DisplayName("Alt Vendor Name"), Column("ALT_VENDOR_NAME"), Size(50)]
        public String AltVendorName
        {
            get { return Fields.AltVendorName[this]; }
            set { Fields.AltVendorName[this] = value; }
        }

        [DisplayName("Alt Address"), Column("ALT_ADDRESS"), Size(50)]
        public String AltAddress
        {
            get { return Fields.AltAddress[this]; }
            set { Fields.AltAddress[this] = value; }
        }

        [DisplayName("Alt Address2"), Column("ALT_ADDRESS2"), Size(50)]
        public String AltAddress2
        {
            get { return Fields.AltAddress2[this]; }
            set { Fields.AltAddress2[this] = value; }
        }

        [DisplayName("Alt Address3"), Column("ALT_ADDRESS3"), Size(50)]
        public String AltAddress3
        {
            get { return Fields.AltAddress3[this]; }
            set { Fields.AltAddress3[this] = value; }
        }

        [DisplayName("Alt Address4"), Column("ALT_ADDRESS4"), Size(50)]
        public String AltAddress4
        {
            get { return Fields.AltAddress4[this]; }
            set { Fields.AltAddress4[this] = value; }
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

        [DisplayName("Pur Price Ctrl"), Column("PUR_PRICE_CTRL"), Size(1)]
        public String PurPriceCtrl
        {
            get { return Fields.PurPriceCtrl[this]; }
            set { Fields.PurPriceCtrl[this] = value; }
        }

        [DisplayName("Pur Max Dev"), Column("PUR_MAX_DEV"), Size(8), Scale(2)]
        public Decimal? PurMaxDev
        {
            get { return Fields.PurMaxDev[this]; }
            set { Fields.PurMaxDev[this] = value; }
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

        [DisplayName("Buyer Code"), Column("BUYER_CODE"), Size(6)]
        public String BuyerCode
        {
            get { return Fields.BuyerCode[this]; }
            set { Fields.BuyerCode[this] = value; }
        }

        [DisplayName("Taxation Lv"), Column("TAXATION_LV"), Size(1)]
        public String TaxationLv
        {
            get { return Fields.TaxationLv[this]; }
            set { Fields.TaxationLv[this] = value; }
        }

        [DisplayName("Putax Pcent"), Column("PUTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? PutaxPcent
        {
            get { return Fields.PutaxPcent[this]; }
            set { Fields.PutaxPcent[this] = value; }
        }

        [DisplayName("Acct Vend Putax"), Column("ACCT_VEND_PUTAX"), Size(30)]
        public String AcctVendPutax
        {
            get { return Fields.AcctVendPutax[this]; }
            set { Fields.AcctVendPutax[this] = value; }
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

        [DisplayName("Acct Temp"), Column("ACCT_TEMP"), Size(30)]
        public String AcctTemp
        {
            get { return Fields.AcctTemp[this]; }
            set { Fields.AcctTemp[this] = value; }
        }

        [DisplayName("Ref Company Code"), Column("REF_COMPANY_CODE"), Size(20)]
        public String RefCompanyCode
        {
            get { return Fields.RefCompanyCode[this]; }
            set { Fields.RefCompanyCode[this] = value; }
        }

        [DisplayName("Ref Customer No"), Column("REF_CUSTOMER_NO"), Size(16)]
        public String RefCustomerNo
        {
            get { return Fields.RefCustomerNo[this]; }
            set { Fields.RefCustomerNo[this] = value; }
        }

        [DisplayName("Ref Integrate Comments"), Column("REF_INTEGRATE_COMMENTS")]
        public Boolean? RefIntegrateComments
        {
            get { return Fields.RefIntegrateComments[this]; }
            set { Fields.RefIntegrateComments[this] = value; }
        }

        [DisplayName("Ref Integrate Anlys"), Column("REF_INTEGRATE_ANLYS")]
        public Boolean? RefIntegrateAnlys
        {
            get { return Fields.RefIntegrateAnlys[this]; }
            set { Fields.RefIntegrateAnlys[this] = value; }
        }

        [DisplayName("Tax Terms"), Column("TAX_TERMS"), Size(8)]
        public String TaxTerms
        {
            get { return Fields.TaxTerms[this]; }
            set { Fields.TaxTerms[this] = value; }
        }

        [DisplayName("Custom Terms"), Column("CUSTOM_TERMS"), Size(8)]
        public String CustomTerms
        {
            get { return Fields.CustomTerms[this]; }
            set { Fields.CustomTerms[this] = value; }
        }

        [DisplayName("Over Receipt Pcent"), Column("OVER_RECEIPT_PCENT"), Size(5), Scale(2)]
        public Decimal? OverReceiptPcent
        {
            get { return Fields.OverReceiptPcent[this]; }
            set { Fields.OverReceiptPcent[this] = value; }
        }

        [DisplayName("Acct Ap Deposit"), Column("ACCT_AP_DEPOSIT"), Size(30)]
        public String AcctApDeposit
        {
            get { return Fields.AcctApDeposit[this]; }
            set { Fields.AcctApDeposit[this] = value; }
        }

        [DisplayName("Vendor Group Recnum"), Expression("jVendorGroup.[RECNUM]")]
        public Decimal? VendorGroupRecnum
        {
            get { return Fields.VendorGroupRecnum[this]; }
            set { Fields.VendorGroupRecnum[this] = value; }
        }

        [DisplayName("Vendor Group Description"), Expression("jVendorGroup.[DESCRIPTION]")]
        public String VendorGroupDescription
        {
            get { return Fields.VendorGroupDescription[this]; }
            set { Fields.VendorGroupDescription[this] = value; }
        }

        [DisplayName("Vendor Group Suspended"), Expression("jVendorGroup.[SUSPENDED]")]
        public String VendorGroupSuspended
        {
            get { return Fields.VendorGroupSuspended[this]; }
            set { Fields.VendorGroupSuspended[this] = value; }
        }

        [DisplayName("Vendor Group Acct Ap Vend"), Expression("jVendorGroup.[ACCT_AP_VEND]")]
        public String VendorGroupAcctApVend
        {
            get { return Fields.VendorGroupAcctApVend[this]; }
            set { Fields.VendorGroupAcctApVend[this] = value; }
        }

        [DisplayName("Vendor Group Acct Ap Disc"), Expression("jVendorGroup.[ACCT_AP_DISC]")]
        public String VendorGroupAcctApDisc
        {
            get { return Fields.VendorGroupAcctApDisc[this]; }
            set { Fields.VendorGroupAcctApDisc[this] = value; }
        }

        [DisplayName("Vendor Group Acct Ap Adj"), Expression("jVendorGroup.[ACCT_AP_ADJ]")]
        public String VendorGroupAcctApAdj
        {
            get { return Fields.VendorGroupAcctApAdj[this]; }
            set { Fields.VendorGroupAcctApAdj[this] = value; }
        }

        [DisplayName("Vendor Group Acct Pur Trdisc"), Expression("jVendorGroup.[ACCT_PUR_TRDISC]")]
        public String VendorGroupAcctPurTrdisc
        {
            get { return Fields.VendorGroupAcctPurTrdisc[this]; }
            set { Fields.VendorGroupAcctPurTrdisc[this] = value; }
        }

        [DisplayName("Vendor Group Gtax Code"), Expression("jVendorGroup.[GTAX_CODE]")]
        public String VendorGroupGtaxCode
        {
            get { return Fields.VendorGroupGtaxCode[this]; }
            set { Fields.VendorGroupGtaxCode[this] = value; }
        }

        [DisplayName("Vendor Group Ltax Code"), Expression("jVendorGroup.[LTAX_CODE]")]
        public String VendorGroupLtaxCode
        {
            get { return Fields.VendorGroupLtaxCode[this]; }
            set { Fields.VendorGroupLtaxCode[this] = value; }
        }

        [DisplayName("Vendor Group Order Ccy"), Expression("jVendorGroup.[ORDER_CCY]")]
        public String VendorGroupOrderCcy
        {
            get { return Fields.VendorGroupOrderCcy[this]; }
            set { Fields.VendorGroupOrderCcy[this] = value; }
        }

        [DisplayName("Vendor Group Pay Terms"), Expression("jVendorGroup.[PAY_TERMS]")]
        public String VendorGroupPayTerms
        {
            get { return Fields.VendorGroupPayTerms[this]; }
            set { Fields.VendorGroupPayTerms[this] = value; }
        }

        [DisplayName("Vendor Group Use Alt Names"), Expression("jVendorGroup.[USE_ALT_NAMES]")]
        public String VendorGroupUseAltNames
        {
            get { return Fields.VendorGroupUseAltNames[this]; }
            set { Fields.VendorGroupUseAltNames[this] = value; }
        }

        [DisplayName("Vendor Group With Cr Limit"), Expression("jVendorGroup.[WITH_CR_LIMIT]")]
        public String VendorGroupWithCrLimit
        {
            get { return Fields.VendorGroupWithCrLimit[this]; }
            set { Fields.VendorGroupWithCrLimit[this] = value; }
        }

        [DisplayName("Vendor Group Credit Limit"), Expression("jVendorGroup.[CREDIT_LIMIT]")]
        public Decimal? VendorGroupCreditLimit
        {
            get { return Fields.VendorGroupCreditLimit[this]; }
            set { Fields.VendorGroupCreditLimit[this] = value; }
        }

        [DisplayName("Vendor Group Trade Discount"), Expression("jVendorGroup.[TRADE_DISCOUNT]")]
        public Decimal? VendorGroupTradeDiscount
        {
            get { return Fields.VendorGroupTradeDiscount[this]; }
            set { Fields.VendorGroupTradeDiscount[this] = value; }
        }

        [DisplayName("Vendor Group Anlys1"), Expression("jVendorGroup.[ANLYS1]")]
        public String VendorGroupAnlys1
        {
            get { return Fields.VendorGroupAnlys1[this]; }
            set { Fields.VendorGroupAnlys1[this] = value; }
        }

        [DisplayName("Vendor Group Anlys2"), Expression("jVendorGroup.[ANLYS2]")]
        public String VendorGroupAnlys2
        {
            get { return Fields.VendorGroupAnlys2[this]; }
            set { Fields.VendorGroupAnlys2[this] = value; }
        }

        [DisplayName("Vendor Group Anlys3"), Expression("jVendorGroup.[ANLYS3]")]
        public String VendorGroupAnlys3
        {
            get { return Fields.VendorGroupAnlys3[this]; }
            set { Fields.VendorGroupAnlys3[this] = value; }
        }

        [DisplayName("Vendor Group Anlys4"), Expression("jVendorGroup.[ANLYS4]")]
        public String VendorGroupAnlys4
        {
            get { return Fields.VendorGroupAnlys4[this]; }
            set { Fields.VendorGroupAnlys4[this] = value; }
        }

        [DisplayName("Vendor Group Vendor Count"), Expression("jVendorGroup.[VENDOR_COUNT]")]
        public Decimal? VendorGroupVendorCount
        {
            get { return Fields.VendorGroupVendorCount[this]; }
            set { Fields.VendorGroupVendorCount[this] = value; }
        }

        [DisplayName("Vendor Group Created Date"), Expression("jVendorGroup.[CREATED_DATE]")]
        public DateTime? VendorGroupCreatedDate
        {
            get { return Fields.VendorGroupCreatedDate[this]; }
            set { Fields.VendorGroupCreatedDate[this] = value; }
        }

        [DisplayName("Vendor Group Created By"), Expression("jVendorGroup.[CREATED_BY]")]
        public String VendorGroupCreatedBy
        {
            get { return Fields.VendorGroupCreatedBy[this]; }
            set { Fields.VendorGroupCreatedBy[this] = value; }
        }

        [DisplayName("Vendor Group Revised Date"), Expression("jVendorGroup.[REVISED_DATE]")]
        public DateTime? VendorGroupRevisedDate
        {
            get { return Fields.VendorGroupRevisedDate[this]; }
            set { Fields.VendorGroupRevisedDate[this] = value; }
        }

        [DisplayName("Vendor Group Revised By"), Expression("jVendorGroup.[REVISED_BY]")]
        public String VendorGroupRevisedBy
        {
            get { return Fields.VendorGroupRevisedBy[this]; }
            set { Fields.VendorGroupRevisedBy[this] = value; }
        }

        [DisplayName("Vendor Group Arevised Date"), Expression("jVendorGroup.[AREVISED_DATE]")]
        public DateTime? VendorGroupArevisedDate
        {
            get { return Fields.VendorGroupArevisedDate[this]; }
            set { Fields.VendorGroupArevisedDate[this] = value; }
        }

        [DisplayName("Vendor Group Arevised By"), Expression("jVendorGroup.[AREVISED_BY]")]
        public String VendorGroupArevisedBy
        {
            get { return Fields.VendorGroupArevisedBy[this]; }
            set { Fields.VendorGroupArevisedBy[this] = value; }
        }

        [DisplayName("Vendor Group Trevised Date"), Expression("jVendorGroup.[TREVISED_DATE]")]
        public DateTime? VendorGroupTrevisedDate
        {
            get { return Fields.VendorGroupTrevisedDate[this]; }
            set { Fields.VendorGroupTrevisedDate[this] = value; }
        }

        [DisplayName("Vendor Group Trevised By"), Expression("jVendorGroup.[TREVISED_BY]")]
        public String VendorGroupTrevisedBy
        {
            get { return Fields.VendorGroupTrevisedBy[this]; }
            set { Fields.VendorGroupTrevisedBy[this] = value; }
        }

        [DisplayName("Vendor Group Owner Branch"), Expression("jVendorGroup.[OWNER_BRANCH]")]
        public String VendorGroupOwnerBranch
        {
            get { return Fields.VendorGroupOwnerBranch[this]; }
            set { Fields.VendorGroupOwnerBranch[this] = value; }
        }

        [DisplayName("Vendor Group Source Branch"), Expression("jVendorGroup.[SOURCE_BRANCH]")]
        public String VendorGroupSourceBranch
        {
            get { return Fields.VendorGroupSourceBranch[this]; }
            set { Fields.VendorGroupSourceBranch[this] = value; }
        }

        [DisplayName("Vendor Group Putax Pcent"), Expression("jVendorGroup.[PUTAX_PCENT]")]
        public Decimal? VendorGroupPutaxPcent
        {
            get { return Fields.VendorGroupPutaxPcent[this]; }
            set { Fields.VendorGroupPutaxPcent[this] = value; }
        }

        [DisplayName("Vendor Group Acct Vend Putax"), Expression("jVendorGroup.[ACCT_VEND_PUTAX]")]
        public String VendorGroupAcctVendPutax
        {
            get { return Fields.VendorGroupAcctVendPutax[this]; }
            set { Fields.VendorGroupAcctVendPutax[this] = value; }
        }

        [DisplayName("Vendor Group Anlys5"), Expression("jVendorGroup.[ANLYS5]")]
        public String VendorGroupAnlys5
        {
            get { return Fields.VendorGroupAnlys5[this]; }
            set { Fields.VendorGroupAnlys5[this] = value; }
        }

        [DisplayName("Vendor Group Anlys6"), Expression("jVendorGroup.[ANLYS6]")]
        public String VendorGroupAnlys6
        {
            get { return Fields.VendorGroupAnlys6[this]; }
            set { Fields.VendorGroupAnlys6[this] = value; }
        }

        [DisplayName("Vendor Group Anlys7"), Expression("jVendorGroup.[ANLYS7]")]
        public String VendorGroupAnlys7
        {
            get { return Fields.VendorGroupAnlys7[this]; }
            set { Fields.VendorGroupAnlys7[this] = value; }
        }

        [DisplayName("Vendor Group Anlys8"), Expression("jVendorGroup.[ANLYS8]")]
        public String VendorGroupAnlys8
        {
            get { return Fields.VendorGroupAnlys8[this]; }
            set { Fields.VendorGroupAnlys8[this] = value; }
        }

        [DisplayName("Vendor Group Anlys9"), Expression("jVendorGroup.[ANLYS9]")]
        public String VendorGroupAnlys9
        {
            get { return Fields.VendorGroupAnlys9[this]; }
            set { Fields.VendorGroupAnlys9[this] = value; }
        }

        [DisplayName("Vendor Group Anlys10"), Expression("jVendorGroup.[ANLYS10]")]
        public String VendorGroupAnlys10
        {
            get { return Fields.VendorGroupAnlys10[this]; }
            set { Fields.VendorGroupAnlys10[this] = value; }
        }

        [DisplayName("Vendor Group Acct Temp"), Expression("jVendorGroup.[ACCT_TEMP]")]
        public String VendorGroupAcctTemp
        {
            get { return Fields.VendorGroupAcctTemp[this]; }
            set { Fields.VendorGroupAcctTemp[this] = value; }
        }

        [DisplayName("Vendor Group Acct Ap Deposit"), Expression("jVendorGroup.[ACCT_AP_DEPOSIT]")]
        public String VendorGroupAcctApDeposit
        {
            get { return Fields.VendorGroupAcctApDeposit[this]; }
            set { Fields.VendorGroupAcctApDeposit[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.VendorNo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.VendorName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VendorRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField VendorNo;
            public StringField VendorName;
            public StringField Address;
            public StringField Address2;
            public StringField Address3;
            public StringField Address4;
            public StringField PostCode;
            public StringField TelNo;
            public StringField FaxNo;
            public StringField Email;
            public BooleanField Suspended;
            public StringField VendorGroup;
            public StringField OrderCcy;
            public StringField PayTerms;
            public StringField GtaxCode;
            public StringField LtaxCode;
            public StringField AcctApVend;
            public StringField AcctApDisc;
            public StringField AcctApAdj;
            public StringField AcctPurTrdisc;
            public StringField UseAltNames;
            public BooleanField WithCrLimit;
            public DecimalField CreditLimit;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField ContactPerson;
            public StringField ContactTitle;
            public DecimalField TradeDiscount;
            public DecimalField LeadTime;
            public StringField BankName;
            public StringField BankAcctNo;
            public StringField AltVendorName;
            public StringField AltAddress;
            public StringField AltAddress2;
            public StringField AltAddress3;
            public StringField AltAddress4;
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
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField UseAltDesc;
            public StringField PurPriceCtrl;
            public DecimalField PurMaxDev;
            public DecimalField PendAmtOrd;
            public DecimalField PendAmtInv;
            public StringField BuyerCode;
            public StringField TaxationLv;
            public DecimalField PutaxPcent;
            public StringField AcctVendPutax;
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
            public StringField AcctTemp;
            public StringField RefCompanyCode;
            public StringField RefCustomerNo;
            public BooleanField RefIntegrateComments;
            public BooleanField RefIntegrateAnlys;
            public StringField TaxTerms;
            public StringField CustomTerms;
            public DecimalField OverReceiptPcent;
            public StringField AcctApDeposit;

            public DecimalField VendorGroupRecnum;
            public StringField VendorGroupDescription;
            public StringField VendorGroupSuspended;
            public StringField VendorGroupAcctApVend;
            public StringField VendorGroupAcctApDisc;
            public StringField VendorGroupAcctApAdj;
            public StringField VendorGroupAcctPurTrdisc;
            public StringField VendorGroupGtaxCode;
            public StringField VendorGroupLtaxCode;
            public StringField VendorGroupOrderCcy;
            public StringField VendorGroupPayTerms;
            public StringField VendorGroupUseAltNames;
            public StringField VendorGroupWithCrLimit;
            public DecimalField VendorGroupCreditLimit;
            public DecimalField VendorGroupTradeDiscount;
            public StringField VendorGroupAnlys1;
            public StringField VendorGroupAnlys2;
            public StringField VendorGroupAnlys3;
            public StringField VendorGroupAnlys4;
            public DecimalField VendorGroupVendorCount;
            public DateTimeField VendorGroupCreatedDate;
            public StringField VendorGroupCreatedBy;
            public DateTimeField VendorGroupRevisedDate;
            public StringField VendorGroupRevisedBy;
            public DateTimeField VendorGroupArevisedDate;
            public StringField VendorGroupArevisedBy;
            public DateTimeField VendorGroupTrevisedDate;
            public StringField VendorGroupTrevisedBy;
            public StringField VendorGroupOwnerBranch;
            public StringField VendorGroupSourceBranch;
            public DecimalField VendorGroupPutaxPcent;
            public StringField VendorGroupAcctVendPutax;
            public StringField VendorGroupAnlys5;
            public StringField VendorGroupAnlys6;
            public StringField VendorGroupAnlys7;
            public StringField VendorGroupAnlys8;
            public StringField VendorGroupAnlys9;
            public StringField VendorGroupAnlys10;
            public StringField VendorGroupAcctTemp;
            public StringField VendorGroupAcctApDeposit;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Enterprise.Vendor";
            }
        }
    }
}
