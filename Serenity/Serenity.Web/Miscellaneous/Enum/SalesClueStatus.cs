using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum SalesClueStatus
    {
        [StringValue("N")]
        [DisplayText("New")]
        New,

        [StringValue("I")]
        [DisplayText("In Progress")]
        InProgress,

        [StringValue("C")]
        [DisplayText("Closed")]
        Closed
    }
}
