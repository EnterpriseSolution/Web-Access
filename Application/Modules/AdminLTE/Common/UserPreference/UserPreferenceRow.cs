#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  UserPreferenceRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Common.Entities
{
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Administration"), DisplayName("User Preferences"), InstanceName("UserPreference"), TwoLevelCached]
    public sealed class UserPreferenceRow : Row, IIdRow, INameRow
    {
        [DisplayName("ID"), Identity]
        public Int32? UserPreferenceId
        {
            get { return Fields.UserPreferenceId[this]; }
            set { Fields.UserPreferenceId[this] = value; }
        }

        [DisplayName("User ID")]
        public string UserId
        {
            get { return Fields.UserId[this]; }
            set { Fields.UserId[this] = value; }
        }

        [DisplayName("PreferenceType"), Size(100), NotNull]
        public String PreferenceType
        {
            get { return Fields.PreferenceType[this]; }
            set { Fields.PreferenceType[this] = value; }
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Value")]
        public String Value
        {
            get { return Fields.Value[this]; }
            set { Fields.Value[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.UserPreferenceId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public UserPreferenceRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public readonly Int32Field UserPreferenceId;
            public readonly StringField UserId;
            public readonly StringField PreferenceType;
            public readonly StringField Name;
            public readonly StringField Value;

            public RowFields()
                : base("UserPreferences")
            {
                LocalTextPrefix = "Common.UserPreference";
            }
        }
    }
}