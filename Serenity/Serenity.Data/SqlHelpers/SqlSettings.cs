
namespace Serenity.Data
{
    public static class SqlSettings
    {
        public static bool AutoQuotedIdentifiers { get; set; }

        public static ISqlDialect DefaultDialect = SqlServer2008Dialect.Instance;
    }
}