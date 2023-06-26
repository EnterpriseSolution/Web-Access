#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  WorkflowColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MasterData.Workflow")]
    [BasedOnRow(typeof(Entities.WorkflowRow))]
    public class WorkflowColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        [EditLink, AlignRight]
        public Int32 Seqno { get; set; }

        public String Workflowname { get; set; }
        public String Description { get; set; }
        public String Tablename { get; set; }
        public Int32 Workflowtype { get; set; }
        
        //public String Xoml { get; set; }
        //public String Rules { get; set; }
        public Boolean Suspended { get; set; }
        public Boolean Published { get; set; }
        //public String Publishedxoml { get; set; }
        //public String Publishedrules { get; set; }
        //public String Createdby { get; set; }
        //public DateTime Createddate { get; set; }
        //public String Revisedby { get; set; }
        //public DateTime Reviseddate { get; set; }
    }
}