#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  DecimalUtil.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Matrix.Modules.Common
{
    public class DecimalUtil
    {
        public const string Decimal82 = "###,##0.00";
        public const string Decimal182 = "#,###,###,###,###,##0.00";
        public const string Decimal186 = "#,###,###,###,###,##0.000000";

    }


    public class RepositoryBase : MarshalByRefObject
    {
        #region Fields

        //const string SYSTEM_ADAPTER_CONTEXT_KEY = "MICROSOFT_SYSTEM_ADAPTER";
        //const string COMPANY_ADAPTER_CONTEXT_KEY = "MICROSOFT_COMPANY_ADAPTER";
        //public const int DEFAULT_COMMAND_TIMEOUT = 300;
        //private string sessionId;

        #endregion Fields
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class RepositoryService : Attribute
    {
        private string _value;

        public RepositoryService(string value)
        {
            this._value = value;
        }

        public string Value
        {
            get
            {
                return this._value;
            }
        }
    }
}