namespace Matrix.MasterData {
    export class LocationForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Location';

    }

    export interface LocationForm {
        Loc: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Address2: Serenity.StringEditor;
        Address3: Serenity.StringEditor;
        Address4: Serenity.StringEditor;
        NoReservation: Serenity.BooleanEditor;
        NoWaitlist: Serenity.BooleanEditor;
        NoAvailable: Serenity.BooleanEditor;
        NoPlanning: Serenity.BooleanEditor;
        NoIssuance: Serenity.BooleanEditor;
        NoReceipts: Serenity.BooleanEditor;
        NoMatIssue: Serenity.BooleanEditor;
        NoFgReturn: Serenity.BooleanEditor;
        NoShipment: Serenity.BooleanEditor;
        NoGrn: Serenity.BooleanEditor;
        OnSorderCount: Serenity.DecimalEditor;
        OnPorderCount: Serenity.DecimalEditor;
        OnJorderCount: Serenity.DecimalEditor;
        WithBinCtrl: Serenity.StringEditor;
        WithPackingBox: Serenity.BooleanEditor;
        WithBacklog: Serenity.StringEditor;
        InvtCostAvail: Serenity.DecimalEditor;
        InvtCostLdg: Serenity.DecimalEditor;
    }

    [['Loc', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.StringEditor]
   , ['Address', () => Serenity.StringEditor]
   , ['Address2', () => Serenity.StringEditor]
   , ['Address3', () => Serenity.StringEditor]
   , ['Address4', () => Serenity.StringEditor]
   , ['NoReservation', () => Serenity.BooleanEditor]
   , ['NoWaitlist', () => Serenity.BooleanEditor]
   , ['NoAvailable', () => Serenity.BooleanEditor]
   , ['NoPlanning', () => Serenity.BooleanEditor]
   , ['NoIssuance', () => Serenity.BooleanEditor]
   , ['NoReceipts', () => Serenity.BooleanEditor]
   , ['NoMatIssue', () => Serenity.BooleanEditor]
   , ['NoFgReturn', () => Serenity.BooleanEditor]
   , ['NoShipment', () => Serenity.BooleanEditor]
   , ['NoGrn', () => Serenity.BooleanEditor]
   , ['OnSorderCount', () => Serenity.DecimalEditor]
   , ['OnPorderCount', () => Serenity.DecimalEditor]
   , ['OnJorderCount', () => Serenity.DecimalEditor]
   , ['WithBinCtrl', () => Serenity.StringEditor]
   , ['WithPackingBox', () => Serenity.BooleanEditor]
   , ['WithBacklog', () => Serenity.StringEditor]
   , ['InvtCostAvail', () => Serenity.DecimalEditor]
   , ['InvtCostLdg', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(LocationForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

