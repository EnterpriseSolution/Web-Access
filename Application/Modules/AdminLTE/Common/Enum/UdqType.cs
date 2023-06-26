#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  UdqType.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Matrix.Modules.AdminLTE.Common.Enum
{
    public class UdqType
    {
    }
}

namespace Matrix
{
    public enum UdqType
    {
        [Description("Enquiry")]
        Enquiry = 'E',

        [Description("Lookup")]
        Lookup = 'L',

        [Description("Alert")]
        Alert = 'A',

        [Description("Comparation")]
        Comparation = 'C'
    }
}