namespace Matrix.Enterprise {

    @Serenity.Decorators.registerFormatter()
    export class ItemTypeFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext) {
            
            let allocationMethod = ctx.value as string;
            if (!allocationMethod)
                return "";

            let dic = new ItemTypeOption();
            return dic.Mapping.Item(allocationMethod);
        }
    }
}