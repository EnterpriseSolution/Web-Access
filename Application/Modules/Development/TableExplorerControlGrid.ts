namespace Matrix.Modules.Development {
    
    @Serenity.Decorators.registerClass()
    export class TableExplorerControlGrid extends Serenity.EntityGrid<TableExplorerColumns, any> {
        protected getColumnsKey() { return 'Development.TableExplorerColumns'; }
        protected getDialogType() { return null; }
        protected getIdProperty() { return TableExplorerColumns.idProperty; }
        protected getLocalTextPrefix() { return ""; }
        protected getService() { return TableExplorerService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
            this.setTitle("Table Explorer");
        }

        protected getButtons(): Serenity.ToolButton[] {

            var buttons = super.getButtons();
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "add-button"), 1);
            return buttons;
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

   
    export interface TableExplorerColumns {
        LineNo?: number;
        Table?: string;
        Entity?: string;
        }
    
    export namespace TableExplorerColumns {
        export const idProperty = 'LineNo';
        export const nameProperty = 'Table';
            export const localTextPrefix = 'Administration.User';
            export const lookupKey = 'Administration.User';

        export function getLookup(): Q.Lookup<TableExplorerColumns> {
            return Q.getLookup<TableExplorerColumns>('Administration.User');
            }

            export namespace Fields {
                export declare const LineNo: number;
                export declare const Table: string;
                export declare const Entity: string;
            }

            [
                'LineNo',
                'Table',
                'Entity'
            ].forEach(x => (<any>Fields)[x] = x);
        }
}