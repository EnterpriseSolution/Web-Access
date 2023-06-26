using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Common;

namespace Serenity.Foundation.Enum
{
    public enum ReportType
    {
        [StringValue("0"), DisplayText("Crystal Reports")]
        CrystalReports = 0,

        [StringValue("1"), DisplayText("Reporting Services")]
        ReportingServices = 1
    }

}
