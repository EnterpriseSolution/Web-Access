#region Enterprise Solution
// Copyright ?2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PeriodicVoucherDetailEditorAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity.ComponentModel;

namespace Matrix.Finance.Entities
{
    public partial class PeriodicVoucherDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.Finance.PeriodicVoucherDetailEditor";

        public PeriodicVoucherDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}