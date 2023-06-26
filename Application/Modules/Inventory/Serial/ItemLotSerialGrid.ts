
namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    export class ItemLotSerialGrid extends Serenity.EntityGrid<ItemLotSerialRow, any> {
        protected getColumnsKey() { return 'Inventory.ItemLotSerial'; }
        protected getDialogType() { return ItemLotSerialDialog; }
        protected getIdProperty() { return ItemLotSerialRow.idProperty; }
        protected getLocalTextPrefix() { return ItemLotSerialRow.localTextPrefix; }
        protected getService() { return ItemLotSerialService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        private sourceLanguage: Serenity.LookupEditor;

        protected createToolbarExtensions(): void {
            super.createToolbarExtensions();

            let opt: Serenity.LookupEditorOptions = {
                lookupKey: 'Inventory.ItemLotSerialItemLookup'
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