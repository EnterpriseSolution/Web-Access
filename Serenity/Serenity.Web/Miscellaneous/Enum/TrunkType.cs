using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum TrunkType
    {
        [StringValue("H")]
        [DisplayText("Heavy")]
        Center,

        [StringValue("M")]
        [DisplayText("Medium")]
        Left,

        [StringValue("L")]
        [DisplayText("Light")]
        Right
    }
}
