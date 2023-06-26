#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  WorkflowForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Common.Enum;

namespace Matrix.MasterData.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MasterData.Workflow")]
    [BasedOnRow(typeof(Entities.WorkflowRow))]
    public class WorkflowForm
    {
        public String Workflowname { get; set; }
        public String Description { get; set; }
        public String Tablename { get; set; }
        public Int32 Workflowtype { get; set; }
        public Boolean Suspended { get; set; }
        public Int32 Seqno { get; set; }

        [Category(CategoryName.Definition)]
        [TextAreaEditor(Rows = 4)]
        public String Xoml { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Rules { get; set; }

        [Category(CategoryName.Publish)]
        public Boolean Published { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Publishedxoml { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Publishedrules { get; set; }
        //public String Createdby { get; set; }
        //public DateTime Createddate { get; set; }
        //public String Revisedby { get; set; }
        //public DateTime Reviseddate { get; set; }
    }
}