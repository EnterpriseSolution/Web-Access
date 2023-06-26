#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  UserRow.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Administration.Forms;
using Matrix.Common;

namespace Matrix.Administration.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey(SiteInitialization.Database), TableName("User"), DisplayName("Users"), InstanceName("User"), TwoLevelCached]
    [LookupScript("Administration.User")]
    public sealed class UserRow : Row,IIdRow, INameRow
    {
        [DisplayName("User Id"), Identity,Column("USER_ID")]
        public String UserId
        {
            get { return Fields.UserId[this]; }
            set { Fields.UserId[this] = value; }
        }

        [DisplayName("User Name"),Column("USER_NAME"), Size(100), NotNull, QuickSearch, LookupInclude]
        public String Username
        {
            get { return Fields.Username[this]; }
            set { Fields.Username[this] = value; }
        }

        [DisplayName("User Group"), Column("USER_GROUP"), Size(100), NotNull, LookupInclude]
        public String UserGroup
        {
            get { return Fields.UserGroup[this]; }
            set { Fields.UserGroup[this] = value; }
        }

        [DisplayName("Email"),Column("EMAIL"), Size(100)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        //[DisplayName("User Image"), Size(100)]
        //[ImageUploadEditor(FilenameFormat = "UserImage/~", CopyToHistory = true)]
        //public String UserImage
        //{
        //    get { return Fields.UserImage[this]; }
        //    set { Fields.UserImage[this] = value; }
        //}

        [DisplayName("Password"),Column("PASSWORD"), Size(50)]
        public String Password
        {
            get { return Fields.Password[this]; }
            set { Fields.Password[this] = value; }
        }

        [NotNull, Insertable(false), Updatable(true)]
        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        //[DisplayName("Confirm Password"), Size(50), NotMapped]
        //public String PasswordConfirm
        //{
        //    get { return Fields.PasswordConfirm[this]; }
        //    set { Fields.PasswordConfirm[this] = value; }
        //}

        //[DisplayName("Last Directory Update"), Insertable(false), Updatable(false)]
        //public DateTime? LastDirectoryUpdate
        //{
        //    get { return Fields.LastDirectoryUpdate[this]; }
        //    set { Fields.LastDirectoryUpdate[this] = value; }
        //}
        [NotMapped]
        //[EnumSelectFormatter(EnumKey = "TranslationFormTranslationLanguage", AllowClear = false)]
        public string CompanyCode { get; set; }
        
        IIdField IIdRow.IdField
        {
            get { return Fields.UserId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Username; }
        }

        //Int16Field IIsActiveRow.IsActiveField
        //{
        //    get { return Fields.IsActive; }
        //}

        public static readonly RowFields Fields = new RowFields().Init();

        public UserRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField UserId;
            public StringField Username;
            //public StringField Source;
            public StringField UserGroup;

            //public StringField PasswordHash;
            //public StringField PasswordSalt;
            //public StringField DisplayName;
            public StringField Email;
            // public StringField UserImage;
            // public DateTimeField LastDirectoryUpdate;
              public BooleanField Suspended;

            public StringField Password;
           // public StringField PasswordConfirm;

            public RowFields()
            {
                LocalTextPrefix = "Administration.User";
            }
        }
    }
}