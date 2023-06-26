#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  DepartmentForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Enterprise.Entities;
using Matrix.Modules.Common;

namespace Matrix.Enterprise.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Enterprise.Department")]
    [BasedOnRow(typeof(Entities.DepartmentRow))]
    public class DepartmentForm
    {
        [Updatable(false)]
        public String Dept { get; set; }
        public String Description { get; set; }
        public Boolean Suspended { get; set; }

        //[LookupEditor(typeof(ItemGroupRow))]
        //public String RevisedBy { get; set; }

        //[EnterpriseLookup("ItemLookup", "Non Suspended")]
        //public String CreatedBy { get; set; }
    }
}