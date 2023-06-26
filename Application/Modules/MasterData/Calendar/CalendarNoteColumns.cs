#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CalendarNoteColumns.cs
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

    [ColumnsScript("MasterData.CalendarNote")]
    [BasedOnRow(typeof(Entities.CalendarNoteRow))]
    public class CalendarNoteColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        public DateTime TranDate { get; set; }
        public Decimal EntryNo { get; set; }
        [EditLink]
        public String EntryBy { get; set; }
        public DateTime EntryDate { get; set; }
        public String EntryType { get; set; }
        public String Subject { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
        public String Notes { get; set; }
    }
}