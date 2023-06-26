namespace Matrix.Enterprise {

    @Serenity.Decorators.registerFormatter()
    export class AllocationMethodFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext) {
           
            let allocationMethod = ctx.value as string;
            if (!allocationMethod)
                return "";

            let dic = new AllocationMethodOption();
            return dic.Mapping.Item(allocationMethod);
        }
    }
}