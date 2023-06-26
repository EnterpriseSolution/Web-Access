#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  UserForm.cs
// Date: 2018/04/03 20:51

#endregion
namespace Matrix.Administration.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Administration.User")]
    [BasedOnRow(typeof(Entities.UserRow))]
    public class UserForm
    {
        public String UserId { get; set; }

        public String Username { get; set; }

        //public String DisplayName { get; set; }

        [EmailEditor]
        public String Email { get; set; }

        //public String UserImage { get; set; }

        [PasswordEditor, Required(true)]
        public String Password { get; set; }
    }
}