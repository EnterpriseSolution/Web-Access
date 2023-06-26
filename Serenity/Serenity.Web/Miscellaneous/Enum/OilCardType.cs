using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum OilCardType
    {
        [StringValue("U")]
        [DisplayText("User Card")]
        Center,

        [StringValue("C")]
        [DisplayText("Company Card")]
        Left,

        [StringValue("D")]
        [DisplayText("Credit Card")]
        Right
    }
}
