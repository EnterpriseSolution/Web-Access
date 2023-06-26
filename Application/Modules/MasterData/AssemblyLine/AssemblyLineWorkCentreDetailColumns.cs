#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AssemblyLineWorkCentreDetailColumns.cs
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

    [ColumnsScript("MasterData.AssemblyLineWorkCentreDetail")]
    [BasedOnRow(typeof(Entities.AssemblyLineWorkCentreDetailRow))]
    public class AssemblyLineWorkCentreDetailColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        //[EditLink]
        //public String AssemblyLineDescription { get; set; }
        public Decimal SeqNo { get; set; }
        public String WorkCentreDescription { get; set; }
        public String Description { get; set; }
        public bool Alternate { get; set; }
        public bool Suspended { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
    }
}