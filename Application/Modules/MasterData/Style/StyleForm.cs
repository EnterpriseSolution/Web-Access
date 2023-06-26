#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  StyleForm.cs
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

    [FormScript("MasterData.Style")]
    [BasedOnRow(typeof(Entities.StyleRow))]
    public class StyleForm
    {
        [Updatable(false)]
        public String StyleCode { get; set; }
        public String CollectionCode { get; set; }
        public String Description { get; set; }
        //public String ChineseDescription { get; set; }
        public Decimal DieCutter { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
    }
}