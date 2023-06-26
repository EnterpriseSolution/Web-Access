

namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class PurchaseRequisitionApprovalGrid extends Serenity.EntityGrid<PurchaseRequisitionRow, any> {
        protected getColumnsKey() { return 'Purchasing.PurchaseRequisitionApproval'; }
        protected getDialogType() { return PurchaseRequisitionDialog; }
        protected getIdProperty() { return PurchaseRequisitionRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseRequisitionRow.localTextPrefix; }
        protected getService() { return PurchaseRequisitionService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            buttons.splice(Q.indexOf(buttons, x => x.cssClass === "add-button"), 1);
            return buttons;
        }


        /*
        When constructing your options, you can use forceFitColumns: true
        var options = {
        enableCellNavigation: true,
        forceFitColumns: true
        };
    
       This will make the columns fill the entire width of your grid div.


slickgrid-column-data-autosize

This plug-in is for slickgrid to handle auto size columns based on the header size, data size, cell-formats and max data length.

######Single column auto size Double click on a column resize handle.

######All columns auto size Select a cell or row => Ctrl-Shift-a

######How it works

1.Column will auto fit to given/default max width if cell data width is more than given max width. Slick.AutoColumnSize(100) or default :200

OR


2.Column will auto fit to max data width in the row if header width is lesser than data width.

OR


3.Column will auto fit to header width if header width is greater than data width.


######Browser <script src="../src/slick.autocolumnsize.js"></script>

######Bower npm install slickgrid-column-data-autosize

######Usage
  grid = new Slick.Grid("#myGrid", data, columns, options);
  grid.registerPlugin( new Slick.AutoColumnSize());
  [OR]
  grid.registerPlugin( new Slick.AutoColumnSize(200));


       */

        protected getSlickOptions(): Slick.GridOptions {
            var opt = super.getSlickOptions();
            opt.enableTextSelectionOnCells = true;
            opt.selectedCellCssClass = "slick-row-selected";
            opt.enableCellNavigation = true;
            opt.forceFitColumns = true;
            opt.enableColumnReorder = false;
            return opt;
        }

        //protected createSlickGrid() {
        //    var grid = super.createSlickGrid();

        //    // need to register this plugin for grouping or you'll have errors
           

        //    this.view.setSummaryOptions({
        //        aggregators: [
        //            new Slick.Aggregators.Avg('UnitPrice'),
        //            new Slick.Aggregators.Sum('UnitsInStock'),
        //            new Slick.Aggregators.Max('UnitsOnOrder'),
        //            new Slick.Aggregators.Avg('ReorderLevel')
        //        ]
        //    });

        //    return grid;
        //}

        protected createSlickGrid(): Slick.Grid {
            var grid = super.createSlickGrid();
            grid.setSelectionModel(new Slick.RowSelectionModel());
            grid.registerPlugin(new Slick.Data.GroupItemMetadataProvider());
            //grid.registerPlugin(new Slick.AutoColumnSize());

            // *** If you want to make it autoresize when grid is loaded, use: new Slick.AutoColumnSize(true);
            let autoSize = new Slick.AutoColumnSize(true);
            grid.registerPlugin(autoSize);
            return grid;
        }
           
        /*
        protected createSlickGrid(): Slick.Grid {
            let grid = super.createSlickGrid();
            let autoSize = new Slick.AutoColumnSize(true); // *** If you want to make it autoresize when grid is loaded, use: new Slick.AutoColumnSize(true);
            grid.registerPlugin(autoSize);

            return grid;
        }
        */
    }
}