#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PayTermForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Common.Enum;

namespace Matrix.MasterData.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MasterData.PayTerm")]
    [BasedOnRow(typeof(Entities.PayTermRow))]
    public class PayTermForm
    {
        [Tab(TabName.GeneralInformation)]
        [Category(CategoryName.BasicInformation)]
        public String PayTerms { get; set; }
        public String Description { get; set; }
        public Boolean Suspended { get; set; }

        [Category(CategoryName.Computation)]
        public String BaseDate { get; set; }
        public Decimal DueDays { get; set; }
        public Decimal DiscDays { get; set; }
        public Decimal DiscPercent { get; set; }
        public String AdjustCrlimit { get; set; }
        public Decimal MinDueDays { get; set; }

        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }

        [Tab(TabName.Computation)]
        [Category(CategoryName.Phase1)]
        public String Phase1PayTerms { get; set; }
        public String Phase1BaseDate { get; set; }
        public Decimal Phase1DueDays { get; set; }
        public Decimal Phase1PayPercent { get; set; }

        [Category(CategoryName.Phase2)]
        public String Phase2PayTerms { get; set; }
        public String Phase2BaseDate { get; set; }
        public Decimal Phase2DueDays { get; set; }
        public Decimal Phase2PayPercent { get; set; }

        [Category(CategoryName.Phase3)]
        public String Phase3PayTerms { get; set; }
        public String Phase3BaseDate { get; set; }
        public Decimal Phase3DueDays { get; set; }
        public Decimal Phase3PayPercent { get; set; }

        [Category(CategoryName.Phase4)]
        public String Phase4PayTerms { get; set; }
        public String Phase4BaseDate { get; set; }
        public Decimal Phase4DueDays { get; set; }
        public Decimal Phase4PayPercent { get; set; }

        [Category(CategoryName.Phase5)]
        public String Phase5PayTerms { get; set; }
        public String Phase5BaseDate { get; set; }
        public Decimal Phase5DueDays { get; set; }
        public Decimal Phase5PayPercent { get; set; }
    }
}