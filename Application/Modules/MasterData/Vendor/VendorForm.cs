#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Common.Enum;

namespace Matrix.Enterprise.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Enterprise.Vendor")]
    [BasedOnRow(typeof(Entities.VendorRow))]
    public class VendorForm
    {
        [Tab(TabName.GeneralInformation)]
        public String VendorNo { get; set; }
        public String VendorName { get; set; }
        public String VendorGroup { get; set; }

        [Category(CategoryName.BasicInformation)]
        public String Address { get; set; }
        public String Address2 { get; set; }
        public String Address3 { get; set; }
        public String Address4 { get; set; }
        public String PostCode { get; set; }
        public String TelNo { get; set; }
        public String FaxNo { get; set; }
        public String Email { get; set; }
        public String ContactPerson { get; set; }
        public String ContactTitle { get; set; }

        [Category(CategoryName.AlternateInformation)]
        //
        public String AltVendorName { get; set; }
        public String AltAddress { get; set; }
        public String AltAddress2 { get; set; }
        public String AltAddress3 { get; set; }
        public String AltAddress4 { get; set; }

        [Tab(TabName.ProcessingInformation)]
        [Category(CategoryName.Control)]
        public bool Suspended { get; set; }
        public String UseAltNames { get; set; }
        public String UseAltDesc { get; set; }

        [Category(CategoryName.Payment)]
        public String OrderCcy { get; set; }
        public String PayTerms { get; set; }
        public String BuyerCode { get; set; }
        public Decimal LeadTime { get; set; }
        public Decimal PutaxPcent { get; set; }
        public String TaxationLv { get; set; }
        public String BankName { get; set; }
        public String BankAcctNo { get; set; }

        //public String GtaxCode { get; set; }
        //public String LtaxCode { get; set; }
        //public String AcctApVend { get; set; }
        //public String AcctApDisc { get; set; }
        //public String AcctApAdj { get; set; }
        //public String AcctPurTrdisc { get; set; }
     
        //public String WithCrLimit { get; set; }
        //public Decimal CreditLimit { get; set; }
        //public Decimal TradeDiscount { get; set; }
      

        //[Category(CategoryName.BuyerControl)]
       
      
        //public String PurPriceCtrl { get; set; }
        //public Decimal PurMaxDev { get; set; }
        //public Decimal PendAmtOrd { get; set; }
        //public Decimal PendAmtInv { get; set; }
        //public String AcctVendPutax { get; set; }

        //[Tab(TabName.Finance)]
        //[Category(CategoryName.Account)]
    
        //public String TaxTerms { get; set; }
        //public String CustomTerms { get; set; }
        //public String AcctApDeposit { get; set; }
        //public String AcctTemp { get; set; }
        
        //[Category(CategoryName.AccountPayable)]
        //public Decimal OverReceiptPcent { get; set; }
        //public String WithBacklog { get; set; }
        //public String WithBalance { get; set; }
        //public Decimal OnOrderCount { get; set; }
        //public Decimal InvoAmtBal { get; set; }
        //public Decimal OpenAmtBal { get; set; }
        //public Decimal NetAmtBal { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime ArevisedDate { get; set; }
        //public String ArevisedBy { get; set; }
        //public DateTime TrevisedDate { get; set; }
        //public String TrevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }

        //public String IsApproved { get; set; }
        //public String ApprovedBy { get; set; }
        //public String Preapprove { get; set; }
        //public DateTime ApprovedDate { get; set; }

        [Category(CategoryName.Intercompany)]
        public String RefCompanyCode { get; set; }
        public String RefCustomerNo { get; set; }
        public Boolean RefIntegrateComments { get; set; }
        public Boolean RefIntegrateAnlys { get; set; }
        
        //[Tab(TabName.Analysis)]
        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
        //public String Anlys3 { get; set; }
        //public String Anlys4 { get; set; }
        //public String Anlys5 { get; set; }
        //public String Anlys6 { get; set; }
        //public String Anlys7 { get; set; }
        //public String Anlys8 { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }

        //[Tab(TabName.UserDefinedField)]
        //public String UserDefinedField1 { get; set; }
        //public String UserDefinedField2 { get; set; }
        //public String UserDefinedField3 { get; set; }
        //public String UserDefinedField4 { get; set; }
        //public String UserDefinedField5 { get; set; }
        //public String UserDefinedField6 { get; set; }
        //public String UserDefinedField7 { get; set; }
        //public String UserDefinedField8 { get; set; }
        //public String UserDefinedField9 { get; set; }
        //public String UserDefinedField10 { get; set; }
        //public String UserDefinedField11 { get; set; }
        //public String UserDefinedField12 { get; set; }
        //public String UserDefinedField13 { get; set; }
        //public String UserDefinedField14 { get; set; }
        //public String UserDefinedField15 { get; set; }
        //public String UserDefinedField16 { get; set; }
        //public String UserDefinedField17 { get; set; }
        //public String UserDefinedField18 { get; set; }
        //public String UserDefinedField19 { get; set; }
        //public String UserDefinedField20 { get; set; }
    }
}