#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  QuotationDetailColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Sales.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Sales.QuotationDetail")]
    [BasedOnRow(typeof(Entities.QuotationDetailRow))]
    public class QuotationDetailColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        //[EditLink]
        //public String RefNoClosed { get; set; }

        public Decimal LineNo { get; set; }
        public String ItemNo { get; set; }
        public String Description { get; set; }
        public String Uom { get; set; }
        public Decimal LotSize { get; set; }
        public Decimal Qty { get; set; }
        public Decimal Price { get; set; }
        //public Decimal Ptax { get; set; }
        public Decimal ExtPrice { get; set; }

        //public Decimal NetPrice { get; set; }
        public Decimal LdiscPcent { get; set; }
        public Decimal LdiscAmt { get; set; }
        public Decimal NetItemAmt { get; set; }

        
        //
        //
        //public Decimal AtaxAmt { get; set; }
        //
        //public Decimal PriceAmt { get; set; }
        //public Decimal PtaxAmt { get; set; }
        //public Decimal PriceCpd { get; set; }
        //public Decimal PtaxCpd { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String Configurable { get; set; }
        //public String CustItemNo { get; set; }
        //public String SpecNo { get; set; }
        //public String BomNo { get; set; }
        //public String StdAssort { get; set; }
        //public String ExtDescription { get; set; }
        //public Decimal SltaxPcent { get; set; }
        //public Decimal SltaxAmt { get; set; }
        //public String Anlys3 { get; set; }
        //public String Anlys4 { get; set; }
        //public String Anlys5 { get; set; }
        //public String Anlys6 { get; set; }
        //public Decimal MarkupPcent { get; set; }
        //public Decimal Markup { get; set; }
        //public String MoldBomNo { get; set; }
        //public String MoldFormulaCode { get; set; }
        //public Decimal MoldExpectedQty { get; set; }
        //public String Anlys15 { get; set; }
        //public String Anlys16 { get; set; }
        //public String Anlys17 { get; set; }
        //public String Anlys18 { get; set; }
        //public String Anlys19 { get; set; }
        //public String Anlys20 { get; set; }
    }
}