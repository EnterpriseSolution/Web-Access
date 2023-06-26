#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LookupDialogForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Administration.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Administration.LookupDialog")]
    [BasedOnRow(typeof(Entities.LookupDialogRow))]
    public class LookupDialogForm
    {
        public String Description { get; set; }
        public String QueryId { get; set; }
        public String KeyField1 { get; set; }
        public String KeyField2 { get; set; }
        public String KeyField3 { get; set; }
        public Boolean Suspended { get; set; }
        public String CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public String RevisedBy { get; set; }
        public DateTime RevisedDate { get; set; }
    }
}