#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AssemblyLineForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.MasterData.Entities;
using Matrix.Modules.Common.Enum;
using Matrix.Sales.Entities;

namespace Matrix.MasterData.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MasterData.AssemblyLine")]
    [BasedOnRow(typeof(Entities.AssemblyLineRow))]
    public class AssemblyLineForm
    {
        public String AssemblyLine { get; set; }
        public String Description { get; set; }
        //public String BranchNo { get; set; }
        public bool Suspended { get; set; }
        public String Priority { get; set; }
        [DisplayName("Efficiency Rating")]
        public Decimal EffcRating { get; set; }

        [Category(CategoryName.NotAllowJobCategory)]
        public String Restrict0 { get; set; }
        public String Restrict1 { get; set; }
        public String Restrict2 { get; set; }
        public String Restrict3 { get; set; }
        public String Restrict4 { get; set; }
        public String Restrict5 { get; set; }
        public String Restrict6 { get; set; }
        public String Restrict7 { get; set; }
        public String Restrict8 { get; set; }
        public String Restrict9 { get; set; }

        [Category(CategoryName.RequiredJobCategory)]
        public String Require0 { get; set; }
        public String Require1 { get; set; }
        public String Require2 { get; set; }
        public String Require3 { get; set; }
        public String Require4 { get; set; }
        public String Require5 { get; set; }
        public String Require6 { get; set; }
        public String Require7 { get; set; }
        public String Require8 { get; set; }
        public String Require9 { get; set; }

        [Tab(TabName.Details)]
        [AssemblyLineWorkCentreDetailEditor]
        List<AssemblyLineWorkCentreDetailRow> DetailList { get; set; }

        //public String AcctMachine { get; set; }
        //public String AcctEnergy { get; set; }
        //public String AcctWater { get; set; }
        //public String AcctRental { get; set; }
        //public String AcctLabor { get; set; }
        //public String AcctInlab { get; set; }
        //public String AcctInmat { get; set; }
        //public String AcctMisc { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime BrevisedDate { get; set; }
        //public String BrevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
    }
}