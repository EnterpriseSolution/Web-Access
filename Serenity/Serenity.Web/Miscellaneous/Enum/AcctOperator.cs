using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum AcctOperator
    {
        [StringValue("N")]
        [DisplayText("None")]
        None,

        [StringValue("A")]
        [DisplayText("Add")]
        Add,

        [StringValue("S")]
        [DisplayText("Subtraction")]
        Subtraction
    }
}
