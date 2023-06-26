#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common
// File:  HiddenEnumAttribute.cs 
// Date: 2014/07/14 0:40

#endregion
namespace Microsoft.Common
{
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    public sealed class HiddenEnumAttribute : Attribute
    {
        private bool _value;

        public HiddenEnumAttribute(bool value)
        {
            this._value = value;
        }

        public bool Value
        {
            get
            {
                return this._value;
            }
        }
    }
}

