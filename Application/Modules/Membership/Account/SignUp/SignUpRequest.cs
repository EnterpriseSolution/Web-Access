#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  SignUpRequest.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Membership
{
    using Serenity.Services;
    using System;

    public class SignUpRequest : ServiceRequest
    {
        public String DisplayName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
    }
}