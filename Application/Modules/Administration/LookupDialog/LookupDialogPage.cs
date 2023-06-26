#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LookupDialogPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Administration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Administration/LookupDialog"), Route("{action=index}")]    
    public class LookupDialogController : Controller
    {
        public ActionResult Enquiry()
        {
            
            return View("~/Modules/Administration/LookupDialog/LookupDialogIndex.cshtml",model: UdqType.Enquiry.ToString());
        }

        public ActionResult Lookup()
        {
            return View("~/Modules/Administration/LookupDialog/LookupDialogIndex.cshtml", model: UdqType.Lookup.ToString());
        }

        public ActionResult Alert()
        {
            return View("~/Modules/Administration/LookupDialog/LookupDialogIndex.cshtml", model: UdqType.Alert.ToString());
        }

        public ActionResult Comparation()
        {
            return View("~/Modules/Administration/LookupDialog/LookupDialogIndex.cshtml", model: UdqType.Comparation.ToString());
        }
    }
}