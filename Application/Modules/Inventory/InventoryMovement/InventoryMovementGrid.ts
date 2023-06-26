
namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    export class InventoryMovementGrid extends Serenity.EntityGrid<InventoryMovementRow, any> {
        protected getColumnsKey() { return 'Inventory.InventoryMovement'; }
        protected getDialogType() {
            return InventoryMovementDialog;
        }
        protected getIdProperty() { return InventoryMovementRow.idProperty; }
        protected getLocalTextPrefix() { return InventoryMovementRow.localTextPrefix; }
        protected getService() { return InventoryMovementService.baseUrl; }

        flowType: string;

        protected getSlickOptions(): Slick.GridOptions {
            var opt = super.getSlickOptions();
            opt.enableTextSelectionOnCells = true;
            opt.selectedCellCssClass = "slick-row-selected";
            opt.enableCellNavigation = true;
            return opt;
        }
        
        public setFlowType(flowType: string):void {
            this.flowType = flowType;
            InventoryMovementDialog.FlowType = flowType;
        }

        protected createSlickGrid(): Slick.Grid {
            var grid = super.createSlickGrid();
            grid.setSelectionModel(new Slick.RowSelectionModel());
            return grid;
        }

        constructor(container: JQuery,flowType:string) {
            super(container);
            this.flowType = flowType;
        }

        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            buttons.splice(Q.indexOf(buttons, x => x.cssClass === "add-button"), 1);
            return buttons;
        }

        protected getQuickFilters() {
            let items = super.getQuickFilters();
            var genreListFilter = Q.first(items, x => x.field === InventoryMovementRow.Fields.FlowType);

            genreListFilter.handler = h => {
                var request = (h.request as InventoryMovementListRequest);
                request.FlowType = this.flowType;
                h.handled = true;
            };

            return items;
        }

    }
}