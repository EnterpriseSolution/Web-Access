
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class ColorGrid extends Serenity.EntityGrid<ColorRow, any> {
        protected getColumnsKey() { return 'MasterData.Color'; }

        protected getDialogType() { return ColorDialog; }

        protected getIdProperty() { return ColorRow.idProperty; }

        protected getLocalTextPrefix() { return ColorRow.localTextPrefix; }

        protected getService() { return ColorService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getSlickOptions(): Slick.GridOptions {
            var opt = super.getSlickOptions();
            opt.enableTextSelectionOnCells = true;
            opt.selectedCellCssClass = "slick-row-selected";
            opt.enableCellNavigation = true;
            opt.forceFitColumns = true;
            opt.enableColumnReorder = false;
            return opt;
        }

        protected createSlickGrid(): Slick.Grid {
            var self = this;
            var grid = super.createSlickGrid();
            grid.setSelectionModel(new Slick.RowSelectionModel());

            var headerMenuPlugin = new Slick.Plugins.HeaderMenu({});
            headerMenuPlugin.onBeforeMenuShow.subscribe(function(e, args) {
                var menu = args.menu;
                // We can add or modify the menu here, or cancel it by returning false.
                //return false;
                //var i = menu.items.length;
                //menu.items.push({
                //    title: "Menu item " + i,
                //    command: "item" + i
                //});
            });
            headerMenuPlugin.onCommand.subscribe(function (e, args) {
                console.log("command",e,args);
                Q.notifyInfo("Command: " + args.command);


                if (args.comand === "group") {
                    self.view.setGrouping(
                        [
                            {
                                getter: args.column.field
                            }
                        ]);
                }
            });
            grid.registerPlugin(headerMenuPlugin);

            //group
            grid.registerPlugin(new Slick.Data.GroupItemMetadataProvider());

            return grid;
        }

        protected getColumns() {
            var columns = super.getColumns();
            for (var i = 0; i < columns.length; i++) {
                (columns[i] as any).header = {
                    menu: {
                        items: [
                            {
                                iconImage: "/content/images/sort-asc.gif",
                                title: "Sort Ascending",
                                command: "sort-asc"
                            },
                            {
                                iconImage: "/content/images/sort-desc.gif",
                                title: "Sort Descending",
                                command: "sort-desc"
                            },
                            {
                                title: "Group By",
                                command: "group",
                                disabled: false,
                                tooltip: "Can't hide this column"
                            },
                            {
                                iconCssClass: "/content/images/icon-help",
                                title: "Help",
                                command: "help"
                            }
                        ]
                    }
                };
            }

            return columns;
        }
    }
}