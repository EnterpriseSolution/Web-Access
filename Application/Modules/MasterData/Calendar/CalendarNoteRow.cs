#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CalendarNoteRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBCALN]")]
    [DisplayName("Calendar Note"), InstanceName("Calendar Note"), TwoLevelCached]   
    public sealed class CalendarNoteRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Tran Date"), Column("TRAN_DATE"), PrimaryKey]
        public DateTime? TranDate
        {
            get { return Fields.TranDate[this]; }
            set { Fields.TranDate[this] = value; }
        }

        [DisplayName("Entry No"), Column("ENTRY_NO"), Size(8), PrimaryKey]
        public Decimal? EntryNo
        {
            get { return Fields.EntryNo[this]; }
            set { Fields.EntryNo[this] = value; }
        }

        [DisplayName("Entry By"), Column("ENTRY_BY"), Size(10), QuickSearch]
        public String EntryBy
        {
            get { return Fields.EntryBy[this]; }
            set { Fields.EntryBy[this] = value; }
        }

        [DisplayName("Entry Date"), Column("ENTRY_DATE")]
        public DateTime? EntryDate
        {
            get { return Fields.EntryDate[this]; }
            set { Fields.EntryDate[this] = value; }
        }

        [DisplayName("Entry Type"), Column("ENTRY_TYPE"), Size(10)]
        public String EntryType
        {
            get { return Fields.EntryType[this]; }
            set { Fields.EntryType[this] = value; }
        }

        [DisplayName("Subject"), Column("SUBJECT"), Size(50), NotNull]
        public String Subject
        {
            get { return Fields.Subject[this]; }
            set { Fields.Subject[this] = value; }
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

        [DisplayName("Notes"), Column("NOTES"), Size(1073741823)]
        public String Notes
        {
            get { return Fields.Notes[this]; }
            set { Fields.Notes[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.EntryBy; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CalendarNoteRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public DateTimeField TranDate;
            public DecimalField EntryNo;
            public StringField EntryBy;
            public DateTimeField EntryDate;
            public StringField EntryType;
            public StringField Subject;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Notes;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.CalendarNote";
            }
        }
    }
}
