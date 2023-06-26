#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  JobCategoryColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Enterprise.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Enterprise.JobCategory")]
    [BasedOnRow(typeof(Entities.JobCategoryRow))]
    public class JobCategoryColumns
    {
        [EditLink]
        public String Category { get; set; }

        public String Description { get; set; }

        [Width(80)]
        public bool Suspended { get; set; }

        [AlignRight]
        public Decimal Priority { get; set; }
    }
}