#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CompanyRow.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Administration.Company;

namespace Matrix.Administration.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Administration"), TableName("[dbo].[Company]")]
    [DisplayName("Company"), InstanceName("Company"), TwoLevelCached]
    //[LookupScript("Administration.CompanyRow")]
    [LookupScript(typeof(CompanyLookup))]
    public sealed class CompanyRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(28), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Company Code"), Column("COMPANY_CODE"), Size(10), PrimaryKey, QuickSearch]
        [LookupInclude]
        public String CompanyCode
        {
            get { return Fields.CompanyCode[this]; }
            set { Fields.CompanyCode[this] = value; }
        }

        [DisplayName("Company Name"), Column("COMPANY_NAME"), Size(50), NotNull]
        public String CompanyName
        {
            get { return Fields.CompanyName[this]; }
            set { Fields.CompanyName[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Server"), Column("DB_SERVER"), Size(128)]
        public String DbServer
        {
            get { return Fields.DbServer[this]; }
            set { Fields.DbServer[this] = value; }
        }

        [DisplayName("Database"), Column("DB_DATABASE"), Size(128)]
        public String DbDatabase
        {
            get { return Fields.DbDatabase[this]; }
            set { Fields.DbDatabase[this] = value; }
        }

        [DisplayName("User"), Column("DB_USER"), Size(128)]
        public String DbUser
        {
            get { return Fields.DbUser[this]; }
            set { Fields.DbUser[this] = value; }
        }

        [DisplayName("Password"), Column("DB_PASSWORD"), Size(128)]
        public String DbPassword
        {
            get { return Fields.DbPassword[this]; }
            set { Fields.DbPassword[this] = value; }
        }

        [DisplayName("Db Driver"), Column("DB_DRIVER"), Size(20)]
        public String DbDriver
        {
            get { return Fields.DbDriver[this]; }
            set { Fields.DbDriver[this] = value; }
        }

        [DisplayName("Db Rept Driver"), Column("DB_REPT_DRIVER"), Size(20)]
        public String DbReptDriver
        {
            get { return Fields.DbReptDriver[this]; }
            set { Fields.DbReptDriver[this] = value; }
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

        [DisplayName("Acct Anlys1 Opt"), Column("ACCT_ANLYS1_OPT"), Size(1)]
        public String AcctAnlys1Opt
        {
            get { return Fields.AcctAnlys1Opt[this]; }
            set { Fields.AcctAnlys1Opt[this] = value; }
        }

        [DisplayName("Acct Anlys2 Opt"), Column("ACCT_ANLYS2_OPT"), Size(1)]
        public String AcctAnlys2Opt
        {
            get { return Fields.AcctAnlys2Opt[this]; }
            set { Fields.AcctAnlys2Opt[this] = value; }
        }

        [DisplayName("Acct Anlys3 Opt"), Column("ACCT_ANLYS3_OPT"), Size(1)]
        public String AcctAnlys3Opt
        {
            get { return Fields.AcctAnlys3Opt[this]; }
            set { Fields.AcctAnlys3Opt[this] = value; }
        }

        [DisplayName("Acct Anlys4 Opt"), Column("ACCT_ANLYS4_OPT"), Size(1)]
        public String AcctAnlys4Opt
        {
            get { return Fields.AcctAnlys4Opt[this]; }
            set { Fields.AcctAnlys4Opt[this] = value; }
        }

        [DisplayName("Voch Anlys1 Opt"), Column("VOCH_ANLYS1_OPT"), Size(1)]
        public String VochAnlys1Opt
        {
            get { return Fields.VochAnlys1Opt[this]; }
            set { Fields.VochAnlys1Opt[this] = value; }
        }

        [DisplayName("Voch Anlys2 Opt"), Column("VOCH_ANLYS2_OPT"), Size(1)]
        public String VochAnlys2Opt
        {
            get { return Fields.VochAnlys2Opt[this]; }
            set { Fields.VochAnlys2Opt[this] = value; }
        }

        [DisplayName("Voch Anlys3 Opt"), Column("VOCH_ANLYS3_OPT"), Size(1)]
        public String VochAnlys3Opt
        {
            get { return Fields.VochAnlys3Opt[this]; }
            set { Fields.VochAnlys3Opt[this] = value; }
        }

        [DisplayName("Voch Anlys4 Opt"), Column("VOCH_ANLYS4_OPT"), Size(1)]
        public String VochAnlys4Opt
        {
            get { return Fields.VochAnlys4Opt[this]; }
            set { Fields.VochAnlys4Opt[this] = value; }
        }

        [DisplayName("Voch Anlys5 Opt"), Column("VOCH_ANLYS5_OPT"), Size(1)]
        public String VochAnlys5Opt
        {
            get { return Fields.VochAnlys5Opt[this]; }
            set { Fields.VochAnlys5Opt[this] = value; }
        }

        [DisplayName("Voch Anlys6 Opt"), Column("VOCH_ANLYS6_OPT"), Size(1)]
        public String VochAnlys6Opt
        {
            get { return Fields.VochAnlys6Opt[this]; }
            set { Fields.VochAnlys6Opt[this] = value; }
        }

        [DisplayName("Item Anlys1 Opt"), Column("ITEM_ANLYS1_OPT"), Size(1)]
        public String ItemAnlys1Opt
        {
            get { return Fields.ItemAnlys1Opt[this]; }
            set { Fields.ItemAnlys1Opt[this] = value; }
        }

        [DisplayName("Item Anlys2 Opt"), Column("ITEM_ANLYS2_OPT"), Size(1)]
        public String ItemAnlys2Opt
        {
            get { return Fields.ItemAnlys2Opt[this]; }
            set { Fields.ItemAnlys2Opt[this] = value; }
        }

        [DisplayName("Item Anlys3 Opt"), Column("ITEM_ANLYS3_OPT"), Size(1)]
        public String ItemAnlys3Opt
        {
            get { return Fields.ItemAnlys3Opt[this]; }
            set { Fields.ItemAnlys3Opt[this] = value; }
        }

        [DisplayName("Item Anlys4 Opt"), Column("ITEM_ANLYS4_OPT"), Size(1)]
        public String ItemAnlys4Opt
        {
            get { return Fields.ItemAnlys4Opt[this]; }
            set { Fields.ItemAnlys4Opt[this] = value; }
        }

        [DisplayName("Cust Anlys1 Opt"), Column("CUST_ANLYS1_OPT"), Size(1)]
        public String CustAnlys1Opt
        {
            get { return Fields.CustAnlys1Opt[this]; }
            set { Fields.CustAnlys1Opt[this] = value; }
        }

        [DisplayName("Cust Anlys2 Opt"), Column("CUST_ANLYS2_OPT"), Size(1)]
        public String CustAnlys2Opt
        {
            get { return Fields.CustAnlys2Opt[this]; }
            set { Fields.CustAnlys2Opt[this] = value; }
        }

        [DisplayName("Cust Anlys3 Opt"), Column("CUST_ANLYS3_OPT"), Size(1)]
        public String CustAnlys3Opt
        {
            get { return Fields.CustAnlys3Opt[this]; }
            set { Fields.CustAnlys3Opt[this] = value; }
        }

        [DisplayName("Cust Anlys4 Opt"), Column("CUST_ANLYS4_OPT"), Size(1)]
        public String CustAnlys4Opt
        {
            get { return Fields.CustAnlys4Opt[this]; }
            set { Fields.CustAnlys4Opt[this] = value; }
        }

        [DisplayName("Vend Anlys1 Opt"), Column("VEND_ANLYS1_OPT"), Size(1)]
        public String VendAnlys1Opt
        {
            get { return Fields.VendAnlys1Opt[this]; }
            set { Fields.VendAnlys1Opt[this] = value; }
        }

        [DisplayName("Vend Anlys2 Opt"), Column("VEND_ANLYS2_OPT"), Size(1)]
        public String VendAnlys2Opt
        {
            get { return Fields.VendAnlys2Opt[this]; }
            set { Fields.VendAnlys2Opt[this] = value; }
        }

        [DisplayName("Vend Anlys3 Opt"), Column("VEND_ANLYS3_OPT"), Size(1)]
        public String VendAnlys3Opt
        {
            get { return Fields.VendAnlys3Opt[this]; }
            set { Fields.VendAnlys3Opt[this] = value; }
        }

        [DisplayName("Vend Anlys4 Opt"), Column("VEND_ANLYS4_OPT"), Size(1)]
        public String VendAnlys4Opt
        {
            get { return Fields.VendAnlys4Opt[this]; }
            set { Fields.VendAnlys4Opt[this] = value; }
        }

        [DisplayName("Sale Anlys1 Opt"), Column("SALE_ANLYS1_OPT"), Size(1)]
        public String SaleAnlys1Opt
        {
            get { return Fields.SaleAnlys1Opt[this]; }
            set { Fields.SaleAnlys1Opt[this] = value; }
        }

        [DisplayName("Sale Anlys2 Opt"), Column("SALE_ANLYS2_OPT"), Size(1)]
        public String SaleAnlys2Opt
        {
            get { return Fields.SaleAnlys2Opt[this]; }
            set { Fields.SaleAnlys2Opt[this] = value; }
        }

        [DisplayName("Sale Anlys3 Opt"), Column("SALE_ANLYS3_OPT"), Size(1)]
        public String SaleAnlys3Opt
        {
            get { return Fields.SaleAnlys3Opt[this]; }
            set { Fields.SaleAnlys3Opt[this] = value; }
        }

        [DisplayName("Sale Anlys4 Opt"), Column("SALE_ANLYS4_OPT"), Size(1)]
        public String SaleAnlys4Opt
        {
            get { return Fields.SaleAnlys4Opt[this]; }
            set { Fields.SaleAnlys4Opt[this] = value; }
        }

        [DisplayName("Sale Anlys5 Opt"), Column("SALE_ANLYS5_OPT"), Size(1)]
        public String SaleAnlys5Opt
        {
            get { return Fields.SaleAnlys5Opt[this]; }
            set { Fields.SaleAnlys5Opt[this] = value; }
        }

        [DisplayName("Sale Anlys6 Opt"), Column("SALE_ANLYS6_OPT"), Size(1)]
        public String SaleAnlys6Opt
        {
            get { return Fields.SaleAnlys6Opt[this]; }
            set { Fields.SaleAnlys6Opt[this] = value; }
        }

        [DisplayName("Purc Anlys1 Opt"), Column("PURC_ANLYS1_OPT"), Size(1)]
        public String PurcAnlys1Opt
        {
            get { return Fields.PurcAnlys1Opt[this]; }
            set { Fields.PurcAnlys1Opt[this] = value; }
        }

        [DisplayName("Purc Anlys2 Opt"), Column("PURC_ANLYS2_OPT"), Size(1)]
        public String PurcAnlys2Opt
        {
            get { return Fields.PurcAnlys2Opt[this]; }
            set { Fields.PurcAnlys2Opt[this] = value; }
        }

        [DisplayName("Purc Anlys3 Opt"), Column("PURC_ANLYS3_OPT"), Size(1)]
        public String PurcAnlys3Opt
        {
            get { return Fields.PurcAnlys3Opt[this]; }
            set { Fields.PurcAnlys3Opt[this] = value; }
        }

        [DisplayName("Purc Anlys4 Opt"), Column("PURC_ANLYS4_OPT"), Size(1)]
        public String PurcAnlys4Opt
        {
            get { return Fields.PurcAnlys4Opt[this]; }
            set { Fields.PurcAnlys4Opt[this] = value; }
        }

        [DisplayName("Purc Anlys5 Opt"), Column("PURC_ANLYS5_OPT"), Size(1)]
        public String PurcAnlys5Opt
        {
            get { return Fields.PurcAnlys5Opt[this]; }
            set { Fields.PurcAnlys5Opt[this] = value; }
        }

        [DisplayName("Purc Anlys6 Opt"), Column("PURC_ANLYS6_OPT"), Size(1)]
        public String PurcAnlys6Opt
        {
            get { return Fields.PurcAnlys6Opt[this]; }
            set { Fields.PurcAnlys6Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys1 Opt"), Column("MVMT_ANLYS1_OPT"), Size(1)]
        public String MvmtAnlys1Opt
        {
            get { return Fields.MvmtAnlys1Opt[this]; }
            set { Fields.MvmtAnlys1Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys2 Opt"), Column("MVMT_ANLYS2_OPT"), Size(1)]
        public String MvmtAnlys2Opt
        {
            get { return Fields.MvmtAnlys2Opt[this]; }
            set { Fields.MvmtAnlys2Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys3 Opt"), Column("MVMT_ANLYS3_OPT"), Size(1)]
        public String MvmtAnlys3Opt
        {
            get { return Fields.MvmtAnlys3Opt[this]; }
            set { Fields.MvmtAnlys3Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys4 Opt"), Column("MVMT_ANLYS4_OPT"), Size(1)]
        public String MvmtAnlys4Opt
        {
            get { return Fields.MvmtAnlys4Opt[this]; }
            set { Fields.MvmtAnlys4Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys5 Opt"), Column("MVMT_ANLYS5_OPT"), Size(1)]
        public String MvmtAnlys5Opt
        {
            get { return Fields.MvmtAnlys5Opt[this]; }
            set { Fields.MvmtAnlys5Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys6 Opt"), Column("MVMT_ANLYS6_OPT"), Size(1)]
        public String MvmtAnlys6Opt
        {
            get { return Fields.MvmtAnlys6Opt[this]; }
            set { Fields.MvmtAnlys6Opt[this] = value; }
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

        [DisplayName("Jord Anlys1 Opt"), Column("JORD_ANLYS1_OPT"), Size(1)]
        public String JordAnlys1Opt
        {
            get { return Fields.JordAnlys1Opt[this]; }
            set { Fields.JordAnlys1Opt[this] = value; }
        }

        [DisplayName("Jord Anlys2 Opt"), Column("JORD_ANLYS2_OPT"), Size(1)]
        public String JordAnlys2Opt
        {
            get { return Fields.JordAnlys2Opt[this]; }
            set { Fields.JordAnlys2Opt[this] = value; }
        }

        [DisplayName("Jord Anlys3 Opt"), Column("JORD_ANLYS3_OPT"), Size(1)]
        public String JordAnlys3Opt
        {
            get { return Fields.JordAnlys3Opt[this]; }
            set { Fields.JordAnlys3Opt[this] = value; }
        }

        [DisplayName("Jord Anlys4 Opt"), Column("JORD_ANLYS4_OPT"), Size(1)]
        public String JordAnlys4Opt
        {
            get { return Fields.JordAnlys4Opt[this]; }
            set { Fields.JordAnlys4Opt[this] = value; }
        }

        [DisplayName("Jord Anlys5 Opt"), Column("JORD_ANLYS5_OPT"), Size(1)]
        public String JordAnlys5Opt
        {
            get { return Fields.JordAnlys5Opt[this]; }
            set { Fields.JordAnlys5Opt[this] = value; }
        }

        [DisplayName("Jord Anlys6 Opt"), Column("JORD_ANLYS6_OPT"), Size(1)]
        public String JordAnlys6Opt
        {
            get { return Fields.JordAnlys6Opt[this]; }
            set { Fields.JordAnlys6Opt[this] = value; }
        }

        [DisplayName("Voch Anlys7 Opt"), Column("VOCH_ANLYS7_OPT"), Size(1)]
        public String VochAnlys7Opt
        {
            get { return Fields.VochAnlys7Opt[this]; }
            set { Fields.VochAnlys7Opt[this] = value; }
        }

        [DisplayName("Voch Anlys8 Opt"), Column("VOCH_ANLYS8_OPT"), Size(1)]
        public String VochAnlys8Opt
        {
            get { return Fields.VochAnlys8Opt[this]; }
            set { Fields.VochAnlys8Opt[this] = value; }
        }

        [DisplayName("Sale Anlys7 Opt"), Column("SALE_ANLYS7_OPT"), Size(1)]
        public String SaleAnlys7Opt
        {
            get { return Fields.SaleAnlys7Opt[this]; }
            set { Fields.SaleAnlys7Opt[this] = value; }
        }

        [DisplayName("Sale Anlys8 Opt"), Column("SALE_ANLYS8_OPT"), Size(1)]
        public String SaleAnlys8Opt
        {
            get { return Fields.SaleAnlys8Opt[this]; }
            set { Fields.SaleAnlys8Opt[this] = value; }
        }

        [DisplayName("Purc Anlys7 Opt"), Column("PURC_ANLYS7_OPT"), Size(1)]
        public String PurcAnlys7Opt
        {
            get { return Fields.PurcAnlys7Opt[this]; }
            set { Fields.PurcAnlys7Opt[this] = value; }
        }

        [DisplayName("Purc Anlys8 Opt"), Column("PURC_ANLYS8_OPT"), Size(1)]
        public String PurcAnlys8Opt
        {
            get { return Fields.PurcAnlys8Opt[this]; }
            set { Fields.PurcAnlys8Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys7 Opt"), Column("MVMT_ANLYS7_OPT"), Size(1)]
        public String MvmtAnlys7Opt
        {
            get { return Fields.MvmtAnlys7Opt[this]; }
            set { Fields.MvmtAnlys7Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys8 Opt"), Column("MVMT_ANLYS8_OPT"), Size(1)]
        public String MvmtAnlys8Opt
        {
            get { return Fields.MvmtAnlys8Opt[this]; }
            set { Fields.MvmtAnlys8Opt[this] = value; }
        }

        [DisplayName("Jord Anlys7 Opt"), Column("JORD_ANLYS7_OPT"), Size(1)]
        public String JordAnlys7Opt
        {
            get { return Fields.JordAnlys7Opt[this]; }
            set { Fields.JordAnlys7Opt[this] = value; }
        }

        [DisplayName("Jord Anlys8 Opt"), Column("JORD_ANLYS8_OPT"), Size(1)]
        public String JordAnlys8Opt
        {
            get { return Fields.JordAnlys8Opt[this]; }
            set { Fields.JordAnlys8Opt[this] = value; }
        }

        [DisplayName("Ar Anlys1 Opt"), Column("AR_ANLYS1_OPT"), Size(1)]
        public String ArAnlys1Opt
        {
            get { return Fields.ArAnlys1Opt[this]; }
            set { Fields.ArAnlys1Opt[this] = value; }
        }

        [DisplayName("Ar Anlys2 Opt"), Column("AR_ANLYS2_OPT"), Size(1)]
        public String ArAnlys2Opt
        {
            get { return Fields.ArAnlys2Opt[this]; }
            set { Fields.ArAnlys2Opt[this] = value; }
        }

        [DisplayName("Ar Anlys3 Opt"), Column("AR_ANLYS3_OPT"), Size(1)]
        public String ArAnlys3Opt
        {
            get { return Fields.ArAnlys3Opt[this]; }
            set { Fields.ArAnlys3Opt[this] = value; }
        }

        [DisplayName("Ar Anlys4 Opt"), Column("AR_ANLYS4_OPT"), Size(1)]
        public String ArAnlys4Opt
        {
            get { return Fields.ArAnlys4Opt[this]; }
            set { Fields.ArAnlys4Opt[this] = value; }
        }

        [DisplayName("Ar Anlys5 Opt"), Column("AR_ANLYS5_OPT"), Size(1)]
        public String ArAnlys5Opt
        {
            get { return Fields.ArAnlys5Opt[this]; }
            set { Fields.ArAnlys5Opt[this] = value; }
        }

        [DisplayName("Ar Anlys6 Opt"), Column("AR_ANLYS6_OPT"), Size(1)]
        public String ArAnlys6Opt
        {
            get { return Fields.ArAnlys6Opt[this]; }
            set { Fields.ArAnlys6Opt[this] = value; }
        }

        [DisplayName("Ar Anlys7 Opt"), Column("AR_ANLYS7_OPT"), Size(1)]
        public String ArAnlys7Opt
        {
            get { return Fields.ArAnlys7Opt[this]; }
            set { Fields.ArAnlys7Opt[this] = value; }
        }

        [DisplayName("Ar Anlys8 Opt"), Column("AR_ANLYS8_OPT"), Size(1)]
        public String ArAnlys8Opt
        {
            get { return Fields.ArAnlys8Opt[this]; }
            set { Fields.ArAnlys8Opt[this] = value; }
        }

        [DisplayName("Ap Anlys1 Opt"), Column("AP_ANLYS1_OPT"), Size(1)]
        public String ApAnlys1Opt
        {
            get { return Fields.ApAnlys1Opt[this]; }
            set { Fields.ApAnlys1Opt[this] = value; }
        }

        [DisplayName("Ap Anlys2 Opt"), Column("AP_ANLYS2_OPT"), Size(1)]
        public String ApAnlys2Opt
        {
            get { return Fields.ApAnlys2Opt[this]; }
            set { Fields.ApAnlys2Opt[this] = value; }
        }

        [DisplayName("Ap Anlys3 Opt"), Column("AP_ANLYS3_OPT"), Size(1)]
        public String ApAnlys3Opt
        {
            get { return Fields.ApAnlys3Opt[this]; }
            set { Fields.ApAnlys3Opt[this] = value; }
        }

        [DisplayName("Ap Anlys4 Opt"), Column("AP_ANLYS4_OPT"), Size(1)]
        public String ApAnlys4Opt
        {
            get { return Fields.ApAnlys4Opt[this]; }
            set { Fields.ApAnlys4Opt[this] = value; }
        }

        [DisplayName("Ap Anlys5 Opt"), Column("AP_ANLYS5_OPT"), Size(1)]
        public String ApAnlys5Opt
        {
            get { return Fields.ApAnlys5Opt[this]; }
            set { Fields.ApAnlys5Opt[this] = value; }
        }

        [DisplayName("Ap Anlys6 Opt"), Column("AP_ANLYS6_OPT"), Size(1)]
        public String ApAnlys6Opt
        {
            get { return Fields.ApAnlys6Opt[this]; }
            set { Fields.ApAnlys6Opt[this] = value; }
        }

        [DisplayName("Ap Anlys7 Opt"), Column("AP_ANLYS7_OPT"), Size(1)]
        public String ApAnlys7Opt
        {
            get { return Fields.ApAnlys7Opt[this]; }
            set { Fields.ApAnlys7Opt[this] = value; }
        }

        [DisplayName("Ap Anlys8 Opt"), Column("AP_ANLYS8_OPT"), Size(1)]
        public String ApAnlys8Opt
        {
            get { return Fields.ApAnlys8Opt[this]; }
            set { Fields.ApAnlys8Opt[this] = value; }
        }

        [DisplayName("Odbc"), Column("ODBC"), Size(20)]
        public String Odbc
        {
            get { return Fields.Odbc[this]; }
            set { Fields.Odbc[this] = value; }
        }

        [DisplayName("Master Company"), Column("MASTER_COMPANY"), Size(1)]
        public String MasterCompany
        {
            get { return Fields.MasterCompany[this]; }
            set { Fields.MasterCompany[this] = value; }
        }

        [DisplayName("Acct Anlys5 Opt"), Column("ACCT_ANLYS5_OPT"), Size(1)]
        public String AcctAnlys5Opt
        {
            get { return Fields.AcctAnlys5Opt[this]; }
            set { Fields.AcctAnlys5Opt[this] = value; }
        }

        [DisplayName("Acct Anlys6 Opt"), Column("ACCT_ANLYS6_OPT"), Size(1)]
        public String AcctAnlys6Opt
        {
            get { return Fields.AcctAnlys6Opt[this]; }
            set { Fields.AcctAnlys6Opt[this] = value; }
        }

        [DisplayName("Acct Anlys7 Opt"), Column("ACCT_ANLYS7_OPT"), Size(1)]
        public String AcctAnlys7Opt
        {
            get { return Fields.AcctAnlys7Opt[this]; }
            set { Fields.AcctAnlys7Opt[this] = value; }
        }

        [DisplayName("Acct Anlys8 Opt"), Column("ACCT_ANLYS8_OPT"), Size(1)]
        public String AcctAnlys8Opt
        {
            get { return Fields.AcctAnlys8Opt[this]; }
            set { Fields.AcctAnlys8Opt[this] = value; }
        }

        [DisplayName("Acct Anlys9 Opt"), Column("ACCT_ANLYS9_OPT"), Size(1)]
        public String AcctAnlys9Opt
        {
            get { return Fields.AcctAnlys9Opt[this]; }
            set { Fields.AcctAnlys9Opt[this] = value; }
        }

        [DisplayName("Acct Anlys10 Opt"), Column("ACCT_ANLYS10_OPT"), Size(1)]
        public String AcctAnlys10Opt
        {
            get { return Fields.AcctAnlys10Opt[this]; }
            set { Fields.AcctAnlys10Opt[this] = value; }
        }

        [DisplayName("Item Anlys5 Opt"), Column("ITEM_ANLYS5_OPT"), Size(1)]
        public String ItemAnlys5Opt
        {
            get { return Fields.ItemAnlys5Opt[this]; }
            set { Fields.ItemAnlys5Opt[this] = value; }
        }

        [DisplayName("Item Anlys6 Opt"), Column("ITEM_ANLYS6_OPT"), Size(1)]
        public String ItemAnlys6Opt
        {
            get { return Fields.ItemAnlys6Opt[this]; }
            set { Fields.ItemAnlys6Opt[this] = value; }
        }

        [DisplayName("Item Anlys7 Opt"), Column("ITEM_ANLYS7_OPT"), Size(1)]
        public String ItemAnlys7Opt
        {
            get { return Fields.ItemAnlys7Opt[this]; }
            set { Fields.ItemAnlys7Opt[this] = value; }
        }

        [DisplayName("Item Anlys8 Opt"), Column("ITEM_ANLYS8_OPT"), Size(1)]
        public String ItemAnlys8Opt
        {
            get { return Fields.ItemAnlys8Opt[this]; }
            set { Fields.ItemAnlys8Opt[this] = value; }
        }

        [DisplayName("Item Anlys9 Opt"), Column("ITEM_ANLYS9_OPT"), Size(1)]
        public String ItemAnlys9Opt
        {
            get { return Fields.ItemAnlys9Opt[this]; }
            set { Fields.ItemAnlys9Opt[this] = value; }
        }

        [DisplayName("Item Anlys10 Opt"), Column("ITEM_ANLYS10_OPT"), Size(1)]
        public String ItemAnlys10Opt
        {
            get { return Fields.ItemAnlys10Opt[this]; }
            set { Fields.ItemAnlys10Opt[this] = value; }
        }

        [DisplayName("Cust Anlys5 Opt"), Column("CUST_ANLYS5_OPT"), Size(1)]
        public String CustAnlys5Opt
        {
            get { return Fields.CustAnlys5Opt[this]; }
            set { Fields.CustAnlys5Opt[this] = value; }
        }

        [DisplayName("Cust Anlys6 Opt"), Column("CUST_ANLYS6_OPT"), Size(1)]
        public String CustAnlys6Opt
        {
            get { return Fields.CustAnlys6Opt[this]; }
            set { Fields.CustAnlys6Opt[this] = value; }
        }

        [DisplayName("Cust Anlys7 Opt"), Column("CUST_ANLYS7_OPT"), Size(1)]
        public String CustAnlys7Opt
        {
            get { return Fields.CustAnlys7Opt[this]; }
            set { Fields.CustAnlys7Opt[this] = value; }
        }

        [DisplayName("Cust Anlys8 Opt"), Column("CUST_ANLYS8_OPT"), Size(1)]
        public String CustAnlys8Opt
        {
            get { return Fields.CustAnlys8Opt[this]; }
            set { Fields.CustAnlys8Opt[this] = value; }
        }

        [DisplayName("Cust Anlys9 Opt"), Column("CUST_ANLYS9_OPT"), Size(1)]
        public String CustAnlys9Opt
        {
            get { return Fields.CustAnlys9Opt[this]; }
            set { Fields.CustAnlys9Opt[this] = value; }
        }

        [DisplayName("Cust Anlys10 Opt"), Column("CUST_ANLYS10_OPT"), Size(1)]
        public String CustAnlys10Opt
        {
            get { return Fields.CustAnlys10Opt[this]; }
            set { Fields.CustAnlys10Opt[this] = value; }
        }

        [DisplayName("Vend Anlys5 Opt"), Column("VEND_ANLYS5_OPT"), Size(1)]
        public String VendAnlys5Opt
        {
            get { return Fields.VendAnlys5Opt[this]; }
            set { Fields.VendAnlys5Opt[this] = value; }
        }

        [DisplayName("Vend Anlys6 Opt"), Column("VEND_ANLYS6_OPT"), Size(1)]
        public String VendAnlys6Opt
        {
            get { return Fields.VendAnlys6Opt[this]; }
            set { Fields.VendAnlys6Opt[this] = value; }
        }

        [DisplayName("Vend Anlys7 Opt"), Column("VEND_ANLYS7_OPT"), Size(1)]
        public String VendAnlys7Opt
        {
            get { return Fields.VendAnlys7Opt[this]; }
            set { Fields.VendAnlys7Opt[this] = value; }
        }

        [DisplayName("Vend Anlys8 Opt"), Column("VEND_ANLYS8_OPT"), Size(1)]
        public String VendAnlys8Opt
        {
            get { return Fields.VendAnlys8Opt[this]; }
            set { Fields.VendAnlys8Opt[this] = value; }
        }

        [DisplayName("Vend Anlys9 Opt"), Column("VEND_ANLYS9_OPT"), Size(1)]
        public String VendAnlys9Opt
        {
            get { return Fields.VendAnlys9Opt[this]; }
            set { Fields.VendAnlys9Opt[this] = value; }
        }

        [DisplayName("Vend Anlys10 Opt"), Column("VEND_ANLYS10_OPT"), Size(1)]
        public String VendAnlys10Opt
        {
            get { return Fields.VendAnlys10Opt[this]; }
            set { Fields.VendAnlys10Opt[this] = value; }
        }

        [DisplayName("Sale Anlys9 Opt"), Column("SALE_ANLYS9_OPT"), Size(1)]
        public String SaleAnlys9Opt
        {
            get { return Fields.SaleAnlys9Opt[this]; }
            set { Fields.SaleAnlys9Opt[this] = value; }
        }

        [DisplayName("Sale Anlys10 Opt"), Column("SALE_ANLYS10_OPT"), Size(1)]
        public String SaleAnlys10Opt
        {
            get { return Fields.SaleAnlys10Opt[this]; }
            set { Fields.SaleAnlys10Opt[this] = value; }
        }

        [DisplayName("Sale Anlys11 Opt"), Column("SALE_ANLYS11_OPT"), Size(1)]
        public String SaleAnlys11Opt
        {
            get { return Fields.SaleAnlys11Opt[this]; }
            set { Fields.SaleAnlys11Opt[this] = value; }
        }

        [DisplayName("Sale Anlys12 Opt"), Column("SALE_ANLYS12_OPT"), Size(1)]
        public String SaleAnlys12Opt
        {
            get { return Fields.SaleAnlys12Opt[this]; }
            set { Fields.SaleAnlys12Opt[this] = value; }
        }

        [DisplayName("Sale Anlys13 Opt"), Column("SALE_ANLYS13_OPT"), Size(1)]
        public String SaleAnlys13Opt
        {
            get { return Fields.SaleAnlys13Opt[this]; }
            set { Fields.SaleAnlys13Opt[this] = value; }
        }

        [DisplayName("Sale Anlys14 Opt"), Column("SALE_ANLYS14_OPT"), Size(1)]
        public String SaleAnlys14Opt
        {
            get { return Fields.SaleAnlys14Opt[this]; }
            set { Fields.SaleAnlys14Opt[this] = value; }
        }

        [DisplayName("Sale Anlys15 Opt"), Column("SALE_ANLYS15_OPT"), Size(1)]
        public String SaleAnlys15Opt
        {
            get { return Fields.SaleAnlys15Opt[this]; }
            set { Fields.SaleAnlys15Opt[this] = value; }
        }

        [DisplayName("Sale Anlys16 Opt"), Column("SALE_ANLYS16_OPT"), Size(1)]
        public String SaleAnlys16Opt
        {
            get { return Fields.SaleAnlys16Opt[this]; }
            set { Fields.SaleAnlys16Opt[this] = value; }
        }

        [DisplayName("Sale Anlys17 Opt"), Column("SALE_ANLYS17_OPT"), Size(1)]
        public String SaleAnlys17Opt
        {
            get { return Fields.SaleAnlys17Opt[this]; }
            set { Fields.SaleAnlys17Opt[this] = value; }
        }

        [DisplayName("Sale Anlys18 Opt"), Column("SALE_ANLYS18_OPT"), Size(1)]
        public String SaleAnlys18Opt
        {
            get { return Fields.SaleAnlys18Opt[this]; }
            set { Fields.SaleAnlys18Opt[this] = value; }
        }

        [DisplayName("Sale Anlys19 Opt"), Column("SALE_ANLYS19_OPT"), Size(1)]
        public String SaleAnlys19Opt
        {
            get { return Fields.SaleAnlys19Opt[this]; }
            set { Fields.SaleAnlys19Opt[this] = value; }
        }

        [DisplayName("Sale Anlys20 Opt"), Column("SALE_ANLYS20_OPT"), Size(1)]
        public String SaleAnlys20Opt
        {
            get { return Fields.SaleAnlys20Opt[this]; }
            set { Fields.SaleAnlys20Opt[this] = value; }
        }

        [DisplayName("Purc Anlys9 Opt"), Column("PURC_ANLYS9_OPT"), Size(1)]
        public String PurcAnlys9Opt
        {
            get { return Fields.PurcAnlys9Opt[this]; }
            set { Fields.PurcAnlys9Opt[this] = value; }
        }

        [DisplayName("Purc Anlys10 Opt"), Column("PURC_ANLYS10_OPT"), Size(1)]
        public String PurcAnlys10Opt
        {
            get { return Fields.PurcAnlys10Opt[this]; }
            set { Fields.PurcAnlys10Opt[this] = value; }
        }

        [DisplayName("Purc Anlys11 Opt"), Column("PURC_ANLYS11_OPT"), Size(1)]
        public String PurcAnlys11Opt
        {
            get { return Fields.PurcAnlys11Opt[this]; }
            set { Fields.PurcAnlys11Opt[this] = value; }
        }

        [DisplayName("Purc Anlys12 Opt"), Column("PURC_ANLYS12_OPT"), Size(1)]
        public String PurcAnlys12Opt
        {
            get { return Fields.PurcAnlys12Opt[this]; }
            set { Fields.PurcAnlys12Opt[this] = value; }
        }

        [DisplayName("Purc Anlys13 Opt"), Column("PURC_ANLYS13_OPT"), Size(1)]
        public String PurcAnlys13Opt
        {
            get { return Fields.PurcAnlys13Opt[this]; }
            set { Fields.PurcAnlys13Opt[this] = value; }
        }

        [DisplayName("Purc Anlys14 Opt"), Column("PURC_ANLYS14_OPT"), Size(1)]
        public String PurcAnlys14Opt
        {
            get { return Fields.PurcAnlys14Opt[this]; }
            set { Fields.PurcAnlys14Opt[this] = value; }
        }

        [DisplayName("Purc Anlys15 Opt"), Column("PURC_ANLYS15_OPT"), Size(1)]
        public String PurcAnlys15Opt
        {
            get { return Fields.PurcAnlys15Opt[this]; }
            set { Fields.PurcAnlys15Opt[this] = value; }
        }

        [DisplayName("Purc Anlys16 Opt"), Column("PURC_ANLYS16_OPT"), Size(1)]
        public String PurcAnlys16Opt
        {
            get { return Fields.PurcAnlys16Opt[this]; }
            set { Fields.PurcAnlys16Opt[this] = value; }
        }

        [DisplayName("Purc Anlys17 Opt"), Column("PURC_ANLYS17_OPT"), Size(1)]
        public String PurcAnlys17Opt
        {
            get { return Fields.PurcAnlys17Opt[this]; }
            set { Fields.PurcAnlys17Opt[this] = value; }
        }

        [DisplayName("Purc Anlys18 Opt"), Column("PURC_ANLYS18_OPT"), Size(1)]
        public String PurcAnlys18Opt
        {
            get { return Fields.PurcAnlys18Opt[this]; }
            set { Fields.PurcAnlys18Opt[this] = value; }
        }

        [DisplayName("Purc Anlys19 Opt"), Column("PURC_ANLYS19_OPT"), Size(1)]
        public String PurcAnlys19Opt
        {
            get { return Fields.PurcAnlys19Opt[this]; }
            set { Fields.PurcAnlys19Opt[this] = value; }
        }

        [DisplayName("Purc Anlys20 Opt"), Column("PURC_ANLYS20_OPT"), Size(1)]
        public String PurcAnlys20Opt
        {
            get { return Fields.PurcAnlys20Opt[this]; }
            set { Fields.PurcAnlys20Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys9 Opt"), Column("MVMT_ANLYS9_OPT"), Size(1)]
        public String MvmtAnlys9Opt
        {
            get { return Fields.MvmtAnlys9Opt[this]; }
            set { Fields.MvmtAnlys9Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys10 Opt"), Column("MVMT_ANLYS10_OPT"), Size(1)]
        public String MvmtAnlys10Opt
        {
            get { return Fields.MvmtAnlys10Opt[this]; }
            set { Fields.MvmtAnlys10Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys11 Opt"), Column("MVMT_ANLYS11_OPT"), Size(1)]
        public String MvmtAnlys11Opt
        {
            get { return Fields.MvmtAnlys11Opt[this]; }
            set { Fields.MvmtAnlys11Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys12 Opt"), Column("MVMT_ANLYS12_OPT"), Size(1)]
        public String MvmtAnlys12Opt
        {
            get { return Fields.MvmtAnlys12Opt[this]; }
            set { Fields.MvmtAnlys12Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys13 Opt"), Column("MVMT_ANLYS13_OPT"), Size(1)]
        public String MvmtAnlys13Opt
        {
            get { return Fields.MvmtAnlys13Opt[this]; }
            set { Fields.MvmtAnlys13Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys14 Opt"), Column("MVMT_ANLYS14_OPT"), Size(1)]
        public String MvmtAnlys14Opt
        {
            get { return Fields.MvmtAnlys14Opt[this]; }
            set { Fields.MvmtAnlys14Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys15 Opt"), Column("MVMT_ANLYS15_OPT"), Size(1)]
        public String MvmtAnlys15Opt
        {
            get { return Fields.MvmtAnlys15Opt[this]; }
            set { Fields.MvmtAnlys15Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys16 Opt"), Column("MVMT_ANLYS16_OPT"), Size(1)]
        public String MvmtAnlys16Opt
        {
            get { return Fields.MvmtAnlys16Opt[this]; }
            set { Fields.MvmtAnlys16Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys17 Opt"), Column("MVMT_ANLYS17_OPT"), Size(1)]
        public String MvmtAnlys17Opt
        {
            get { return Fields.MvmtAnlys17Opt[this]; }
            set { Fields.MvmtAnlys17Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys18 Opt"), Column("MVMT_ANLYS18_OPT"), Size(1)]
        public String MvmtAnlys18Opt
        {
            get { return Fields.MvmtAnlys18Opt[this]; }
            set { Fields.MvmtAnlys18Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys19 Opt"), Column("MVMT_ANLYS19_OPT"), Size(1)]
        public String MvmtAnlys19Opt
        {
            get { return Fields.MvmtAnlys19Opt[this]; }
            set { Fields.MvmtAnlys19Opt[this] = value; }
        }

        [DisplayName("Mvmt Anlys20 Opt"), Column("MVMT_ANLYS20_OPT"), Size(1)]
        public String MvmtAnlys20Opt
        {
            get { return Fields.MvmtAnlys20Opt[this]; }
            set { Fields.MvmtAnlys20Opt[this] = value; }
        }

        [DisplayName("Jord Anlys9 Opt"), Column("JORD_ANLYS9_OPT"), Size(1)]
        public String JordAnlys9Opt
        {
            get { return Fields.JordAnlys9Opt[this]; }
            set { Fields.JordAnlys9Opt[this] = value; }
        }

        [DisplayName("Jord Anlys10 Opt"), Column("JORD_ANLYS10_OPT"), Size(1)]
        public String JordAnlys10Opt
        {
            get { return Fields.JordAnlys10Opt[this]; }
            set { Fields.JordAnlys10Opt[this] = value; }
        }

        [DisplayName("Jord Anlys11 Opt"), Column("JORD_ANLYS11_OPT"), Size(1)]
        public String JordAnlys11Opt
        {
            get { return Fields.JordAnlys11Opt[this]; }
            set { Fields.JordAnlys11Opt[this] = value; }
        }

        [DisplayName("Jord Anlys12 Opt"), Column("JORD_ANLYS12_OPT"), Size(1)]
        public String JordAnlys12Opt
        {
            get { return Fields.JordAnlys12Opt[this]; }
            set { Fields.JordAnlys12Opt[this] = value; }
        }

        [DisplayName("Jord Anlys13 Opt"), Column("JORD_ANLYS13_OPT"), Size(1)]
        public String JordAnlys13Opt
        {
            get { return Fields.JordAnlys13Opt[this]; }
            set { Fields.JordAnlys13Opt[this] = value; }
        }

        [DisplayName("Jord Anlys14 Opt"), Column("JORD_ANLYS14_OPT"), Size(1)]
        public String JordAnlys14Opt
        {
            get { return Fields.JordAnlys14Opt[this]; }
            set { Fields.JordAnlys14Opt[this] = value; }
        }

        [DisplayName("Jord Anlys15 Opt"), Column("JORD_ANLYS15_OPT"), Size(1)]
        public String JordAnlys15Opt
        {
            get { return Fields.JordAnlys15Opt[this]; }
            set { Fields.JordAnlys15Opt[this] = value; }
        }

        [DisplayName("Jord Anlys16 Opt"), Column("JORD_ANLYS16_OPT"), Size(1)]
        public String JordAnlys16Opt
        {
            get { return Fields.JordAnlys16Opt[this]; }
            set { Fields.JordAnlys16Opt[this] = value; }
        }

        [DisplayName("Jord Anlys17 Opt"), Column("JORD_ANLYS17_OPT"), Size(1)]
        public String JordAnlys17Opt
        {
            get { return Fields.JordAnlys17Opt[this]; }
            set { Fields.JordAnlys17Opt[this] = value; }
        }

        [DisplayName("Jord Anlys18 Opt"), Column("JORD_ANLYS18_OPT"), Size(1)]
        public String JordAnlys18Opt
        {
            get { return Fields.JordAnlys18Opt[this]; }
            set { Fields.JordAnlys18Opt[this] = value; }
        }

        [DisplayName("Jord Anlys19 Opt"), Column("JORD_ANLYS19_OPT"), Size(1)]
        public String JordAnlys19Opt
        {
            get { return Fields.JordAnlys19Opt[this]; }
            set { Fields.JordAnlys19Opt[this] = value; }
        }

        [DisplayName("Jord Anlys20 Opt"), Column("JORD_ANLYS20_OPT"), Size(1)]
        public String JordAnlys20Opt
        {
            get { return Fields.JordAnlys20Opt[this]; }
            set { Fields.JordAnlys20Opt[this] = value; }
        }

        [DisplayName("Ar Anlys9 Opt"), Column("AR_ANLYS9_OPT"), Size(1)]
        public String ArAnlys9Opt
        {
            get { return Fields.ArAnlys9Opt[this]; }
            set { Fields.ArAnlys9Opt[this] = value; }
        }

        [DisplayName("Ar Anlys10 Opt"), Column("AR_ANLYS10_OPT"), Size(1)]
        public String ArAnlys10Opt
        {
            get { return Fields.ArAnlys10Opt[this]; }
            set { Fields.ArAnlys10Opt[this] = value; }
        }

        [DisplayName("Ar Anlys11 Opt"), Column("AR_ANLYS11_OPT"), Size(1)]
        public String ArAnlys11Opt
        {
            get { return Fields.ArAnlys11Opt[this]; }
            set { Fields.ArAnlys11Opt[this] = value; }
        }

        [DisplayName("Ar Anlys12 Opt"), Column("AR_ANLYS12_OPT"), Size(1)]
        public String ArAnlys12Opt
        {
            get { return Fields.ArAnlys12Opt[this]; }
            set { Fields.ArAnlys12Opt[this] = value; }
        }

        [DisplayName("Ar Anlys13 Opt"), Column("AR_ANLYS13_OPT"), Size(1)]
        public String ArAnlys13Opt
        {
            get { return Fields.ArAnlys13Opt[this]; }
            set { Fields.ArAnlys13Opt[this] = value; }
        }

        [DisplayName("Ar Anlys14 Opt"), Column("AR_ANLYS14_OPT"), Size(1)]
        public String ArAnlys14Opt
        {
            get { return Fields.ArAnlys14Opt[this]; }
            set { Fields.ArAnlys14Opt[this] = value; }
        }

        [DisplayName("Ar Anlys15 Opt"), Column("AR_ANLYS15_OPT"), Size(1)]
        public String ArAnlys15Opt
        {
            get { return Fields.ArAnlys15Opt[this]; }
            set { Fields.ArAnlys15Opt[this] = value; }
        }

        [DisplayName("Ar Anlys16 Opt"), Column("AR_ANLYS16_OPT"), Size(1)]
        public String ArAnlys16Opt
        {
            get { return Fields.ArAnlys16Opt[this]; }
            set { Fields.ArAnlys16Opt[this] = value; }
        }

        [DisplayName("Ar Anlys17 Opt"), Column("AR_ANLYS17_OPT"), Size(1)]
        public String ArAnlys17Opt
        {
            get { return Fields.ArAnlys17Opt[this]; }
            set { Fields.ArAnlys17Opt[this] = value; }
        }

        [DisplayName("Ar Anlys18 Opt"), Column("AR_ANLYS18_OPT"), Size(1)]
        public String ArAnlys18Opt
        {
            get { return Fields.ArAnlys18Opt[this]; }
            set { Fields.ArAnlys18Opt[this] = value; }
        }

        [DisplayName("Ar Anlys19 Opt"), Column("AR_ANLYS19_OPT"), Size(1)]
        public String ArAnlys19Opt
        {
            get { return Fields.ArAnlys19Opt[this]; }
            set { Fields.ArAnlys19Opt[this] = value; }
        }

        [DisplayName("Ar Anlys20 Opt"), Column("AR_ANLYS20_OPT"), Size(1)]
        public String ArAnlys20Opt
        {
            get { return Fields.ArAnlys20Opt[this]; }
            set { Fields.ArAnlys20Opt[this] = value; }
        }

        [DisplayName("Ap Anlys9 Opt"), Column("AP_ANLYS9_OPT"), Size(1)]
        public String ApAnlys9Opt
        {
            get { return Fields.ApAnlys9Opt[this]; }
            set { Fields.ApAnlys9Opt[this] = value; }
        }

        [DisplayName("Ap Anlys10 Opt"), Column("AP_ANLYS10_OPT"), Size(1)]
        public String ApAnlys10Opt
        {
            get { return Fields.ApAnlys10Opt[this]; }
            set { Fields.ApAnlys10Opt[this] = value; }
        }

        [DisplayName("Ap Anlys11 Opt"), Column("AP_ANLYS11_OPT"), Size(1)]
        public String ApAnlys11Opt
        {
            get { return Fields.ApAnlys11Opt[this]; }
            set { Fields.ApAnlys11Opt[this] = value; }
        }

        [DisplayName("Ap Anlys12 Opt"), Column("AP_ANLYS12_OPT"), Size(1)]
        public String ApAnlys12Opt
        {
            get { return Fields.ApAnlys12Opt[this]; }
            set { Fields.ApAnlys12Opt[this] = value; }
        }

        [DisplayName("Ap Anlys13 Opt"), Column("AP_ANLYS13_OPT"), Size(1)]
        public String ApAnlys13Opt
        {
            get { return Fields.ApAnlys13Opt[this]; }
            set { Fields.ApAnlys13Opt[this] = value; }
        }

        [DisplayName("Ap Anlys14 Opt"), Column("AP_ANLYS14_OPT"), Size(1)]
        public String ApAnlys14Opt
        {
            get { return Fields.ApAnlys14Opt[this]; }
            set { Fields.ApAnlys14Opt[this] = value; }
        }

        [DisplayName("Ap Anlys15 Opt"), Column("AP_ANLYS15_OPT"), Size(1)]
        public String ApAnlys15Opt
        {
            get { return Fields.ApAnlys15Opt[this]; }
            set { Fields.ApAnlys15Opt[this] = value; }
        }

        [DisplayName("Ap Anlys16 Opt"), Column("AP_ANLYS16_OPT"), Size(1)]
        public String ApAnlys16Opt
        {
            get { return Fields.ApAnlys16Opt[this]; }
            set { Fields.ApAnlys16Opt[this] = value; }
        }

        [DisplayName("Ap Anlys17 Opt"), Column("AP_ANLYS17_OPT"), Size(1)]
        public String ApAnlys17Opt
        {
            get { return Fields.ApAnlys17Opt[this]; }
            set { Fields.ApAnlys17Opt[this] = value; }
        }

        [DisplayName("Ap Anlys18 Opt"), Column("AP_ANLYS18_OPT"), Size(1)]
        public String ApAnlys18Opt
        {
            get { return Fields.ApAnlys18Opt[this]; }
            set { Fields.ApAnlys18Opt[this] = value; }
        }

        [DisplayName("Ap Anlys19 Opt"), Column("AP_ANLYS19_OPT"), Size(1)]
        public String ApAnlys19Opt
        {
            get { return Fields.ApAnlys19Opt[this]; }
            set { Fields.ApAnlys19Opt[this] = value; }
        }

        [DisplayName("Ap Anlys20 Opt"), Column("AP_ANLYS20_OPT"), Size(1)]
        public String ApAnlys20Opt
        {
            get { return Fields.ApAnlys20Opt[this]; }
            set { Fields.ApAnlys20Opt[this] = value; }
        }

        [DisplayName("Voch Anlys9 Opt"), Column("VOCH_ANLYS9_OPT"), Size(1)]
        public String VochAnlys9Opt
        {
            get { return Fields.VochAnlys9Opt[this]; }
            set { Fields.VochAnlys9Opt[this] = value; }
        }

        [DisplayName("Voch Anlys10 Opt"), Column("VOCH_ANLYS10_OPT"), Size(1)]
        public String VochAnlys10Opt
        {
            get { return Fields.VochAnlys10Opt[this]; }
            set { Fields.VochAnlys10Opt[this] = value; }
        }

        [DisplayName("Voch Anlys11 Opt"), Column("VOCH_ANLYS11_OPT"), Size(1)]
        public String VochAnlys11Opt
        {
            get { return Fields.VochAnlys11Opt[this]; }
            set { Fields.VochAnlys11Opt[this] = value; }
        }

        [DisplayName("Voch Anlys12 Opt"), Column("VOCH_ANLYS12_OPT"), Size(1)]
        public String VochAnlys12Opt
        {
            get { return Fields.VochAnlys12Opt[this]; }
            set { Fields.VochAnlys12Opt[this] = value; }
        }

        [DisplayName("Voch Anlys13 Opt"), Column("VOCH_ANLYS13_OPT"), Size(1)]
        public String VochAnlys13Opt
        {
            get { return Fields.VochAnlys13Opt[this]; }
            set { Fields.VochAnlys13Opt[this] = value; }
        }

        [DisplayName("Voch Anlys14 Opt"), Column("VOCH_ANLYS14_OPT"), Size(1)]
        public String VochAnlys14Opt
        {
            get { return Fields.VochAnlys14Opt[this]; }
            set { Fields.VochAnlys14Opt[this] = value; }
        }

        [DisplayName("Voch Anlys15 Opt"), Column("VOCH_ANLYS15_OPT"), Size(1)]
        public String VochAnlys15Opt
        {
            get { return Fields.VochAnlys15Opt[this]; }
            set { Fields.VochAnlys15Opt[this] = value; }
        }

        [DisplayName("Voch Anlys16 Opt"), Column("VOCH_ANLYS16_OPT"), Size(1)]
        public String VochAnlys16Opt
        {
            get { return Fields.VochAnlys16Opt[this]; }
            set { Fields.VochAnlys16Opt[this] = value; }
        }

        [DisplayName("Voch Anlys17 Opt"), Column("VOCH_ANLYS17_OPT"), Size(1)]
        public String VochAnlys17Opt
        {
            get { return Fields.VochAnlys17Opt[this]; }
            set { Fields.VochAnlys17Opt[this] = value; }
        }

        [DisplayName("Voch Anlys18 Opt"), Column("VOCH_ANLYS18_OPT"), Size(1)]
        public String VochAnlys18Opt
        {
            get { return Fields.VochAnlys18Opt[this]; }
            set { Fields.VochAnlys18Opt[this] = value; }
        }

        [DisplayName("Voch Anlys19 Opt"), Column("VOCH_ANLYS19_OPT"), Size(1)]
        public String VochAnlys19Opt
        {
            get { return Fields.VochAnlys19Opt[this]; }
            set { Fields.VochAnlys19Opt[this] = value; }
        }

        [DisplayName("Voch Anlys20 Opt"), Column("VOCH_ANLYS20_OPT"), Size(1)]
        public String VochAnlys20Opt
        {
            get { return Fields.VochAnlys20Opt[this]; }
            set { Fields.VochAnlys20Opt[this] = value; }
        }

        [DisplayName("Olap Server"), Column("OLAP_SERVER"), Size(128)]
        public String OlapServer
        {
            get { return Fields.OlapServer[this]; }
            set { Fields.OlapServer[this] = value; }
        }

        [DisplayName("Olap Database"), Column("OLAP_DATABASE"), Size(128)]
        public String OlapDatabase
        {
            get { return Fields.OlapDatabase[this]; }
            set { Fields.OlapDatabase[this] = value; }
        }

        [DisplayName("Expiry Date"), Column("EXPIRY_DATE")]
        public DateTime? ExpiryDate
        {
            get { return Fields.ExpiryDate[this]; }
            set { Fields.ExpiryDate[this] = value; }
        }

        [DisplayName("Max Users"), Column("MAX_USERS")]
        public Int32? MaxUsers
        {
            get { return Fields.MaxUsers[this]; }
            set { Fields.MaxUsers[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CompanyCode; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CompanyName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CompanyRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField CompanyCode;
            public StringField CompanyName;
            public BooleanField Suspended;
            public StringField DbServer;
            public StringField DbDatabase;
            public StringField DbUser;
            public StringField DbPassword;
            public StringField DbDriver;
            public StringField DbReptDriver;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField AcctAnlys1Opt;
            public StringField AcctAnlys2Opt;
            public StringField AcctAnlys3Opt;
            public StringField AcctAnlys4Opt;
            public StringField VochAnlys1Opt;
            public StringField VochAnlys2Opt;
            public StringField VochAnlys3Opt;
            public StringField VochAnlys4Opt;
            public StringField VochAnlys5Opt;
            public StringField VochAnlys6Opt;
            public StringField ItemAnlys1Opt;
            public StringField ItemAnlys2Opt;
            public StringField ItemAnlys3Opt;
            public StringField ItemAnlys4Opt;
            public StringField CustAnlys1Opt;
            public StringField CustAnlys2Opt;
            public StringField CustAnlys3Opt;
            public StringField CustAnlys4Opt;
            public StringField VendAnlys1Opt;
            public StringField VendAnlys2Opt;
            public StringField VendAnlys3Opt;
            public StringField VendAnlys4Opt;
            public StringField SaleAnlys1Opt;
            public StringField SaleAnlys2Opt;
            public StringField SaleAnlys3Opt;
            public StringField SaleAnlys4Opt;
            public StringField SaleAnlys5Opt;
            public StringField SaleAnlys6Opt;
            public StringField PurcAnlys1Opt;
            public StringField PurcAnlys2Opt;
            public StringField PurcAnlys3Opt;
            public StringField PurcAnlys4Opt;
            public StringField PurcAnlys5Opt;
            public StringField PurcAnlys6Opt;
            public StringField MvmtAnlys1Opt;
            public StringField MvmtAnlys2Opt;
            public StringField MvmtAnlys3Opt;
            public StringField MvmtAnlys4Opt;
            public StringField MvmtAnlys5Opt;
            public StringField MvmtAnlys6Opt;
            public DateTimeField ArevisedDate;
            public StringField ArevisedBy;
            public StringField JordAnlys1Opt;
            public StringField JordAnlys2Opt;
            public StringField JordAnlys3Opt;
            public StringField JordAnlys4Opt;
            public StringField JordAnlys5Opt;
            public StringField JordAnlys6Opt;
            public StringField VochAnlys7Opt;
            public StringField VochAnlys8Opt;
            public StringField SaleAnlys7Opt;
            public StringField SaleAnlys8Opt;
            public StringField PurcAnlys7Opt;
            public StringField PurcAnlys8Opt;
            public StringField MvmtAnlys7Opt;
            public StringField MvmtAnlys8Opt;
            public StringField JordAnlys7Opt;
            public StringField JordAnlys8Opt;
            public StringField ArAnlys1Opt;
            public StringField ArAnlys2Opt;
            public StringField ArAnlys3Opt;
            public StringField ArAnlys4Opt;
            public StringField ArAnlys5Opt;
            public StringField ArAnlys6Opt;
            public StringField ArAnlys7Opt;
            public StringField ArAnlys8Opt;
            public StringField ApAnlys1Opt;
            public StringField ApAnlys2Opt;
            public StringField ApAnlys3Opt;
            public StringField ApAnlys4Opt;
            public StringField ApAnlys5Opt;
            public StringField ApAnlys6Opt;
            public StringField ApAnlys7Opt;
            public StringField ApAnlys8Opt;
            public StringField Odbc;
            public StringField MasterCompany;
            public StringField AcctAnlys5Opt;
            public StringField AcctAnlys6Opt;
            public StringField AcctAnlys7Opt;
            public StringField AcctAnlys8Opt;
            public StringField AcctAnlys9Opt;
            public StringField AcctAnlys10Opt;
            public StringField ItemAnlys5Opt;
            public StringField ItemAnlys6Opt;
            public StringField ItemAnlys7Opt;
            public StringField ItemAnlys8Opt;
            public StringField ItemAnlys9Opt;
            public StringField ItemAnlys10Opt;
            public StringField CustAnlys5Opt;
            public StringField CustAnlys6Opt;
            public StringField CustAnlys7Opt;
            public StringField CustAnlys8Opt;
            public StringField CustAnlys9Opt;
            public StringField CustAnlys10Opt;
            public StringField VendAnlys5Opt;
            public StringField VendAnlys6Opt;
            public StringField VendAnlys7Opt;
            public StringField VendAnlys8Opt;
            public StringField VendAnlys9Opt;
            public StringField VendAnlys10Opt;
            public StringField SaleAnlys9Opt;
            public StringField SaleAnlys10Opt;
            public StringField SaleAnlys11Opt;
            public StringField SaleAnlys12Opt;
            public StringField SaleAnlys13Opt;
            public StringField SaleAnlys14Opt;
            public StringField SaleAnlys15Opt;
            public StringField SaleAnlys16Opt;
            public StringField SaleAnlys17Opt;
            public StringField SaleAnlys18Opt;
            public StringField SaleAnlys19Opt;
            public StringField SaleAnlys20Opt;
            public StringField PurcAnlys9Opt;
            public StringField PurcAnlys10Opt;
            public StringField PurcAnlys11Opt;
            public StringField PurcAnlys12Opt;
            public StringField PurcAnlys13Opt;
            public StringField PurcAnlys14Opt;
            public StringField PurcAnlys15Opt;
            public StringField PurcAnlys16Opt;
            public StringField PurcAnlys17Opt;
            public StringField PurcAnlys18Opt;
            public StringField PurcAnlys19Opt;
            public StringField PurcAnlys20Opt;
            public StringField MvmtAnlys9Opt;
            public StringField MvmtAnlys10Opt;
            public StringField MvmtAnlys11Opt;
            public StringField MvmtAnlys12Opt;
            public StringField MvmtAnlys13Opt;
            public StringField MvmtAnlys14Opt;
            public StringField MvmtAnlys15Opt;
            public StringField MvmtAnlys16Opt;
            public StringField MvmtAnlys17Opt;
            public StringField MvmtAnlys18Opt;
            public StringField MvmtAnlys19Opt;
            public StringField MvmtAnlys20Opt;
            public StringField JordAnlys9Opt;
            public StringField JordAnlys10Opt;
            public StringField JordAnlys11Opt;
            public StringField JordAnlys12Opt;
            public StringField JordAnlys13Opt;
            public StringField JordAnlys14Opt;
            public StringField JordAnlys15Opt;
            public StringField JordAnlys16Opt;
            public StringField JordAnlys17Opt;
            public StringField JordAnlys18Opt;
            public StringField JordAnlys19Opt;
            public StringField JordAnlys20Opt;
            public StringField ArAnlys9Opt;
            public StringField ArAnlys10Opt;
            public StringField ArAnlys11Opt;
            public StringField ArAnlys12Opt;
            public StringField ArAnlys13Opt;
            public StringField ArAnlys14Opt;
            public StringField ArAnlys15Opt;
            public StringField ArAnlys16Opt;
            public StringField ArAnlys17Opt;
            public StringField ArAnlys18Opt;
            public StringField ArAnlys19Opt;
            public StringField ArAnlys20Opt;
            public StringField ApAnlys9Opt;
            public StringField ApAnlys10Opt;
            public StringField ApAnlys11Opt;
            public StringField ApAnlys12Opt;
            public StringField ApAnlys13Opt;
            public StringField ApAnlys14Opt;
            public StringField ApAnlys15Opt;
            public StringField ApAnlys16Opt;
            public StringField ApAnlys17Opt;
            public StringField ApAnlys18Opt;
            public StringField ApAnlys19Opt;
            public StringField ApAnlys20Opt;
            public StringField VochAnlys9Opt;
            public StringField VochAnlys10Opt;
            public StringField VochAnlys11Opt;
            public StringField VochAnlys12Opt;
            public StringField VochAnlys13Opt;
            public StringField VochAnlys14Opt;
            public StringField VochAnlys15Opt;
            public StringField VochAnlys16Opt;
            public StringField VochAnlys17Opt;
            public StringField VochAnlys18Opt;
            public StringField VochAnlys19Opt;
            public StringField VochAnlys20Opt;
            public StringField OlapServer;
            public StringField OlapDatabase;
            public DateTimeField ExpiryDate;
            public Int32Field MaxUsers;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Administration.Company";
            }
        }
    }
}
