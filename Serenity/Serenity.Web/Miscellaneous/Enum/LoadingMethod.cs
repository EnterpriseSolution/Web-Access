using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum  LoadingMethod
    {
        [StringValue("L")]
        [DisplayText("Less-than-Truck-Load")]
        LessThanTruckLoad,

        [StringValue("F")]
        [DisplayText("Full-Truck-Load")]
        FullTruckLoad
    }
}
