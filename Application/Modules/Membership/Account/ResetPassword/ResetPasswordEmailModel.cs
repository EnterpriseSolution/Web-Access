﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ResetPasswordEmailModel.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Membership
{
    public class ResetPasswordEmailModel
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string ResetLink { get; set; }
    }
}