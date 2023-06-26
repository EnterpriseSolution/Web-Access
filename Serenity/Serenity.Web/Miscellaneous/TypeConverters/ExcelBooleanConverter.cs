#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common
// File:  ExcelBooleanConverter.cs 
// Date: 2014/07/14 22:03

#endregion
namespace Microsoft.TypeConverters
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Globalization;

    public class ExcelBooleanConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            switch (sourceType.FullName)
            {
                case "System.Int64":
                case "System.Int32":
                case "System.Int16":
                case "System.Byte":
                case "System.SByte":
                case "System.UInt64":
                case "System.UInt32":
                case "System.UInt16":
                case "System.Decimal":
                case "System.Double":
                case "System.String":
                    return true;
            }
            return false;
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            switch (destinationType.FullName)
            {
                case "System.Int64":
                case "System.Int32":
                case "System.Int16":
                case "System.Byte":
                case "System.SByte":
                case "System.UInt64":
                case "System.UInt32":
                case "System.UInt16":
                case "System.Decimal":
                case "System.Double":
                case "System.String":
                    return true;

                case "System.DBNull":
                    return false;
            }
            return false;
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            switch (value.GetType().FullName)
            {
                case "System.Int64":
                    return (((long) value) > 0L);

                case "System.Int32":
                    return (((int) value) > 0);

                case "System.Int16":
                    return (((short) value) > 0);

                case "System.Byte":
                    return (((byte) value) > 0);

                case "System.SByte":
                    return (((sbyte) value) > 0);

                case "System.UInt64":
                    return (((ulong) value) > 0L);

                case "System.UInt32":
                    return (((uint) value) > 0);

                case "System.UInt16":
                    return (((ushort) value) > 0);

                case "System.Decimal":
                    return (((decimal) value) > 0M);

                case "System.Double":
                    return (((double) value) > 0.0);

                case "System.Boolean":
                    return (bool) value;

                case "System.String":
                {
                    string str = ((string) value).ToUpper();
                    return ((((str == "Y") || (str == "YES")) || (str == "T")) || (str == "TRUE"));
                }
                case "System.DBNull":
                    return false;
            }
            throw new NotSupportedException("Conversion from a value of type '" + value.GetType().ToString() + "' to System.Boolean isn't supported");
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
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
                switch (destinationType.FullName)
                {
                    case "System.Int64":
                        return 1L;

                    case "System.Int32":
                        return 1;

                    case "System.Int16":
                        return (short) 1;

                    case "System.Byte":
                        return (byte) 1;

                    case "System.SByte":
                        return (sbyte) 1;

                    case "System.UInt64":
                        return (ulong) 1L;

                    case "System.UInt32":
                        return 1;

                    case "System.UInt16":
                        return (ushort) 1;

                    case "System.Decimal":
                        return 1M;

                    case "System.Double":
                        return 1.0;

                    case "System.String":
                        return "Y";
                }
                throw new NotSupportedException("Conversion to a value of type '" + destinationType.ToString() + "' isn't supported");
            }
            switch (destinationType.FullName)
            {
                case "System.Int64":
                    return 0L;

                case "System.Int32":
                    return 0;

                case "System.Int16":
                    return (short) 0;

                case "System.Byte":
                    return (byte) 0;

                case "System.SByte":
                    return (sbyte) 0;

                case "System.UInt64":
                    return (ulong) 0L;

                case "System.UInt32":
                    return 0;

                case "System.UInt16":
                    return (ushort) 0;

                case "System.Decimal":
                    return 0M;

                case "System.Double":
                    return 0.0;

                case "System.String":
                    return "N";
            }
            throw new NotSupportedException("Conversion to a value of type '" + destinationType.ToString() + "' isn't supported");
        }

        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
            return true;
        }
    }
}

