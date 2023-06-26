
namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    export class ItemLotGrid extends Serenity.EntityGrid<ItemLotRow, any> {
        protected getColumnsKey() { return 'Inventory.ItemLot'; }
        protected getDialogType() { return ItemLotDialog; }
        protected getIdProperty() { return ItemLotRow.idProperty; }
        protected getLocalTextPrefix() { return ItemLotRow.localTextPrefix; }
        protected getService() { return ItemLotService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
        private sourceLanguage: Serenity.LookupEditor;

        protected createToolbarExtensions(): void {
            super.createToolbarExtensions();

            let opt: Serenity.LookupEditorOptions = {
                lookupKey: 'Inventory.ItemLotItemLookup'
            };

            this.sourceLanguage = Serenity.Widget.create({
                type: Serenity.LookupEditor,
                element: el => el.appendTo(this.toolbar.element).attr('placeholder', 'Item No.'),
                options: opt
            });

            this.sourceLanguage.changeSelect2(e => {
                this.refresh();
            });
        }

        protected onViewSubmit(): boolean {
            var request = this.view.params;
            if (Q.isEmptyOrNull(this.sourceLanguage.value))
                return false;

            request.ItemNo = this.sourceLanguage.value;
            return super.onViewSubmit();
        }

    }
}