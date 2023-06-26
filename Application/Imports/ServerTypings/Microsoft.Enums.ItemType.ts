namespace Microsoft.Enums {
    export enum ItemType {
        StandardStockItem = 0,
        StandardAssortment = 1,
        ConfiguredAssortment = 2,
        NonStockItem = 3
    }
    Serenity.Decorators.registerEnum(ItemType, 'Enums.ItemType');
}

