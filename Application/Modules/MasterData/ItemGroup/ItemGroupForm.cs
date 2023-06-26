#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ItemGroupForm.cs
// Date: 2018/04/03 20:51

#endregion
using Matrix.Administration.Entities;
using Microsoft.Enums;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Matrix.Enterprise.Forms
{
    [FormScript("Enterprise.ItemGroup")]
    [BasedOnRow(typeof(Entities.ItemGroupRow))]
    public class ItemGroupForm
    {
        public String ItemGroup { get; set; }
        public String Description { get; set; }
        public Boolean Suspended { get; set; }
        public Boolean Product { get; set; }
        public Boolean Material { get; set; }
        public Boolean Inspected { get; set; }
        //[LookupEditor(typeof(CompanyRow))]
        //public ItemType ItemType  { get; set; }
        //public String ItemType { get; set; }
        public AllocationMethod AllocMethod { get; set; }
        public Boolean MakeOrBuy { get; set; }
        public Decimal ScrapRate { get; set; }

    }
}