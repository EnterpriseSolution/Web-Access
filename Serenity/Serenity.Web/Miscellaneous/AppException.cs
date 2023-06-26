#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common
// File:  AppException.cs 
// Date: 2014/07/14 0:40

#endregion
namespace Microsoft.Common
{
    using System;
    using System.Collections;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class AppException : Exception
    {
        private object[] _args;
        private string _customStackTrace;
        private ArrayList _invalidData;

        public AppException()
        {
            this.InitializeInvalidData(null);
        }

        public AppException(AppException ex) : this(ex.InvalidData, ex.Message, ex.Args, ex, ex.CustomStackTrace)
        {
        }

        public AppException(string message) : base(message)
        {
            this.InitializeInvalidData(null);
        }

        public AppException(object invalidData, string message) : base(message)
        {
            this.InitializeInvalidData(invalidData);
        }

        protected AppException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            this._args = info.GetValue("_args", typeof(object[])) as object[];
            this._invalidData = info.GetValue("_invalidData", typeof(ArrayList)) as ArrayList;
            this._customStackTrace = info.GetString("_customStackTrace");
        }

        public AppException(string message, object[] args) : base(message)
        {
            this._args = args;
            this.InitializeInvalidData(null);
        }

        public AppException(string message, Exception inner) : base(message, inner)
        {
            this.InitializeInvalidData(null);
        }

        public AppException(object invalidData, string message, object[] args) : base(message)
        {
            this._args = args;
            this.InitializeInvalidData(invalidData);
        }

        public AppException(object invalidData, string message, Exception inner) : base(message, inner)
        {
            this.InitializeInvalidData(invalidData);
        }

        public AppException(string message, object[] args, Exception inner) : base(message, inner)
        {
            this._args = args;
            this.InitializeInvalidData(null);
        }

        public AppException(object invalidData, string message, object[] args, Exception inner) : base(message, inner)
        {
            this._args = args;
            this.InitializeInvalidData(invalidData);
        }

        public AppException(object invalidData, string message, object[] args, Exception inner, string customStackTrace) : base(message, inner)
        {
            this._args = args;
            this._customStackTrace = customStackTrace;
            this.InitializeInvalidData(invalidData);
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter=true), SecurityPermission(SecurityAction.LinkDemand, Flags=SecurityPermissionFlag.SerializationFormatter)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("_args", this._args, typeof(object[]));
            info.AddValue("_invalidData", this._invalidData, typeof(ArrayList));
            info.AddValue("_customStackTrace", this._customStackTrace, typeof(string));
            base.GetObjectData(info, context);
        }

        private void InitializeInvalidData(object invalidData)
        {
            this._invalidData = new ArrayList();
            if (invalidData != null)
            {
                if (invalidData is ICollection)
                {
                    this._invalidData.AddRange((ICollection) invalidData);
                }
                else
                {
                    this._invalidData.Add(invalidData);
                }
            }
        }

        public override string ToString()
        {
            if (this._args != null)
            {
                return string.Format(this.Message, this._args);
            }
            return base.ToString();
        }

        public object[] Args
        {
            get
            {
                return this._args;
            }
        }

        public string CustomStackTrace
        {
            get
            {
                return this._customStackTrace;
            }
        }

        public ArrayList InvalidData
        {
            get
            {
                return this._invalidData;
            }
        }
    }
}

