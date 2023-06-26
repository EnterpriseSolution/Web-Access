#region Enterprise Solution
// Copyright ?2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  QuotationDetailEditorAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity.ComponentModel;

namespace Matrix.Sales.Entities
{
    public partial class QuotationDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.Sales.QuotationDetailEditor";

        public QuotationDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}