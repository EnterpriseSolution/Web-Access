
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class PlannerGrid extends Serenity.EntityGrid<PlannerRow, any> {
        protected getColumnsKey() { return 'MasterData.Planner'; }
        protected getDialogType() { return PlannerDialog; }
        protected getIdProperty() { return PlannerRow.idProperty; }
        protected getLocalTextPrefix() { return PlannerRow.localTextPrefix; }
        protected getService() { return PlannerService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }


    }
}