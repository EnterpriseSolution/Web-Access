﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  FifoControlForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Inventory.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Inventory.FifoControl")]
    [BasedOnRow(typeof(Entities.FifoControlRow))]
    public class FifoControlForm
    {
        public String Loc { get; set; }
        public String ItemNo { get; set; }
        public String Allocated { get; set; }
        public DateTime ValueDate { get; set; }
        [AlignRight]
        public Decimal LogNo { get; set; }
        [AlignRight]
        public Decimal LineNo { get; set; }
        [AlignRight]
        public Decimal LogNoOut { get; set; }
        [AlignRight]
        public Decimal LineNoOut { get; set; }
        [AlignRight]
        public Decimal Qty { get; set; }
        [AlignRight]
        public Decimal Cost { get; set; }
    }
}