#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LocationForm.cs
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

    [FormScript("MasterData.Location")]
    [BasedOnRow(typeof(Entities.LocationRow))]
    public class LocationForm
    {
        [Tab(TabName.GeneralInformation)]
        [Category(CategoryName.BasicInformation)]
        public String Loc { get; set; }
        public String Description { get; set; }
        public String Suspended { get; set; }
        public String Address { get; set; }
        public String Address2 { get; set; }
        public String Address3 { get; set; }
        public String Address4 { get; set; }

        [Category(CategoryName.OperationNotAllow)]
        //public String BranchNo { get; set; }
        public bool NoReservation { get; set; }
        public bool NoWaitlist { get; set; }
        public bool NoAvailable { get; set; }
        public bool NoPlanning { get; set; }
        public bool NoIssuance { get; set; }
        public bool NoReceipts { get; set; }
        public bool NoMatIssue { get; set; }
        public bool NoFgReturn { get; set; }
        public bool NoShipment { get; set; }
        public bool NoGrn { get; set; }
       
        [Category(CategoryName.Order)]
        public Decimal OnSorderCount { get; set; }
        public Decimal OnPorderCount { get; set; }
        public Decimal OnJorderCount { get; set; }

        [Category(CategoryName.Control)]
        public String WithBinCtrl { get; set; }
        public Boolean WithPackingBox { get; set; }

        [Category(CategoryName.Inventory)]
        public String WithBacklog { get; set; }
        public Decimal InvtCostAvail { get; set; }
        public Decimal InvtCostLdg { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
    }
}