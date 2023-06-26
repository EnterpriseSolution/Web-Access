#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  Database.cs
// Date: 2018/04/03 20:51

#endregion
using System.Collections.Generic;
using DapperCodeGenerator.Core.Enumerations;

namespace DapperCodeGenerator.Core.Models
{
    public class Database
	{
	    public DbConnectionTypes ConnectionType { get; set; }
        public string DatabaseName { get; set; }
        
        public List<DatabaseTable> Tables { get; set; } = new List<DatabaseTable>();
    }
}
