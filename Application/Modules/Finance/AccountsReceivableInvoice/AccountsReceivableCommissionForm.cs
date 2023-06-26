#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivableCommissionForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Finance.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Finance.AccountsReceivableCommission")]
    [BasedOnRow(typeof(Entities.AccountsReceivableCommissionRow))]
    public class AccountsReceivableCommissionForm
    {
        public String Salesman { get; set; }
        public String SalesmanName { get; set; }
        public Decimal Rate { get; set; }
    }
}