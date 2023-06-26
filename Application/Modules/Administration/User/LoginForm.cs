#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LoginForm.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Matrix.Administration.Entities;
using Serenity.ComponentModel;

namespace Matrix.Membership
{
    [FormScript("Membership.Login")]
    [BasedOnRow(typeof(Administration.Entities.UserRow))]
    public class LoginForm
    {
        [Placeholder("default username is 'admin'"), Required(true), DefaultValue("MIS")]
        public string Username { get; set; }

        [PasswordEditor, Placeholder("default password for 'admin' is 'serenity'"), Required(true),DefaultValue("MIS")]
        public string Password { get; set; }

        [Placeholder("default company code is 'STD'"), DisplayName("Company Code"), Required(true), DefaultValue("STD")]
        [LookupEditor(typeof(CompanyRow))]
        public string CompanyCode { get; set; }
    }
}