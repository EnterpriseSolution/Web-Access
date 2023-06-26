#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  MachineRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBMACH]")]
    [DisplayName("Machine"), InstanceName("Machine"), TwoLevelCached]   
    public sealed class MachineRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(28), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Machine No"), Column("MACHINE_NO"), Size(30), PrimaryKey, QuickSearch]
        public String MachineNo
        {
            get { return Fields.MachineNo[this]; }
            set { Fields.MachineNo[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(60)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Template Code"), Column("TEMPLATE_CODE"), Size(10)]
        public String TemplateCode
        {
            get { return Fields.TemplateCode[this]; }
            set { Fields.TemplateCode[this] = value; }
        }

        [DisplayName("Picture File"), Column("PICTURE_FILE"), Size(255)]
        public String PictureFile
        {
            get { return Fields.PictureFile[this]; }
            set { Fields.PictureFile[this] = value; }
        }

        [DisplayName("Picture"), Column("PICTURE"), Size(2147483647)]
        public Stream Picture
        {
            get { return Fields.Picture[this]; }
            set { Fields.Picture[this] = value; }
        }

        [DisplayName("Remarks"), Column("REMARKS"), Size(200)]
        public String Remarks
        {
            get { return Fields.Remarks[this]; }
            set { Fields.Remarks[this] = value; }
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

        [DisplayName("Last Detail No"), Column("LAST_DETAIL_NO")]
        public Int32? LastDetailNo
        {
            get { return Fields.LastDetailNo[this]; }
            set { Fields.LastDetailNo[this] = value; }
        }

        [DisplayName("Work Centre"), Column("WORK_CENTRE"), Size(10)]
        public String WorkCentre
        {
            get { return Fields.WorkCentre[this]; }
            set { Fields.WorkCentre[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.MachineNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MachineRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField MachineNo;
            public StringField Description;
            public BooleanField Suspended;
            public StringField TemplateCode;
            public StringField PictureFile;
            public StreamField Picture;
            public StringField Remarks;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public Int32Field LastDetailNo;
            public StringField WorkCentre;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Machine";
            }
        }
    }
}
