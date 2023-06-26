namespace Matrix {
    export enum AllocationMethod {
        ActualCost = 65,
        FifoAllocation = 70,
        LifoAllocation = 76,
        NoAllocation = 78
    }

    export class AllocationMethodOption  {
        Mapping: KeyedCollection<string>;
        constructor() {
        this.Mapping =new KeyedCollection<string>();
        this.Mapping.Add("A", "Actual Cost");   //65,
        this.Mapping.Add("F", "First-In-First-Out");   //70,
        this.Mapping.Add("L", "Last-In-First-Out");   //76,
        this.Mapping.Add("N", "No Allocation");   //78
        }
    }

    Serenity.Decorators.registerEnum(AllocationMethod, 'Enums.AllocationMethod');
}

