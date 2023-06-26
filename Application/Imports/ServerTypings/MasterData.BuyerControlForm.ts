namespace Matrix.MasterData {
    export class BuyerControlForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.BuyerControl';

    }

    export interface BuyerControlForm {
        BuyerCode: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        TypeGroup: Serenity.StringEditor;
        TypeItem: Serenity.StringEditor;
        EntryCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.StringEditor;
        MaxQty: Serenity.DecimalEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
    }

    [['BuyerCode', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['TypeGroup', () => Serenity.StringEditor]
   , ['TypeItem', () => Serenity.StringEditor]
   , ['EntryCode', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.StringEditor]
   , ['MaxQty', () => Serenity.DecimalEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(BuyerControlForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

