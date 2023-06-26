﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  NavigationModel.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Navigation
{
    using Matrix.Administration.Entities;
    using Serenity;
    using Serenity.Navigation;
    using System;
    using System.Collections.Generic;
    using System.Web;
    using System.Web.Hosting;

    public partial class NavigationModel
    {
        public List<NavigationItem> Items { get; private set; }
        public int[] ActivePath { get; set; }

        public NavigationModel()
        {
            Items =NavigationHelper.GetNavigationItems(x => x != null && x.StartsWith("~/") ? VirtualPathUtility.ToAbsolute(x) : x);
            SetActivePath();
        }

        private void SetActivePath()
        {
            string currentUrl = "";
            if (HttpContext.Current != null)
            {
                var requestUrl = HttpContext.Current.Request.Url;
                currentUrl = requestUrl.ToString();
                if (!requestUrl.ToString().EndsWith("/") &&
                    String.Compare(requestUrl.AbsolutePath, HostingEnvironment.ApplicationVirtualPath, StringComparison.OrdinalIgnoreCase) == 0)
                    currentUrl += "/";
            }

            int[] currentPath = new int[10];
            int[] bestMatch = null;
            int bestMatchLength = 0;

            foreach (var item in Items)
                SearchActivePath(item, currentUrl, currentPath, 0, ref bestMatch, ref bestMatchLength);

            ActivePath = bestMatch == null ? new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 } : bestMatch;
        }

        private void SearchActivePath(NavigationItem link, string currentUrl, int[] currentPath, int depth,
            ref int[] bestMatch, ref int bestMatchLength)
        {
            currentPath[depth + 1] = 0;
            var url = link.Url ?? "";

            if (url != null && url.StartsWith("~/", StringComparison.Ordinal))
                url = VirtualPathUtility.ToAbsolute(url);

            if (currentUrl.IndexOf(url, StringComparison.OrdinalIgnoreCase) >= 0 &&
                (bestMatchLength == 0 || url.Length > bestMatchLength))
            {
                bestMatch = (int[])currentPath.Clone();
                bestMatchLength = url.Length;
            }

            if (depth <= 9)
            {
                foreach (var child in link.Children)
                    SearchActivePath(child, currentUrl, currentPath, depth + 1, ref bestMatch, ref bestMatchLength);
            }

            currentPath[depth]++;
        }
    }
}