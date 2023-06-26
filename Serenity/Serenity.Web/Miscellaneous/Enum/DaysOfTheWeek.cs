#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  DaysOfTheWeek.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum DaysOfTheWeek
    {
        /// <summary>
        /// Monday
        /// </summary>
        [StringValue("1")]
        [DisplayText("Monday")]
        Monday,
        
        /// <summary>
        /// Tuesday
        /// </summary>
        [StringValue("2")]
        [DisplayText("Tuesday")]        
        Tuesday,
        
        /// <summary>
        /// Wednesday
        /// </summary>
        [StringValue("3")]
        [DisplayText("Wednesday")]
        Wednesday,
        
        /// <summary>
        /// Thursday
        /// </summary>
        [StringValue("4")]
        [DisplayText("Thursday")]
        Thursday,
        
        /// <summary>
        /// Friday
        /// </summary>
        [StringValue("5")]
        [DisplayText("Friday")]
        Friday,
        
        /// <summary>
        /// Saturday
        /// </summary>
        [StringValue("6")]
        [DisplayText("Saturday")]
        Saturday,
        
        /// <summary>
        /// Sunday
        /// </summary>
        [StringValue("7")]
        [DisplayText("Sunday")]
        Sunday

    }
}
