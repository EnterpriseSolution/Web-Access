#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VoucherDetailEditorAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity.ComponentModel;

namespace Matrix.Finance.Forms
{
    public partial class VoucherDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.Finance.VoucherDetailEditor";

        public VoucherDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}