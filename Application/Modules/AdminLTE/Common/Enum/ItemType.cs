#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ItemType.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.Common;
using Serenity;
using Serenity.ComponentModel;

namespace Matrix
{
    [EnumKey("Enums.ItemType")]
    public enum ItemType
    {
        [StringValue("STD")]
        [Description("Standard Stocked Item")]
        StandardStockItem,

        [StringValue("STA")]
        [Description("Standard Assortment")]
        StandardAssortment,

        [StringValue("CFA")]
        [Description("Configurable Assortment")]
        ConfiguredAssortment,

        [StringValue("NSI")]
        [Description("Non-Stocked Item")]
        NonStockItem
    }
}
