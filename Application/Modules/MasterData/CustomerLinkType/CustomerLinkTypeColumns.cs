﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CustomerLinkTypeColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MasterData.CustomerLinkType")]
    [BasedOnRow(typeof(Entities.CustomerLinkTypeRow))]
    public class CustomerLinkTypeColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String LinkType { get; set; }
        public String Description { get; set; }
        public bool Suspended { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
    }
}