namespace Matrix.Production {
    export class BomMaterialForm extends Serenity.PrefixedContext {
        static formKey = 'Production.BomMaterial';

    }

    export interface BomMaterialForm {
        BomNo: Serenity.StringEditor;
        SeqNo: Serenity.DecimalEditor;
        PartItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        QtyPer: Serenity.DecimalEditor;
        WithAltern: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        EntrySeqNo: Serenity.DecimalEditor;
        AssmItemNo: Serenity.StringEditor;
        ScrapRate: Serenity.DecimalEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
        LocCount: Serenity.DecimalEditor;
        BlowThruBomNo: Serenity.StringEditor;
        Remarks: Serenity.StringEditor;
        LastAltSeqNo: Serenity.DecimalEditor;
        LastEcnNo: Serenity.StringEditor;
        RunnerWaste: Serenity.StringEditor;
        RunnerWasteRate: Serenity.DecimalEditor;
        UserDefinedField1: Serenity.StringEditor;
        UserDefinedField2: Serenity.StringEditor;
        UserDefinedField3: Serenity.StringEditor;
        UserDefinedField4: Serenity.StringEditor;
        UserDefinedField5: Serenity.StringEditor;
        UserDefinedField6: Serenity.StringEditor;
        UserDefinedField7: Serenity.StringEditor;
        UserDefinedField8: Serenity.StringEditor;
        UserDefinedField9: Serenity.StringEditor;
        UserDefinedField10: Serenity.StringEditor;
        UserDefinedField11: Serenity.StringEditor;
        UserDefinedField12: Serenity.StringEditor;
        UserDefinedField13: Serenity.StringEditor;
        UserDefinedField14: Serenity.StringEditor;
        UserDefinedField15: Serenity.StringEditor;
        UserDefinedField16: Serenity.StringEditor;
        UserDefinedField17: Serenity.StringEditor;
        UserDefinedField18: Serenity.StringEditor;
        UserDefinedField19: Serenity.StringEditor;
        UserDefinedField20: Serenity.StringEditor;
        RohsCompliance: Serenity.BooleanEditor;
        Approved: Serenity.BooleanEditor;
        Uom2: Serenity.StringEditor;
        QtyPer2: Serenity.DecimalEditor;
        WorkCentre: Serenity.StringEditor;
        QuotationScrapQty: Serenity.DecimalEditor;
        QuotationScrapRate: Serenity.DecimalEditor;
        QuotationQty: Serenity.DecimalEditor;
        ShowCost: Serenity.BooleanEditor;
        QtyBeforeConversion: Serenity.DecimalEditor;
    }

    [['BomNo', () => Serenity.StringEditor]
   , ['SeqNo', () => Serenity.DecimalEditor]
   , ['PartItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['QtyPer', () => Serenity.DecimalEditor]
   , ['WithAltern', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['EntrySeqNo', () => Serenity.DecimalEditor]
   , ['AssmItemNo', () => Serenity.StringEditor]
   , ['ScrapRate', () => Serenity.DecimalEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
   , ['LocCount', () => Serenity.DecimalEditor]
   , ['BlowThruBomNo', () => Serenity.StringEditor]
   , ['Remarks', () => Serenity.StringEditor]
   , ['LastAltSeqNo', () => Serenity.DecimalEditor]
   , ['LastEcnNo', () => Serenity.StringEditor]
   , ['RunnerWaste', () => Serenity.StringEditor]
   , ['RunnerWasteRate', () => Serenity.DecimalEditor]
   , ['UserDefinedField1', () => Serenity.StringEditor]
   , ['UserDefinedField2', () => Serenity.StringEditor]
   , ['UserDefinedField3', () => Serenity.StringEditor]
   , ['UserDefinedField4', () => Serenity.StringEditor]
   , ['UserDefinedField5', () => Serenity.StringEditor]
   , ['UserDefinedField6', () => Serenity.StringEditor]
   , ['UserDefinedField7', () => Serenity.StringEditor]
   , ['UserDefinedField8', () => Serenity.StringEditor]
   , ['UserDefinedField9', () => Serenity.StringEditor]
   , ['UserDefinedField10', () => Serenity.StringEditor]
   , ['UserDefinedField11', () => Serenity.StringEditor]
   , ['UserDefinedField12', () => Serenity.StringEditor]
   , ['UserDefinedField13', () => Serenity.StringEditor]
   , ['UserDefinedField14', () => Serenity.StringEditor]
   , ['UserDefinedField15', () => Serenity.StringEditor]
   , ['UserDefinedField16', () => Serenity.StringEditor]
   , ['UserDefinedField17', () => Serenity.StringEditor]
   , ['UserDefinedField18', () => Serenity.StringEditor]
   , ['UserDefinedField19', () => Serenity.StringEditor]
   , ['UserDefinedField20', () => Serenity.StringEditor]
   , ['RohsCompliance', () => Serenity.BooleanEditor]
   , ['Approved', () => Serenity.BooleanEditor]
   , ['Uom2', () => Serenity.StringEditor]
   , ['QtyPer2', () => Serenity.DecimalEditor]
   , ['WorkCentre', () => Serenity.StringEditor]
   , ['QuotationScrapQty', () => Serenity.DecimalEditor]
   , ['QuotationScrapRate', () => Serenity.DecimalEditor]
   , ['QuotationQty', () => Serenity.DecimalEditor]
   , ['ShowCost', () => Serenity.BooleanEditor]
   , ['QtyBeforeConversion', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(BomMaterialForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

