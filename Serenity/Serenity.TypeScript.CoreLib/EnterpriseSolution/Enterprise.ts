namespace Enterprise {

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

    export class String {
        public static isNullOrEmpty(value: string | any): boolean {
            if (value === undefined || value == null || value === '')
                return true;
            return false;
        }
        //public static toDate(value: string | any, formats?: any): Date {
        //    if (Object.isNullOrUndefined(formats)) {
        //        formats = DateTimeFormat.DateTimeSecond;
        //    }
        //    return kendo.parseDate(value, formats, Setting['lang']);
        //}

        //public static translate(code: string): any {

        //    var gettextCatalog = Setting['gettext'] as angular.gettext.gettextCatalog;
        //    return gettextCatalog.getString(code);
        //}

        //public static format(code: string, formatdata: any): string {

        //    var gettextCatalog = Setting['gettext'] as angular.gettext.gettextCatalog;

        //    var txt = gettextCatalog.getString(code);
        //    var j: number = 0;

        //    $.each(formatdata, (i, n) => {
        //        var langStr = "{" + j + "}";
        //        txt = txt.replace(langStr, "{{" + i + "}}");
        //        j++;
        //    });
        //    return gettextCatalog.getString(txt, formatdata);
        //}
    }
}