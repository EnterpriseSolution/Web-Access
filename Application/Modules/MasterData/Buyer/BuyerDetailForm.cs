#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  BuyerDetailForm.cs
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

    [FormScript("MasterData.BuyerDetail")]
    [BasedOnRow(typeof(Entities.BuyerDetailRow))]
    public class BuyerDetailForm
    {
        public String BuyerCode { get; set; }
        public String VendorNo { get; set; }
        public String VendorName { get; set; }
    }
}