#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AttachmentPage.cs
// Date: 2018/04/03 20:51

#endregion

using System;
using System.IO;

namespace Matrix.Document.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Document/Attachment"), Route("{action=index}")]    
    public class AttachmentController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Document/Attachment/AttachmentIndex.cshtml");
        }
        
        public FileResult DisplayPDF(string fileName)
        {
            return File("/Temp.pdf", "application/pdf");
        }

        public FileResult PDFDisplay(string fileName)
        {
            string filepath = Server.MapPath(string.Format("~/App_Data/{0}", fileName));
            byte[] pdfByte = GetBytesFromFile(filepath);
            return File(pdfByte, "application/pdf");
        }

        private static byte[] GetBytesFromFile(string fullFilePath)
        {
            // this method is limited to 2^32 byte files (4.2 GB)
            FileStream fs = null;
            try
            {
                fs = System.IO.File.OpenRead(fullFilePath);
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
                return bytes;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            }
        }
    }
}