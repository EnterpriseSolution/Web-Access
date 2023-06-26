#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountPage.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;
using System.Data.SqlClient;
using Matrix.Administration.Entities;
using Matrix.Administration.Repositories;
using Matrix.EnterpriseSys.Entities;
using Matrix.MasterData.Entities;
using Matrix.MasterData.Repositories;
using Serenity.Data;

/*
 TO use Cookies check the jQUery Cookie plugin

https://github.com/carhartl/jquery-cookie

You can then do:

$.cookie("test", 1);
To delete:

$.removeCookie("test");
Additionally, to set a timeout of a certain number of days (5 here) on the cookie:

$.cookie("test", 1, { expires : 5 });
If the expires option is omitted, then the cookie becomes a session cookie, and is deleted when the browser exits.

To cover all the options:

$.cookie("test", 1, {
   expires : 10,           //expires in 10 days

   path    : '/',          //The value of the path attribute of the cookie 
                       //(default: path of page that created the cookie).

   domain  : 'jquery.com',  //The value of the domain attribute of the cookie
                       //(default: domain of page that created the cookie).

   secure  : true          //If set to true the secure attribute of the cookie
                       //will be set and the cookie transmission will
                       //require a secure protocol (defaults to false).
});
To read back the value of the cookie:

var cookieValue = $.cookie("test");
You may wish to specify the path parameter if the cookie was created on a different path to the current one:

var cookieValue = $.cookie("test", { path: '/foo' });

 */
namespace Matrix.Membership.Pages
{
    using Serenity;
    using Serenity.Services;
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Web.Mvc;
    using System.Web.Security;

    [RoutePrefix("Account"), Route("{action=index}")]
    public partial class AccountController : Controller
    {
        public static bool UseAdminLTELoginBox = false;

        [HttpGet]
        public ActionResult Login(string activated)
        {
            ViewData["Activated"] = activated;
            ViewData["HideLeftNavigation"] = true;

            //if (UseAdminLTELoginBox)
            //    return View(MVC.Views.Membership.Account.AccountLogin_AdminLTE);
            //else
                return View(MVC.Views.Membership.Account.AccountLogin);
        }

        [HttpGet]
        public ActionResult AccessDenied(string returnURL)
        {
            ViewData["HideLeftNavigation"] = !Authorization.IsLoggedIn;

            return View(MVC.Views.Errors.AccessDenied, (object)returnURL);
        }

        [HttpPost, JsonFilter]
        public Result<ServiceResponse> Login(LoginRequest request)
        {
            return this.ExecuteMethod(() =>
            {
                request.CheckNotNull();

                if (string.IsNullOrEmpty(request.Username))
                    throw new ArgumentNullException("username");

                if (string.IsNullOrEmpty(request.CompanyCode))
                    throw new ArgumentNullException("CompanyCode");

                var username = request.Username;

                using (var connection = SqlConnections.NewByKey(SiteInitialization.Database))
                {
                    CompanyRow companyRow = connection.Single<CompanyRow>(q =>
                    {
                        q.SelectTableFields()
                            .Where(new Criteria(CompanyRow.Fields.CompanyCode) == request.CompanyCode);
                    });
                    
                    SqlConnectionStringBuilder builder=new SqlConnectionStringBuilder();
                    builder.DataSource = companyRow.DbServer;
                    builder.InitialCatalog = companyRow.DbDatabase;
                    builder.UserID = "sa";// companyRow.DbUser;
                    builder.Password = "Enterprise";// companyRow.DbPassword;
                    
                    using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                    {
                        try
                        {
                            conn.Open();
                        }
                        catch (SqlException exception)
                        {
                            throw new Exception(exception.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }

                if (WebSecurityHelper.Authenticate(ref username, request.Password, request.CompanyCode, false))
                {
                    return new ServiceResponse();
                }

                throw new ValidationError("AuthenticationError", Texts.Validation.AuthenticationError);
            });
        }

        private ActionResult Error(string message)
        {
            return View(MVC.Views.Errors.ValidationError,
                new ValidationError(Texts.Validation.InvalidResetToken));
        }

        public ActionResult Signout()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            return new RedirectResult("~/");
        }

        public ActionResult GetDictJson()
        {
            List<CompanyInfo> treeList = new List<CompanyInfo>();
            using (var connection = SqlConnections.NewByKey("BasicInformation"))
            {
                ListRequest request = new ListRequest();
                request.Sort = new SortBy[] {new SortBy("CompanyCode", false)};
                CompanyRepository repository = new CompanyRepository();
                ListResponse<CompanyRow> response = repository.List(connection, request);
                foreach (CompanyRow entity in response.Entities)
                {
                    treeList.Add(new CompanyInfo()
                    {
                        CompanyCode = entity.CompanyCode,
                        CompanyName = entity.CompanyName
                    });
                }

            }

            return Json(treeList, JsonRequestBehavior.AllowGet);
        }

        public class CompanyInfo
        {
            public string CompanyCode { get; set; }
            public string CompanyName { get; set; }
        }

    }
}