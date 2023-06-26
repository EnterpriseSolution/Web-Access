#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  PlannedOrderReleaseResult.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Microsoft.Enums
{
    [Serializable]
    public sealed class PlannedOrderReleaseResult
    {
        private DataSet _releasedLog;
        private Exception _error;

        public DataSet ReleaseLog
        {
            get { return _releasedLog; }
            set { _releasedLog = value; }
        }

        public Exception Error
        {
            get { return _error; }
            set { _error = value; }
        }
    }
}
