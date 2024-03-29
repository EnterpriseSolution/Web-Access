﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ReportDialogOptionForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.EnterpriseSys.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("EnterpriseSys.ReportDialogOption")]
    [BasedOnRow(typeof(Entities.ReportDialogOptionRow))]
    public class ReportDialogOptionForm
    {
        public Int32 OptionNo { get; set; }
        public Int32 SeqNo { get; set; }
        public String Caption { get; set; }
        public String FieldName { get; set; }
        public Int32 FieldType { get; set; }
        public Int32 Style { get; set; }
        public Int32 DataType { get; set; }
        public Boolean CapsLock { get; set; }
        public String LookupName { get; set; }
        public String LookupFilterName { get; set; }
        public Boolean Required { get; set; }
    }
}