#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LocationColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MasterData.Location")]
    [BasedOnRow(typeof(Entities.LocationRow))]
    public class LocationColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String Loc { get; set; }
        public String Description { get; set; }
        public bool Suspended { get; set; }
        //public String Address { get; set; }
        //public String Address2 { get; set; }
        //public String Address3 { get; set; }
        //public String Address4 { get; set; }
        //public String BranchNo { get; set; }
        //public String NoReservation { get; set; }
        //public String NoWaitlist { get; set; }
        //public String NoAvailable { get; set; }
        //public String NoPlanning { get; set; }
        //public String NoIssuance { get; set; }
        //public String NoReceipts { get; set; }
        //public String NoMatIssue { get; set; }
        //public String NoFgReturn { get; set; }
        //public String NoShipment { get; set; }
        //public String NoGrn { get; set; }
        //public String WithBacklog { get; set; }

        //public Decimal OnSorderCount { get; set; }
        //public Decimal OnPorderCount { get; set; }
        //public Decimal OnJorderCount { get; set; }
        //public Decimal InvtCostAvail { get; set; }
        //public Decimal InvtCostLdg { get; set; }

        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        public bool WithBinCtrl { get; set; }
        public Boolean WithPackingBox { get; set; }
    }
}