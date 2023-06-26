#region Enterprise Solution
// Copyright ?2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PeriodicVoucherScheduleEditorAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity.ComponentModel;

namespace Matrix.Finance.Entities
{
    public partial class PeriodicVoucherScheduleEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.Finance.PeriodicVoucherScheduleDetailEditor";

        public PeriodicVoucherScheduleEditorAttribute()
            : base(Key)
        {
        }
    }
}