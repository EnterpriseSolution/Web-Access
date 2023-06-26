namespace Matrix.Sales {
    export class QuotationDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Sales.QuotationDetail';

    }

    export interface QuotationDetailForm {
        RefNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        ItemNo: Serenity.StringEditor;
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
        PriceCpd: Serenity.DecimalEditor;
        PtaxCpd: Serenity.DecimalEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        Configurable: Serenity.StringEditor;
        CustItemNo: Serenity.StringEditor;
        SpecNo: Serenity.StringEditor;
        BomNo: Serenity.StringEditor;
        StdAssort: Serenity.StringEditor;
        ExtDescription: Serenity.StringEditor;
        SltaxPcent: Serenity.DecimalEditor;
        SltaxAmt: Serenity.DecimalEditor;
        Anlys3: Serenity.StringEditor;
        Anlys4: Serenity.StringEditor;
        Anlys5: Serenity.StringEditor;
        Anlys6: Serenity.StringEditor;
        MarkupPcent: Serenity.DecimalEditor;
        Markup: Serenity.DecimalEditor;
        MoldBomNo: Serenity.StringEditor;
        MoldFormulaCode: Serenity.StringEditor;
        MoldExpectedQty: Serenity.DecimalEditor;
        Anlys15: Serenity.StringEditor;
        Anlys16: Serenity.StringEditor;
        Anlys17: Serenity.StringEditor;
        Anlys18: Serenity.StringEditor;
        Anlys19: Serenity.StringEditor;
        Anlys20: Serenity.StringEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['ItemNo', () => Serenity.StringEditor]
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
   , ['PriceCpd', () => Serenity.DecimalEditor]
   , ['PtaxCpd', () => Serenity.DecimalEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['Configurable', () => Serenity.StringEditor]
   , ['CustItemNo', () => Serenity.StringEditor]
   , ['SpecNo', () => Serenity.StringEditor]
   , ['BomNo', () => Serenity.StringEditor]
   , ['StdAssort', () => Serenity.StringEditor]
   , ['ExtDescription', () => Serenity.StringEditor]
   , ['SltaxPcent', () => Serenity.DecimalEditor]
   , ['SltaxAmt', () => Serenity.DecimalEditor]
   , ['Anlys3', () => Serenity.StringEditor]
   , ['Anlys4', () => Serenity.StringEditor]
   , ['Anlys5', () => Serenity.StringEditor]
   , ['Anlys6', () => Serenity.StringEditor]
   , ['MarkupPcent', () => Serenity.DecimalEditor]
   , ['Markup', () => Serenity.DecimalEditor]
   , ['MoldBomNo', () => Serenity.StringEditor]
   , ['MoldFormulaCode', () => Serenity.StringEditor]
   , ['MoldExpectedQty', () => Serenity.DecimalEditor]
   , ['Anlys15', () => Serenity.StringEditor]
   , ['Anlys16', () => Serenity.StringEditor]
   , ['Anlys17', () => Serenity.StringEditor]
   , ['Anlys18', () => Serenity.StringEditor]
   , ['Anlys19', () => Serenity.StringEditor]
   , ['Anlys20', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(QuotationDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

