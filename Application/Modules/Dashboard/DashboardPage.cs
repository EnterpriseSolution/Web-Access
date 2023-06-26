#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  DashboardPage.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Security;
using Matrix.MasterData.Entities;
using Matrix.MasterData.Repositories;
using Serenity.Services;
using X.PagedList;

/*
 fld is a reference to your entity fields (metadata), not the entity instance itself.

In SaveHandler, this.Row references to created/updated entity with new values, while this.Old references entity with old values for update (kinda similar to a SQL trigger).

So you should write Row.LastModifiedBy = userId;

FYI, instead of doing it this way in every repository, implement IUpdateLogRow (and/or InsertLogRow) interfaces in your entity and default save behaviors will fill Insert/Update UserId/Date fields automatically.

Define a base row like LoggingRow sample in Serene to avoid having to implement this interface in every entity

    
391
down vote
accepted
From: http://jquery-howto.blogspot.com/2009/09/get-url-parameters-values-with-jquery.html

This is what you need :)

The following code will return a JavaScript Object containing the URL parameters:

// Read a page's GET URL variables and return them as an associative array.
function getUrlVars()
{
    var vars = [], hash;
    var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
    for(var i = 0; i < hashes.length; i++)
    {
        hash = hashes[i].split('=');
        vars.push(hash[0]);
        vars[hash[0]] = hash[1];
    }
    return vars;
}
For example, if you have the URL:

http://www.example.com/?me=myValue&name2=SomeOtherValue
This code will return:

{
    "me"    : "myValue",
    "name2" : "SomeOtherValue"
}
and you can do:

var me = getUrlVars()["me"];
var name2 = getUrlVars()["name2"];

 */


namespace Matrix.Common.Pages
{
    //using Northwind;
    //using Northwind.Entities;
    using Serenity;
    using Serenity.Data;
    using System;
    using System.Web.Mvc;

    [RoutePrefix("Dashboard"), Route("{action=index}")]
    public class DashboardController : Controller
    {
        [Authorize, HttpGet, Route("~/")]
        public ActionResult Index()
        {
            var userdefin = HttpRuntime.Cache["COMPANY_INFO"] as IUserDefinition;

            if (userdefin==null || string.IsNullOrWhiteSpace(WebSecurityHelper.HttpContextUsername))
            {
                Session.Abandon();
                FormsAuthentication.SignOut();
                return new RedirectResult("~/");
            }

            ViewBag.PeriodNo =  userdefin.Period;
            ViewBag.Period = "Period:"+userdefin.Period;
            ViewBag.UserName = userdefin.Username;
            ViewBag.CompanyInfo = string.Format("Company: {0}[{1}]", userdefin.CompanyName, userdefin.CompanyCode);

            return View("~/Modules/Dashboard/DashboardIndex.cshtml");
        }

        #region Navigation

        [Authorize,HttpGet]
        public ActionResult Controller()
        {
            //var cachedModel = TwoLevelCache.GetLocalStoreOnly("DashboardPageModel", TimeSpan.FromMinutes(5),
            //    OrderRow.Fields.GenerationKey, () =>
            //    {
            //        var model = new DashboardPageModel();
            //        var o = OrderRow.Fields;
            //        using (var connection = SqlConnections.NewFor<OrderRow>())
            //        {
            //            model.OpenOrders = connection.Count<OrderRow>(o.ShippingState == (int)OrderShippingState.NotShipped);
            //            var closedOrders = connection.Count<OrderRow>(o.ShippingState == (int)OrderShippingState.Shipped);
            //            var totalOrders = model.OpenOrders + closedOrders;
            //            model.ClosedOrderPercent = (int)Math.Round(totalOrders == 0 ? 100 :
            //                ((double)closedOrders / (double)totalOrders * 100));
            //            model.CustomerCount = connection.Count<CustomerRow>();
            //            model.ProductCount = connection.Count<ProductRow>();
            //        }
            //        return model;
            //    });

            //var model = new DashboardPageModel();

            //model.OpenOrders = 20;
            //var closedOrders = 30;
            //var totalOrders = model.OpenOrders + closedOrders;
            //model.ClosedOrderPercent = (int) Math.Round(totalOrders == 0
            //    ? 100
            //    : ((double) closedOrders/(double) totalOrders*100));
            //model.CustomerCount = 10;
            //model.ProductCount = 15;

            Dictionary<string, List<string>> model = ActionNames();

            return View("~/Modules/Dashboard/NavigationIndex.cshtml", model);
        }

        private Dictionary<string, List<string>> ActionNames()
        {
            //Assembly asm = Assembly.GetAssembly(typeof(MyWebDll.MvcApplication));
            //var controlleractionlist = asm.GetTypes()
            //    .Where(type => typeof(System.Web.Mvc.Controller).IsAssignableFrom(type))
            //    .SelectMany(type => type.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public))
            //    .Where(m => !m.GetCustomAttributes(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), true).Any())
            //    .Select(x => new { Controller = x.DeclaringType.Name, Action = x.Name, ReturnType = x.ReturnType.Name, Attributes = String.Join(",", x.GetCustomAttributes().Select(a => a.GetType().Name.Replace("Attribute", ""))) })
            //    .OrderBy(x => x.Controller).ThenBy(x => x.Action).ToList();

            //Assembly asm = Assembly.GetExecutingAssembly();
            //asm.GetTypes()
            //    .Where(type => typeof(Controller).IsAssignableFrom(type)) //filter controllers
            //    .SelectMany(type => type.GetMethods())
            //    .Where(method => method.IsPublic && !method.IsDefined(typeof(NonActionAttribute)));

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            Assembly assembly = Assembly.GetAssembly(typeof(SiteInitialization));

            var types =
                from t in assembly.GetTypes()
                where typeof(Controller).IsAssignableFrom(t) && !t.IsSubclassOf(typeof(ServiceEndpoint)) &&
                      !t.IsAbstract &&
                      t.IsPublic &&
                      t.Name.EndsWith("Controller", StringComparison.OrdinalIgnoreCase)
                select t;

            foreach (Type controllerType in types)
            {
                var actions = new ReflectedControllerDescriptor(controllerType).GetCanonicalActions().Select(x => x.ActionName)
                    .ToList();

                var attribute = controllerType.GetCustomAttribute(typeof(RoutePrefixAttribute));
                if (attribute != null && actions.Count > 0)
                {
                    dictionary.Add((attribute as RoutePrefixAttribute).Prefix, actions);
                }
            }

            //sort key and make it better look
            var l = dictionary.OrderBy(key => key.Key);
            var dic = l.ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);

            return dic;
        }

        #endregion

        #region Inbox

        private const int PAGE_NUMBER = 1;
        private const int PAGE_SIZE = 18;

        public ActionResult Inbox(int? page,string search)
        {
            using (var connection = SqlConnections.NewByKey("BasicInformation"))
            {
                ListRequest request = new ListRequest();
                int pageNumber = page ?? PAGE_NUMBER;
                request.Take = PAGE_SIZE;
                request.Skip = (pageNumber - 1) * request.Take;
                
                request.Sort=new SortBy[] { new SortBy("CreatedDate", true) };
                MessageRepository repository = new MessageRepository();
                ListResponse<MessageRow> response= repository.List(connection, request);
                var pageIndex = (page ?? 1) - 1; 
                var usersAsIPagedList = new StaticPagedList<MessageRow>(response.Entities, pageIndex + 1, PAGE_SIZE, response.TotalCount);
                
                //ViewBag.Pager = response.Entities.ToPagedList(response.TotalCount, PAGE_SIZE);
                ViewBag.Pager = usersAsIPagedList;

                //var fld = MessageRow.Fields;
                ////var messageRows = connection.List<MessageRow>(q => { q.Select(fld.MessageId, fld.CreatedBy, fld.CreatedDate,  fld.Summary, fld.MsgTo, fld.Detail).Take(20); })
                ////    .OrderByDescending(en => en.CreatedDate).ToList();

                //var messageRows = connection.List<MessageRow>(q =>
                //{
                //    q.SelectTableFields();
                //    //.Select(fld.DetailList);
                //}).OrderByDescending(en => en.CreatedDate).Take(20).ToList();

                return View("~/Modules/Dashboard/Inbox.cshtml", response.Entities);
            }
        }

        public ActionResult Compose()
        {
            return View("~/Modules/Dashboard/DashboardIndex.cshtml");
        }

        public ActionResult Read(int messageId)
        {
            using (var connection = SqlConnections.NewByKey("BasicInformation"))
            {
                MessageRepository repository = new MessageRepository();
                RetrieveRequest request = new RetrieveRequest();
                request.EntityId = messageId;
                RetrieveResponse<MessageRow> response = repository.Retrieve(connection, request);

                return View("~/Modules/Dashboard/Read.cshtml", response.Entity);
            }
        }

        public ActionResult Previous(int messageId)
        {
            using (var connection = SqlConnections.NewByKey("BasicInformation"))
            {
                int id = messageId > 0 ? messageId - 1 : 1;
                bool exist = false;
                do
                {
                    exist = connection.ExistsById<MessageRow>(id);
                    if (!exist)
                        id = id - 1;
                } while (!exist);

                return RedirectToAction("Read", "Dashboard", new {messageId = id});
            }
        }

        public ActionResult Next(int messageId)
        {
            using (var connection = SqlConnections.NewByKey("BasicInformation"))
            {
                int id = messageId > 0 ? messageId + 1 : 1;
                bool exist = false;
                do
                {
                    exist = connection.ExistsById<MessageRow>(id);
                    if (!exist)
                        id = id + 1;
                } while (!exist);

                return RedirectToAction("Read", "Dashboard", new {messageId = id});
            }
        }

        #endregion
    }
}
