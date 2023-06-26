#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ReportDialogColumns.cs
// Date: 2018/04/03 20:51

#endregion
using Matrix.EnterpriseSys.Entities;
using Matrix.Modules.Common.Enum;
using Serenity.Foundation.Enum;

namespace Matrix.EnterpriseSys.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("EnterpriseSys.ReportDialog")]
    [BasedOnRow(typeof(Entities.ReportDialogRow))]
    public class ReportDialogColumns
    {
        [Tab(TabName.GeneralInformation)]
        [EditLink, DisplayName("Report Id")]
        public String ReportId { get; set; }
        [Width(160)]
        public String Description { get; set; }
        [Width(80)]
        public Boolean Suspended { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public Boolean FilterBySalesmanCode { get; set; }
        //public Boolean FilterByBuyerCode { get; set; }

        //public string ReportType
        //{
        //    get
        //    {
        //      StringEnum<ReportType>.GetDisplayText()   
        //    }
        //}

        //public Int32 DataSource { get; set; }
    }
}