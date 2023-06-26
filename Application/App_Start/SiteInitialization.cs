#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  SiteInitialization.cs
// Date: 2018/04/03 20:51

#endregion
using System.Linq;

namespace Matrix
{
    using Administration;
    using Serenity;
    using Serenity.Abstractions;
    using Serenity.Data;
    using Serenity.Web;
    using System;
    using System.Configuration;

    public static partial class SiteInitialization
    {
        public const string Database = "Administration";

        public const string ProviderName = "System.Data.SqlClient";


        public static void ApplicationStart()
        {
            try
            {
                SqlSettings.AutoQuotedIdentifiers = true;
                Serenity.Web.CommonInitialization.Run();

                foreach (var conn in System.Configuration.ConfigurationManager.ConnectionStrings.Cast<ConnectionStringSettings>())
                {
                    if (ConfigurationManager.ConnectionStrings[conn.Name] != null)
                        SqlConnections.GetConnectionString(conn.Name).Dialect = SqlServer2008Dialect.Instance;
                }


                var registrar = Dependency.Resolve<IDependencyRegistrar>();
                registrar.RegisterInstance<IAuthorizationService>(new Administration.AuthorizationService());
                registrar.RegisterInstance<IAuthenticationService>(new Administration.AuthenticationService());
                registrar.RegisterInstance<IPermissionService>(new LogicOperatorPermissionService(new Administration.PermissionService()));
                registrar.RegisterInstance<IUserRetrieveService>(new Administration.UserRetrieveService());

                if (!ConfigurationManager.AppSettings["LDAP"].IsTrimmedEmpty())
                    registrar.RegisterInstance<IDirectoryService>(new LdapDirectoryService());

                if (!ConfigurationManager.AppSettings["ActiveDirectory"].IsTrimmedEmpty())
                    registrar.RegisterInstance<IDirectoryService>(new ActiveDirectoryService());
                
            }
            catch (Exception ex)
            {
                ex.Log();
                throw;
            }
            
        }

        public static void ApplicationEnd()
        {
        }
    }
}