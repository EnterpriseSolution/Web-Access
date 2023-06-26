namespace Matrix.Inventory {
    export class InventoryMovementDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.InventoryMovementDetail';

    }

    export interface InventoryMovementDetailForm {
        RefNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        ItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        LotSize: Serenity.DecimalEditor;
        LineRef: Serenity.StringEditor;
        Qty: Serenity.DecimalEditor;
        UnitCost: Serenity.DecimalEditor;
        TotalCost: Serenity.DecimalEditor;
        QtyPerRec: Serenity.DecimalEditor;
        QtyPerCount: Serenity.DecimalEditor;
        BinQtyIn: Serenity.DecimalEditor;
        BinQtyOut: Serenity.DecimalEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        Anlys3: Serenity.StringEditor;
        Anlys4: Serenity.StringEditor;
        Anlys5: Serenity.StringEditor;
        Anlys6: Serenity.StringEditor;
        BaseQty: Serenity.DecimalEditor;
        BaseUnitCost: Serenity.DecimalEditor;
        QtyCommitted: Serenity.DecimalEditor;
        QtyRequired: Serenity.DecimalEditor;
        QtyIssued: Serenity.DecimalEditor;
        QtyBalance: Serenity.DecimalEditor;
        QtyPer: Serenity.DecimalEditor;
        Final: Serenity.StringEditor;
        DebitAcct: Serenity.StringEditor;
        CreditAcct: Serenity.StringEditor;
        AllocMethod: Serenity.StringEditor;
        SourceType: Serenity.StringEditor;
        SourceRefNo: Serenity.StringEditor;
        SourceEntryNo: Serenity.DecimalEditor;
        SourcePartNo: Serenity.DecimalEditor;
        Particulars: Serenity.StringEditor;
        RevisedCost: Serenity.DecimalEditor;
        CostDiff: Serenity.DecimalEditor;
        FlowType: Serenity.StringEditor;
        LocFrom: Serenity.StringEditor;
        LocTo: Serenity.StringEditor;
        TempStubNo: Serenity.StringEditor;
        TempLoc: Serenity.StringEditor;
        TempReserved: Serenity.DecimalEditor;
        TempDateNeeded: Serenity.DateEditor;
        TempRemarks: Serenity.StringEditor;
        Anlys15: Serenity.StringEditor;
        Anlys16: Serenity.StringEditor;
        Anlys17: Serenity.StringEditor;
        Anlys18: Serenity.StringEditor;
        Anlys19: Serenity.StringEditor;
        Anlys20: Serenity.StringEditor;
        AllocatedQty: Serenity.DecimalEditor;
        AllocatedCost: Serenity.DecimalEditor;
        QtyPick: Serenity.DecimalEditor;
        Weight: Serenity.DecimalEditor;
        TotalWeight: Serenity.DecimalEditor;
        QtyFollowList: Serenity.DecimalEditor;
        QuotationScrapQty: Serenity.DecimalEditor;
        QuotationScrapRate: Serenity.DecimalEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['LotSize', () => Serenity.DecimalEditor]
   , ['LineRef', () => Serenity.StringEditor]
   , ['Qty', () => Serenity.DecimalEditor]
   , ['UnitCost', () => Serenity.DecimalEditor]
   , ['TotalCost', () => Serenity.DecimalEditor]
   , ['QtyPerRec', () => Serenity.DecimalEditor]
   , ['QtyPerCount', () => Serenity.DecimalEditor]
   , ['BinQtyIn', () => Serenity.DecimalEditor]
   , ['BinQtyOut', () => Serenity.DecimalEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['Anlys3', () => Serenity.StringEditor]
   , ['Anlys4', () => Serenity.StringEditor]
   , ['Anlys5', () => Serenity.StringEditor]
   , ['Anlys6', () => Serenity.StringEditor]
   , ['BaseQty', () => Serenity.DecimalEditor]
   , ['BaseUnitCost', () => Serenity.DecimalEditor]
   , ['QtyCommitted', () => Serenity.DecimalEditor]
   , ['QtyRequired', () => Serenity.DecimalEditor]
   , ['QtyIssued', () => Serenity.DecimalEditor]
   , ['QtyBalance', () => Serenity.DecimalEditor]
   , ['QtyPer', () => Serenity.DecimalEditor]
   , ['Final', () => Serenity.StringEditor]
   , ['DebitAcct', () => Serenity.StringEditor]
   , ['CreditAcct', () => Serenity.StringEditor]
   , ['AllocMethod', () => Serenity.StringEditor]
   , ['SourceType', () => Serenity.StringEditor]
   , ['SourceRefNo', () => Serenity.StringEditor]
   , ['SourceEntryNo', () => Serenity.DecimalEditor]
   , ['SourcePartNo', () => Serenity.DecimalEditor]
   , ['Particulars', () => Serenity.StringEditor]
   , ['RevisedCost', () => Serenity.DecimalEditor]
   , ['CostDiff', () => Serenity.DecimalEditor]
   , ['FlowType', () => Serenity.StringEditor]
   , ['LocFrom', () => Serenity.StringEditor]
   , ['LocTo', () => Serenity.StringEditor]
   , ['TempStubNo', () => Serenity.StringEditor]
   , ['TempLoc', () => Serenity.StringEditor]
   , ['TempReserved', () => Serenity.DecimalEditor]
   , ['TempDateNeeded', () => Serenity.DateEditor]
   , ['TempRemarks', () => Serenity.StringEditor]
   , ['Anlys15', () => Serenity.StringEditor]
   , ['Anlys16', () => Serenity.StringEditor]
   , ['Anlys17', () => Serenity.StringEditor]
   , ['Anlys18', () => Serenity.StringEditor]
   , ['Anlys19', () => Serenity.StringEditor]
   , ['Anlys20', () => Serenity.StringEditor]
   , ['AllocatedQty', () => Serenity.DecimalEditor]
   , ['AllocatedCost', () => Serenity.DecimalEditor]
   , ['QtyPick', () => Serenity.DecimalEditor]
   , ['Weight', () => Serenity.DecimalEditor]
   , ['TotalWeight', () => Serenity.DecimalEditor]
   , ['QtyFollowList', () => Serenity.DecimalEditor]
   , ['QuotationScrapQty', () => Serenity.DecimalEditor]
   , ['QuotationScrapRate', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(InventoryMovementDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

