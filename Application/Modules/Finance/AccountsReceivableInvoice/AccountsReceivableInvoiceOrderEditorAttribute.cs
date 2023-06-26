#region Enterprise Solution
// Copyright ?2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivableInvoiceOrderEditorAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity.ComponentModel;

namespace Matrix.Sales.Entities
{
    public partial class AccountsReceivableInvoiceOrderEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.Finance.AccountsReceivableInvoiceOrderEditor";

        public AccountsReceivableInvoiceOrderEditorAttribute()
            : base(Key)
        {
        }
    }

    public partial class AccountsReceivableInvoiceDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.Finance.AccountsReceivableInvoiceDetailEditor";

        public AccountsReceivableInvoiceDetailEditorAttribute()
            : base(Key)
        {
        }
    }


    public partial class AccountsReceivableCommissionEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.Finance.AccountsReceivableCommissionEditor";

        public AccountsReceivableCommissionEditorAttribute()
            : base(Key)
        {
        }
    }
}