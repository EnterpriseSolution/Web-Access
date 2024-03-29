﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  BuyerControlForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MasterData.BuyerControl")]
    [BasedOnRow(typeof(Entities.BuyerControlRow))]
    public class BuyerControlForm
    {
        public String BuyerCode { get; set; }
        public Decimal LineNo { get; set; }
        public String TypeGroup { get; set; }
        public String TypeItem { get; set; }
        public String EntryCode { get; set; }
        public String Description { get; set; }
        public String Suspended { get; set; }
        public Decimal MaxQty { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
    }
}