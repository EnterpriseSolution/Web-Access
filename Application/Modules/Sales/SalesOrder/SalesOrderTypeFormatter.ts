namespace Matrix.Enterprise {

    @Serenity.Decorators.registerFormatter()
    export class SalesOrderTypeFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext) {
           
            let allocationMethod = ctx.value as string;
            if (!allocationMethod)
                return "";

            let dic = new SalesOrderTypeOption();
            return dic.Mapping.Item(allocationMethod);
        }
    }
}