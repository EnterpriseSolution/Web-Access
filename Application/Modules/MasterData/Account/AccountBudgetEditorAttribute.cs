#region Enterprise Solution
// Copyright ?2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountBudgetEditorAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity.ComponentModel;

namespace Matrix.MasterData
{
    public partial class AccountBudgetEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.MasterData.AccountBudgetDetailEditor";

        public AccountBudgetEditorAttribute()
            : base(Key)
        {
        }
    }
}