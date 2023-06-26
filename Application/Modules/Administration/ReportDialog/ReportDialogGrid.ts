
namespace Matrix.EnterpriseSys {

    @Serenity.Decorators.registerClass()
    export class ReportDialogGrid extends Serenity.EntityGrid<ReportDialogRow, any> {
        protected getColumnsKey() { return 'EnterpriseSys.ReportDialog'; }
        protected getDialogType() { return ReportDialogDialog; }
        protected getIdProperty() { return ReportDialogRow.idProperty; }
        protected getLocalTextPrefix() { return ReportDialogRow.localTextPrefix; }
        protected getService() { return ReportDialogService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getColumns() {
            var columns = super.getColumns();

            columns.push({
                field: 'Preview',  
                name: '',
                format: ctx => '<a class="inline-action preview-report"  title="Preview">' +
                         '<i class="fa fa-trash-o text-red"></i></a>',
                width: 24,
                minWidth: 24,
                maxWidth: 24
            });
            return columns;
        }

        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            buttons.splice(Q.indexOf(buttons, x => x.cssClass === "add-button"), 1);
            return buttons;
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number) {
            super.onClick(e, row, cell);

            if (e.isDefaultPrevented())
                return;

            var item = this.itemAt(row);
            var target = $(e.target);
            
            if (target.parent().hasClass('inline-action'))
                target = target.parent();

            if (target.hasClass('inline-action')) {
                e.preventDefault();
                if (target.hasClass('preview-report')) {
                    //let reportId = item.ReportId;
                    //let desc = item.Description;
                    let parm= {
                        reportId: item.ReportId,
                        desc : item.Description
                    };
                    var dlg = new Matrix.EnterpriseSys.ReportPreivewDialog(parm);
                    this.initDialog(dlg);
                    dlg.dialogOpen(false);
                }
            }
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
    }
}