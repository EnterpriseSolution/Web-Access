
namespace Matrix.EnterpriseSys {
    //import any = Q.any;

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.resizable()
    @Serenity.Decorators.maximizable()
    export class ReportPreivewDialog extends Serenity.TemplatedDialog<any> {
        reportId: string;
        desc:string;
        rows: any;
          
        constructor(reportId: any) {
            super(reportId);
            this.reportId = reportId.reportId;
            this.desc = reportId.desc;
            
            $('#reportTitle').val(this.reportId);
            this.load(this.reportId);
        }

        load(reportId: string) {
            var data = {
                ReportId: reportId
            };
           
            ReportDialogService.ReportDetail(data, response => {
                let initialize = "";
                for (var x of response.Rows) {
                    (x as any).Vue = initialize;
                }
                this.rows = response.Rows;

                console.log("ReportDetail", response);

                var vm = new Vue({
                    el: '#reports',
                    data: {
                        rows: this.rows,
                        yes: true,
                        no: false,
                        age: 28,
                        name: 'keepfool'
                    },
                    methods: {
                        OnPreview: function (event) {
                            if (event)
                                event.preventDefault();

                            console.log("changed", this.rows);
                            
                            var values: ReportPreviewUserInput []=[];
                            for (let entry of this.rows) {

                                if (entry.Required === 1) {
                                    Q.warning(entry.Caption + " is required");
                                    return;
                                }
                                let item: ReportPreviewUserInput = {};
                                item.OptionNo = entry.OptionNo as number;
                                item.Value = entry.Vue as string;
                               
                                values.push(item);
                            }

                            let parm: ReportPreviewRequest = {} as ReportPreviewRequest;
                            parm.ReportId = reportId;
                            parm.Values = values;
                           
                            let url = "http://localhost:7451/Modules/Report/Default.aspx";

                            ReportDialogService.ReportPreview(parm, response => {
                                window.open(url, "_blank");
                                
                            });
                        },
                        OnPrint: function (msg) {
                            //alert(msg)
                        }
                    }
                });
            });
        }

      
        static initializePage() {
            //$(function () {
            //    $('#LaunchDialogButton').click(function (e) {
            //        (new ChartInDialog()).dialogOpen();
            //    });
            //});
        }

        protected onDialogOpen() {
            super.onDialogOpen();
            //BasicSamplesService.OrdersByShipper({}, response => {
            //    this.areaChart = new Morris.Area({
            //        element: this.idPrefix + 'Chart',
            //        resize: true, parseTime: false,
            //        data: response.Values,
            //        xkey: 'Month',
            //        ykeys: response.ShipperKeys, labels: response.ShipperLabels, hideHover: 'auto'
            //    });
            //});
        }

        protected getDialogOptions() {
            var opt = super.getDialogOptions();
            opt.title = this.desc;
            return opt;
        }
    }
}