#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common
// File:  BooleanStringConverter.cs 
// Date: 2014/07/14 22:03

#endregion
namespace Microsoft.TypeConverters
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Globalization;

    [Description("Converter with as core type System.Boolean, for mapping a field with a .NET type System.Boolean onto a string database field")]
    public class BooleanStringConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            string fullName = sourceType.FullName;
            return ((fullName != null) && (fullName == "System.String"));
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            string fullName = destinationType.FullName;
            return ((fullName != null) && (fullName == "System.String"));
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            bool flag = false;
            if (value == null)
            {
                return flag;
            }
            switch (value.GetType().FullName)
            {
                case "System.String":
                    return (string.CompareOrdinal((string) value, "Y") == 0);

                case "System.DBNull":
                    return false;
            }
            throw new NotSupportedException("Conversion from a value of type '" + value.GetType().ToString() + "' to System.Boolean isn't supported");
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            string fullName;
            if (value == null)
            {
                throw new ArgumentNullException("value", "Value can't be null");
            }
            if (!(value is bool))
            {
                throw new ArgumentException("Value isn't of type boolean", "value");
            }
            if ((bool) value)
            {
                fullName = destinationType.FullName;
                if ((fullName == null) || (fullName != "System.String"))
                {
                    throw new NotSupportedException("Conversion to a value of type '" + destinationType.ToString() + "' isn't supported");
                }
                return "Y";
            }
            fullName = destinationType.FullName;
            if ((fullName == null) || (fullName != "System.String"))
            {
                throw new NotSupportedException("Conversion to a value of type '" + destinationType.ToString() + "' isn't supported");
            }
            return "N";
        }

        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
            return true;
        }
    }
}

