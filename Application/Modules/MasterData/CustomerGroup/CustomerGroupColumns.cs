#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CustomerGroupColumns.cs
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

    [ColumnsScript("Enterprise.CustomerGroup")]
    [BasedOnRow(typeof(Entities.CustomerGroupRow))]
    public class CustomerGroupColumns
    {
        [EditLink]
        public String CustomerGroup { get; set; }

        public String Description { get; set; }

        [Width(80)]
        public Boolean Suspended { get; set; }
    }
}