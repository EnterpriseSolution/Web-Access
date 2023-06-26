namespace Matrix.Sales {
    export class QuotationForm extends Serenity.PrefixedContext {
        static formKey = 'Sales.Quotation';

    }

    export interface QuotationForm {
        RefNo: Serenity.StringEditor;
        IssueDate: Serenity.DateEditor;
        ValidUntil: Serenity.DateEditor;
        CustomerNo: Serenity.StringEditor;
        CustomerName: Serenity.StringEditor;
        PortLoading: Serenity.StringEditor;
        PortDischarge: Serenity.StringEditor;
        ShipVia: Serenity.StringEditor;
        ShipmentTerms: Serenity.StringEditor;
        OriginCountry: Serenity.StringEditor;
        ShipTo: Serenity.StringEditor;
        Attention: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Address2: Serenity.StringEditor;
        Address3: Serenity.StringEditor;
        Address4: Serenity.StringEditor;
        TelNo: Serenity.StringEditor;
        FaxNo: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        PayTerms: Serenity.StringEditor;
        Salesman: Serenity.StringEditor;
        PriceCode: Serenity.StringEditor;
        BaseLoc: Serenity.StringEditor;
        TotItemAmt: Serenity.DecimalEditor;
        TotPtaxAmt: Serenity.DecimalEditor;
        TotTdiscAmt: Serenity.DecimalEditor;
        TdiscPcent: Serenity.DecimalEditor;
        TotLdiscAmt: Serenity.DecimalEditor;
        NetTradeAmt: Serenity.DecimalEditor;
        TotChgsAmt: Serenity.DecimalEditor;
        NetPayAmt: Serenity.DecimalEditor;
        DpsPcent: Serenity.DecimalEditor;
        TotDpsAmt: Serenity.DecimalEditor;
        DetailList: QuotationDetailEditor;
        Comments1: Serenity.StringEditor;
        Comments2: Serenity.StringEditor;
        Comments3: Serenity.StringEditor;
        Comments4: Serenity.StringEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['IssueDate', () => Serenity.DateEditor]
   , ['ValidUntil', () => Serenity.DateEditor]
   , ['CustomerNo', () => Serenity.StringEditor]
   , ['CustomerName', () => Serenity.StringEditor]
   , ['PortLoading', () => Serenity.StringEditor]
   , ['PortDischarge', () => Serenity.StringEditor]
   , ['ShipVia', () => Serenity.StringEditor]
   , ['ShipmentTerms', () => Serenity.StringEditor]
   , ['OriginCountry', () => Serenity.StringEditor]
   , ['ShipTo', () => Serenity.StringEditor]
   , ['Attention', () => Serenity.StringEditor]
   , ['Address', () => Serenity.StringEditor]
   , ['Address2', () => Serenity.StringEditor]
   , ['Address3', () => Serenity.StringEditor]
   , ['Address4', () => Serenity.StringEditor]
   , ['TelNo', () => Serenity.StringEditor]
   , ['FaxNo', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['PayTerms', () => Serenity.StringEditor]
   , ['Salesman', () => Serenity.StringEditor]
   , ['PriceCode', () => Serenity.StringEditor]
   , ['BaseLoc', () => Serenity.StringEditor]
   , ['TotItemAmt', () => Serenity.DecimalEditor]
   , ['TotPtaxAmt', () => Serenity.DecimalEditor]
   , ['TotTdiscAmt', () => Serenity.DecimalEditor]
   , ['TdiscPcent', () => Serenity.DecimalEditor]
   , ['TotLdiscAmt', () => Serenity.DecimalEditor]
   , ['NetTradeAmt', () => Serenity.DecimalEditor]
   , ['TotChgsAmt', () => Serenity.DecimalEditor]
   , ['NetPayAmt', () => Serenity.DecimalEditor]
   , ['DpsPcent', () => Serenity.DecimalEditor]
   , ['TotDpsAmt', () => Serenity.DecimalEditor]
   , ['DetailList', () => QuotationDetailEditor]
   , ['Comments1', () => Serenity.StringEditor]
   , ['Comments2', () => Serenity.StringEditor]
   , ['Comments3', () => Serenity.StringEditor]
   , ['Comments4', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(QuotationForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

