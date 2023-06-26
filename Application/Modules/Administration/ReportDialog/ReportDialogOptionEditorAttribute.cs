#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ReportDialogOptionEditorAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity.ComponentModel;

namespace Matrix.EnterpriseSys.Columns
{
    public partial class ReportDialogOptionEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.EnterpriseSys.ReportDialogOptionEditor";

        public ReportDialogOptionEditorAttribute()
            : base(Key)
        {
        }
    }
}