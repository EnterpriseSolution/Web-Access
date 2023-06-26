using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Common;

namespace Serenity.Foundation.Enum
{
    public enum ReportDataSource
    {
        [DisplayText("Company Database"), StringValue("0")]
        CompanyDatabase = 0,
        [StringValue("1"), DisplayText("System Database")]
        SystemDatabase = 1
    }

}
