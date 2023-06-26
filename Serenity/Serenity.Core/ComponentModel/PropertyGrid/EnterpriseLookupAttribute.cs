using System;

namespace Serenity.ComponentModel
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class EnterpriseLookupAttribute : Attribute
    {
        private string _lookup;
        private string _filter;

        public EnterpriseLookupAttribute(string lookup) : this(lookup, string.Empty)
        {

        }

        public EnterpriseLookupAttribute(string lookup, string filter)
        {
            this._lookup = lookup;
            this._filter = filter;
        }

        public string Lookup
        {
            get
            {
                return this._lookup;
            }
        }

        public string Filter
        {
            get { return _filter; }
        }
    }
}