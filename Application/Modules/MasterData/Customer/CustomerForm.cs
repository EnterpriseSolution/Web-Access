#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CustomerForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Common.Enum;

namespace Matrix.MasterData.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MasterData.Customer")]
    [BasedOnRow(typeof(Entities.CustomerRow))]
    public class CustomerForm
    {
        [Tab(TabName.GeneralInformation)]
        public String CustomerNo { get; set; }
        public String CustomerName { get; set; }
        public String CustomerGroup { get; set; }

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
        public String AltCustName { get; set; }
        public String AltCustAddr { get; set; }
        public String AltCustAddr2 { get; set; }
        public String AltCustAddr3 { get; set; }
        public String AltCustAddr4 { get; set; }

        [Tab(TabName.ProcessingInformation)]
        [Category(CategoryName.Control)]
        public bool Suspended { get; set; }
        public String UseAltNames { get; set; }
        public String UseAltDesc { get; set; }
        public String WithCrLimit { get; set; }

        [Category(CategoryName.Payment)]
        public String Salesman { get; set; }
        public String PaymentCcy { get; set; }
        public String PayTerms { get; set; }
        public String PriceCode { get; set; }
        public Decimal CreditLimit { get; set; }
        public String ShipmentTerms { get; set; }
        public String TaxationLv { get; set; }
        public Decimal SltaxPcent { get; set; }




        //public String GtaxCode { get; set; }
        //public String LtaxCode { get; set; }
       
     
      
       
        //public Decimal TradeDiscount { get; set; }
      
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
        //public Decimal LastNoteNo { get; set; }
        ////public String OwnerBranch { get; set; }
        ////public String SourceBranch { get; set; }
       
        //public String MaskCode { get; set; }
        //public String ShortName { get; set; }
        //public Decimal PendAmtOrd { get; set; }
        //public Decimal PendAmtInv { get; set; }
    
      
        //public String IsApproved { get; set; }
        //public String ApprovedBy { get; set; }
        //public String Preapprove { get; set; }
        //public DateTime ApprovedDate { get; set; }

        [Tab(TabName.Account)]
        public String AcctCustSltax { get; set; }
        public String AcctArCust { get; set; }
        public String AcctArDisc { get; set; }
        public String AcctArAdj { get; set; }
        public String AcctSlsTrdisc { get; set; }
        public String AcctTemp { get; set; }
        public String AcctArDeposit { get; set; }
        
        [Tab(TabName.Analysis)]
        public String Anlys1 { get; set; }
        public String Anlys2 { get; set; }
        public String Anlys3 { get; set; }
        public String Anlys4 { get; set; }
        public String Anlys5 { get; set; }
        public String Anlys6 { get; set; }
        public String Anlys7 { get; set; }
        public String Anlys8 { get; set; }
        public String Anlys9 { get; set; }
        public String Anlys10 { get; set; }
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
        
        public Boolean BreakDebitNote { get; set; }
        public String ContractorCode { get; set; }
        public String PayTermsAr { get; set; }
        
    }
}