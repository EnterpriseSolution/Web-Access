#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ItemGroupRow.cs
// Date: 2018/04/03 20:51

#endregion
using Microsoft.Common;
using Microsoft.Enums;

namespace Matrix.Enterprise.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Enterprise"), TableName("[dbo].[GBIGRP]")]
    [DisplayName("Item Group"), InstanceName("Item Group"), TwoLevelCached]
    [LookupScript("Enterprise.ItemGroupLookup")]
    public sealed class ItemGroupRow : Row, IIdRow, INameRow
    {
        [DisplayName("Item Group"), Column("ITEM_GROUP"), Size(10), PrimaryKey, QuickSearch]
        public String ItemGroup
        {
            get { return Fields.ItemGroup[this]; }
            set { Fields.ItemGroup[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(40), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(30)]
        [Serenity.Data.BoolStringConverterAttribute]
        public Boolean? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Product"), Column("PRODUCT"), Size(30), NotNull]
        [Serenity.Data.BoolStringConverterAttribute]
        public Boolean? Product
        {
            get { return Fields.Product[this]; }
            set { Fields.Product[this] = value; }
        }

        [DisplayName("Material"), Column("MATERIAL"), Size(30), NotNull]
        [Serenity.Data.BoolStringConverterAttribute]
        public Boolean? Material
        {
            get { return Fields.Material[this]; }
            set { Fields.Material[this] = value; }
        }

        [DisplayName("Inspected"), Column("INSPECTED"), Size(30)]
        [Serenity.Data.BoolStringConverterAttribute]
        public Boolean? Inspected
        {
            get { return Fields.Inspected[this]; }
            set { Fields.Inspected[this] = value; }
        }
       
        [DisplayName("Item Type"), Column("ITEM_TYPE"), Size(3)]
        public string ItemType
        {
            get { return Fields.ItemType[this]; }
            set { Fields.ItemType[this] = value; }
        }

        [DisplayName("Alloc Method"), Column("ALLOC_METHOD"), Size(1)]
        public AllocationMethod? AllocMethod
        {
            get;
            set;

            //get
            //{
            //    return StringEnum<AllocationMethod>.Parse(Fields.AllocMethod[this]);
            //}
            //set
            //{
            //    if (value.HasValue)
            //        Fields.AllocMethod[this] = StringEnum<AllocationMethod>.GetStringValue(value.Value);
            //}
        }

        [DisplayName("Scrap Rate"), Column("SCRAP_RATE"), Size(6), Scale(2)]
        public Decimal? ScrapRate
        {
            get { return Fields.ScrapRate[this]; }
            set { Fields.ScrapRate[this] = value; }
        }

        [DisplayName("MakeOrBuy"), Column("MAKE_OR_BUY"), Size(30), NotNull]
        [Serenity.Data.BoolStringConverterAttribute]
        public Boolean? MakeOrBuy
        {
            get { return Fields.MakeOrBuy[this]; }
            set { Fields.MakeOrBuy[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ItemGroup; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Description; }
        }

        //[NotMapped]
        //public string ItemTypeDescription
        //{
        //    get;
        //    set;
        //    //get
        //    //{
        //    //    if (string.IsNullOrWhiteSpace(this.ItemType))
        //    //        return string.Empty;

        //    //    ItemType itemType = StringEnum<ItemType>.Parse(this.ItemType);
        //    //    return StringEnum<ItemType>.GetDisplayText(itemType);
        //    //}
        //}

        //[NotMapped]
        //public string AllocMethodDescription
        //{
        //    set;
        //    get;
        //    //get
        //    //{
        //    //    if (string.IsNullOrWhiteSpace(this.AllocMethod))
        //    //        return string.Empty;

        //    //    AllocationMethod allocationMethod = StringEnum<AllocationMethod>.Parse(this.AllocMethod);
        //    //    return StringEnum<AllocationMethod>.GetDisplayText(allocationMethod);
        //    //}
        //}

        public static readonly RowFields Fields = new RowFields().Init();

        public ItemGroupRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField ItemGroup;
            public StringField Description;
            public BooleanField Suspended;
            public BooleanField Product;
            public BooleanField Material;
            public BooleanField Inspected;
            public StringField ItemType;
            public StringField AllocMethod;
            public BooleanField MakeOrBuy;
            public DecimalField ScrapRate;
           

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Enterprise.ItemGroup";
            }
        }
    }
}
