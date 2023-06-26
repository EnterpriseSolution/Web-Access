namespace Matrix.Purchasing {
    export class PurchaseOrderDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.PurchaseOrderDetail';

    }

    export interface PurchaseOrderDetailForm {
        OrderNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        Posted: Serenity.StringEditor;
        Closed: Serenity.StringEditor;
        ItemNo: Serenity.StringEditor;
        VendorItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        LotSize: Serenity.DecimalEditor;
        Qty: Serenity.DecimalEditor;
        Price: Serenity.DecimalEditor;
        Ptax: Serenity.DecimalEditor;
        NetPrice: Serenity.DecimalEditor;
        ExtPrice: Serenity.DecimalEditor;
        LdiscPcent: Serenity.DecimalEditor;
        LdiscAmt: Serenity.DecimalEditor;
        AtaxAmt: Serenity.DecimalEditor;
        NetItemAmt: Serenity.DecimalEditor;
        PriceAmt: Serenity.DecimalEditor;
        PtaxAmt: Serenity.DecimalEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        Anlys3: Serenity.StringEditor;
        Anlys4: Serenity.StringEditor;
        Anlys5: Serenity.StringEditor;
        Anlys6: Serenity.StringEditor;
        FirstShipQty: Serenity.DecimalEditor;
        OtherShipQty: Serenity.DecimalEditor;
        LastShipNo: Serenity.DecimalEditor;
        WeightUom: Serenity.StringEditor;
        GrossWt: Serenity.DecimalEditor;
        NetWt: Serenity.DecimalEditor;
        DimensionUom: Serenity.StringEditor;
        Flength: Serenity.DecimalEditor;
        Width: Serenity.DecimalEditor;
        Height: Serenity.DecimalEditor;
        Volume: Serenity.DecimalEditor;
        PriceCpd: Serenity.DecimalEditor;
        PtaxCpd: Serenity.DecimalEditor;
        AtaxCpd: Serenity.DecimalEditor;
        DiscCpd: Serenity.DecimalEditor;
        GrossWtCpd: Serenity.DecimalEditor;
        NetWtCpd: Serenity.DecimalEditor;
        VolumeCpd: Serenity.DecimalEditor;
        InnerPkgType: Serenity.StringEditor;
        InnerQty: Serenity.DecimalEditor;
        InnerPkgs: Serenity.DecimalEditor;
        InnerExcsQty: Serenity.DecimalEditor;
        OuterPkgType: Serenity.StringEditor;
        OuterQty: Serenity.DecimalEditor;
        OuterPkgs: Serenity.DecimalEditor;
        OuterExcsQty: Serenity.DecimalEditor;
        QtyReceived: Serenity.DecimalEditor;
        SchedCount: Serenity.DecimalEditor;
        ExtDescription: Serenity.StringEditor;
        QtyPending: Serenity.DecimalEditor;
        JobNo: Serenity.StringEditor;
        OriginQty: Serenity.DecimalEditor;
        PutaxPcent: Serenity.DecimalEditor;
        PutaxAmt: Serenity.DecimalEditor;
        TotAllocatedQty: Serenity.DecimalEditor;
        IweightUom: Serenity.StringEditor;
        IgrossWt: Serenity.DecimalEditor;
        InetWt: Serenity.DecimalEditor;
        Ivolume: Serenity.DecimalEditor;
        TotGrossWt: Serenity.DecimalEditor;
        TotNetWt: Serenity.DecimalEditor;
        Dimension: Serenity.StringEditor;
        ReorderQty: Serenity.DecimalEditor;
        Remark: Serenity.StringEditor;
        SubconJob: Serenity.StringEditor;
        Anlys15: Serenity.StringEditor;
        Anlys16: Serenity.StringEditor;
        Anlys17: Serenity.StringEditor;
        Anlys18: Serenity.StringEditor;
        Anlys19: Serenity.StringEditor;
        Anlys20: Serenity.StringEditor;
        MrpRequiredQty: Serenity.DecimalEditor;
        OverReceiptPcent: Serenity.DecimalEditor;
        ZeroPrice: Serenity.BooleanEditor;
    }

    [['OrderNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['Closed', () => Serenity.StringEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['VendorItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['LotSize', () => Serenity.DecimalEditor]
   , ['Qty', () => Serenity.DecimalEditor]
   , ['Price', () => Serenity.DecimalEditor]
   , ['Ptax', () => Serenity.DecimalEditor]
   , ['NetPrice', () => Serenity.DecimalEditor]
   , ['ExtPrice', () => Serenity.DecimalEditor]
   , ['LdiscPcent', () => Serenity.DecimalEditor]
   , ['LdiscAmt', () => Serenity.DecimalEditor]
   , ['AtaxAmt', () => Serenity.DecimalEditor]
   , ['NetItemAmt', () => Serenity.DecimalEditor]
   , ['PriceAmt', () => Serenity.DecimalEditor]
   , ['PtaxAmt', () => Serenity.DecimalEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['Anlys3', () => Serenity.StringEditor]
   , ['Anlys4', () => Serenity.StringEditor]
   , ['Anlys5', () => Serenity.StringEditor]
   , ['Anlys6', () => Serenity.StringEditor]
   , ['FirstShipQty', () => Serenity.DecimalEditor]
   , ['OtherShipQty', () => Serenity.DecimalEditor]
   , ['LastShipNo', () => Serenity.DecimalEditor]
   , ['WeightUom', () => Serenity.StringEditor]
   , ['GrossWt', () => Serenity.DecimalEditor]
   , ['NetWt', () => Serenity.DecimalEditor]
   , ['DimensionUom', () => Serenity.StringEditor]
   , ['Flength', () => Serenity.DecimalEditor]
   , ['Width', () => Serenity.DecimalEditor]
   , ['Height', () => Serenity.DecimalEditor]
   , ['Volume', () => Serenity.DecimalEditor]
   , ['PriceCpd', () => Serenity.DecimalEditor]
   , ['PtaxCpd', () => Serenity.DecimalEditor]
   , ['AtaxCpd', () => Serenity.DecimalEditor]
   , ['DiscCpd', () => Serenity.DecimalEditor]
   , ['GrossWtCpd', () => Serenity.DecimalEditor]
   , ['NetWtCpd', () => Serenity.DecimalEditor]
   , ['VolumeCpd', () => Serenity.DecimalEditor]
   , ['InnerPkgType', () => Serenity.StringEditor]
   , ['InnerQty', () => Serenity.DecimalEditor]
   , ['InnerPkgs', () => Serenity.DecimalEditor]
   , ['InnerExcsQty', () => Serenity.DecimalEditor]
   , ['OuterPkgType', () => Serenity.StringEditor]
   , ['OuterQty', () => Serenity.DecimalEditor]
   , ['OuterPkgs', () => Serenity.DecimalEditor]
   , ['OuterExcsQty', () => Serenity.DecimalEditor]
   , ['QtyReceived', () => Serenity.DecimalEditor]
   , ['SchedCount', () => Serenity.DecimalEditor]
   , ['ExtDescription', () => Serenity.StringEditor]
   , ['QtyPending', () => Serenity.DecimalEditor]
   , ['JobNo', () => Serenity.StringEditor]
   , ['OriginQty', () => Serenity.DecimalEditor]
   , ['PutaxPcent', () => Serenity.DecimalEditor]
   , ['PutaxAmt', () => Serenity.DecimalEditor]
   , ['TotAllocatedQty', () => Serenity.DecimalEditor]
   , ['IweightUom', () => Serenity.StringEditor]
   , ['IgrossWt', () => Serenity.DecimalEditor]
   , ['InetWt', () => Serenity.DecimalEditor]
   , ['Ivolume', () => Serenity.DecimalEditor]
   , ['TotGrossWt', () => Serenity.DecimalEditor]
   , ['TotNetWt', () => Serenity.DecimalEditor]
   , ['Dimension', () => Serenity.StringEditor]
   , ['ReorderQty', () => Serenity.DecimalEditor]
   , ['Remark', () => Serenity.StringEditor]
   , ['SubconJob', () => Serenity.StringEditor]
   , ['Anlys15', () => Serenity.StringEditor]
   , ['Anlys16', () => Serenity.StringEditor]
   , ['Anlys17', () => Serenity.StringEditor]
   , ['Anlys18', () => Serenity.StringEditor]
   , ['Anlys19', () => Serenity.StringEditor]
   , ['Anlys20', () => Serenity.StringEditor]
   , ['MrpRequiredQty', () => Serenity.DecimalEditor]
   , ['OverReceiptPcent', () => Serenity.DecimalEditor]
   , ['ZeroPrice', () => Serenity.BooleanEditor]
].forEach(x => Object.defineProperty(PurchaseOrderDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

