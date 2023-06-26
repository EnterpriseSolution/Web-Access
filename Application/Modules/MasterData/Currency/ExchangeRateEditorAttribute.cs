#region Enterprise Solution
// Copyright ?2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ExchangeRateEditorAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity.ComponentModel;

namespace Matrix.Sales.Entities
{
    public partial class ExchangeRateEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.MasterData.ExchangeRateDetailEditor";

        public ExchangeRateEditorAttribute()
            : base(Key)
        {
        }
    }
}