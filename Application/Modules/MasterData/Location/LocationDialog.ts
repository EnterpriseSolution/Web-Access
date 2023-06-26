﻿
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.panel()
    export class LocationDialog extends Serenity.EntityDialog<LocationRow, any> {
        protected getFormKey() { return LocationForm.formKey; }
        protected getIdProperty() { return LocationRow.idProperty; }
        protected getLocalTextPrefix() { return LocationRow.localTextPrefix; }
        protected getNameProperty() { return LocationRow.nameProperty; }
        protected getService() { return LocationService.baseUrl; }

        protected form = new LocationForm(this.idPrefix);

    }
}