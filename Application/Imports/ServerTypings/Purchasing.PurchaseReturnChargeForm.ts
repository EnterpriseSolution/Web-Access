namespace Matrix.Purchasing {
    export class PurchaseReturnChargeForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.PurchaseReturnCharge';

    }

    export interface PurchaseReturnChargeForm {
        RefNo: Serenity.StringEditor;
        EntryNo: Serenity.DecimalEditor;
        OrderNo: Serenity.StringEditor;
        SeqNo: Serenity.DecimalEditor;
        ChargeType: Serenity.StringEditor;
        Particulars: Serenity.StringEditor;
        BalAmt: Serenity.DecimalEditor;
        ReturnAmt: Serenity.DecimalEditor;
        LocReturnAmt: Serenity.DecimalEditor;
        AcctPurchase: Serenity.StringEditor;
        Deduction: Serenity.StringEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        Anlys7: Serenity.StringEditor;
        Anlys8: Serenity.StringEditor;
        Anlys9: Serenity.StringEditor;
        Anlys10: Serenity.StringEditor;
        Anlys11: Serenity.StringEditor;
        Anlys12: Serenity.StringEditor;
        Anlys13: Serenity.StringEditor;
        Anlys14: Serenity.StringEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['EntryNo', () => Serenity.DecimalEditor]
   , ['OrderNo', () => Serenity.StringEditor]
   , ['SeqNo', () => Serenity.DecimalEditor]
   , ['ChargeType', () => Serenity.StringEditor]
   , ['Particulars', () => Serenity.StringEditor]
   , ['BalAmt', () => Serenity.DecimalEditor]
   , ['ReturnAmt', () => Serenity.DecimalEditor]
   , ['LocReturnAmt', () => Serenity.DecimalEditor]
   , ['AcctPurchase', () => Serenity.StringEditor]
   , ['Deduction', () => Serenity.StringEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['Anlys7', () => Serenity.StringEditor]
   , ['Anlys8', () => Serenity.StringEditor]
   , ['Anlys9', () => Serenity.StringEditor]
   , ['Anlys10', () => Serenity.StringEditor]
   , ['Anlys11', () => Serenity.StringEditor]
   , ['Anlys12', () => Serenity.StringEditor]
   , ['Anlys13', () => Serenity.StringEditor]
   , ['Anlys14', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(PurchaseReturnChargeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

