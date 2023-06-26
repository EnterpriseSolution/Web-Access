#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  EnterpriseNavigation.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Matrix.Enterprisesys.Entities;
using Matrix.EnterpriseSys.Entities;
using Serenity.Data;
using Serenity.Navigation;
using MyPages = Matrix.EnterpriseSys.Pages;

namespace Matrix.BasicSamples
{
    public class EnterpriseNavigation : INavigationItemSource
    {
        string USERG_GROUP = "SYSADM";
        public List<NavigationItemAttribute> GetItems()
        {
            USERG_GROUP = System.Configuration.ConfigurationManager.AppSettings["MenuUserGroup"];

            List<NavigationItemAttribute> itemList =new List<NavigationItemAttribute>(); 
            
            using (var connection = SqlConnections.NewByKey(SiteInitialization.Database))
            {
                string file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "configuration.json");
                string jsonString = File.ReadAllText(file);
                dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString);

                Dictionary<string,string> iconDictionary=new Dictionary<string, string>();
                foreach (var icon in result.Icons.Default)
                {
                    iconDictionary.Add((string)icon.module, (string)icon.value);
                }

                var menuRows = connection.List<MenuRow>(q =>
                {
                    q.SelectTableFields()
                        .Where(new Criteria(MenuRow.Fields.UserGroup) == USERG_GROUP);
                }); 
                var menuTypeRows = connection.List<MenuTypeRow>(q =>
                {
                    q.SelectTableFields()
                        .Where(new Criteria(MenuTypeRow.Fields.UserGroup) == USERG_GROUP);
                }); 
                var menuItemRows = connection.List<MenuItemRow>(q =>
                {
                    q.SelectTableFields()
                        .Where(new Criteria(MenuItemRow.Fields.UserGroup) == USERG_GROUP);
                }); 
                var systemFunctionRow = connection.List<SystemFunctionRow>(q =>
                {
                    q.SelectTableFields()
                        .Where(new Criteria(SystemFunctionRow.Fields.Suspended) == "N");
                }); 

                var fistLevel = menuRows.Where(t => t.MenuLevel == 1 && t.UserGroup==USERG_GROUP && t.Suspended=="N").OrderBy(t=>t.MenuCode).ToList();
                //var secondaryLevel = menuRows.Where(t => t.MenuLevel == 2 && t.UserGroup == USERG_GROUP && t.Suspended == "N").OrderBy(t => t.MenuCode).ToList();
                int orderMenu = 100;
                foreach (MenuRow row in fistLevel)
                {
                    List<NavigationItemAttribute> items = null;
                    string defaultIcon = iconDictionary.ContainsKey(row.Description) ? iconDictionary[row.Description] : "icon-folder";
                    items = new List<NavigationItemAttribute>
                    {
                        new NavigationMenuAttribute(orderMenu, row.Description,defaultIcon)
                    };
                    

                    //var rows = secondaryLevel.Where(t => t.MenuCode.Contains(menuRow.MenuCode) && t.UserGroup == USERG_GROUP).ToList();
                    //foreach (MenuRow row in rows)
                    //{
                    //    row.MenuCodeShort = Convert.ToInt32(row.MenuCode.Replace(menuRow.MenuCode, ""));
                    //}
                    //rows = rows.OrderBy(t => t.MenuCodeShort).ToList();

                    //foreach (MenuRow row in rows)
                    //{
                        var types =menuTypeRows.Where(t => t.UserGroup == row.UserGroup && t.ProcessCode == row.ProcessCode && t.UserGroup == USERG_GROUP && t.Suspended == "N").OrderBy(t => t.MenuCode).ToList();
                        int orderLink = 10;
                        foreach (MenuTypeRow typeRow in types)
                        {
                            
                            var functioncodes =menuItemRows.Where(t =>
                                        t.UserGroup == typeRow.UserGroup && t.ProcessCode == typeRow.ProcessCode &&
                                        t.MenuType == typeRow.MenuType && t.Suspended == "N").OrderBy(t => t.MenuCode).ToList();
                            foreach (MenuItemRow functioncode in functioncodes)
                            {
                                string path = string.Format("{0}/{1}/{2}", row.Description.Replace("/", ""), 
                                    typeRow.Description.Replace("&", ""), functioncode.Description);

                                string extension = string.Empty;
                                var function = systemFunctionRow.FirstOrDefault(t => t.FunctionCode == functioncode.FunctionCode);
                                if (function != null && !string.IsNullOrWhiteSpace(function.Extension))
                                    extension = function.Extension;

                                //STD:BasicInformation:ItemGroup => ~/BasicInformation/ItemGroup
                                //RPT:Reports:SLSOSOD => ~/Reports/Report?ReportId=SLSOSOD
                                //string icon = "icon-folder";
                                defaultIcon = iconDictionary.ContainsKey(row.Description) ? iconDictionary[row.Description] : "icon-folder";
                                string url =string.Format("{0}/{1}", row.Description.Replace("/", ""), row.Description);
                                int orderLevel =Convert.ToInt32(orderMenu.ToString() + orderLink.ToString());
                                string module = string.Empty;
                                string functionType = string.Empty;
                                string functionCode = string.Empty;
                                defaultIcon = "fa-tablet";
                                if (!string.IsNullOrWhiteSpace(extension))
                                {
                                    string[] array = Regex.Split(extension, ":", RegexOptions.IgnorePatternWhitespace);
                                    if (array.Length == 3)
                                    {
                                        functionType = array[0];
                                        module = array[1];
                                        functionCode = array[2];
                                        switch (functionType)
                                        {
                                            case "STD":
                                                url = string.Format("~/{0}/{1}", module, functionCode);
                                                break;
                                            case "RPT":
                                                url = string.Format("~/Reports/Report?ReportId={0}", functionCode);
                                                break;


                                        }
                                    }

                                    items.Add(new NavigationLinkAttribute(orderLevel, path: path, url: url,
                                        permission: "", iconClass: defaultIcon, icon: defaultIcon));

                                    orderLink++;
                                }
                            }

                        }

                        orderMenu += 100;
                        items.ForEach(i => itemList.Add(i));
                }
            }
            
            return itemList;
        }
    }

}
