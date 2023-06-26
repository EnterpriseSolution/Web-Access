#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AnalysisCategoryForm.cs
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

    [FormScript("MasterData.AnalysisCategory")]
    [BasedOnRow(typeof(Entities.AnalysisCategoryRow))]
    public class AnalysisCategoryForm
    {
        [EditLink]
        public String Category { get; set; }
        public String Description { get; set; }
        public String Caption { get; set; }

        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }

        [Tab(TabName.Details), AnalysisCategoryDetailEditor]
        public List<AnalysisCodeRow> DetailList { get; set; }
    }
}