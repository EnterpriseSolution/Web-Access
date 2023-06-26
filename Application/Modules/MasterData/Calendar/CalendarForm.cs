#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CalendarForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MasterData.Calendar")]
    [BasedOnRow(typeof(Entities.CalendarRow))]
    public class CalendarForm
    {
        public String TranMonth { get; set; }
        public Decimal TranYear { get; set; }
        public Decimal MonthNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
    }
}