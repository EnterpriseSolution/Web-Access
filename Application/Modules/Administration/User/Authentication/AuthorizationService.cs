#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AuthorizationService.cs
// Date: 2018/04/03 20:51

#endregion
namespace Matrix.Administration
{
    using Serenity;
    using Serenity.Abstractions;

    public class AuthorizationService : IAuthorizationService
    {
        public bool IsLoggedIn
        {
            get { return !string.IsNullOrEmpty(Username); }
        }

        public string Username
        {
            get { return WebSecurityHelper.HttpContextUsername; }
        }
    }
}