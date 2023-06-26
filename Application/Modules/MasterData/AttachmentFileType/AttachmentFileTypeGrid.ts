
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class AttachmentFileTypeGrid extends Serenity.EntityGrid<AttachmentFileTypeRow, any> {
        protected getColumnsKey() { return 'MasterData.AttachmentFileType'; }
        protected getDialogType() { return AttachmentFileTypeDialog; }
        protected getIdProperty() { return AttachmentFileTypeRow.idProperty; }
        protected getLocalTextPrefix() { return AttachmentFileTypeRow.localTextPrefix; }
        protected getService() { return AttachmentFileTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}