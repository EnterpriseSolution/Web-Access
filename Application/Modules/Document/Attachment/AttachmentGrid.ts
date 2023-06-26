
namespace Matrix.Document {

    @Serenity.Decorators.registerClass()
    export class AttachmentGrid extends Serenity.EntityGrid<AttachmentRow, any> {
        protected getColumnsKey() { return 'Document.Attachment'; }
        protected getDialogType() { return AttachmentDialog; }
        protected getIdProperty() { return AttachmentRow.idProperty; }
        protected getLocalTextPrefix() { return AttachmentRow.localTextPrefix; }
        protected getService() { return AttachmentService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            buttons.splice(Q.indexOf(buttons, x => x.cssClass === "add-button"), 1);
            return buttons;
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
                    let parm = {
                        reportId: item.FilePath
                    };
                    var path = Q.format("PDFDisplay?fileName={0}", item.FilePath);
                    document.location.href = path;

                    //open with document 
                    //var dlg = new Matrix.EnterpriseSys.DocumentPreivewDialog(parm);
                    //this.initDialog(dlg);
                    //dlg.dialogOpen(false);
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