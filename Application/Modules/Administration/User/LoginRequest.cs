#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LoginRequest.cs
// Date: 2018/04/03 20:51

#endregion

using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
using Matrix.Administration;
using Matrix.Administration.Entities;
using Matrix.Administration.Forms;
using Serenity.ComponentModel;
using Serenity.Services;

namespace Matrix.Membership
{
    public class LoginRequest : ServiceRequest
    {
        //[Placeholder("default username is 'admin'")]
        [DisplayName("User Id")]
        public string Username { get; set; }

        //[PasswordEditor, Placeholder("default password for 'admin' is 'serenity'"), Required(true)]
        public string Password { get; set; }

        //[Placeholder("default company code is 'STD'"),DisplayName("Company Code")]
        //[LookupEditor(typeof(CompanyRow))]
        public string CompanyCode { get; set; }
    }
}