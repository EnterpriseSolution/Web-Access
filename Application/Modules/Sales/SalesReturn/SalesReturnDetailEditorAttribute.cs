#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  SalesReturnDetailEditorAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity.ComponentModel;

namespace Matrix.Sales.Forms
{
    public partial class SalesReturnDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.Sales.SalesReturnDetailEditor";

        public SalesReturnDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}