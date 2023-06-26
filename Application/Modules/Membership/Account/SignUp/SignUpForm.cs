#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  SignUpForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Membership
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Membership.SignUp")]
    public class SignUpForm
    {
        [Required(true), Placeholder("Full name")]
        public String DisplayName { get; set; }
        [EmailEditor, Required(true), Placeholder("Email")]
        public String Email { get; set; }
        [EmailEditor, Required(true), Placeholder("Confirm email")]
        public String ConfirmEmail { get; set; }
        [PasswordEditor, Required(true), Placeholder("Password")]
        public String Password { get; set; }
        [PasswordEditor, Required(true), Placeholder("Confirm password")]
        public String ConfirmPassword { get; set; }
    }
}
