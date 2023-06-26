#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ReasonCodeForm.cs
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

    [FormScript("MasterData.ReasonCode")]
    [BasedOnRow(typeof(Entities.ReasonCodeRow))]
    public class ReasonCodeForm
    {
        public String ReasonCode { get; set; }
        public String Description { get; set; }
        public bool Suspended { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Remarks { get; set; }
    }
}