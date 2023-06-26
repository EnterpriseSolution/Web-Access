#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ReportDialogForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.EnterpriseSys.Columns;
using Matrix.EnterpriseSys.Entities;
using Matrix.Modules.Common.Enum;

namespace Matrix.EnterpriseSys.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("EnterpriseSys.ReportDialog")]
    [BasedOnRow(typeof(Entities.ReportDialogRow))]
    public class ReportDialogForm
    {
        [Tab(TabName.GeneralInformation)]
        public String Description { get; set; }
        public Boolean Suspended { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        public Boolean FilterBySalesmanCode { get; set; }
        public Boolean FilterByBuyerCode { get; set; }
        public Int32 ReportType { get; set; }
        public Int32 DataSource { get; set; }

        [Tab(TabName.Details)]
        [ReportDialogOptionEditor]
        public List<ReportDialogOptionRow> ItemDetailList { get; set; }
    }
}