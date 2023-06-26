namespace Matrix.MasterData {
    export class MachineForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Machine';

    }

    export interface MachineForm {
        MachineNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        TemplateCode: Serenity.StringEditor;
        PictureFile: Serenity.StringEditor;
        Picture: Serenity.StringEditor;
        Remarks: Serenity.StringEditor;
        WorkCentre: Serenity.StringEditor;
    }

    [['MachineNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['TemplateCode', () => Serenity.StringEditor]
   , ['PictureFile', () => Serenity.StringEditor]
   , ['Picture', () => Serenity.StringEditor]
   , ['Remarks', () => Serenity.StringEditor]
   , ['WorkCentre', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(MachineForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

