namespace Matrix.Purchasing {
    export class GrnOrderForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.GrnOrder';

    }

    export interface GrnOrderForm {
        GrnNo: Serenity.StringEditor;
        SeqNo: Serenity.DecimalEditor;
        OrderNo: Serenity.StringEditor;
        Posted: Serenity.StringEditor;
        OrderDate: Serenity.DateEditor;
        NextDueDate: Serenity.DateEditor;
        Final: Serenity.StringEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        TotPriceAmt: Serenity.DecimalEditor;
        TotPtaxAmt: Serenity.DecimalEditor;
        TotExtPrice: Serenity.DecimalEditor;
        TotLdiscAmt: Serenity.DecimalEditor;
        TotAtaxAmt: Serenity.DecimalEditor;
        TotItemAmt: Serenity.DecimalEditor;
        TdiscPcent: Serenity.DecimalEditor;
        TotTdiscAmt: Serenity.DecimalEditor;
        NetTradeAmt: Serenity.DecimalEditor;
        TotChgsAmt: Serenity.DecimalEditor;
        NetOrdrAmt: Serenity.DecimalEditor;
        TotGtaxAmt: Serenity.DecimalEditor;
        NetPayAmt: Serenity.DecimalEditor;
        DpsCover: Serenity.DecimalEditor;
        DpsPcent: Serenity.DecimalEditor;
        DpsApplied: Serenity.DecimalEditor;
        LocDpsApplied: Serenity.DecimalEditor;
        NetBalAmt: Serenity.DecimalEditor;
        TdiscRate: Serenity.DecimalEditor;
        GtaxRate: Serenity.DecimalEditor;
        DpsRate: Serenity.DecimalEditor;
        TotTdiscCpd: Serenity.DecimalEditor;
        TotGtaxCpd: Serenity.DecimalEditor;
        DpsAppliedCpd: Serenity.DecimalEditor;
        LastLineNo: Serenity.DecimalEditor;
        LastChgsNo: Serenity.DecimalEditor;
        LogNo: Serenity.DecimalEditor;
        LastLogNo: Serenity.DecimalEditor;
        Buyer: Serenity.StringEditor;
        ReceivedDate: Serenity.DateEditor;
        DetailCount: Serenity.DecimalEditor;
        ChargesCount: Serenity.DecimalEditor;
        DpsEntryNo: Serenity.DecimalEditor;
        CheckCrbal: Serenity.DecimalEditor;
        PutaxType: Serenity.StringEditor;
        GputaxPcent: Serenity.DecimalEditor;
        TotGputaxAmt: Serenity.DecimalEditor;
        TotLputaxAmt: Serenity.DecimalEditor;
        Anlys7: Serenity.StringEditor;
        Anlys8: Serenity.StringEditor;
        ReceiveAll: Serenity.StringEditor;
        Anlys9: Serenity.StringEditor;
        Anlys10: Serenity.StringEditor;
        Anlys11: Serenity.StringEditor;
        Anlys12: Serenity.StringEditor;
        Anlys13: Serenity.StringEditor;
        Anlys14: Serenity.StringEditor;
    }

    [['GrnNo', () => Serenity.StringEditor]
   , ['SeqNo', () => Serenity.DecimalEditor]
   , ['OrderNo', () => Serenity.StringEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['OrderDate', () => Serenity.DateEditor]
   , ['NextDueDate', () => Serenity.DateEditor]
   , ['Final', () => Serenity.StringEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['TotPriceAmt', () => Serenity.DecimalEditor]
   , ['TotPtaxAmt', () => Serenity.DecimalEditor]
   , ['TotExtPrice', () => Serenity.DecimalEditor]
   , ['TotLdiscAmt', () => Serenity.DecimalEditor]
   , ['TotAtaxAmt', () => Serenity.DecimalEditor]
   , ['TotItemAmt', () => Serenity.DecimalEditor]
   , ['TdiscPcent', () => Serenity.DecimalEditor]
   , ['TotTdiscAmt', () => Serenity.DecimalEditor]
   , ['NetTradeAmt', () => Serenity.DecimalEditor]
   , ['TotChgsAmt', () => Serenity.DecimalEditor]
   , ['NetOrdrAmt', () => Serenity.DecimalEditor]
   , ['TotGtaxAmt', () => Serenity.DecimalEditor]
   , ['NetPayAmt', () => Serenity.DecimalEditor]
   , ['DpsCover', () => Serenity.DecimalEditor]
   , ['DpsPcent', () => Serenity.DecimalEditor]
   , ['DpsApplied', () => Serenity.DecimalEditor]
   , ['LocDpsApplied', () => Serenity.DecimalEditor]
   , ['NetBalAmt', () => Serenity.DecimalEditor]
   , ['TdiscRate', () => Serenity.DecimalEditor]
   , ['GtaxRate', () => Serenity.DecimalEditor]
   , ['DpsRate', () => Serenity.DecimalEditor]
   , ['TotTdiscCpd', () => Serenity.DecimalEditor]
   , ['TotGtaxCpd', () => Serenity.DecimalEditor]
   , ['DpsAppliedCpd', () => Serenity.DecimalEditor]
   , ['LastLineNo', () => Serenity.DecimalEditor]
   , ['LastChgsNo', () => Serenity.DecimalEditor]
   , ['LogNo', () => Serenity.DecimalEditor]
   , ['LastLogNo', () => Serenity.DecimalEditor]
   , ['Buyer', () => Serenity.StringEditor]
   , ['ReceivedDate', () => Serenity.DateEditor]
   , ['DetailCount', () => Serenity.DecimalEditor]
   , ['ChargesCount', () => Serenity.DecimalEditor]
   , ['DpsEntryNo', () => Serenity.DecimalEditor]
   , ['CheckCrbal', () => Serenity.DecimalEditor]
   , ['PutaxType', () => Serenity.StringEditor]
   , ['GputaxPcent', () => Serenity.DecimalEditor]
   , ['TotGputaxAmt', () => Serenity.DecimalEditor]
   , ['TotLputaxAmt', () => Serenity.DecimalEditor]
   , ['Anlys7', () => Serenity.StringEditor]
   , ['Anlys8', () => Serenity.StringEditor]
   , ['ReceiveAll', () => Serenity.StringEditor]
   , ['Anlys9', () => Serenity.StringEditor]
   , ['Anlys10', () => Serenity.StringEditor]
   , ['Anlys11', () => Serenity.StringEditor]
   , ['Anlys12', () => Serenity.StringEditor]
   , ['Anlys13', () => Serenity.StringEditor]
   , ['Anlys14', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(GrnOrderForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

