#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseRequisitionColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Purchasing.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Purchasing.PurchaseRequisition")]
    [BasedOnRow(typeof(Entities.PurchaseRequisitionRow))]
    public class PurchaseRequisitionColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
       // public Decimal Recnum { get; set; }
        [EditLink]
        public String ReqNo { get; set; }
        //public String Status { get; set; }
        //public String Closed { get; set; }

        public String RequestBy { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime RemindDate { get; set; }
        //public String Reminded { get; set; }
        public String Recipients { get; set; }

        public String Approved { get; set; }
        //public String ApprovedBy { get; set; }
        //public DateTime ApprovedDate { get; set; }

        //public String Comments1 { get; set; }
        //public String Comments2 { get; set; }
        //public String Comments3 { get; set; }
        //public String Comments4 { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String ClosedBy { get; set; }
        //public DateTime ClosedDate { get; set; }
        //public Decimal MessageId { get; set; }
    }
}