#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  InventoryMovementDetailEditorAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using Serenity.ComponentModel;

namespace Matrix.Inventory.Forms
{
    public partial class InventoryMovementDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Matrix.Inventory.InventoryMovementDetailEditor";

        public InventoryMovementDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}