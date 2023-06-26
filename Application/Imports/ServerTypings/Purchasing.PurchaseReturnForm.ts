namespace Matrix.Purchasing {
    export class PurchaseReturnForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.PurchaseReturn';

    }

    export interface PurchaseReturnForm {
        RefNo: Serenity.StringEditor;
        EntryMethod: Serenity.StringEditor;
        Posted: Serenity.StringEditor;
        TranDate: Serenity.DateEditor;
        GrnNo: Serenity.StringEditor;
        VendorNo: Serenity.StringEditor;
        VendorName: Serenity.StringEditor;
        DoNo: Serenity.StringEditor;
        InvoiceNo: Serenity.StringEditor;
        HoldItems: Serenity.StringEditor;
        Loc: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        TotPriceAmt: Serenity.DecimalEditor;
        TotPtaxAmt: Serenity.DecimalEditor;
        TotExtPrice: Serenity.DecimalEditor;
        TotLdiscAmt: Serenity.DecimalEditor;
        TotAtaxAmt: Serenity.DecimalEditor;
        TotItemAmt: Serenity.DecimalEditor;
        TotRefundAmt: Serenity.DecimalEditor;
        TotVariaAmt: Serenity.DecimalEditor;
        TdiscPcent: Serenity.DecimalEditor;
        TotTdiscAmt: Serenity.DecimalEditor;
        NetTradeAmt: Serenity.DecimalEditor;
        TotChgsAmt: Serenity.DecimalEditor;
        NetOrdrAmt: Serenity.DecimalEditor;
        TotGtaxAmt: Serenity.DecimalEditor;
        NetPayAmt: Serenity.DecimalEditor;
        TotTdiscCpd: Serenity.DecimalEditor;
        LocPriceAmt: Serenity.DecimalEditor;
        LocPtaxAmt: Serenity.DecimalEditor;
        LocExtPrice: Serenity.DecimalEditor;
        LocLdiscAmt: Serenity.DecimalEditor;
        LocAtaxAmt: Serenity.DecimalEditor;
        LocItemAmt: Serenity.DecimalEditor;
        LocRefundAmt: Serenity.DecimalEditor;
        LocVariaAmt: Serenity.DecimalEditor;
        LocTdiscAmt: Serenity.DecimalEditor;
        LocChgsAmt: Serenity.DecimalEditor;
        LocGtaxAmt: Serenity.DecimalEditor;
        LocPayAmt: Serenity.DecimalEditor;
        AcctVendor: Serenity.StringEditor;
        AcctTdisc: Serenity.StringEditor;
        AcctGtax: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        PostedDate: Serenity.DateEditor;
        PostedBy: Serenity.StringEditor;
        LogNo: Serenity.DecimalEditor;
        LastLogNo: Serenity.DecimalEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
        SettleAt: Serenity.StringEditor;
        Reason: Serenity.StringEditor;
        Anlys9: Serenity.StringEditor;
        Anlys10: Serenity.StringEditor;
        Anlys11: Serenity.StringEditor;
        Anlys12: Serenity.StringEditor;
        Anlys13: Serenity.StringEditor;
        Anlys14: Serenity.StringEditor;
        Anlys15: Serenity.StringEditor;
        Anlys16: Serenity.StringEditor;
        Anlys17: Serenity.StringEditor;
        Anlys18: Serenity.StringEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['EntryMethod', () => Serenity.StringEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['TranDate', () => Serenity.DateEditor]
   , ['GrnNo', () => Serenity.StringEditor]
   , ['VendorNo', () => Serenity.StringEditor]
   , ['VendorName', () => Serenity.StringEditor]
   , ['DoNo', () => Serenity.StringEditor]
   , ['InvoiceNo', () => Serenity.StringEditor]
   , ['HoldItems', () => Serenity.StringEditor]
   , ['Loc', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['TotPriceAmt', () => Serenity.DecimalEditor]
   , ['TotPtaxAmt', () => Serenity.DecimalEditor]
   , ['TotExtPrice', () => Serenity.DecimalEditor]
   , ['TotLdiscAmt', () => Serenity.DecimalEditor]
   , ['TotAtaxAmt', () => Serenity.DecimalEditor]
   , ['TotItemAmt', () => Serenity.DecimalEditor]
   , ['TotRefundAmt', () => Serenity.DecimalEditor]
   , ['TotVariaAmt', () => Serenity.DecimalEditor]
   , ['TdiscPcent', () => Serenity.DecimalEditor]
   , ['TotTdiscAmt', () => Serenity.DecimalEditor]
   , ['NetTradeAmt', () => Serenity.DecimalEditor]
   , ['TotChgsAmt', () => Serenity.DecimalEditor]
   , ['NetOrdrAmt', () => Serenity.DecimalEditor]
   , ['TotGtaxAmt', () => Serenity.DecimalEditor]
   , ['NetPayAmt', () => Serenity.DecimalEditor]
   , ['TotTdiscCpd', () => Serenity.DecimalEditor]
   , ['LocPriceAmt', () => Serenity.DecimalEditor]
   , ['LocPtaxAmt', () => Serenity.DecimalEditor]
   , ['LocExtPrice', () => Serenity.DecimalEditor]
   , ['LocLdiscAmt', () => Serenity.DecimalEditor]
   , ['LocAtaxAmt', () => Serenity.DecimalEditor]
   , ['LocItemAmt', () => Serenity.DecimalEditor]
   , ['LocRefundAmt', () => Serenity.DecimalEditor]
   , ['LocVariaAmt', () => Serenity.DecimalEditor]
   , ['LocTdiscAmt', () => Serenity.DecimalEditor]
   , ['LocChgsAmt', () => Serenity.DecimalEditor]
   , ['LocGtaxAmt', () => Serenity.DecimalEditor]
   , ['LocPayAmt', () => Serenity.DecimalEditor]
   , ['AcctVendor', () => Serenity.StringEditor]
   , ['AcctTdisc', () => Serenity.StringEditor]
   , ['AcctGtax', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['PostedDate', () => Serenity.DateEditor]
   , ['PostedBy', () => Serenity.StringEditor]
   , ['LogNo', () => Serenity.DecimalEditor]
   , ['LastLogNo', () => Serenity.DecimalEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
   , ['SettleAt', () => Serenity.StringEditor]
   , ['Reason', () => Serenity.StringEditor]
   , ['Anlys9', () => Serenity.StringEditor]
   , ['Anlys10', () => Serenity.StringEditor]
   , ['Anlys11', () => Serenity.StringEditor]
   , ['Anlys12', () => Serenity.StringEditor]
   , ['Anlys13', () => Serenity.StringEditor]
   , ['Anlys14', () => Serenity.StringEditor]
   , ['Anlys15', () => Serenity.StringEditor]
   , ['Anlys16', () => Serenity.StringEditor]
   , ['Anlys17', () => Serenity.StringEditor]
   , ['Anlys18', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(PurchaseReturnForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

