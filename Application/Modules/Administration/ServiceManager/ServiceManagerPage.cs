#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ServiceManagerPage.cs
// Date: 2018/04/03 20:51

#endregion
using System.Collections.Generic;
using System.ServiceProcess;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;

namespace Matrix.Enterprise.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Administration/ServiceManager"), Route("{action=index}")]
    public class ServiceManagerController : Controller
    {
        const string AssemblyVersion = "5.4.301.0";
        private List<string> ServiceList;

        public ActionResult Index()
        {
            var viewModel = GetServiceList();
            return View("~/Modules/Administration/ServiceManager/ServiceManagerIndex.cshtml", viewModel);
        }

        private List<ServiceViewModel> GetServiceList()
        {
            ServiceList = new List<string>();

            ServiceList.Add(string.Format("EntAppSvr_v{0}", AssemblyVersion));
            ServiceList.Add(string.Format("EntReportSvr_v{0}", AssemblyVersion));
            ServiceList.Add(string.Format("EntWorkflowSvr_v{0}", AssemblyVersion));
            ServiceList.Add(string.Format("EntMobileSvr_v{0}", AssemblyVersion));
            ServiceList.Add(string.Format("EntCacheSvr_v{0}", AssemblyVersion));
            
            List<ServiceController> list = (from serviceCode in ServiceList
                let service = GetService(serviceCode)
                where service != null
                select new ServiceController(serviceCode)).ToList();

            int sn = 1;
            List<ServiceViewModel> viewModel = new List<ServiceViewModel>();

            foreach (ServiceController controller in list)
            {
                viewModel.Add(new ServiceViewModel()
                {
                    SN = sn++,
                    Name = controller.ServiceName,
                    Description = controller.DisplayName,
                    Status = controller.Status.ToString(),
                    Action = GetActionName(controller.Status)
                });
            }
            return viewModel;
        }

        [HttpPost]
        public void TakenAction(ServiceViewModel data)
        {
            string serviceName = data.Name;
            string action = data.Action;
            var service = GetService(serviceName);
            if (action == "Start")
            {
                StartService(service);
            }
            else
            {
                StopService(service);

            }
            RedirectToAction("Index");
        }

        private bool StartService(ServiceController service)
        {
            try
            {
                service.Refresh();
                if (service.Status == ServiceControllerStatus.Stopped)
                {
                    //ReportProgress(string.Format("Starting {0}...\r\n", service.DisplayName));
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool StopService(ServiceController service)
        {
            try
            {
                service.Refresh();
                if (service.Status == ServiceControllerStatus.Running)
                {
                    //ReportProgress(string.Format("Stopping {0}...\r\n", service.DisplayName));
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static ServiceController GetService(string serviceCode)
        {
            var service = new ServiceController(serviceCode);

            try
            {
                var name = service.ServiceName;
            }
            catch (Exception)
            {
                return null;
            }
            return service;
        }

        private string GetActionName(ServiceControllerStatus status)
        {
            string button = string.Empty;
            if (status != ServiceControllerStatus.Running)
                button = "Start";
            else
                button = "Stop";
            return button;
        }

        public class ServiceViewModel
        {
            public int SN { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }
            public string Action { get; set; }
        }
    }
}