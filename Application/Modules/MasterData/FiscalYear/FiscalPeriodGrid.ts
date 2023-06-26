
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class FiscalPeriodGrid extends Serenity.EntityGrid<FiscalPeriodRow, any> {
        protected getColumnsKey() { return 'MasterData.FiscalPeriod'; }
        protected getDialogType() { return FiscalPeriodDialog; }
        protected getIdProperty() { return FiscalPeriodRow.idProperty; }
        protected getLocalTextPrefix() { return FiscalPeriodRow.localTextPrefix; }
        protected getService() { return FiscalPeriodService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        private sourceLanguage: Serenity.LookupEditor; 

        protected createToolbarExtensions(): void {
            super.createToolbarExtensions();

            let opt: Serenity.LookupEditorOptions = {
                lookupKey: 'MasterData.FiscalYearRow'
            };

            this.sourceLanguage = Serenity.Widget.create({
                type: Serenity.LookupEditor,
                element: el => el.appendTo(this.toolbar.element).attr('placeholder', 'Fiscal Year'),
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

            request.FiscalYear = this.sourceLanguage.value;
            return super.onViewSubmit();
        }
    }
}