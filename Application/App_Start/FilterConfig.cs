#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  FilterConfig.cs
// Date: 2018/04/03 20:51

#endregion
using System.Web.Mvc;

namespace Matrix
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Serenity.Services.AntiforgeryCookieResultFilter());
            filters.Add(new Serenity.Services.AutoValidateAntiforgeryTokenAttribute());
        }
    }
}