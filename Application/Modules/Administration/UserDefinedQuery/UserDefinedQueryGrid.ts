
namespace Matrix.Administration {

    @Serenity.Decorators.registerClass()
    export class UserDefinedQueryGrid extends Serenity.EntityGrid<UserDefinedQueryRow, any> {
        protected getColumnsKey() { return 'Administration.UserDefinedQuery'; }
        protected getDialogType() { return UserDefinedQueryDialog; }
        protected getIdProperty() { return UserDefinedQueryRow.idProperty; }
        protected getLocalTextPrefix() { return UserDefinedQueryRow.localTextPrefix; }
        protected getService() { return UserDefinedQueryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getSlickOptions(): Slick.GridOptions {
            var opt = super.getSlickOptions();
            opt.enableTextSelectionOnCells = true;
            opt.selectedCellCssClass = "slick-row-selected";
            opt.enableCellNavigation = true;
            return opt;
        }

        protected createSlickGrid(): Slick.Grid {
            var grid = super.createSlickGrid();
            grid.setSelectionModel(new Slick.RowSelectionModel());
            return grid;
        }

        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            buttons.splice(Q.indexOf(buttons, x => x.cssClass === "add-button"), 1);
            return buttons;
        }

        protected getColumns() {
            var columns = super.getColumns();
            columns.push(
                {
                    field: 'View Details',
                    name: '',
                    format: ctx => '<a class="inline-action view-details" title="view details">View Detail</a>',
                    width: 24,
                    minWidth: 24,
                    maxWidth: 24   
                });
            return columns;      
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number) {
            super.onClick(e, row, cell);

            if (e.isDefaultPrevented())
                return;   

            var item = this.itemAt(row);
            var target = $(e.target);
               
            // if user clicks "i" element, e.g. icon
            if (target.parent().hasClass('inline-action'))
                target = target.parent();

            if (target.hasClass('inline-action')) {
                e.preventDefault();

               
                if (target.hasClass('view-details')) {
                    Q.notifySuccess("No problem!" + item);
                }
               
            }
        }
    }
}