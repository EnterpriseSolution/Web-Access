﻿#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  PriceCodeFormulaComputationOperator.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum PriceCodeFormulaComputationOperator
    {
        [StringValue("+")]
        [DisplayText("Plus")]
        Plus,

        [StringValue("-")]
        [DisplayText("Minus")]
        Minus,

        [StringValue("*")]
        [DisplayText("Times")]
        Times,

        [StringValue("/")]
        [DisplayText("Divide")]
        Divide
    }
}
