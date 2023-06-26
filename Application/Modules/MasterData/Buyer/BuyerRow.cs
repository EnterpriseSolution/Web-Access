#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  BuyerRow.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;

namespace Matrix.MasterData.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MasterData"), TableName("[dbo].[PUBUYR]")]
    [DisplayName("Buyer"), InstanceName("Buyer"), TwoLevelCached]   
    public sealed class BuyerRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Buyer Code"), Column("BUYER_CODE"), Size(6), PrimaryKey, QuickSearch]
        public String BuyerCode
        {
            get { return Fields.BuyerCode[this]; }
            set { Fields.BuyerCode[this] = value; }
        }

        [DisplayName("Buyer Name"), Column("BUYER_NAME"), Size(30), NotNull]
        public String BuyerName
        {
            get { return Fields.BuyerName[this]; }
            set { Fields.BuyerName[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("With Backlog"), Column("WITH_BACKLOG"), Size(1), NotNull]
        public String WithBacklog
        {
            get { return Fields.WithBacklog[this]; }
            set { Fields.WithBacklog[this] = value; }
        }

        [DisplayName("On Order Count"), Column("ON_ORDER_COUNT"), Size(6)]
        public Decimal? OnOrderCount
        {
            get { return Fields.OnOrderCount[this]; }
            set { Fields.OnOrderCount[this] = value; }
        }

        [DisplayName("Last Line No"), Column("LAST_LINE_NO"), Size(8)]
        public Decimal? LastLineNo
        {
            get { return Fields.LastLineNo[this]; }
            set { Fields.LastLineNo[this] = value; }
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

        [DisplayName("Supervisor"), Column("SUPERVISOR"), Size(6)]
        public String Supervisor
        {
            get { return Fields.Supervisor[this]; }
            set { Fields.Supervisor[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.BuyerCode; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.BuyerName; }
        }
        

        [DisplayName("Buyer List")]
        [MasterDetailRelation("BuyerCode"), BuyerDetailEditor]
        public List<BuyerDetailRow> AttendeeList
        {
            get { return Fields.AttendeeList[this]; }
            set { Fields.AttendeeList[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public BuyerRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public ListField<BuyerDetailRow> AttendeeList;

            public DecimalField Recnum;
            public StringField BuyerCode;
            public StringField BuyerName;
            public BooleanField Suspended;
            public StringField WithBacklog;
            public DecimalField OnOrderCount;
            public DecimalField LastLineNo;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Supervisor;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Buyer";
            }
        }
    }

    public partial class BuyerDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "NorthwindSerene.Meeting.MeetingAttendeeEditor";

        public BuyerDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}
