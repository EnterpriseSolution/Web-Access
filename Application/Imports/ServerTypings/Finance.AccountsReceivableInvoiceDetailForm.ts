namespace Matrix.Finance {
    export class AccountsReceivableInvoiceDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsReceivableInvoiceDetail';

    }

    export interface AccountsReceivableInvoiceDetailForm {
        InvoiceNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        ItemNo: Serenity.StringEditor;
        Posted: Serenity.StringEditor;
        Returned: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        Qty: Serenity.DecimalEditor;
        LotSize: Serenity.DecimalEditor;
        Price: Serenity.DecimalEditor;
        ExtPrice: Serenity.DecimalEditor;
        LocExtPrice: Serenity.DecimalEditor;
        PriceCpd: Serenity.DecimalEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        Anlys3: Serenity.StringEditor;
        Anlys4: Serenity.StringEditor;
        Anlys5: Serenity.StringEditor;
        Anlys6: Serenity.StringEditor;
        ReturnQty: Serenity.DecimalEditor;
        ReturnAmt: Serenity.DecimalEditor;
        LreturnAmt: Serenity.DecimalEditor;
        InvoiceDate: Serenity.DateEditor;
        CustomerNo: Serenity.StringEditor;
        AcctSales: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
        ExtDescription: Serenity.StringEditor;
        SltaxPcent: Serenity.DecimalEditor;
        SltaxAmt: Serenity.DecimalEditor;
        LocSltaxAmt: Serenity.DecimalEditor;
        AcctSltax: Serenity.StringEditor;
        ShipmentRef: Serenity.StringEditor;
        ShipmentEntryNo: Serenity.DecimalEditor;
        OrderNo: Serenity.StringEditor;
        LdiscPcent: Serenity.DecimalEditor;
        LdiscAmt: Serenity.DecimalEditor;
        NetItemAmt: Serenity.DecimalEditor;
        OrderLineNo: Serenity.DecimalEditor;
        PriceAmt: Serenity.DecimalEditor;
        NetPrice: Serenity.DecimalEditor;
        AcctLdisc: Serenity.StringEditor;
        ShipItemAmt: Serenity.DecimalEditor;
        LshipItemAmt: Serenity.DecimalEditor;
        LocItemAmt: Serenity.DecimalEditor;
        LocPriceAmt: Serenity.DecimalEditor;
        LocLdiscAmt: Serenity.DecimalEditor;
        AcctVariance: Serenity.StringEditor;
        VariaAmt: Serenity.DecimalEditor;
        LocalVariaAmt: Serenity.DecimalEditor;
        Anlys15: Serenity.StringEditor;
        Anlys16: Serenity.StringEditor;
        Anlys17: Serenity.StringEditor;
        Anlys18: Serenity.StringEditor;
        Anlys19: Serenity.StringEditor;
        Anlys20: Serenity.StringEditor;
    }

    [['InvoiceNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['Returned', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['Qty', () => Serenity.DecimalEditor]
   , ['LotSize', () => Serenity.DecimalEditor]
   , ['Price', () => Serenity.DecimalEditor]
   , ['ExtPrice', () => Serenity.DecimalEditor]
   , ['LocExtPrice', () => Serenity.DecimalEditor]
   , ['PriceCpd', () => Serenity.DecimalEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['Anlys3', () => Serenity.StringEditor]
   , ['Anlys4', () => Serenity.StringEditor]
   , ['Anlys5', () => Serenity.StringEditor]
   , ['Anlys6', () => Serenity.StringEditor]
   , ['ReturnQty', () => Serenity.DecimalEditor]
   , ['ReturnAmt', () => Serenity.DecimalEditor]
   , ['LreturnAmt', () => Serenity.DecimalEditor]
   , ['InvoiceDate', () => Serenity.DateEditor]
   , ['CustomerNo', () => Serenity.StringEditor]
   , ['AcctSales', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
   , ['ExtDescription', () => Serenity.StringEditor]
   , ['SltaxPcent', () => Serenity.DecimalEditor]
   , ['SltaxAmt', () => Serenity.DecimalEditor]
   , ['LocSltaxAmt', () => Serenity.DecimalEditor]
   , ['AcctSltax', () => Serenity.StringEditor]
   , ['ShipmentRef', () => Serenity.StringEditor]
   , ['ShipmentEntryNo', () => Serenity.DecimalEditor]
   , ['OrderNo', () => Serenity.StringEditor]
   , ['LdiscPcent', () => Serenity.DecimalEditor]
   , ['LdiscAmt', () => Serenity.DecimalEditor]
   , ['NetItemAmt', () => Serenity.DecimalEditor]
   , ['OrderLineNo', () => Serenity.DecimalEditor]
   , ['PriceAmt', () => Serenity.DecimalEditor]
   , ['NetPrice', () => Serenity.DecimalEditor]
   , ['AcctLdisc', () => Serenity.StringEditor]
   , ['ShipItemAmt', () => Serenity.DecimalEditor]
   , ['LshipItemAmt', () => Serenity.DecimalEditor]
   , ['LocItemAmt', () => Serenity.DecimalEditor]
   , ['LocPriceAmt', () => Serenity.DecimalEditor]
   , ['LocLdiscAmt', () => Serenity.DecimalEditor]
   , ['AcctVariance', () => Serenity.StringEditor]
   , ['VariaAmt', () => Serenity.DecimalEditor]
   , ['LocalVariaAmt', () => Serenity.DecimalEditor]
   , ['Anlys15', () => Serenity.StringEditor]
   , ['Anlys16', () => Serenity.StringEditor]
   , ['Anlys17', () => Serenity.StringEditor]
   , ['Anlys18', () => Serenity.StringEditor]
   , ['Anlys19', () => Serenity.StringEditor]
   , ['Anlys20', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AccountsReceivableInvoiceDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

