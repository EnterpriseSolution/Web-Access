
namespace Matrix.EnterpriseSys {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.resizable()
    @Serenity.Decorators.maximizable()
    export class DocumentPreivewDialog extends Serenity.TemplatedDialog<any> {
        reportId: string;
        desc:string;
        rows: any;
          
        constructor(reportId: any) {
            super(reportId);
        }

        load(reportId: string) {
           
        }

      
        static initializePage() {
        }

        protected onDialogOpen() {
            super.onDialogOpen();
        }

        protected getDialogOptions() {
            var opt = super.getDialogOptions();
            opt.title = this.desc;
            return opt;
        }
    }
}