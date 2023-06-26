/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    export class InventoryMovementDetailEditor extends Common.GridEditorBase<InventoryMovementDetailRow> {
        protected getColumnsKey() { return "Inventory.InventoryMovementDetail"; }
        protected getDialogType() { return InventoryMovementDetailDialog; }
        protected getLocalTextPrefix() { return InventoryMovementDetailRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }

        validateEntity(row, id) {
            //row.ProductID = Q.toId(row.ProductID);

            //var sameProduct = Q.tryFirst(this.view.getItems(), x => x.ProductID === row.ProductID);
            //if (sameProduct && this.id(sameProduct) !== id) {
            //    Q.alert('This product is already in order details!');
            //    return false;
            //}

            //row.ProductName = ProductRow.getLookup().itemById[row.ProductID].ProductName;
            //row.LineTotal = (row.Quantity || 0) * (row.UnitPrice || 0) - (row.Discount || 0);
            return true;
        }
        

        protected getButtons(): Serenity.ToolButton[] {
            let buttons = super.getButtons();
            buttons = [];
            return buttons;
        }

    }
}