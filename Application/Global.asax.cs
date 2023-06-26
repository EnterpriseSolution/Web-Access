#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  Global.asax.cs
// Date: 2018/04/03 20:51

#endregion

using System.Web;
using Matrix.Modules.Common;

namespace Matrix
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using System.Web.Mvc;
    using System.Web.Routing;

    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ValueProviderFactories.Factories.Remove(ValueProviderFactories.Factories.OfType<JsonValueProviderFactory>().First());

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());

            SiteInitialization.ApplicationStart();
        }

        protected void Application_End(object sender, EventArgs e)
        {
            SiteInitialization.ApplicationEnd();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            var cookie = Request.Cookies["LanguagePreference"];
            if (cookie != null && !string.IsNullOrEmpty(cookie.Value))
            {
                try
                {
                    var culture = CultureInfo.GetCultureInfo(cookie.Value);
                    Thread.CurrentThread.CurrentUICulture = culture;
                }
                catch (CultureNotFoundException)
                {
                    // ignore
                }
            }
        }

        protected void Application_EndRequest()
        {
            //if (Context.Response.StatusCode == 404)
            //{
            //    Response.Clear();

            //    var rd = new RouteData();
            //    rd.DataTokens["area"] = "AreaName"; // In case controller is in another area
            //    rd.Values["controller"] = "Errors";
            //    rd.Values["action"] = "NotFound";

            //    IController c = new ErrorsController();
            //    c.Execute(new RequestContext(new HttpContextWrapper(Context), rd));
            //}
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var raisedException = Server.GetLastError();

            //log the error!
            //_Logger.Error(ex);

            //HttpContext httpContext = HttpContext.Current;
            //if (httpContext != null)
            //{
            //    RequestContext requestContext = ((MvcHandler)httpContext.CurrentHandler).RequestContext;
            //    /* When the request is ajax the system can automatically handle a mistake with a JSON response. 
            //       Then overwrites the default response */
            //    if (requestContext.HttpContext.Request.IsAjaxRequest())
            //    {
            //        httpContext.Response.Clear();
            //        string controllerName = requestContext.RouteData.GetRequiredString("controller");
            //        IControllerFactory factory = ControllerBuilder.Current.GetControllerFactory();
            //        IController controller = factory.CreateController(requestContext, controllerName);
            //        ControllerContext controllerContext = new ControllerContext(requestContext, (ControllerBase)controller);

            //        JsonResult jsonResult = new JsonResult
            //        {
            //            Data = new { success = false, serverError = "500" },
            //            JsonRequestBehavior = JsonRequestBehavior.AllowGet
            //        };
            //        jsonResult.ExecuteResult(controllerContext);
            //        httpContext.Response.End();
            //    }
            //    else
            //    {
            //        httpContext.Response.Redirect("~/Error");
            //    }
            //}
        }
    }
}