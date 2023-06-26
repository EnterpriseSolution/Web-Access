#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  GrnOrderEditorAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity.ComponentModel;

namespace Matrix.Purchasing.Forms
{
    public partial class GrnOrderEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.Purchasing.GrnOrderEditor";

        public GrnOrderEditorAttribute()
            : base(Key)
        {
        }
    }
}