#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  JobCategoryForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Enterprise.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Enterprise.JobCategory")]
    [BasedOnRow(typeof(Entities.JobCategoryRow))]
    public class JobCategoryForm
    {
        public String Category { get; set; }
        public String Description { get; set; }
        public Boolean Suspended { get; set; }
        public Decimal Priority { get; set; }
    }
}