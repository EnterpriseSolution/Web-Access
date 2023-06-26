namespace Matrix.Inventory {
    export class InventoryBalanceForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.InventoryBalance';

    }

    export interface InventoryBalanceForm {
        Loc: Serenity.StringEditor;
        ItemNo: Serenity.StringEditor;
        Loc2: Serenity.StringEditor;
        ItemNo2: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        LastDateIn: Serenity.DateEditor;
        LastDateOut: Serenity.DateEditor;
        WithBalance: Serenity.StringEditor;
        QtyOnHand: Serenity.DecimalEditor;
        QtyWaitlisted: Serenity.DecimalEditor;
        QtyReserved: Serenity.DecimalEditor;
        QtyCommitted: Serenity.DecimalEditor;
        QtyAvailable: Serenity.DecimalEditor;
        QtyUnallocated: Serenity.DecimalEditor;
        InvtCostAvail: Serenity.DecimalEditor;
        InvtCostLdg: Serenity.DecimalEditor;
        AverageCost: Serenity.StringEditor;
        LatestCost: Serenity.DecimalEditor;
        LastCountDate: Serenity.DateEditor;
        DefaultBinNo: Serenity.StringEditor;
        QtyOnInspect: Serenity.DecimalEditor;
        QtyOnTransfer: Serenity.DecimalEditor;
    }

    [['Loc', () => Serenity.StringEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Loc2', () => Serenity.StringEditor]
   , ['ItemNo2', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['LastDateIn', () => Serenity.DateEditor]
   , ['LastDateOut', () => Serenity.DateEditor]
   , ['WithBalance', () => Serenity.StringEditor]
   , ['QtyOnHand', () => Serenity.DecimalEditor]
   , ['QtyWaitlisted', () => Serenity.DecimalEditor]
   , ['QtyReserved', () => Serenity.DecimalEditor]
   , ['QtyCommitted', () => Serenity.DecimalEditor]
   , ['QtyAvailable', () => Serenity.DecimalEditor]
   , ['QtyUnallocated', () => Serenity.DecimalEditor]
   , ['InvtCostAvail', () => Serenity.DecimalEditor]
   , ['InvtCostLdg', () => Serenity.DecimalEditor]
   , ['AverageCost', () => Serenity.StringEditor]
   , ['LatestCost', () => Serenity.DecimalEditor]
   , ['LastCountDate', () => Serenity.DateEditor]
   , ['DefaultBinNo', () => Serenity.StringEditor]
   , ['QtyOnInspect', () => Serenity.DecimalEditor]
   , ['QtyOnTransfer', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(InventoryBalanceForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

