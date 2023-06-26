#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ItemGroupColumns.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Basic.ItemGroup;

namespace Matrix.Enterprise.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Enterprise.ItemGroup")]
    [BasedOnRow(typeof(Entities.ItemGroupRow))]
    public class ItemGroupColumns
    {
        [EditLink]
        public String ItemGroup { get; set; }

        public String Description { get; set; }
        [Width(80)]
        public Boolean Suspended { get; set; }
        [Width(80)]
        public Boolean Product { get; set; }
        [Width(80)]
        public Boolean Material { get; set; }
        [Width(80)]
        public Boolean Inspected { get; set; }
        
        [DisplayName("Allocation Method"), Width(140)]
        [AllocationMethodFormatter]
        public string AllocMethod { get; set; }

        [DisplayName("Item Type"), Width(180)]
        [ItemTypeFormatter]
        public string ItemType { get; set; }
        
        [Width(80),DisplayName("Make")]
        public Boolean MakeOrBuy { get; set; }

        [AlignRight]
        public Decimal ScrapRate { get; set; }
      }
}