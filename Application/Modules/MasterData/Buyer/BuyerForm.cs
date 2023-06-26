#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  BuyerForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MasterData.Buyer")]
    [BasedOnRow(typeof(Entities.BuyerRow))]
    public class BuyerForm
    {
        public String BuyerCode { get; set; }
        public String BuyerName { get; set; }
        public bool Suspended { get; set; }
        //public String WithBacklog { get; set; }
        //public Decimal OnOrderCount { get; set; }
        //public Decimal LastLineNo { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        public String Supervisor { get; set; }
    }
}