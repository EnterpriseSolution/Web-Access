using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum FieldType
    {
        [DisplayText("Text")]
        [StringValue("C")]
        NVarchar,

        [DisplayText("Numeric")]
        [StringValue("N")]
        Numeric,

        [DisplayText("Date Time")]
        [StringValue("D")]
        DateTime,

        [DisplayText("Option Set")]
        [StringValue("O")]
        OptionSet
    }
}
