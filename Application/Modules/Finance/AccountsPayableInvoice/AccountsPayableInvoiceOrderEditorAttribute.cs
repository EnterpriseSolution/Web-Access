#region Enterprise Solution
// Copyright ?2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsPayableInvoiceOrderEditorAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity.ComponentModel;

namespace Matrix.Sales.Entities
{
    public partial class AccountsPayableInvoiceOrderEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.Finance.AccountsPayableInvoiceOrderEditor";

        public AccountsPayableInvoiceOrderEditorAttribute()
            : base(Key)
        {
        }
    }
}