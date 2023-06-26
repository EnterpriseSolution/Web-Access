
namespace Matrix.Administration {

    export class LookupDialogController {

        controls: any;
        constructor(data?: any) {
            this.controls = data;
        }

        public InitiaizeLookupUI(): void {
            this.controls.each(function (i, item) {
                var txt = $(item).text();
                var lookup = $(item).attr("lookup");
                var filter = $(item).attr("filter");
                var targetId = $(item).attr("id");

                var ctrl = jQuery.validator
                    .format(
                        '<input id="btn{2}" style="margin-left:5pt" class="buttonLookup" type="button" value="..."  lookup="{0}"   filter="{1}"  targetId="{2}" />',
                        lookup,
                        filter,
                        targetId);

                $(item).after($(ctrl));
            });
        }
        
        public InitiaizeLookupExecution(): void {
            this.controls.each(function (i, item) {
                   
                jQuery(document).off().on('click', item, function (event) {
                    //event.preventDefault();
                    event.stopPropagation();

                    //$(event).one('click', function (e) { e.stopImmediatePropagation(); });


                    var control = event.target;

                    if (control.tagName !== "INPUT")
                        return;

                    console.log("control",control);

                    var lookupname = control.getAttribute("lookup");
                    if (lookupname == null)
                        return;

                    var filter = control.getAttribute("filter");
                    var targetId = control.getAttribute("targetId");
                    var pageIndex = 1;

                    if (lookupname == null || filter == null) {
                        console.log("Error in retrieve lookup data", control);
                        return;
                    }

                    console.log(jQuery.validator.format("reuest param:{0}.{1}.{2}.{3}",
                        lookupname,
                        filter,
                        targetId,
                        pageIndex));

                    var data = {
                        LookupName: lookupname,
                        LookupFilter: filter,
                        TargetId: targetId,
                        CurrentPageIndex: pageIndex
                    };

                    var dlg = new Matrix.Administration.LookupDialog(data);
                    dlg.dialogOpen(false);
                });

            });
        }
    }
}