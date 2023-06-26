namespace Matrix.Production {
    export class JobOrderMaterialForm extends Serenity.PrefixedContext {
        static formKey = 'Production.JobOrderMaterial';

    }

    export interface JobOrderMaterialForm {
        JobNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        PartItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        QtyPer: Serenity.DecimalEditor;
        QtyRequired: Serenity.DecimalEditor;
        QtyReserved: Serenity.DecimalEditor;
        QtyWaitlisted: Serenity.DecimalEditor;
        QtyPurchase: Serenity.DecimalEditor;
        QtyProduce: Serenity.DecimalEditor;
        SubJobNo: Serenity.StringEditor;
        VendorNo: Serenity.StringEditor;
        OrderNo: Serenity.StringEditor;
        OrderDate: Serenity.DateEditor;
        PurchaseUom: Serenity.StringEditor;
        LotSize: Serenity.DecimalEditor;
        PriceCcy: Serenity.StringEditor;
        ExpectedPrice: Serenity.DecimalEditor;
        DueDate: Serenity.DateEditor;
        SchedDate: Serenity.DateEditor;
        InvCost: Serenity.DecimalEditor;
        StdCost: Serenity.DecimalEditor;
        LatCost: Serenity.DecimalEditor;
        UnitCost: Serenity.DecimalEditor;
        CostMaterial: Serenity.DecimalEditor;
        SubDueDate: Serenity.DateEditor;
        SubStartDate: Serenity.DateEditor;
        SubBomNo: Serenity.StringEditor;
        Specifications: Serenity.StringEditor;
        QtyNeeded: Serenity.DecimalEditor;
        ScrapRate: Serenity.DecimalEditor;
        ScrapQty: Serenity.DecimalEditor;
        QtyAdjusted: Serenity.DecimalEditor;
        SubQty: Serenity.DecimalEditor;
        IsAlternate: Serenity.StringEditor;
        MainLineNo: Serenity.DecimalEditor;
        UsageRate: Serenity.DecimalEditor;
        Loc: Serenity.StringEditor;
        Eod: Serenity.DateEditor;
        Edd: Serenity.DateEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        SubBlowThru: Serenity.StringEditor;
        BinQtyOut: Serenity.DecimalEditor;
        BuyMake: Serenity.StringEditor;
        IncludeScrapRate: Serenity.StringEditor;
        PoNo: Serenity.StringEditor;
        SubWcBackflush: Serenity.StringEditor;
        RunnerWaste: Serenity.StringEditor;
        ReuseRate: Serenity.DecimalEditor;
        RunnerWasteRate: Serenity.DecimalEditor;
        Anlys15: Serenity.StringEditor;
        Anlys16: Serenity.StringEditor;
        Anlys17: Serenity.StringEditor;
        SubFormulaCode: Serenity.StringEditor;
        IncludeJob: Serenity.BooleanEditor;
        QuotationScrapQty: Serenity.DecimalEditor;
        QuotationScrapRate: Serenity.DecimalEditor;
        CustomerProvided: Serenity.BooleanEditor;
        OriginalItemNo: Serenity.StringEditor;
    }

    [['JobNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['PartItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['QtyPer', () => Serenity.DecimalEditor]
   , ['QtyRequired', () => Serenity.DecimalEditor]
   , ['QtyReserved', () => Serenity.DecimalEditor]
   , ['QtyWaitlisted', () => Serenity.DecimalEditor]
   , ['QtyPurchase', () => Serenity.DecimalEditor]
   , ['QtyProduce', () => Serenity.DecimalEditor]
   , ['SubJobNo', () => Serenity.StringEditor]
   , ['VendorNo', () => Serenity.StringEditor]
   , ['OrderNo', () => Serenity.StringEditor]
   , ['OrderDate', () => Serenity.DateEditor]
   , ['PurchaseUom', () => Serenity.StringEditor]
   , ['LotSize', () => Serenity.DecimalEditor]
   , ['PriceCcy', () => Serenity.StringEditor]
   , ['ExpectedPrice', () => Serenity.DecimalEditor]
   , ['DueDate', () => Serenity.DateEditor]
   , ['SchedDate', () => Serenity.DateEditor]
   , ['InvCost', () => Serenity.DecimalEditor]
   , ['StdCost', () => Serenity.DecimalEditor]
   , ['LatCost', () => Serenity.DecimalEditor]
   , ['UnitCost', () => Serenity.DecimalEditor]
   , ['CostMaterial', () => Serenity.DecimalEditor]
   , ['SubDueDate', () => Serenity.DateEditor]
   , ['SubStartDate', () => Serenity.DateEditor]
   , ['SubBomNo', () => Serenity.StringEditor]
   , ['Specifications', () => Serenity.StringEditor]
   , ['QtyNeeded', () => Serenity.DecimalEditor]
   , ['ScrapRate', () => Serenity.DecimalEditor]
   , ['ScrapQty', () => Serenity.DecimalEditor]
   , ['QtyAdjusted', () => Serenity.DecimalEditor]
   , ['SubQty', () => Serenity.DecimalEditor]
   , ['IsAlternate', () => Serenity.StringEditor]
   , ['MainLineNo', () => Serenity.DecimalEditor]
   , ['UsageRate', () => Serenity.DecimalEditor]
   , ['Loc', () => Serenity.StringEditor]
   , ['Eod', () => Serenity.DateEditor]
   , ['Edd', () => Serenity.DateEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['SubBlowThru', () => Serenity.StringEditor]
   , ['BinQtyOut', () => Serenity.DecimalEditor]
   , ['BuyMake', () => Serenity.StringEditor]
   , ['IncludeScrapRate', () => Serenity.StringEditor]
   , ['PoNo', () => Serenity.StringEditor]
   , ['SubWcBackflush', () => Serenity.StringEditor]
   , ['RunnerWaste', () => Serenity.StringEditor]
   , ['ReuseRate', () => Serenity.DecimalEditor]
   , ['RunnerWasteRate', () => Serenity.DecimalEditor]
   , ['Anlys15', () => Serenity.StringEditor]
   , ['Anlys16', () => Serenity.StringEditor]
   , ['Anlys17', () => Serenity.StringEditor]
   , ['SubFormulaCode', () => Serenity.StringEditor]
   , ['IncludeJob', () => Serenity.BooleanEditor]
   , ['QuotationScrapQty', () => Serenity.DecimalEditor]
   , ['QuotationScrapRate', () => Serenity.DecimalEditor]
   , ['CustomerProvided', () => Serenity.BooleanEditor]
   , ['OriginalItemNo', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(JobOrderMaterialForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

