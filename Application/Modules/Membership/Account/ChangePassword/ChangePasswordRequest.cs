#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ChangePasswordRequest.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Membership
{
    using Serenity.ComponentModel;
    using Serenity.Services;
    using System.ComponentModel;

    [FormScript("Membership.ChangePassword")]
    public class ChangePasswordRequest : ServiceRequest
    {
        [PasswordEditor, Required(true), DisplayName("Current Password")]
        public string OldPassword { get; set; }
        [PasswordEditor, Required(true), DisplayName("New Password")]
        public string NewPassword { get; set; }
        [PasswordEditor, Required(true), DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}