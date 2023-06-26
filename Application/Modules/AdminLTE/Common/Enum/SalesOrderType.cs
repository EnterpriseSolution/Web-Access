#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  SalesOrderType.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.Common;
using Serenity.ComponentModel;

namespace Matrix
{
    [EnumKey("Enums.SalesOrderType")]
    public enum SalesOrderType
    {
        [Description("Standard")]
        Standard='S',
      
        [Description("Blanket")]
        Blanket='B',
        
        [Description("Release")]
        Release='R',
      
        [Description("Sample")]
        Sample='A'
    }
}
