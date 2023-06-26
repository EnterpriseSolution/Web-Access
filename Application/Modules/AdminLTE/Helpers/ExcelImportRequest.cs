#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ExcelImportRequest.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix
{
    using Serenity.Services;
    using System;
    using System.Collections.Generic;

    public class ExcelImportRequest : ServiceRequest
    {
        public String FileName { get; set; }
    }

    public class ExcelImportResponse : ServiceResponse
    {
        public int Inserted { get; set; }
        public int Updated { get; set; }
        public List<string> ErrorList { get; set; }
    }
}