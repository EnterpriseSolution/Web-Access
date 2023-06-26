#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CalendarDetailColumns.cs
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

    [ColumnsScript("MasterData.CalendarDetail")]
    [BasedOnRow(typeof(Entities.CalendarDetailRow))]
    public class CalendarDetailColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String TranMonthCreatedBy { get; set; }
        public DateTime TranDate { get; set; }
        public String TranDay { get; set; }
        public Decimal DayNum { get; set; }
        public String IsHoliday { get; set; }
        public String HalfDayOnly { get; set; }
        public String FirstShift { get; set; }
        public String SecondShift { get; set; }
        public String ThirdShift { get; set; }
        public String CanReceive { get; set; }
        public String CanShip { get; set; }
        public String DayName { get; set; }
        [AlignRight]
        public Decimal LastEntryNo { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
    }
}