#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  UserRetrieveService.cs
// Date: 2018/04/03 20:51

#endregion

using System.Data.SqlClient;
using Matrix.Administration.Entities;
using Matrix.Basic.Entities;

namespace Matrix.Administration
{
    using Serenity;
    using Serenity.Abstractions;
    using Serenity.Data;
    using System;
    using System.Data;
    using MyRow = Entities.UserRow;

    public class UserRetrieveService : IUserRetrieveService
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        private UserDefinition GetFirst(IDbConnection connection, BaseCriteria criteria, string companyCode)
        {
            var user = connection.TrySingle<Entities.UserRow>(criteria);
            UserDefinition userDefinition = new UserDefinition();
            if (user != null  && !string.IsNullOrWhiteSpace(companyCode))
            {
                userDefinition = new UserDefinition()
                {
                    UserId = user.UserId,
                    Username = user.Username,
                    Email = user.Email,
                };
                userDefinition.CompanyCode = companyCode;

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
              
                using (var connectiondb = SqlConnections.NewByKey(SiteInitialization.Database))
                {
                    CompanyRow companyRow = connectiondb.Single<CompanyRow>(q =>
                    {
                        q.SelectTableFields()
                            .Where(new Criteria(CompanyRow.Fields.CompanyCode) == userDefinition.CompanyCode);
                    });
                    
                    userDefinition.DataSource = companyRow.DbServer;
                    userDefinition.InitialCatalog = companyRow.DbDatabase;
                    userDefinition.UserID = "sa"; //companyRow.DbUser;
                    userDefinition.Password = "Enterprise";// companyRow.DbPassword;

                    builder=new SqlConnectionStringBuilder();
                    builder.DataSource = companyRow.DbServer;
                    builder.InitialCatalog = companyRow.DbDatabase;
                    builder.UserID = "sa"; //companyRow.DbUser;
                    builder.Password = "Enterprise";// companyRow.DbPassword;
                }


                using (var compConnection = SqlConnections.New(builder.ConnectionString, SiteInitialization.ProviderName))
                {
                    var basicFld = Matrix.Basic.Entities.CompanyParameterRow.Fields;
                    var companyParameterRow = compConnection.TrySingle<CompanyParameterRow>(new Criteria(basicFld.Recnum) > 0);

                    if (companyParameterRow != null)
                    {
                        userDefinition.Period = companyParameterRow.CurrentPeriod;

                        userDefinition.CompanyName = companyParameterRow.CompanyName;
                    }
                }

                return userDefinition;
            }

            return null;
        }

        public IUserDefinition ById(string id, string companyCode)
        {
            //return TwoLevelCache.Get<UserDefinition>("UserByID_" + id, TimeSpan.Zero, TimeSpan.FromDays(1), fld.GenerationKey, () =>
            //{
                using (var connection = SqlConnections.NewByKey(SiteInitialization.Database))
                    return GetFirst(connection, new Criteria(fld.UserId) == id, companyCode);
            //});
        }

        public IUserDefinition ByUsername(string username, string companyCode)
        {
            if (username.IsEmptyOrNull())
                return null;

            //return TwoLevelCache.Get<UserDefinition>("UserByName_" + username.ToLowerInvariant(), 
            //    TimeSpan.Zero, TimeSpan.FromDays(1), fld.GenerationKey, () =>
            //{
                using (var connection = SqlConnections.NewByKey(SiteInitialization.Database))
                    return GetFirst(connection, new Criteria(fld.Username) == username, companyCode);
            //});
        }

        public static void RemoveCachedUser(int? userId, string username)
        {
            if (userId != null)
                TwoLevelCache.Remove("UserByID_" + userId);

            if (username != null)
                TwoLevelCache.Remove("UserByName_" + username.ToLowerInvariant());
        }
    }
}