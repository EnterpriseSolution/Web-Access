#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  TabDetailColumns.cs
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

    [ColumnsScript("MasterData.TabDetail")]
    [BasedOnRow(typeof(Entities.TabDetailRow))]
    public class TabDetailColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public String TabidCaption { get; set; }
        [EditLink]
        public String ItemGroup { get; set; }
        public String Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
    }
}