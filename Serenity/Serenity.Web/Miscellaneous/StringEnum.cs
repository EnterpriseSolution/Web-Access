#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common
// File:  StringEnum.cs 
// Date: 2014/07/14 0:40

#endregion

using System;
using Microsoft.Common;
using Serenity;

namespace Matrix
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.InteropServices;

    public static class StringEnum<T> where T: struct
    {
        private static ConcurrentDictionary<T, string> _enumToDisplayText;
        private static ConcurrentDictionary<T, string> _enumToStringValue;
        private static List<T> _hiddenEnum;
        private static ConcurrentDictionary<int, T> _integerToEnum;
        private static object _lockObject;
        private static ConcurrentDictionary<string, T> _stringToEnum;
        private static ConcurrentDictionary<string, T> _stringToEnumIgnoreCase;
        private static ConcurrentDictionary<string, T> _stringValueToEnum;
        private static ConcurrentDictionary<string, T> _stringValueToEnumIgnoreCase;
        private static Type _type;

        static StringEnum()
        {
            StringEnum<T>._lockObject = new object();
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException(string.Format("Supplied type must be an Enum.  Type was {0}", typeof(T).ToString()));
            }
            if (StringEnum<T>._type == null)
            {
                lock (StringEnum<T>._lockObject)
                {
                    if (StringEnum<T>._type == null)
                    {
                        StringEnum<T>._type = typeof(T);
                        FieldInfo[] fields = StringEnum<T>._type.GetFields();
                        StringEnum<T>._stringToEnum = new ConcurrentDictionary<string, T>();
                        StringEnum<T>._stringToEnumIgnoreCase = new ConcurrentDictionary<string, T>();
                        StringEnum<T>._integerToEnum = new ConcurrentDictionary<int, T>();
                        StringEnum<T>._stringValueToEnum = new ConcurrentDictionary<string, T>();
                        StringEnum<T>._stringValueToEnumIgnoreCase = new ConcurrentDictionary<string, T>();
                        StringEnum<T>._enumToStringValue = new ConcurrentDictionary<T, string>();
                        StringEnum<T>._enumToDisplayText = new ConcurrentDictionary<T, string>();
                        StringEnum<T>._hiddenEnum = new List<T>(0);
                        foreach (FieldInfo info in fields)
                        {
                            if (info.FieldType.IsEnum)
                            {
                                T local = (T) Enum.Parse(StringEnum<T>._type, info.Name);
                                int key = Convert.ToInt32(local);
                                string str = string.Empty;
                                string formattedDisplayText = string.Empty;
                                StringValueAttribute[] customAttributes = info.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];
                                if ((customAttributes != null) && (customAttributes.Length > 0))
                                {
                                    str = customAttributes[0].Value;
                                }
                                DisplayTextAttribute[] attributeArray2 = info.GetCustomAttributes(typeof(DisplayTextAttribute), false) as DisplayTextAttribute[];
                                if ((attributeArray2 != null) && (attributeArray2.Length > 0))
                                {
                                    formattedDisplayText = attributeArray2[0].Value;
                                }
                                HiddenEnumAttribute[] attributeArray3 = info.GetCustomAttributes(typeof(HiddenEnumAttribute), false) as HiddenEnumAttribute[];
                                if (((attributeArray3 != null) && (attributeArray3.Length > 0)) && attributeArray3[0].Value)
                                {
                                    StringEnum<T>._hiddenEnum.Add(local);
                                }
                                if (string.IsNullOrEmpty(str))
                                {
                                    str = Convert.ToInt32(local).ToString();
                                }
                                if (string.IsNullOrEmpty(formattedDisplayText))
                                {
                                    formattedDisplayText = Shared.GetFormattedDisplayText(local.ToString());
                                }
                                StringEnum<T>._stringToEnum.GetOrAdd(info.Name, local);
                                StringEnum<T>._stringToEnumIgnoreCase.GetOrAdd(info.Name.ToLower(), local);
                                StringEnum<T>._integerToEnum.GetOrAdd(key, local);
                                StringEnum<T>._enumToStringValue.GetOrAdd(local, str);
                                StringEnum<T>._enumToDisplayText.GetOrAdd(local, formattedDisplayText);
                                if (!StringEnum<T>._stringValueToEnum.ContainsKey(str))
                                {
                                    StringEnum<T>._stringValueToEnum.GetOrAdd(str, local);
                                    StringEnum<T>._stringValueToEnumIgnoreCase.GetOrAdd(str.ToLower(), local);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static bool Compare(string stringValue, T enumValue)
        {
            T local;
            return (StringEnum<T>._stringValueToEnum.TryGetValue(stringValue, out local) && local.Equals(enumValue));
        }

        public static bool Compare(string stringValue, T enumValue, bool ignoreCase)
        {
            if (ignoreCase)
            {
                T local;
                return (StringEnum<T>._stringValueToEnumIgnoreCase.TryGetValue(stringValue, out local) && local.Equals(enumValue));
            }
            return StringEnum<T>.Compare(stringValue, enumValue);
        }

        public static string GetDisplayText(T value)
        {
            string str = null;
            if (!StringEnum<T>._enumToDisplayText.TryGetValue(value, out str))
            {
                throw new AppException(value, "Value is not defined in enum type '{0}'", new object[] { value });
            }
            return str;
        }

        public static string GetStringValue(T value)
        {
            string str = null;
            if (!StringEnum<T>._enumToStringValue.TryGetValue(value, out str))
            {
                throw new AppException(value, "Value is not defined in enum type '{0}'", new object[] { value });
            }
            return str;
        }

        public static Type GetUnderlyingType()
        {
            return Enum.GetUnderlyingType(StringEnum<T>._type);
        }

        public static Dictionary<string, string> GetValueList()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>(StringEnum<T>._stringToEnum.Count);
            foreach (T local in StringEnum<T>._stringToEnum.Values)
            {
                if (!StringEnum<T>._hiddenEnum.Contains(local))
                {
                    string stringValue = StringEnum<T>.GetStringValue(local);
                    string displayText = StringEnum<T>.GetDisplayText(local);
                    if (dictionary.ContainsKey(stringValue))
                    {
                        continue;
                        //throw new FieldValidationException("An item with the same key {0} has already been added", new object[] {stringValue});
                    }
                    dictionary.Add(stringValue, displayText);
                }
            }
            return dictionary;
        }

        public static List<T> GetValues()
        {
            List<T> list = new List<T>(StringEnum<T>._stringToEnum.Count);
            foreach (T local in StringEnum<T>._stringToEnum.Values)
            {
                list.Add(local);
            }
            return list;
        }

        public static bool IsDefined(object value)
        {
            try
            {
                int key = (int) value;
                return StringEnum<T>._integerToEnum.ContainsKey(key);
            }
            catch
            {
                return false;
            }
        }

        public static bool IsNameDefined(string value)
        {
            return StringEnum<T>._stringToEnum.ContainsKey(value);
        }

        public static bool IsNameDefined(string value, bool ignoreCase)
        {
            if (ignoreCase)
            {
                return StringEnum<T>._stringToEnumIgnoreCase.ContainsKey(value);
            }
            return StringEnum<T>.IsNameDefined(value);
        }

        public static bool IsStringDefined(string value)
        {
            return StringEnum<T>._stringValueToEnum.ContainsKey(value);
        }

        public static bool IsStringDefined(string value, bool ignoreCase)
        {
            if (ignoreCase)
            {
                string key = value.ToLower();
                return StringEnum<T>._stringValueToEnumIgnoreCase.ContainsKey(key);
            }
            return StringEnum<T>.IsStringDefined(value);
        }

        public static T Parse(string value)
        {
            T local = default(T);
            if (!StringEnum<T>._stringValueToEnum.TryGetValue(value, out local))
            {
                throw new AppException(value, "Value is not defined in enum type '{0}'", new object[] { value });
            }
            return local;
        }

        public static T Parse(string value, bool ignoreCase)
        {
            if (ignoreCase)
            {
                string key = value.ToLower();
                T local = default(T);
                if (!StringEnum<T>._stringValueToEnumIgnoreCase.TryGetValue(key, out local))
                {
                    throw new AppException(value, "Value is not defined in enum type '{0}'", new object[] { value });
                }
                return local;
            }
            return StringEnum<T>.Parse(value);
        }

        public static T ParseByName(string value)
        {
            T local = default(T);
            if (!StringEnum<T>._stringToEnum.TryGetValue(value, out local))
            {
                throw new AppException(value, "Value is not defined in enum type '{0}'", new object[] { value });
            }
            return local;
        }

        public static T ParseByName(string value, bool ignoreCase)
        {
            if (ignoreCase)
            {
                string key = value.ToLower();
                T local = default(T);
                if (!StringEnum<T>._stringToEnumIgnoreCase.TryGetValue(key, out local))
                {
                    throw new AppException(value, "Value is not defined in enum type '{0}'", new object[] { value });
                }
                return local;
            }
            return StringEnum<T>.Parse(value);
        }

        public static T ToObject(int value)
        {
            return StringEnum<T>._integerToEnum[value];
        }

        public static T ToObject(object value)
        {
            T local;
            try
            {
                int num = (int) value;
                local = StringEnum<T>.ToObject(num);
            }
            catch (InvalidCastException)
            {
                throw new ArgumentException(string.Format("Cannot convert '{0}' to int", value));
            }
            return local;
        }

        public static bool TryParse(string value, out T result)
        {
            if (StringEnum<T>._stringValueToEnum.TryGetValue(value, out result))
            {
                return true;
            }
            result = default(T);
            return false;
        }

        public static bool TryParse(string value, bool ignoreCase, out T result)
        {
            if (ignoreCase)
            {
                string str = value.ToLower();
                if (StringEnum<T>._stringValueToEnumIgnoreCase.TryGetValue(value, out result))
                {
                    return true;
                }
                result = default(T);
                return false;
            }
            return StringEnum<T>.TryParse(value, out result);
        }

        public static bool TryParseByName(string value, out T result)
        {
            if (StringEnum<T>._stringToEnum.TryGetValue(value, out result))
            {
                return true;
            }
            result = default(T);
            return false;
        }

        public static bool TryParseByName(string value, bool ignoreCase, out T result)
        {
            if (ignoreCase)
            {
                string str = value.ToLower();
                if (StringEnum<T>._stringToEnumIgnoreCase.TryGetValue(value, out result))
                {
                    return true;
                }
                result = default(T);
                return false;
            }
            return StringEnum<T>.TryParseByName(value, out result);
        }
    }
}

