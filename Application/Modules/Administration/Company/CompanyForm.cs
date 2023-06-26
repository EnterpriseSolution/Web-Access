#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CompanyForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Administration.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Administration.CompanyForm")]
    [BasedOnRow(typeof(Entities.CompanyRow))]
    public class CompanyForm
    {
        public String CompanyCode { get; set; }

        public String CompanyName { get; set; }

        public bool Suspended { get; set; }

        public String DbServer { get; set; }

        public String DbDatabase { get; set; }

        public String DbUser { get; set; }

        public String DbPassword { get; set; }
    }
}