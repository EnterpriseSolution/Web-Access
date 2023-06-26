#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  GrnOrderDetailEditorAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity.ComponentModel;

namespace Matrix.Purchasing.Forms
{
    public partial class GrnOrderDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.Purchasing.GrnOrderDetailEditor";

        public GrnOrderDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}