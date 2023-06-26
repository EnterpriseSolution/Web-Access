#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  GetNextNumberHelper.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix
{
    using Serenity.Data;
    using System.Data;
    using System.Linq;

    public static class GetNextNumberHelper
    {
        public static GetNextNumberResponse GetNextNumber(IDbConnection connection, GetNextNumberRequest request,
            Field field)
        {
            var prefix = request.Prefix ?? "";

            var max = connection.Query<string>(new SqlQuery()
                .From(field.Fields)
                .Select(Sql.Max(field.Expression))
                .Where(
                    field.StartsWith(prefix) &&
                    field >= prefix.PadRight(request.Length, '0') &&
                    field <= prefix.PadRight(request.Length, '9')))
                .FirstOrDefault();

            var response = new GetNextNumberResponse();

            long l;
            response.Number = max == null ||
                !long.TryParse(max.Substring(prefix.Length), out l) ? 1 : l + 1;

            response.Serial = prefix + response.Number.ToString()
                .PadLeft(request.Length - prefix.Length, '0');

            return response;
        }
    }
}