#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CalendarDetailRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MasterData"), TableName("[dbo].[GBCALD]")]
    [DisplayName("Calendar Detail"), InstanceName("Calendar Detail"), TwoLevelCached]   
    public sealed class CalendarDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Tran Month"), Column("TRAN_MONTH"), Size(7), PrimaryKey, ForeignKey("[dbo].[GBCALH]", "TRAN_MONTH"), LeftJoin("jTranMonth"), QuickSearch, TextualField("TranMonthCreatedBy")]
        public String TranMonth
        {
            get { return Fields.TranMonth[this]; }
            set { Fields.TranMonth[this] = value; }
        }

        [DisplayName("Tran Date"), Column("TRAN_DATE"), PrimaryKey]
        public DateTime? TranDate
        {
            get { return Fields.TranDate[this]; }
            set { Fields.TranDate[this] = value; }
        }

        [DisplayName("Tran Day"), Column("TRAN_DAY"), Size(10), NotNull]
        public String TranDay
        {
            get { return Fields.TranDay[this]; }
            set { Fields.TranDay[this] = value; }
        }

        [DisplayName("Day Num"), Column("DAY_NUM"), Size(2)]
        public Decimal? DayNum
        {
            get { return Fields.DayNum[this]; }
            set { Fields.DayNum[this] = value; }
        }

        [DisplayName("Is Holiday"), Column("IS_HOLIDAY"), Size(1), NotNull]
        public String IsHoliday
        {
            get { return Fields.IsHoliday[this]; }
            set { Fields.IsHoliday[this] = value; }
        }

        [DisplayName("Half Day Only"), Column("HALF_DAY_ONLY"), Size(1)]
        public String HalfDayOnly
        {
            get { return Fields.HalfDayOnly[this]; }
            set { Fields.HalfDayOnly[this] = value; }
        }

        [DisplayName("First Shift"), Column("FIRST_SHIFT"), Size(1)]
        public String FirstShift
        {
            get { return Fields.FirstShift[this]; }
            set { Fields.FirstShift[this] = value; }
        }

        [DisplayName("Second Shift"), Column("SECOND_SHIFT"), Size(1)]
        public String SecondShift
        {
            get { return Fields.SecondShift[this]; }
            set { Fields.SecondShift[this] = value; }
        }

        [DisplayName("Third Shift"), Column("THIRD_SHIFT"), Size(1)]
        public String ThirdShift
        {
            get { return Fields.ThirdShift[this]; }
            set { Fields.ThirdShift[this] = value; }
        }

        [DisplayName("Can Receive"), Column("CAN_RECEIVE"), Size(1)]
        public String CanReceive
        {
            get { return Fields.CanReceive[this]; }
            set { Fields.CanReceive[this] = value; }
        }

        [DisplayName("Can Ship"), Column("CAN_SHIP"), Size(1)]
        public String CanShip
        {
            get { return Fields.CanShip[this]; }
            set { Fields.CanShip[this] = value; }
        }

        [DisplayName("Day Name"), Column("DAY_NAME"), Size(30), NotNull]
        public String DayName
        {
            get { return Fields.DayName[this]; }
            set { Fields.DayName[this] = value; }
        }

        [DisplayName("Last Entry No"), Column("LAST_ENTRY_NO"), Size(8)]
        public Decimal? LastEntryNo
        {
            get { return Fields.LastEntryNo[this]; }
            set { Fields.LastEntryNo[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE")]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10)]
        public String CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Revised Date"), Column("REVISED_DATE")]
        public DateTime? RevisedDate
        {
            get { return Fields.RevisedDate[this]; }
            set { Fields.RevisedDate[this] = value; }
        }

        [DisplayName("Revised By"), Column("REVISED_BY"), Size(10)]
        public String RevisedBy
        {
            get { return Fields.RevisedBy[this]; }
            set { Fields.RevisedBy[this] = value; }
        }

        [DisplayName("Owner Branch"), Column("OWNER_BRANCH"), Size(4)]
        public String OwnerBranch
        {
            get { return Fields.OwnerBranch[this]; }
            set { Fields.OwnerBranch[this] = value; }
        }

        [DisplayName("Source Branch"), Column("SOURCE_BRANCH"), Size(4)]
        public String SourceBranch
        {
            get { return Fields.SourceBranch[this]; }
            set { Fields.SourceBranch[this] = value; }
        }

        [DisplayName("Tran Month Recnum"), Expression("jTranMonth.[RECNUM]")]
        public Decimal? TranMonthRecnum
        {
            get { return Fields.TranMonthRecnum[this]; }
            set { Fields.TranMonthRecnum[this] = value; }
        }

        [DisplayName("Tran Month Tran Year"), Expression("jTranMonth.[TRAN_YEAR]")]
        public Decimal? TranMonthTranYear
        {
            get { return Fields.TranMonthTranYear[this]; }
            set { Fields.TranMonthTranYear[this] = value; }
        }

        [DisplayName("Tran Month Month No"), Expression("jTranMonth.[MONTH_NO]")]
        public Decimal? TranMonthMonthNo
        {
            get { return Fields.TranMonthMonthNo[this]; }
            set { Fields.TranMonthMonthNo[this] = value; }
        }

        [DisplayName("Tran Month Created Date"), Expression("jTranMonth.[CREATED_DATE]")]
        public DateTime? TranMonthCreatedDate
        {
            get { return Fields.TranMonthCreatedDate[this]; }
            set { Fields.TranMonthCreatedDate[this] = value; }
        }

        [DisplayName("Tran Month Created By"), Expression("jTranMonth.[CREATED_BY]")]
        public String TranMonthCreatedBy
        {
            get { return Fields.TranMonthCreatedBy[this]; }
            set { Fields.TranMonthCreatedBy[this] = value; }
        }

        [DisplayName("Tran Month Owner Branch"), Expression("jTranMonth.[OWNER_BRANCH]")]
        public String TranMonthOwnerBranch
        {
            get { return Fields.TranMonthOwnerBranch[this]; }
            set { Fields.TranMonthOwnerBranch[this] = value; }
        }

        [DisplayName("Tran Month Source Branch"), Expression("jTranMonth.[SOURCE_BRANCH]")]
        public String TranMonthSourceBranch
        {
            get { return Fields.TranMonthSourceBranch[this]; }
            set { Fields.TranMonthSourceBranch[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.TranMonth; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CalendarDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField TranMonth;
            public DateTimeField TranDate;
            public StringField TranDay;
            public DecimalField DayNum;
            public StringField IsHoliday;
            public StringField HalfDayOnly;
            public StringField FirstShift;
            public StringField SecondShift;
            public StringField ThirdShift;
            public StringField CanReceive;
            public StringField CanShip;
            public StringField DayName;
            public DecimalField LastEntryNo;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;

            public DecimalField TranMonthRecnum;
            public DecimalField TranMonthTranYear;
            public DecimalField TranMonthMonthNo;
            public DateTimeField TranMonthCreatedDate;
            public StringField TranMonthCreatedBy;
            public StringField TranMonthOwnerBranch;
            public StringField TranMonthSourceBranch;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.CalendarDetail";
            }
        }
    }
}
