#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PanelRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBPANL]")]
    [DisplayName("Panel"), InstanceName("Panel"), TwoLevelCached]   
    public sealed class PanelRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Identity]
        public Int32? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Panel Code"), Column("PANEL_CODE"), Size(8), PrimaryKey, QuickSearch]
        public String PanelCode
        {
            get { return Fields.PanelCode[this]; }
            set { Fields.PanelCode[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(60)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Length"), Column("LENGTH"), Size(12), Scale(4)]
        public Decimal? Length
        {
            get { return Fields.Length[this]; }
            set { Fields.Length[this] = value; }
        }

        [DisplayName("Width"), Column("WIDTH"), Size(12), Scale(4)]
        public Decimal? Width
        {
            get { return Fields.Width[this]; }
            set { Fields.Width[this] = value; }
        }

        [DisplayName("Dim Uom"), Column("DIM_UOM"), Size(4)]
        public String DimUom
        {
            get { return Fields.DimUom[this]; }
            set { Fields.DimUom[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED")]
        [BoolStringConverter]
        public Boolean? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
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

        [DisplayName("Item Group"), Column("ITEM_GROUP"), Size(10)]
        public String ItemGroup
        {
            get { return Fields.ItemGroup[this]; }
            set { Fields.ItemGroup[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.PanelCode; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PanelRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Recnum;
            public StringField PanelCode;
            public StringField Description;
            public DecimalField Length;
            public DecimalField Width;
            public StringField DimUom;
            public BooleanField Suspended;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField ItemGroup;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Panel";
            }
        }
    }
}
