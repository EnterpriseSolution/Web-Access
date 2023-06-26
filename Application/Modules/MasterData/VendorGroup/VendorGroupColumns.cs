﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorGroupColumns.cs
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

    [ColumnsScript("Enterprise.VendorGroup")]
    [BasedOnRow(typeof(Entities.VendorGroupRow))]
    public class VendorGroupColumns
    {
        [EditLink]
        public String VendorGroup { get; set; }

        public String Description { get; set; }

        [Width(80)]
        public bool Suspended { get; set; }
    }
}