

namespace App {
    //export class String {
    //    public static isNullOrEmpty(value: string | any): boolean {
    //        if (value === undefined || value == null || value === '')
    //            return true;
    //        return false;
    //    }
    //    public static toDate(value: string | any, formats?: any): Date {
    //        if (Object.isNullOrUndefined(formats)) {
    //            formats = DateTimeFormat.DateTimeSecond;
    //        }
    //        return kendo.parseDate(value, formats, Setting['lang']);
    //    }

    //    public static translate(code: string): any {

    //        var gettextCatalog = Setting['gettext'] as angular.gettext.gettextCatalog;
    //        return gettextCatalog.getString(code);
    //    }

    //    public static format(code: string, formatdata: any): string {

    //        var gettextCatalog = Setting['gettext'] as angular.gettext.gettextCatalog;

    //        var txt = gettextCatalog.getString(code);
    //        var j: number = 0;

    //        $.each(formatdata, (i, n) => {
    //            var langStr = "{" + j + "}";
    //            txt = txt.replace(langStr, "{{" + i + "}}");
    //            j++;
    //        });
    //        return gettextCatalog.getString(txt, formatdata);
    //    }

    //}

    export class DateTime {

        static today(): Date {
            var date = new Date();
            return new Date(date.getFullYear(), date.getMonth(), date.getDate());
        }

        static addDays(date: Date, days: number): Date {
            var resultDate = new Date(date.getFullYear(), date.getMonth(), date.getDate(), date.getHours(), date.getMinutes(), date.getSeconds(), date.getMilliseconds());
            resultDate.setDate(resultDate.getDate() + days);
            return resultDate;
        }

        static addMonths(date: Date, months: number): Date {
            var resultDate = new Date(date.getFullYear(), date.getMonth(), date.getDate(), date.getHours(), date.getMinutes(), date.getSeconds(), date.getMilliseconds());
            resultDate.setMonth(resultDate.getMonth() + months);
            return resultDate;
        }

        static addHours(date: Date, hours: number): Date {
            var resultDate = new Date(date.getFullYear(), date.getMonth(), date.getDate(), date.getHours(), date.getMinutes(), date.getSeconds(), date.getMilliseconds());
            resultDate.setHours(resultDate.getHours() + hours);
            return resultDate;
        }

        static addMintues(date: Date, minutes: number): Date {
            var resultDate = new Date(date.getFullYear(), date.getMonth(), date.getDate(), date.getHours(), date.getMinutes(), date.getSeconds(), date.getMilliseconds());
            resultDate.setMinutes(resultDate.getMinutes() + minutes);
            return resultDate;
        }

        static CheckDateTimeFormatToMinute(value) {
            //Format: dd/MM/yyyy HH:mm
            var formatReg = new RegExp("^([12][0-9]|3[01]|0?[1-9])/([1][0-2]|0?[1-9])/[1-2][0-9][0-9][0-9] ([01][0-9]|[2][0-3]):[0-5][0-9]$");
            return formatReg.test(value);
            // for february need add new one Regexp
        }

        static CheckDateTimeFormatToDay(value) {
            //Format: dd/MM/yyyy
            var formatReg = new RegExp("^([12][0-9]|3[01]|0?[1-9])/([1][0-2]|0?[1-9])/[1-2][0-9][0-9][0-9]$");
            return formatReg.test(value);
            // for february need add new one Regexp
        }
    }

    export class Object {

        static isNullOrUndefined(value: any): boolean {
            if (value === undefined || value == null || value == "")
                return true;
            return false;
        }
    }

    export class Guid {

        static Empty: string = '00000000-0000-0000-0000-000000000000';

        static isEmpty(value: string | any): boolean {
            return value === '00000000-0000-0000-0000-000000000000';
        }

    }

    export class Array {
        public static RemoveAt(index: number, data: any[]): any[] {
            if (isNaN(index) || index > data.length)
            { return data; }
            return data.slice(0, index).concat(data.slice(index + 1, data.length));
        }
    }

    export class Common {
        static HandleError(reason: any): void {
            console.log(reason);
        }
    }
    
    export class Table {
        static InitGridControl(): void {
            $(".table-select tr").bind('click', function (event) {
                //multi table
                var container = $(event.currentTarget).parents(".table-select");
                container.find(".select-tr").removeClass("select-tr");
                //group table
                var containergroup = $(event.currentTarget).parents(".table-group");
                containergroup.find(".select-tr").removeClass("select-tr");

                $(event.currentTarget).addClass("select-tr");
                var dd = $(event.currentTarget).parentsUntil(".table-select");
                $.each(dd, (i, n) => {
                    if ($(n).is("tr")) { $(n).addClass("select-tr"); }
                })
                $(event.currentTarget).find(".table-subgrid tr").first().addClass("select-tr");

                return false;
            });
            this.TableStripedHandle();
            this.InitMultiGrid();
        }
        private static TableStripedHandle(): void {
            $(".table-striped>tbody>tr").each((i, n) => {
                $(n).find(".table-subgrid").css('background-color', $(n).css('background-color'));
            });
        }
        private static InitMultiGrid(): void {
            ($('.collapse') as any).collapse('show');
        }
        //kendo grid
        static InitMergeRowsKendoGrid(mergeColumns: any[], target: any): void {
            var tb = target.element;
            mergeColumns.forEach((ii, nn) => {
                var indexCol = ii;
                if (indexCol > -1) {
                    var first_instance = null;
                    var rowspan = 1;
                    var trs = $(tb).find('tr');
                    var keyRLength;
                    trs.each(function (i, row) {
                        var dimension_td = $($(row).find('td')[indexCol]);
                        var rLength = $($(row).find('td')[mergeColumns[0]]).attr('rowspan');
                        if (rLength)
                            keyRLength = rLength;
                        if (first_instance == null) {
                            first_instance = dimension_td;
                            rowspan = 1;
                        } else if (dimension_td.text() == first_instance.text()) {
                            if (rLength) {
                                first_instance.attr('rowspan', rowspan);
                                rowspan = 1;
                                first_instance = dimension_td;
                            }
                            else {
                                rowspan++;
                                dimension_td.hide();
                            }
                        }
                        else {

                            first_instance.attr('rowspan', rowspan);
                            //set css
                            // console.warn(indexCol == mergeColumns[0], indexCol, mergeColumns[0]);
                            if (indexCol == mergeColumns[0]) {
                                $(first_instance).parent("tr:first").addClass("rowspan");
                            }

                            rowspan = 1;
                            first_instance = dimension_td;
                        }
                        if (i == trs.length - 1) {
                            first_instance.attr('rowspan', rowspan);
                            //set css
                            if (indexCol == mergeColumns[0]) {
                                $(first_instance).parent("tr:first").addClass("rowspan");
                            }
                        }
                    });
                }
            });



            var trs = $(tb).find('tr');
            var mergeRowIndex = 0;
            trs.each(function (i, n) {
                var row = $(n);
                if (row.hasClass("rowspan")) {
                    if (mergeRowIndex % 2 > 0) {
                        row.addClass("odd");
                    }
                    mergeRowIndex++;
                }
                else {

                    var prerow = row.prev("tr");
                    if (prerow.hasClass("rowspan")) {
                        prerow.find("td").css("border-bottom-width", "0px");
                        prerow.find("td[rowspan]").css("border-bottom-width", "1px");
                    }
                    var nextrow = row.next("tr");
                    if (!nextrow.hasClass("rowspan"))
                        row.find("td").css("border-bottom-width", "0px");
                    if (mergeRowIndex % 2 == 0) {
                        row.addClass("odd");
                    }
                }
            });
            trs.last().find("td").css("border-bottom-width", "1px");
            trs.bind('click', function (event) {
                var row = $(event.currentTarget);
                row.siblings().removeClass("k-state-selected");
                row.siblings().find("td").removeClass("k-state-selected");
                row.siblings().find("td").removeClass("select-tr");
                row.addClass("k-state-selected");

                if (!row.hasClass("rowspan")) {
                    var mrows = row.prevAll(".rowspan");
                    // $(mrows[0]).find("td[rowspan]").addClass("k-state-selected");
                    $(mrows[0]).find("td[rowspan]").addClass("select-tr");
                }
            });
            //group header not display
            $(".k-grid .k-grouping-header").hide();
        }

        static InitMergeRowsKendoGridWithGroup(mergeColumns: any[], target: any): void {
            var tb = target.element;
            mergeColumns.forEach((ii, nn) => {
                var indexCol = ii;
                if (indexCol > -1) {
                    var first_instance = null;
                    var rowspan = 1;
                    var trs = $(tb).find('tr');

                    trs.each((i, row) => {
                        var dimension_td = $($(row).find('td')[indexCol]);
                        var rLength = $($(row).find('td')[mergeColumns[0]]).attr('rowspan');

                        if (first_instance == null) {
                            first_instance = dimension_td;
                            rowspan = 1;
                        } else if (dimension_td.text() == first_instance.text()) {
                            if (rLength) {
                                first_instance.attr('rowspan', rowspan);
                                rowspan = 1;
                                first_instance = dimension_td;
                            }
                            else {
                                rowspan++;
                                dimension_td.hide();
                            }
                        }
                        else {
                            first_instance.attr('rowspan', rowspan);
                            //set css
                            //console.warn(indexCol == mergeColumns[0], indexCol, mergeColumns[0]);
                            if (indexCol == mergeColumns[0]) {
                                $(first_instance).parent("tr:first").addClass("rowspan");
                            }
                            rowspan = 1;
                            first_instance = dimension_td;
                        }
                        if (i == trs.length - 1) {
                            first_instance.attr('rowspan', rowspan);
                            //set css
                            if (indexCol == mergeColumns[0]) {
                                $(first_instance).parent("tr:first").addClass("rowspan");
                            }
                        }
                    });
                }
            });


            var trs = $(tb).find('tr');
            var mergeRowIndex = 1;
            trs.each((i, n) => {
                var row = $(n);
                if (row.hasClass("rowspan")) {
                    if (mergeRowIndex % 2 > 0) {
                        row.addClass("odd");
                    }
                    mergeRowIndex++;
                }
                else {

                    var prerow = row.prev("tr");
                    if (prerow.hasClass("rowspan")) {
                        prerow.find("td").css("border-bottom-width", "0px");
                        prerow.find("td[rowspan]").css("border-bottom-width", "1px");
                    }
                    var nextrow = row.next("tr");
                    if (!nextrow.hasClass("rowspan"))
                        row.find("td").css("border-bottom-width", "0px");
                    if (row.hasClass("k-grouping-row")) {
                        row.prev("tr").find("td").css("border-bottom-width", "1px");
                    }
                    if (mergeRowIndex % 2 == 0) {
                        row.addClass("odd");
                    }
                }
                if (row.hasClass("k-grouping-row")) {
                    mergeRowIndex += 1;
                }
            });

            trs.last().find("td").css("border-bottom-width", "1px");

            trs.bind('click', event => {
                var kIcon = $(event.target);
                var row = $(event.currentTarget);
                if (row.hasClass("k-grouping-row") && !kIcon.hasClass("k-icon") && !kIcon.hasClass("linkurl")) {
                    return false;
                }
                row.siblings().removeClass("k-state-selected");
                row.siblings().find("td").removeClass("k-state-selected");
                row.siblings().find("td").removeClass("select-tr");
                row.addClass("k-state-selected");

                if (!row.hasClass("rowspan") && !kIcon.hasClass("k-icon")) {
                    var mrows = row.prevAll(".rowspan");
                    $(mrows[0]).find("td[rowspan]").addClass("select-tr");
                }

                if (kIcon.hasClass("k-icon")) {
                    var groupHeader = kIcon.parents("tr");
                    groupHeader.removeClass("k-state-selected");
                    var rows = groupHeader.nextUntil(".k-grouping-row");
                    if (kIcon.hasClass("k-i-collapse")) {
                        rows.addClass("display-none");
                    } else {
                        rows.removeClass("display-none");
                    }
                }
                return true;
            });

            //group header not display
            $(".k-grid .k-grouping-header").hide();
            if ($("tr").find(".k-group-cell.k-header").length > 1) {
                $("tr:first").find(".k-group-cell.k-header").css("border-bottom", "none");
            }
        }
    }
    
    export class Util {
        static GetUrlParms(parmname: string, matchCase?: boolean): any {
            var reg, r;
            if (!matchCase) {
                reg = new RegExp("(^|&)" + parmname.toLowerCase() + "=([^&]*)(&|$)");
                r = window.location.search.toLowerCase().substr(1).match(reg);
            }
            else {
                reg = new RegExp("(^|&)" + parmname + "=([^&]*)(&|$)");
                r = window.location.search.substr(1).match(reg);
            }
            if (r != null) return r[2]; return null;
        }
        static Timestamp(): any {
            return new Date().getTime();
        }
        static InitFormValidStyle(myForm: any) {
            $("#" + myForm.$name).addClass("ng-dirty");
        }
        static SetWindowAdaptiveHeight(fixedElement: Object[], adaptElemnet: Object[], opts: any): number {
            var setting = {
                adjustHeight: 90,
                componentMinHeight: 200,
                pageAllRowEle: []
            };
            var newWinHeight = 0;
            $.extend(setting, opts);
            var fixedElementHeight = 0;
            var winHeight = $(window).innerHeight();
            setting.pageAllRowEle.forEach(t => {
                newWinHeight += $(t).height();
            });
            if (newWinHeight > winHeight) {
                winHeight = newWinHeight;
            }
            if (fixedElement !== null) {
                fixedElement.forEach((element, index, arr) => {
                    fixedElementHeight += $(element).height();
                });
            }
            var adaptHeight = winHeight - fixedElementHeight - setting.adjustHeight;
            if (adaptHeight < setting.componentMinHeight) {
                adaptHeight = setting.componentMinHeight;
            }
            if (adaptElemnet != null) {
                adaptElemnet.forEach((item) => {
                    if (item.toString().indexOf("|") <= 0) {
                        $(item).height(adaptHeight);
                    } else {
                        var ele = item.toString().split("|");
                        var eleHeight = adaptHeight + parseInt(ele[1]);
                        $(ele[0]).height(eleHeight);
                    }
                });
            }
            return adaptHeight;
        }

        static FindValue(eleName: string, array: any): any {
            var eleValue;
            if (array) {
                $.each(array, (i, n) => {
                    if (n.text == eleName)
                        eleValue = n.value;
                });
            }
            return eleValue;
        }

        static Title(title: string, num: string): string {
            if (num) {
                return title + " for " + num;
            }
            return title;
        };

        static DisplayErroMsg(resp: any): string {
            var erroMsg = "";
            var errMsg = JSON.parse(resp.statusText);
            for (var i = 0, len = errMsg.length; i < len; i++) {
                erroMsg += "*" + errMsg[i].Message + "\n";
            }
            return erroMsg;
        };
        //static DatasPaging(datas: any[], currentPage: number, pageSize: number): IPagingDatas {
        //    var totleCount = datas.length;
        //    var totlePage = totleCount / pageSize;
        //    if ((totleCount) / pageSize > parseInt(((totleCount - 1) / pageSize).toString())) {
        //        totlePage = parseInt(((totleCount - 1) / pageSize).toString()) + 1;
        //    } else {
        //        totlePage = parseInt(((totleCount - 1) / pageSize).toString());
        //    }
        //    currentPage = currentPage < 1 ? totlePage : currentPage;
        //    currentPage = currentPage > totlePage ? 1 : currentPage;
        //    var startRow = (currentPage - 1) * pageSize;
        //    var endRow = currentPage * pageSize;
        //    endRow = (endRow > totleCount) ? totleCount : endRow;
        //    var pageModel = { TotlePages: totlePage, PageSize: pageSize, CurrentPage: currentPage, TotleCount: totleCount }
        //    var result = datas.slice(startRow, endRow);
        //    return { PagingModel: pageModel, Datas: result } as IPagingDatas;
        //}
        //ui 
        static NoRecordTemp: string = "<div><img src='/Content/Images/nodata.png'></div>";
        static SDTemp: string = "<div class='shutdown' style='height:55px;'><span class='glyphicon glyphicon-off' aria-hidden='true'></span><span> SD </span></div>";

        //page control 
        static EnhanceControl(): void {
            var txtInputs = $("input[type='text']");
            txtInputs.each((i, n) => {
                if (!n.hasAttribute("maxlength") && !$(n).parent().parent().hasClass("k-numerictextbox"))
                    $(n).attr("maxlength", 200);
                else if (!n.hasAttribute("maxlength"))
                    $(n).attr("maxlength", 14);
            });


            var areasInputs = $("textarea");
            areasInputs.each((i, n) => {
                if (!n.hasAttribute("maxlength"))
                    $(n).attr("maxlength", 500);
            });

            var numberInputs = $("input[type='number']");
            numberInputs.each((i, n) => {
                if (!n.hasAttribute("oninput"))
                    $(n).attr("oninput", "if (value.length > 14) value = value.slice(0, 14)");
            });
        }
        
        public static GoBack(): void {
            history.go(-1);
        }
        public static GoBackAndRefresh(): void {
            document.location.href = document.referrer;
        }

        //extract messages from  server message object
        static ExtractMessages(messagedata: any, level?: number): string[] {
            var messageData: string[] = [];
            var data = [];
            if (!Object.isNullOrUndefined(messagedata.statusText)) {
                data = JSON.parse(messagedata.statusText as string);
                for (var i = 0; i < data.length; i++) {
                    var msg = data[i];
                    if (level && msg.Level == level)
                        messageData.push(msg.Message);
                    else
                        messageData.push(msg.Message);
                }
            }
            return messageData;
        }
        static OkBtnHandle(): void {
            document.onkeydown = function (e) {
                var event: any = window.event || e;
                var code = event.keyCode || event.which;
                if (code == 13) {
                    var okEle = $(".ngdialog.ng-scope .btnOK");
                    if (okEle.length > 0) {
                        okEle.trigger("click");
                        return false;
                    }

                }
            }
        }
        
    }
}