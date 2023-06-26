#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  DevelopmentPage.cs
// Date: 2018/04/03 20:51

#endregion
using DapperCodeGenerator.Core.Enumerations;
using DapperCodeGenerator.Core.Providers;
using DapperCodeGenerator.Web.Models;

//https://github.com/kcrossman/DapperCodeGenerator

namespace Matrix.Sales.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Development/Entity"), Route("{action=index}")]    
    public class DevelopmentController : Controller
    {
        private readonly ApplicationState state;
        private const string Database = "~/Modules/Development/EntityGeneratorIndex.cshtml";

        public ActionResult TableExplorer()
        {
            return View("~/Modules/Development/TableExplorerIndex.cshtml");
        }

        public ActionResult BugReporter()
        {
            return View("~/Modules/Development/BugReporter.cshtml");
        }

        public ActionResult Login()
        {
            return View("~/Modules/Development/Login.cshtml");
        }

        public ActionResult ModalForm()
        {
            return View("~/Modules/Development/ModalForm.cshtml");
        }

        public ActionResult Splitter()
        {
            return View("~/Modules/Development/Splitter.cshtml");
        }

        public DevelopmentController()
        {
            this.state = new ApplicationState();
        }

        [HttpGet]
        public ActionResult Index()
        {
            string connectionString = GetDefaultConnectionString(DbConnectionTypes.MsSql);
            UpdateState(DbConnectionTypes.MsSql, connectionString);
            state.Databases = state.CurrentProvider?.RefreshDatabases();
            return View(Database, model: state);
        }

     

        [HttpGet]
        public ActionResult SelectConnectionType(DbConnectionTypes connectionType)
        {
            UpdateState(connectionType);
            return View(Database, state);
        }

        [HttpGet]
        public ActionResult Refresh(DbConnectionTypes connectionType, string connectionString)
        {
            UpdateState(connectionType, connectionString);

            state.Databases = state.CurrentProvider?.RefreshDatabases();

            return View(Database, state);
        }

        [HttpGet]
        public ActionResult SelectDatabase(string databaseName)
        {
            string connectionString = GetDefaultConnectionString(DbConnectionTypes.MsSql);
            UpdateState(DbConnectionTypes.MsSql, connectionString);
            state.Databases = state.CurrentProvider?.RefreshDatabases();
            state.SelectedDatabase = state.CurrentProvider?.SelectDatabase(state.Databases, databaseName);
            return View(Database, state);
        }

        private void UpdateState(DbConnectionTypes connectionType, string connectionString = null)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                connectionString = GetDefaultConnectionString(connectionType);
            }

            state.DbConnectionType = connectionType;
            state.ConnectionString = connectionString;
            state.CurrentProvider = GetProvider(connectionType, connectionString);
            state.Databases = null;
            state.SelectedDatabase = null;
        }

        private string GetDefaultConnectionString(DbConnectionTypes connectionType)
        {
            switch (connectionType)
            {
                case DbConnectionTypes.MsSql:
                    return "Data Source=localhost;Integrated Security=True;";
                case DbConnectionTypes.Postgres:
                    return "Server=localhost;Port=5432;User Id=postgres;Password=postgres;";
                case DbConnectionTypes.Oracle:
                    //return "Data Source=127.0.0.1:1521/xe;User Id=oracle;Password=oracle;";
                    return "Data Source=(Local); Initial Catalog=dbEnterprise;UID=sa;PWD=Enterprise";
                default:
                    return null;
            }
        }

        private Provider GetProvider(DbConnectionTypes connectionType, string connectionString)
        {
            Provider provider;
            switch (connectionType)
            {
                case DbConnectionTypes.MsSql:
                    provider = new MsSqlProvider(connectionString);
                    break;
                //case DbConnectionTypes.Postgres:
                //    provider = new PostgresProvider(connectionString);
                //    break;
                //case DbConnectionTypes.Oracle:
                //    provider = new OracleProvider(connectionString);
                //    break;
                default:
                    return null;
            }

            return provider;
        }
    }
}