#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common
// File:  DisplayTextAttribute.cs 
// Date: 2014/07/14 0:40

#endregion
namespace Microsoft.Common
{
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    public sealed class DisplayTextAttribute : Attribute
    {
        private string _value;

        public DisplayTextAttribute(string value)
        {
            this._value = value;
        }

        public string Value
        {
            get
            {
                return this._value;
            }
        }
    }
}

