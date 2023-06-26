namespace Matrix {
    export enum SalesOrderType {
        Sample = 65,
        Blanket = 66,
        Release = 82,
        Standard = 83
    }

    export class SalesOrderTypeOption  {
        Mapping: KeyedCollection<string>;
        constructor() {
        this.Mapping =new KeyedCollection<string>();
        this.Mapping.Add("A", "Sample");   //65,
        this.Mapping.Add("B", "Blanket");   //66,
        this.Mapping.Add("R", "Release");   //82,
        this.Mapping.Add("S", "Standard");   //83
        }
    }

    Serenity.Decorators.registerEnum(SalesOrderType, 'Enums.SalesOrderType');
}

