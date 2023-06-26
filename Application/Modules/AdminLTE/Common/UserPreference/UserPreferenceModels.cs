#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  UserPreferenceModels.cs
// Date: 2018/04/03 20:51

#endregion

using Serenity.Services;

namespace Matrix.Common
{
    public class UserPreferenceUpdateRequest : ServiceRequest
    {
        public string PreferenceType { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class UserPreferenceRetrieveRequest : ServiceRequest
    {
        public string PreferenceType { get; set; }
        public string Name { get; set; }
    }

    public class UserPreferenceRetrieveResponse : ServiceResponse
    {
        public string Value { get; set; }
    }

}